Imports System.IO
Imports System.Data.SqlClient
Public Class Inspector_ApplicationRecord

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormStatus = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        'Con_ms = New SqlConnection(mcs)
        'Con_ms.Open()
        'conn_ms = "UPDATE ONLINE.business_application_tbl set process_status = '0' " _
        '    & "WHERE applicationID='" & applicationID_search & "'"
        'cmd_ms = New SqlCommand(conn_ms, Con_ms)
        'cmd_ms.ExecuteNonQuery()
        'Con_ms.Close()
        Me.Close()
        FormStatus = False

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        'Con_ms = New SqlConnection(mcs)
        'Con_ms.Open()
        'conn_ms = "UPDATE ONLINE.business_application_tbl set process_status = '0' " _
        '    & "WHERE applicationID='" & applicationID_search & "'"
        'cmd_ms = New SqlCommand(conn_ms, Con_ms)
        'cmd_ms.ExecuteNonQuery()
        'Con_ms.Close()
        Me.Close()
        'FormStatus = False

    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPrintHealthCard_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAddNewRecord_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Grid_attachments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_attachments.CellContentClick


        Dim link_string As String
        link_string = link_prefix & folder_directory & TxtRefenceNo.Text & "\" & Grid_attachments.Item(0, Grid_attachments.CurrentRow.Index).Value
        Dim extension = System.IO.Path.GetExtension(link_string)

        If (extension = ".pdf") Then
            ViewAttachments_webcontrol.Text = Grid_attachments.Item(1, Grid_attachments.CurrentRow.Index).Value + " Attachments of " + TxtAccountNo.Text
            ViewAttachments_webcontrol.AxAcroPDF1.src = link_string
            ViewAttachments_webcontrol.ShowDialog()
        Else
            ViewAttachmentsPictureBox.Text = Grid_attachments.Item(1, Grid_attachments.CurrentRow.Index).Value + " Attachments of " + TxtAccountNo.Text
            ViewAttachmentsPictureBox.PictureBox1.Image = Image.FromFile(link_string)
            ViewAttachmentsPictureBox.ShowDialog()

        End If

    End Sub

    Private Sub BtnAddNewRecord_Click_1(sender As Object, e As EventArgs) Handles BtnAddNewRecord.Click


        If String.IsNullOrWhiteSpace(assessment_file.Text) Then
            MsgBox("Please attach Assessment", vbOKOnly & vbCritical, "Construction Permit Online")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TxtBusinessAddress.Text) Then
            MsgBox("Please input the Amount", vbOKOnly & vbCritical, "Construction Permit Online")
            Exit Sub
        End If

        Dim rawPath2 As String = AxAcroPDF2.src
        Dim sourcePath2 As String = rawPath2.Replace("file://", "").Trim()

        Dim folderpath = link_prefix & folder_directory & TxtRefenceNo.Text & "\"
        Dim filename = TxtRefenceNo.Text & "_Tax_Assessment.pdf"
        Dim filePath As String = Path.Combine(folderpath, filename)

        If Not Directory.Exists(folderpath) Then
            Directory.CreateDirectory(folderpath)
        End If

        If String.IsNullOrWhiteSpace(sourcePath2) OrElse Not File.Exists(sourcePath2) Then
            filePath = ""
        Else

            File.Copy(sourcePath2, filePath, True)
        End If

        Dim Construction_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Construction_ApplicationRecord"), Inspector_ApplicationRecord)

        Con_ms = New SqlConnection(mcs)
        Con_ms.Open()
        conn_ms = "UPDATE ONLINE.annual_inspection_application set assessmentfile = @assessmentfile, remark='" & txt_remarks.Text & "' , app_status = 'A', assess_date = @date, user_assess ='" & fullname.Text & "', assessmentamount = @amount WHERE id='" & txt_applicationno.Text & "'"
        Try

            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            cmd_ms.Parameters.Add("@date", SqlDbType.DateTime).Value = Date.Now
            cmd_ms.Parameters.Add("@assessmentfile", SqlDbType.VarChar).Value = filename
            cmd_ms.Parameters.Add("@amount", SqlDbType.VarChar).Value = TxtBusinessAddress.Text
            cmd_ms.ExecuteNonQuery()
            Con_ms.Close()
            FormStatus = False

            Con_ms1 = New SqlConnection(mcs)
            Con_ms1.Open()
            conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, Remarks, email, Subject, fullname, referencecode, datesend, assessment_path) " _
               & "VALUES (@userid, @TDN,  @Remarks, '" & txt_email.Text & "', 'Construction Assessment' ,@Project_title, @TxtRefenceNo, @Date, @assessment_path)"
            cmd_ms1 = New SqlCommand(conn, Con_ms1)
            'cmd_ms1.Parameters.Add("@TDN", SqlDbType.VarChar).Value = lbl_AccountNo.Text & " - " & typeofapplication.Text
            cmd_ms1.Parameters.Add("@Project_title", SqlDbType.VarChar).Value = fullname.Text
            cmd_ms1.Parameters.Add("@userid", SqlDbType.VarChar).Value = useraccountid.Text
            cmd_ms1.Parameters.Add("@TxtRefenceNo", SqlDbType.VarChar).Value = TxtRefenceNo.Text
            cmd_ms1.Parameters.Add("@assessment_path", SqlDbType.VarChar).Value = filePath
            cmd_ms1.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txt_remarks.Text
            cmd_ms1.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
            cmd_ms1.ExecuteNonQuery()
            MsgBox("Construction Permit application successfully Verified", vbOKOnly & vbInformation, "Construction Permit Online")
            Con_ms1.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms.Close()
            Con_ms1.Close()
        End Try
        Me.Close()

    End Sub

    Private Sub btnDeny_Click_1(sender As Object, e As EventArgs) Handles btnDeny.Click
        Deny.Show()
    End Sub

    Private Sub B_assessAttach_Click(sender As Object, e As EventArgs) Handles B_assessAttach.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "PDF Files|*.pdf"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                assessment_file.Text = openFileDialog.FileName
                ' Optionally preview it in the PDF viewer:
                AxAcroPDF2.src = openFileDialog.FileName
            Catch ex As Exception
                MessageBox.Show("Error loading file: " & ex.Message)
            End Try
        End If

    End Sub


    Private Sub B_Reupload_Click(sender As Object, e As EventArgs) Handles B_Reupload.Click

        Con_ms1 = New SqlConnection(mcs)
        Con_ms1.Open()

        conn1 = "SELECT * FROM ONLINE.annual_inspection_application WHERE id = '" & txt_applicationno.Text & "' "
        cmd_ms1 = New SqlCommand(conn1, Con_ms1)
        rdr_ms1 = cmd_ms1.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr_ms1.Read() Then
            If rdr_ms1("app_status").ToString() = "P" Then

                'Con_ms = New SqlConnection(mcs)
                'Con_ms.Open()
                'conn_ms = "UPDATE ONLINE.annual_inspection_application set  , app_status = 'R' WHERE id='" & txt_applicationno.Text & "'"
                'cmd_ms = New SqlCommand(conn_ms, Con_ms)
                'Con_ms.Close()
                ReUpload.ShowDialog()

            Else
                MessageBox.Show("No application to Re-Upload")
            End If

        End If
        rdr_ms1.Close()
        Con_ms1.Close()
        Me.Close()
    End Sub


    Private Sub Construction_ApplicationRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class