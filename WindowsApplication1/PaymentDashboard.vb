Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class PaymentDashboard

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        conn_ms = "SELECT COUNT(id) AS no_asessed " &
                        "FROM ONLINE.annual_inspection_application " &
                        "WHERE app_status = 'A'  "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms.Read = True Then

            lbl_countpending.Text = rdr_ms("no_asessed")
        Else
            lbl_countpending.Text = "0"

        End If
        Con_ms.Close()



        conn_ms = "SELECT COUNT(id) AS no_paid " &
                      "FROM ONLINE.annual_inspection_application " &
                      "WHERE app_status = 'PAID' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms.Read = True Then

            lblcountPaid.Text = rdr_ms("no_paid")
        Else
            lblcountPaid.Text = "0"
        End If
        Con_ms.Close()


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        DataGrid.Rows.Clear()
        lblCount.Visible = False
        Dim Pending As Integer = 0
        conn_ms = "SELECT * " & _
                     "FROM ONLINE.annual_inspection_application " & _
                     "WHERE app_status = 'A' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        Do While rdr_ms.Read()

            DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("assess_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

        Loop
        rdr_ms.Close()
    End Sub

    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellContentClick


        If e.RowIndex = -1 Then

            Exit Sub
        End If

        If e.ColumnIndex = 7 Then

            Try

                conn = "SELECT * " & _
                       "FROM ONLINE.annual_inspection_application AS cpa " & _
                       "INNER JOIN ONLINE.SysMngr AS sm ON cpa.UserID = sm.UserID " & _
                       "INNER JOIN ONLINE.email_outbox AS EO ON cpa.UserID = EO.userid " & _
                       "WHERE cpa.id = '" & DataGrid.Item(0, DataGrid.CurrentRow.Index).Value & "'"

                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms.Read = True Then

                    Dim NewMDIChild As New Payment()
                    NewMDIChild.Show()


                    Dim payment As Payment = CType(Application.OpenForms("Payment"), Payment)
                    With payment

                        .TxtApplicationID.Text = rdr_ms("id").ToString
                        .TxtAccountNo.Text = rdr_ms("accountNo").ToString
                        .referencono.Text = rdr_ms("refno").ToString
                        .TxtProjectName.Text = rdr_ms("project_title").ToString
                        .tax_amount.Text = rdr_ms("payment_").ToString
                        .Txtapplicant_name.Text = rdr_ms("applicant").ToString
                        .useraccountid.Text = rdr_ms("UserID").ToString
                        .txt_email.Text = rdr_ms("email").ToString
                        .TxtTransaction.Text = rdr_ms("Transaction_no").ToString
                        .ORattachment.Text = rdr_ms("file_assessment").ToString
                        .Type_App.Text = rdr_ms("permit_type").ToString


                        Dim folderpath = link_prefix & folder_directory & .referencono.Text & "\" & .referencono.Text & "_OR.pdf"


                        If rdr_ms("app_status") = "PAID" Then

                            .ORattachment.Enabled = False
                            .Button1.Enabled = False
                            .TxtTransaction.Enabled = False


                            If Not String.IsNullOrEmpty("file_assessment") Then
                                If System.IO.File.Exists(folderpath) Then

                                    .AxAcroPDF2.src = "file:///" & folderpath.Replace("\", "/")

                                Else
                                    MessageBox.Show("File not found: " & folderpath, "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("No file path found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                    End With
                End If
                Con_ms.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        DataGrid.Rows.Clear()

        lblCount.Visible = False
        Dim Pending As Integer = 0
        conn_ms = "SELECT id, refNo, tdn, project_title, payment_date, app_status " & _
                     "FROM ONLINE.annual_inspection_application " & _
                     "WHERE app_status = 'PAID' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        Do While rdr_ms.Read()

            Dim applicationDate As DateTime = rdr_ms("payment_date")
            Dim currentDate As DateTime = DateTime.Now

            Dim duration As TimeSpan = currentDate - applicationDate
            Dim daysPending As Integer = duration.Days
            Dim hoursPending As Integer = duration.Hours
            Dim minutesPending As Integer = duration.Minutes

            Dim parts As New List(Of String)
            If daysPending > 0 Then parts.Add(daysPending.ToString() & " day" & If(daysPending > 1, "s", ""))
            If hoursPending > 0 Then parts.Add(hoursPending.ToString() & " hr" & If(hoursPending > 1, "s", ""))
            If minutesPending > 0 Then parts.Add(minutesPending.ToString() & " min" & If(minutesPending > 1, "s", ""))

            Dim pendingText As String = If(parts.Count > 0, String.Join(", ", parts), "Just now")

            DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refNo"), rdr_ms("payment_date"), rdr_ms("tdn"), rdr_ms("project_title"), pendingText, rdr_ms("app_status"), "VIEW")

        Loop
        rdr_ms.Close()
        Con_ms.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormStatus = False
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataGrid.Rows.Clear()

        Try
            If cmb_appointmentstatus.Text = "ASSESSED" Then

                conn_ms = "SELECT id, tdn, refNo, project_title, assess_date, app_status FROM ONLINE.annual_inspection_application WHERE app_status = 'A' AND Convert(date, application_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY application_date ASC;"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    Dim applicationDate As DateTime = rdr_ms("assess_date")
                    Dim currentDate As DateTime = DateTime.Now

                    Dim duration As TimeSpan = currentDate - applicationDate
                    Dim daysPending As Integer = duration.Days
                    Dim hoursPending As Integer = duration.Hours
                    Dim minutesPending As Integer = duration.Minutes

                    Dim parts As New List(Of String)
                    If daysPending > 0 Then parts.Add(daysPending.ToString() & " day" & If(daysPending > 1, "s", ""))
                    If hoursPending > 0 Then parts.Add(hoursPending.ToString() & " hr" & If(hoursPending > 1, "s", ""))
                    If minutesPending > 0 Then parts.Add(minutesPending.ToString() & " min" & If(minutesPending > 1, "s", ""))

                    Dim pendingText As String = If(parts.Count > 0, String.Join(", ", parts), "Just now")

                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refNo"), rdr_ms("assess_date"), rdr_ms("tdn"), rdr_ms("project_title"), pendingText, rdr_ms("app_status"), "VIEW")


                Loop
                rdr_ms.Close()
                Con_ms.Close()

            ElseIf cmb_appointmentstatus.Text = "PAID" Then

                conn_ms = "SELECT id, tdn, refNo, project_title, payment_date, app_status " & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='PAID' AND Convert(date, application_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY application_date ASC; "
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    Dim applicationDate As DateTime = rdr_ms("payment_date")
                    Dim currentDate As DateTime = DateTime.Now

                    Dim duration As TimeSpan = currentDate - applicationDate
                    Dim daysPending As Integer = duration.Days
                    Dim hoursPending As Integer = duration.Hours
                    Dim minutesPending As Integer = duration.Minutes

                    Dim parts As New List(Of String)
                    If daysPending > 0 Then parts.Add(daysPending.ToString() & " day" & If(daysPending > 1, "s", ""))
                    If hoursPending > 0 Then parts.Add(hoursPending.ToString() & " hr" & If(hoursPending > 1, "s", ""))
                    If minutesPending > 0 Then parts.Add(minutesPending.ToString() & " min" & If(minutesPending > 1, "s", ""))

                    Dim pendingText As String = If(parts.Count > 0, String.Join(", ", parts), "Just now")

                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refNo"), rdr_ms("payment_date"), rdr_ms("tdn"), rdr_ms("project_title"), pendingText, rdr_ms("app_status"), "VIEW")

                Loop
                rdr_ms.Close()
                Con_ms.Close()
            ElseIf cmb_appointmentstatus.Text = "ALL" Then

                conn_ms = "SELECT id, tdn, refNo, project_title, payment_date, assess_date, app_status " &
                          "FROM ONLINE.annual_inspection_application " &
                          "WHERE app_status IN ('A', 'PAID') AND " &
                          "((app_status = 'A' AND CONVERT(date, assess_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
                          "OR (app_status = 'PAID' AND CONVERT(date, payment_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "')) " &
                          "ORDER BY payment_date ASC;"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    Dim selectedDate As DateTime
                    Select Case rdr_ms("app_status").ToString().Trim().ToUpper()
                        Case "A"
                            selectedDate = Convert.ToDateTime(rdr_ms("assess_date"))
                        Case "PAID"
                            selectedDate = Convert.ToDateTime(rdr_ms("payment_date"))
                    End Select

                    Dim currentDate As DateTime = DateTime.Now
                    Dim duration As TimeSpan = currentDate - selectedDate
                    Dim daysPending As Integer = duration.Days
                    Dim hoursPending As Integer = duration.Hours
                    Dim minutesPending As Integer = duration.Minutes

                    Dim parts As New List(Of String)
                    If daysPending > 0 Then parts.Add(daysPending.ToString() & " day" & If(daysPending > 1, "s", ""))
                    If hoursPending > 0 Then parts.Add(hoursPending.ToString() & " hr" & If(hoursPending > 1, "s", ""))
                    If minutesPending > 0 Then parts.Add(minutesPending.ToString() & " min" & If(minutesPending > 1, "s", ""))

                    Dim pendingText As String = If(parts.Count > 0, String.Join(", ", parts), "Just now")
                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refNo"), selectedDate, rdr_ms("tdn"), rdr_ms("project_title"), pendingText, rdr_ms("app_status"), "VIEW")

                Loop
                rdr_ms.Close()
                Con_ms.Close()

            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        lblCount.Text = DataGrid.RowCount
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PaymentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class