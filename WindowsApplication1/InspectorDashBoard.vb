Imports System.Data.SqlClient
Public Class InspectorDashBoard
    Dim im_userid, fullnamedaw As String



    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellContentClick



        If e.ColumnIndex = 6 Then
            Try

                conn = "SELECT * FROM ONLINE.annual_inspection_application AS cpa " &
                          "INNER JOIN ONLINE.SysMngr AS sm ON cpa.UserID = sm.UserID " &
                          "WHERE cpa.id = '" & DataGrid.Item(0, DataGrid.CurrentRow.Index).Value & "'"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms.Read = True Then


                    Dim NewMDIChild As New Inspector_ApplicationRecord()
                    NewMDIChild.MdiParent = MainMenu
                    NewMDIChild.Show()


                    Dim Inspector_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Inspector_ApplicationRecord"), Inspector_ApplicationRecord)

                    With Inspector_ApplicationRecord

                        applicationID_search = rdr_ms("id").ToString
                        .TxtRefenceNo.Text = rdr_ms("refno").ToString
                        .lbl_AccountNo.Text = rdr_ms("accountNo").ToString
                        .lbl_BusinessName.Text = rdr_ms("bussName").ToString
                        .TxtAccountNo.Text = rdr_ms("accountNo").ToString
                        .TxtBusinessName.Text = rdr_ms("bussName").ToString
                        .txtBuildingAge.Text = rdr_ms("bldg_age").ToString
                        .TxtBusinessAddress.Text = rdr_ms("bussAddress").ToString
                        .TxtBusinessOwner.Text = rdr_ms("ownerName").ToString
                        .txt_applicationno.Text = rdr_ms("id").ToString
                        .txt_email.Text = rdr_ms("Email").ToString
                        .txt_contactno.Text = rdr_ms("ContactNo").ToString
                        .fullname.Text = rdr_ms("Firstname").ToString() + " " + rdr_ms("Middlename").ToString() + " " + rdr_ms("Lastname").ToString()
                        .useraccountid.Text = rdr_ms("userid").ToString()
                        .txt_remarks.Text = rdr_ms("remarks").ToString

                        .Grid_attachments.Rows.Clear()

                        'attachments
                        conn_ms2 = "SELECT * FROM ONLINE.cho_attachment_m where Type = 'INS'"
                        Con_ms2 = New SqlConnection(mcs)
                        Con_ms2.Open()
                        cmd_ms2 = New SqlCommand(conn_ms2, Con_ms2)
                        rdr_ms2 = cmd_ms2.ExecuteReader(CommandBehavior.CloseConnection)
                        Do While rdr_ms2.Read = True

                            Dim attach_code_temp As String
                            attach_code_temp = rdr_ms2("attachmentcode")
                            If rdr_ms(attach_code_temp).ToString = "" Then
                                'do nothing
                            Else
                                .Grid_attachments.Rows.Add(rdr_ms(attach_code_temp), rdr_ms2("AttachmentDescription"), "VIEW")
                            End If
                        Loop
                        Con_ms2.Close()
                        'track application_Status
                        Dim folderpath = link_prefix & folder_directory & .TxtRefenceNo.Text & "\" & .TxtRefenceNo.Text & "_Tax_Assessment.pdf"

                        If rdr_ms("app_status") = "P" Then
                            .Panel_pending.Visible = True
                            .panel_verified.Visible = False
                            .panel_denied.Visible = False

                        ElseIf rdr_ms("app_status") = "A" Then

                            .Panel_pending.Visible = False
                            .panel_verified.Visible = True
                            .panel_denied.Visible = False
                            .BtnAddNewRecord.Enabled = False
                            .btnDeny.Visible = False
                            .assessment_file.Enabled = False
                            .B_assessAttach.Enabled = False
                            .B_Reupload.Enabled = False
                            .TxtBusinessAddress.Enabled = False
                            .TxtAccountNo.Enabled = False
                            .TxtAmount.Enabled = False

                            .TxtAmount.Text = rdr_ms("payment_amount").ToString()
                            .assessment_file.Text = rdr_ms("file_assessment").ToString()

                            If Not String.IsNullOrEmpty("file_assessment") Then
                                If System.IO.File.Exists(folderpath) Then
                                    .AxAcroPDF2.src = "file:///" & folderpath.Replace("\", "/")
                                Else
                                    MessageBox.Show("File not found: " & folderpath, "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("No file path found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If


                        ElseIf rdr_ms("app_status") = "D" Then
                            .Panel_pending.Visible = False
                            .panel_verified.Visible = False
                            .panel_denied.Visible = True
                            .B_Reupload.Visible = False
                            .BtnAddNewRecord.Enabled = False
                            .btnDeny.Visible = False
                        ElseIf rdr_ms("app_status") = "R" Then
                            .panel_denied.Visible = False
                            .Panel_pending.Visible = False
                            .panel_verified.Visible = False
                            .B_Reupload.Visible = True
                            .BtnAddNewRecord.Enabled = False
                            .btnDeny.Visible = False
                        End If



                    End With

                End If
                Con_ms.Close()
                Con_ms2.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        End If
    End Sub
    Private Sub whoisthisuser()
        conn_ms2 = "SELECT * FROM ONLINE.annual_inspection_application where UserID= '" & im_userid & "' "

        Con_ms2 = New SqlConnection(mcs)
        Con_ms2.Open()
        cmd_ms2 = New SqlCommand(conn_ms2, Con_ms2)
        rdr_ms2 = cmd_ms2.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms2.Read = True Then

            fullnamedaw = rdr_ms2("Fullname").ToString

        End If
        Con_ms2.Close()
    End Sub
    Private Sub BtnSearchRecord_Click(sender As Object, e As EventArgs) Handles BtnSearchRecord.Click
        SearchApplicationRecord.ShowDialog()
        'Dim FrmHealthCertificate As MayorsPermitControl = CType(Application.OpenForms("MayorsPermitControl"), MayorsPermitControl)
        'MayorsPermitControl.txt_AccountNo.Text = "T-01289"
        'MayorsPermitControl.ShowDialog()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try


            'all
            conn_ms = "SELECT COUNT(id) AS no_pending FROM ONLINE.annual_inspection_application "
            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr_ms.Read = True Then
                lblCount.Text = rdr_ms("no_pending").ToString()
            Else
                lblCount.Text = "0"
            End If
            rdr_ms.Close()
            Con_ms.Close()

            'Pending
            conn_ms = "SELECT COUNT(id) AS no_pending " &
                      "FROM ONLINE.annual_inspection_application " &
                      "WHERE app_status = 'P'"

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr_ms.Read() Then
                lbl_countpending.Text = rdr_ms("no_pending").ToString()
                'lblCount.Text = rdr_ms("no_pending").ToString()
            Else
                lbl_countpending.Text = "0"
                'lblCount.Text = "0"
            End If
            rdr_ms.Close()
            Con_ms.Close()

            'Assessed
            conn_ms = "SELECT COUNT(id) AS no_pending " &
                      "FROM ONLINE.annual_inspection_application " &
                      "WHERE app_status = 'A'"

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr_ms.Read() Then
                lblcountAssessed.Text = rdr_ms("no_pending").ToString()
                'lblCount.Text = rdr_ms("no_pending").ToString()
            Else
                lblcountAssessed.Text = "0"
                'lblCount.Text = "0"
            End If
            rdr_ms.Close()
            Con_ms.Close()

            'Re-upload
            conn_ms = "SELECT COUNT(id) AS no_pending " &
                      "FROM ONLINE.annual_inspection_application " &
                      "WHERE app_status = 'R'"

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr_ms.Read() Then
                lbl_countReupload.Text = rdr_ms("no_pending").ToString()
                'lblCount.Text = rdr_ms("no_pending").ToString()
            Else
                lbl_countReupload.Text = "0"
                'lblCount.Text = "0"
            End If
            rdr_ms.Close()
            Con_ms.Close()

            'Denied
            conn_ms = "SELECT COUNT(id) AS no_pending " &
                      "FROM ONLINE.annual_inspection_application " &
                      "WHERE app_status = 'D' "

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr_ms.Read() Then
                lbl_countDenied.Text = rdr_ms("no_pending").ToString()
                'lblCount.Text = rdr_ms("no_pending").ToString()
            Else
                lbl_countDenied.Text = "0"
                'lblCount.Text = "0"
            End If
            rdr_ms.Close()
            Con_ms.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rdr_ms.Close()
            Con_ms.Close()
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        DataGrid.Rows.Clear()
        lblCount.Visible = False
        Dim Pending As Integer = 0
        conn_ms = "SELECT * " &
                     "FROM ONLINE.annual_inspection_application " &
                     "WHERE app_status = 'P' "
        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        Do While rdr_ms.Read()

            DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("application_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

        Loop
        rdr_ms.Close()
        Con_ms.Close()


    End Sub

    Private Sub dt_Appoinment_ValueChanged(sender As Object, e As EventArgs) Handles dt_Appoinment.ValueChanged

        lblCount.Visible = True

        conn_ms = "SELECT COUNT(id) AS no_pending " &
                     "FROM ONLINE.annual_inspection_application " &
                     "WHERE CONVERT(date, application_date) BETWEEN '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' AND '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' "

        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms.Read() Then
            lblCount.Text = rdr_ms("no_pending").ToString()
        Else
            lblCount.Text = "0"
        End If
        rdr_ms.Close()
        Con_ms.Close()


    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

        DataGrid.Rows.Clear()
        lblCount.Visible = False
        Try
            If cmb_appointmentstatus.Text = "ALL" Then

                conn_ms = "SELECT * " &
           "FROM ONLINE.annual_inspection_application " &
           "WHERE ((app_status = 'P' AND CONVERT(date, application_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
           " OR (app_status = 'R' AND CONVERT(date, reupload_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
           " OR (app_status = 'A' AND CONVERT(date, assess_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "') " &
           " OR (app_status = 'D' AND CONVERT(date, denied_date) BETWEEN '" & Format(dt_Appoinment.Value, "yyyy-MM-dd") & "' AND '" & Format(dt_Appoinment1.Value, "yyyy-MM-dd") & "'));"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)

                Do While rdr_ms.Read = True

                    Dim status As String = rdr_ms("app_status").ToString()
                    Dim dateValue As String = ""


                    If status = "P" Then
                        If IsDBNull(rdr_ms("application_date")) Then
                            dateValue = "-"
                        Else
                            dateValue = Format(rdr_ms("application_date"), "yyyy-MM-dd")
                        End If
                    ElseIf status = "A" Then
                        If IsDBNull(rdr_ms("assess_date")) Then
                            dateValue = "-"
                        Else
                            dateValue = Format(rdr_ms("assess_date"), "yyyy-MM-dd")
                        End If

                    ElseIf status = "R" Then
                        If IsDBNull(rdr_ms("reupload_date")) Then
                            dateValue = "-"
                        Else
                            dateValue = Format(rdr_ms("reupload_date"), "yyyy-MM-dd")
                        End If
                    ElseIf status = "D" Then
                        If IsDBNull(rdr_ms("denied_date")) Then
                            dateValue = "-"
                        Else
                            dateValue = Format(rdr_ms("denied_date"), "yyyy-MM-dd")
                        End If
                    End If

                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), dateValue, rdr_ms("accountno"), rdr_ms("bussname"), status, "VIEW")
                Loop
                Con_ms.Close()

            ElseIf cmb_appointmentstatus.Text = "PENDING" Then

                conn_ms = "SELECT * " & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='P' and Convert(date, application_date) between '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' and '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY application_date ASC"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("application_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
                Loop
                rdr_ms.Close()
                Con_ms.Close()

            ElseIf cmb_appointmentstatus.Text = "ASSESSED" Then


                conn_ms = "SELECT *" & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='A' and Convert(date, assess_date) between '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' and '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY application_date ASC"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("assess_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

                Loop
                rdr_ms.Close()
                Con_ms.Close()

            ElseIf cmb_appointmentstatus.Text = "DENIED" Then


                conn_ms = "SELECT * " & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='D' and Convert(date, denied_date) between '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' and '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY application_date ASC"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("denied_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

                Loop
                rdr_ms.Close()
                Con_ms.Close()

            ElseIf cmb_appointmentstatus.Text = "RE-UPLOAD" Then

                conn_ms = "SELECT * " & _
                          "FROM ONLINE.annual_inspection_application " & _
                          "WHERE app_status ='R' and Convert(date, reupload_date) between '" & Format((dt_Appoinment.Value), "yyyy-MM-dd") & "' and '" & Format((dt_Appoinment1.Value), "yyyy-MM-dd") & "' ORDER BY application_date ASC"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True

                    DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("reupload_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

                Loop
                rdr_ms.Close()
                Con_ms.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        lblCount.Text = DataGrid.RowCount
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormStatus = False
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click


        DataGrid.Rows.Clear()
        lblCount.Visible = False
        Try
            conn_ms = "SELECT * " _
                         & "FROM ONLINE.annual_inspection_application " _
                         & "WHERE app_status = 'D'"
            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            Do While rdr_ms.Read = True

                DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("denied_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

            Loop

            Con_ms.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label9.Click

    End Sub

    Private Sub lblcountissued_Click(sender As Object, e As EventArgs) Handles lblcountAssessed.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint, Panel1.Paint

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        'Assessed
        DataGrid.Rows.Clear()
        lblCount.Visible = False
        Try
            conn_ms = "SELECT * " _
                     & "FROM ONLINE.annual_inspection_application " _
                     & "WHERE app_status = 'A'" _
                     & "ORDER BY assess_date"
            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            Do While rdr_ms.Read = True

                DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("assess_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

            Loop

            Con_ms.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        conn_ms = "DELETE from ONLINE.annual_inspection_application WHERE ApplicationID='" & DataGrid.Item(0, DataGrid.CurrentRow.Index).Value & "'"
        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        cmd_ms.ExecuteNonQuery()
        MsgBox("This application record is sucessfully deleted!")

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        'Re-Upload
        DataGrid.Rows.Clear()
        lblCount.Visible = False

        Try
            conn_ms = "SELECT * " &
              "FROM ONLINE.annual_inspection_application " &
              "WHERE app_status = 'R' ORDER BY reupload_date"

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)

            Do While rdr_ms.Read()

                DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("reupload_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")

            Loop

            Con_ms.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  
End Class