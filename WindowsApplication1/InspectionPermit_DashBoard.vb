
Imports System.Data.SqlClient

Public Class InspectionPermit_DashBoard

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        conn_ms = "SELECT COUNT(id) AS no_paid FROM ONLINE.annual_inspection_application " &
                        "WHERE app_status = 'PAID' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms.Read = True Then

            lbl_countpending.Text = rdr_ms("no_paid")
        Else
            lbl_countpending.Text = "0"

        End If
        Con_ms.Close()



        conn_ms = "SELECT COUNT(id) AS no_issued FROM ONLINE.annual_inspection_application " &
                      "WHERE app_status = 'I' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms.Read = True Then

            lblcountPaid.Text = rdr_ms("no_issued")
        Else
            lblcountPaid.Text = "0"
        End If
        Con_ms.Close()


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

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

            Dim payment_date As DateTime = rdr_ms("payment_date")
            Dim currentDate As DateTime = DateTime.Now

            Dim duration As TimeSpan = currentDate - payment_date
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
    End Sub

    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellContentClick


        If e.RowIndex = -1 Then

            Exit Sub
        End If

        If e.ColumnIndex = 7 Then

            Try
                conn = "SELECT * " & _
                       "FROM ONLINE.annual_inspection_application AS ais " & _
                       "INNER JOIN ONLINE.SysMngr AS sm ON ais.UserID = sm.UserID " & _
                       "INNER JOIN ONLINE.email_outbox AS EO ON ais.userId = EO.userid " & _
                       "WHERE cpa.id = '" & DataGrid.Item(0, DataGrid.CurrentRow.Index).Value & "'"

                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms.Read = True Then

                    Dim NewMDIChild As New IssuedPermit()
                    NewMDIChild.Show()


                    Dim IssuedPermit As IssuedPermit = CType(Application.OpenForms("IssuedPermit"), IssuedPermit)
                    With IssuedPermit

                        .TxtApplicationID.Text = rdr_ms("id").ToString
                        .TxtAccountNo.Text = rdr_ms("accountNo").ToString
                        .referencono.Text = rdr_ms("refno").ToString
                        .TxtBusinessName.Text = rdr_ms("bussName").ToString
                        .TxtOwnerName.Text = rdr_ms("ownerName").ToString
                        .useraccountid.Text = rdr_ms("UserID").ToString

                        .Type_App.Text = rdr_ms("permit_type").ToString
                        .fullname.Text = rdr_ms("fullname").ToString
                        .txt_email.Text = rdr_ms("email").ToString
                        .txt_contactno.Text = rdr_ms("ContactNo").ToString


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
        conn_ms = "SELECT * " & _
                     "FROM ONLINE.annual_inspection_application " & _
                     "WHERE app_status = 'I'  "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        Do While rdr_ms.Read()
            DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("issuance_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
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
            If cmb_appointmentstatus.Text = "ISSUED" Then

                conn_ms = "SELECT * FROM ONLINE.annual_inspection_application WHERE app_status = 'I' Convert(date, issuance_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY application_date ASC;"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True
                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("issuance_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
                Loop
                rdr_ms.Close()
                Con_ms.Close()

            ElseIf cmb_appointmentstatus.Text = "PAID" Then

                conn_ms = "SELECT * " & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='PAID' Convert(date, paid_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY paid_date ASC;"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True
                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("paid_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
                Loop
                rdr_ms.Close()
                Con_ms.Close()
            ElseIf cmb_appointmentstatus.Text = "ALL" Then

                conn_ms = "SELECT * " &
                          "FROM ONLINE.annual_inspection_application " &
                          "WHERE app_status IN ('PAID', 'I') AND " &
                          "((app_status = 'I' AND CONVERT(date, issuance_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
                          "OR (app_status = 'PAID' AND CONVERT(date, paid_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "')) " &
                          "ORDER BY payment_date ASC"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    Dim selectedDate As DateTime
                    Select Case rdr_ms("app_status").ToString().Trim().ToUpper()
                        Case "I"
                            selectedDate = Convert.ToDateTime(rdr_ms("issuance_date"))
                        Case "PAID"
                            selectedDate = Convert.ToDateTime(rdr_ms("paid_date"))
                    End Select
                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), selectedDate, rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
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

End Class