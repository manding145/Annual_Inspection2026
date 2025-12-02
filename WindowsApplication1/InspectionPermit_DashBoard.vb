
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

            lblcountIssued.Text = rdr_ms("no_issued")
        Else
            lblcountIssued.Text = "0"
        End If
        Con_ms.Close()

        conn_ms = "SELECT COUNT(id) AS no_signing FROM ONLINE.annual_inspection_application " &
                  "WHERE app_status = 'S' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms.Read = True Then

            lblcountForSigning.Text = rdr_ms("no_signing")
        Else
            lblcountForSigning.Text = "0"
        End If
        Con_ms.Close()

        conn_ms = "SELECT COUNT(id) AS no_sgined FROM ONLINE.annual_inspection_application " &
                     "WHERE app_status = 'SD' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms.Read = True Then

            lblcountSigned.Text = rdr_ms("no_sgined")
        Else
            lblcountSigned.Text = "0"
        End If
        Con_ms.Close()


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        DataGrid.Rows.Clear()
        lblCount.Visible = False
        Dim Pending As Integer = 0
        conn_ms = "SELECT * " & _
                     "FROM ONLINE.annual_inspection_application " & _
                     "WHERE app_status = 'PAID' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        Do While rdr_ms.Read()

            DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("paid_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

        Loop
        rdr_ms.Close()
    End Sub

    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellContentClick


        If e.RowIndex = -1 Then

            Exit Sub
        End If

        If e.ColumnIndex = 6 Then

            Try
                conn = "SELECT * " & _
                       "FROM ONLINE.annual_inspection_application AS ais " & _
                       "INNER JOIN ONLINE.SysMngr AS sm ON ais.userId = sm.UserID " & _
                       "WHERE ais.id = '" & DataGrid.Item(0, DataGrid.CurrentRow.Index).Value & "'"

                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms.Read = True Then


                    Dim f As New IssuedPermit()
                    f.MdiParent = Nothing
                    f.StartPosition = FormStartPosition.Manual

                    Dim wa As Rectangle = Screen.PrimaryScreen.WorkingArea
                    Dim x As Integer = wa.Left + (wa.Width - f.Width + 200) \ 2
                    Dim y As Integer = wa.Top + (wa.Height - f.Height + 50) \ 2

                    f.Location = New Point(x, y)
                    f.Show()


                    Dim IssuedPermit As IssuedPermit = CType(Application.OpenForms("IssuedPermit"), IssuedPermit)
                    With IssuedPermit

                        .Type_App.Text = rdr_ms("app_type").ToString

                        .TxtApplicationID.Text = rdr_ms("id").ToString
                        .TxtAccountNo.Text = rdr_ms("accountNo").ToString
                        .referencono.Text = rdr_ms("refno").ToString
                        .TxtBusinessName.Text = rdr_ms("bussName").ToString
                        .TxtOwnerName.Text = rdr_ms("ownerName").ToString
                        .TxtNoStorey.Text = rdr_ms("noStorey").ToString
                        .useraccountid.Text = rdr_ms("UserID").ToString
                        .txtBuildingAge.Text = rdr_ms("bldg_age").ToString
                        .TxtBuildingAddress.Text = rdr_ms("bussAddress").ToString

                        .TxtBldg_permit.Text = rdr_ms("BldgPermit_No").ToString
                        If Not IsDBNull(rdr_ms("bldgPermit_IssuedDate")) Then
                            .TxtBldg_date.Text = Format(rdr_ms("bldgPermit_IssuedDate"), "MM-dd-yyyy")
                        Else
                            .TxtBldg_date.Text = ""
                        End If

                        .TxtOccupancyPermit.Text = rdr_ms("OccupPermit_No").ToString
                        If Not IsDBNull(rdr_ms("occuPermit_IssuedDate")) Then
                            .TxtOccupancy_date.Text = Format(rdr_ms("occuPermit_IssuedDate"), "MM-dd-yyyy")
                        Else
                            .TxtOccupancy_date.Text = ""
                        End If

                        .fullname.Text = rdr_ms("Firstname").ToString() + " " + rdr_ms("Middlename").ToString() + " " + rdr_ms("Lastname").ToString()
                        .txt_email.Text = rdr_ms("email").ToString
                        .txt_contactno.Text = rdr_ms("ContactNo").ToString


                        Dim folderpath = link_prefix & folder_directory & .referencono.Text & "\" & .referencono.Text & "_Certificate.pdf"

                        If rdr_ms("app_status") = "PAID" Then

                            .B_Issued.Visible = False
                            .B_SentNotification.Visible = True
                            .B_Signed.Visible = False
                            .B_IssuedAttach.Visible = False
                            .Issued_file.Visible = False
                            .Lbl_Upload.Visible = False


                            If Not String.IsNullOrEmpty("file_or") Then
                                .Or_link.Location = New Point(260, 300)
                                .Or_link.Visible = True
                            End If

                        ElseIf rdr_ms("app_status") = "S" Then

                            .B_Issued.Visible = False
                            .B_SentNotification.Visible = False
                            .B_Signed.Visible = True
                            .B_IssuedAttach.Visible = False
                            .Issued_file.Visible = False
                            .Lbl_Upload.Visible = False
                            .Print_Record.Visible = True

                            If Not String.IsNullOrEmpty("file_or") Then
                                .Or_link.Location = New Point(260, 300)
                                .Or_link.Visible = True
                            End If

                        ElseIf rdr_ms("app_status") = "SD" Then

                            .B_SentNotification.Visible = False
                            .B_Signed.Visible = False
                            .B_IssuedAttach.Enabled = True
                            .Issued_file.Visible = True
                            .B_Issued.Visible = True
                            .Print_Record.Visible = True
                            .Or_link.Visible = True

                        ElseIf rdr_ms("app_status") = "I" Then

                            .B_Issued.Enabled = False
                            .B_SentNotification.Enabled = False
                            .B_Signed.Enabled = False

                            .B_Issued.Visible = False
                            .B_SentNotification.Visible = False
                            .B_Signed.Visible = False
                            .B_Issued.Visible = True
                            .Or_link.Visible = True
                            .Print_Record.Visible = True

                            .Issued_file.Text = rdr_ms("file_certificate").ToString()

                            If Not String.IsNullOrEmpty("file_certificate") Then
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

                conn_ms = "SELECT * FROM ONLINE.annual_inspection_application WHERE app_status = 'I' Convert(date, issuance_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY issuance_date ASC;"
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
              
            ElseIf cmb_appointmentstatus.Text = "SIGNING" Then

                conn_ms = "SELECT * " & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='S' Convert(date, signing_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY signing_date ASC;"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True
                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("signing_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
                Loop
                rdr_ms.Close()
                Con_ms.Close()

            ElseIf cmb_appointmentstatus.Text = "SIGNED" Then

                conn_ms = "SELECT * " & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='SD' Convert(date, Signed_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY Signed_date ASC;"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True
                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("Signed_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
                Loop
                rdr_ms.Close()
                Con_ms.Close()


            ElseIf cmb_appointmentstatus.Text = "ALL" Then

                conn_ms = "SELECT * " &
                          "FROM ONLINE.annual_inspection_application " &
                          "WHERE app_status IN ('PAID', 'I', 'S', 'SD') AND " &
                          "((app_status = 'I' AND CONVERT(date, issuance_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
                          "OR (app_status = 'PAID' AND CONVERT(date, paid_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
                           "OR (app_status = 'S' AND CONVERT(date, signing_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
                            "OR (app_status = 'SD' AND CONVERT(date, Signed_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "')) " &
                          "ORDER BY paid_date ASC"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    Dim selectedDate As DateTime
                    Select Case rdr_ms("app_status").ToString().Trim().ToUpper()
                        Case "I"
                            selectedDate = Convert.ToDateTime(rdr_ms("issuance_date"))
                        Case "S"
                            selectedDate = Convert.ToDateTime(rdr_ms("signing_date"))
                        Case "SD"
                            selectedDate = Convert.ToDateTime(rdr_ms("Signed_date"))
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        DataGrid.Rows.Clear()

        lblCount.Visible = False
        Dim Pending As Integer = 0
        conn_ms = "SELECT * " & _
                     "FROM ONLINE.annual_inspection_application " & _
                     "WHERE app_status = 'S'  "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        Do While rdr_ms.Read()
            DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("Signing_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
        Loop
        rdr_ms.Close()
        Con_ms.Close()
    End Sub

 
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        DataGrid.Rows.Clear()

        lblCount.Visible = False
        Dim Pending As Integer = 0
        conn_ms = "SELECT * " & _
                     "FROM ONLINE.annual_inspection_application " & _
                     "WHERE app_status = 'SD'  "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        Do While rdr_ms.Read()
            DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("Signed_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
        Loop
        rdr_ms.Close()
        Con_ms.Close()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            conn_ms = "DELETE from ONLINE.annual_inspection_application WHERE refno='" & DataGrid.Item(1, DataGrid.CurrentRow.Index).Value & "'"
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            cmd_ms.ExecuteNonQuery()
            Con_ms.Close()

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            conn_ms = "DELETE from ONLINE.constr_permit_application WHERE app_id='" & DataGrid.Item(0, DataGrid.CurrentRow.Index).Value & "'"
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            cmd_ms.ExecuteNonQuery()
            Con_ms.Close()

            MsgBox("This application record is sucessfully deleted!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class