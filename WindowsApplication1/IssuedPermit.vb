Imports System.Data.SqlClient
Imports System.IO


Public Class IssuedPermit

    Private Sub UploadScannedReceipt_Click(sender As Object, e As EventArgs) Handles UploadScannedReceipt.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff"


        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Try
                'PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            Catch ex As Exception

                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ORlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Try
            Dim folderpath As String = link_prefix & folder_directory & referencono.Text & "\" & referencono.Text & "_OR.pdf"

            If System.IO.File.Exists(folderpath) Then
                Dim viewer As New ORviewer()
                viewer.AxAcroPDF2.src = folderpath
                viewer.ShowDialog()
            Else
                MessageBox.Show("Please Contact Management Informantion System Office to Track this Reference: " & referencono.Text, "Management Informantion System Office", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error opening OR file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub B_Issued_Click(sender As Object, e As EventArgs) Handles B_Issued.Click

        'attachment here
        If String.IsNullOrWhiteSpace(Issued_file.Text) Then
            MsgBox("Please attach your Issuance", vbOKOnly & vbCritical, "Annual Inspection Online")
            Exit Sub
        End If
        Try

            Dim rawPath2 As String = AxAcroPDF2.src
            Dim sourcePath2 As String = rawPath2.Replace("file://", "").Trim()

            Dim folderpath = link_prefix & folder_directory & referencono.Text & "\"
            Dim filename = referencono.Text & "_Certificate.pdf"
            Dim filePath As String = Path.Combine(folderpath, filename)
            Dim ask As DialogResult

            ask = MessageBox.Show("Are you sure this is CERTIFICATE?",
                                 "Annual Inspection Online",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

            If ask = DialogResult.Yes Then

                If Not Directory.Exists(folderpath) Then
                    Directory.CreateDirectory(folderpath)
                End If

                If String.IsNullOrWhiteSpace(sourcePath2) OrElse Not File.Exists(sourcePath2) Then
                    filePath = ""
                Else

                    File.Copy(sourcePath2, filePath, True)
                End If

                Con_ms1 = New SqlConnection(mcs)
                Con_ms1.Open()
                conn_ms1 = "UPDATE ONLINE.annual_inspection_application SET app_status = 'I', issuance_date = @issuance_date, file_certificate = @file_certificate where id='" & TxtApplicationID.Text & "'"
                cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
                cmd_ms1.Parameters.Add("@issuance_date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms1.Parameters.Add("@file_certificate", SqlDbType.VarChar).Value = filename
                cmd_ms1.ExecuteNonQuery()
                Con_ms1.Close()

                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, email, Subject, fullname, referencecode, datesend, assessment_path) " _
                   & "VALUES (@userid, @accountno, @txt_email, 'Annual Inspection Issuance' ,@fullname, @referencono, @Date, @assessment_path)"
                cmd_ms = New SqlCommand(conn, Con_ms)
                cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = useraccountid.Text
                cmd_ms.Parameters.Add("@accountno", SqlDbType.VarChar).Value = TxtAccountNo.Text & "-" & TxtBusinessName.Text
                cmd_ms.Parameters.Add("@txt_email", SqlDbType.VarChar).Value = txt_email.Text
                cmd_ms.Parameters.Add("@fullname", SqlDbType.VarChar).Value = fullname.Text
                cmd_ms.Parameters.Add("@referencono", SqlDbType.VarChar).Value = referencono.Text
                cmd_ms.Parameters.Add("@assessment_path", SqlDbType.VarChar).Value = filePath
                cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()
                MsgBox("Annual Inspection Issued successfully", vbOKOnly & vbInformation, "Annual Inspection Online")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms.Close()
        End Try
        Me.Close()
    End Sub

    

    Private Sub B_SentNotification_Click(sender As Object, e As EventArgs) Handles B_SentNotification.Click

        Dim ask As DialogResult

        ask = MessageBox.Show("Are you going to notify the applicant to signing?",
                             "Annual Inspection Online",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question)

        If ask = DialogResult.Yes Then
            Dim YearEnd As DateTime = New DateTime(DateTime.Now.Year, 12, 31, 0, 0, 0)
            Try
                Con_ms1 = New SqlConnection(mcs)
                Con_ms1.Open()
                conn_ms1 = "UPDATE ONLINE.annual_inspection_application SET app_status = 'S', AdminUserID = @Admin, Signed_date = @Date where id='" & TxtApplicationID.Text & "'"
                cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
                cmd_ms1.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms1.Parameters.Add("@Admin", SqlDbType.VarChar).Value = AdminUserID
                cmd_ms1.ExecuteNonQuery()
                Con_ms1.Close()


                Con_ms2 = New SqlConnection(mcs)
                Con_ms2.Open()
                conn2 = "INSERT INTO ONLINE.blocklistedBusiness (user_created, accountno, businessname, businessowner, businessaddress, regulatory, status, dateblocked, remarks, user_updated, Expirationdate) " _
                   & "VALUES (@userid, @accountno, @businessname, @businessowner ,@businessaddress, 'BUSINESS', 'U', @Date, 'ISSUANCE', @user_update, @Expirationdate)"
                cmd_ms2 = New SqlCommand(conn2, Con_ms2)
                cmd_ms2.Parameters.Add("@userid", SqlDbType.VarChar).Value = useraccountid.Text
                cmd_ms2.Parameters.Add("@accountno", SqlDbType.VarChar).Value = TxtNoStorey.Text
                cmd_ms2.Parameters.Add("@businessname", SqlDbType.VarChar).Value = TxtBldg_permit.Text
                cmd_ms2.Parameters.Add("@businessowner", SqlDbType.VarChar).Value = TxtOccupancyPermit.Text
                cmd_ms2.Parameters.Add("@businessaddress", SqlDbType.VarChar).Value = TxtBuildingAddress.Text
                cmd_ms2.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms2.Parameters.Add("@user_update", SqlDbType.VarChar).Value = useraccountid.Text
                cmd_ms2.Parameters.Add("@Expirationdate", SqlDbType.DateTime).Value = YearEnd
                cmd_ms2.ExecuteNonQuery()
                Con_ms2.Close()


                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, email, Subject, fullname, referencecode, datesend) " _
                   & "VALUES (@userid, @accountno, @txt_email, 'Annual Inspection Signed' ,@fullname, @referencono, @Date)"
                cmd_ms = New SqlCommand(conn, Con_ms)
                cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = useraccountid.Text
                cmd_ms.Parameters.Add("@accountno", SqlDbType.VarChar).Value = TxtAccountNo.Text & "-" & TxtBusinessName.Text
                cmd_ms.Parameters.Add("@txt_email", SqlDbType.VarChar).Value = txt_email.Text
                cmd_ms.Parameters.Add("@fullname", SqlDbType.VarChar).Value = fullname.Text
                cmd_ms.Parameters.Add("@referencono", SqlDbType.VarChar).Value = referencono.Text
                cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()

                InspectionPermit_DashBoard.PictureBox2_Click(sender, e)
                MsgBox("Annual Inspection Signed successfully", vbOKOnly & vbInformation, "Annual Inspection Online")
                PrintInspectionRecord.Show()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Con_ms.Close()
                Con_ms1.Close()
                Con_ms2.Close()
            End Try
        End If
        Con_ms.Close()
        Con_ms1.Close()
        Con_ms2.Close()
        Me.Close()
    End Sub

    Private Sub B_IssuedAttach_Click(sender As Object, e As EventArgs) Handles B_IssuedAttach.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "PDF Files|*.pdf"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Issued_file.Text = openFileDialog.FileName
                ' Optionally preview it in the PDF viewer:
                AxAcroPDF2.src = openFileDialog.FileName
            Catch ex As Exception
                MessageBox.Show("Error loading file: " & ex.Message)
            End Try
        End If

    End Sub
    Private Sub B_Signed_Click(sender As Object, e As EventArgs) Handles B_Signed.Click

        Con_ms1 = New SqlConnection(mcs)
        Con_ms1.Open()
        conn_ms1 = "UPDATE ONLINE.annual_inspection_application SET app_status = 'SD', Signed_date = @Date where id='" & TxtApplicationID.Text & "'"
        cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
        cmd_ms1.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
        cmd_ms1.ExecuteNonQuery()
        Con_ms1.Close()
        MsgBox("Annual Inspection Already Signed", vbOKOnly & vbInformation, "Annual Inspection Online")
        Me.Close()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Or_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Or_link.LinkClicked

        Try
            Dim folderpath As String = link_prefix & folder_directory & referencono.Text & "\" & referencono.Text & "_OR.pdf"

            If System.IO.File.Exists(folderpath) Then
                Dim viewer As New ORviewer()
                viewer.AxAcroPDF2.src = folderpath
                viewer.ShowDialog()
            Else
                MessageBox.Show("Please Contact Management Informantion System Office to Track this Reference: " & referencono.Text, "Management Informantion System Office", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error opening OR file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Print_Record_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Print_Record.LinkClicked
        PrintInspectionRecord.Show()
    End Sub

End Class