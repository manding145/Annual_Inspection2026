Imports System.Data.SqlClient
Imports System.IO


Public Class Payment

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSearchRecord_Click(sender As Object, e As EventArgs) Handles BtnSearchRecord.Click
        Try
            InspectorDashBoard.DataGrid.Rows.Clear()
            conn = "SELECT ONLINE.business_application_tbl.applicationID as applicationID , ONLINE.business_application_tbl.accountno AS act, ONLINE.business_record_hdr.b_name as bname, ONLINE.business_assessment_dtl.Total_amt as amt " _
            & "FROM " _
            & "ONLINE.business_application_tbl INNER JOIN ONLINE.business_assessment_dtl ON ONLINE.business_assessment_dtl.applicationID= ONLINE.business_application_tbl.applicationID INNER JOIN ONLINE.business_applicationstatus_dtl ON ONLINE.business_applicationstatus_dtl.ApplicationID = ONLINE.business_application_tbl.applicationID INNER JOIN ONLINE.business_record_hdr ON ONLINE.business_record_hdr.recordID =  ONLINE.business_application_tbl.recordID " & _
            "where ONLINE.business_application_tbl.accountno LIKE '%" & referencono.Text & "' and YEAR(ONLINE.business_application_tbl.application_date)='" & Date.Now.Year & "' AND ONLINE.business_applicationstatus_dtl.payment_status='P'"
            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr_ms.Read = True Then

                TxtProjectName.Text = rdr_ms("bname").ToString
                'TotalAssessmentAmount.Text = rdr_ms("amt").ToString
                TxtTDN.Text = rdr_ms("id").ToString

            Else

                MsgBox("Business Record Not Found!")
            End If


            Con_ms.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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

    Private Sub SaveNow_Click(sender As Object, e As EventArgs) Handles SaveNow.Click

        Try

            'If TxtTransaction.Text = "" Then

            '    MsgBox("Transaction cannot be empty!")
            '    Exit Sub
            'End If


            If ORattachment.Text = "" Then

                MsgBox(" No Offiecial Receipt file uploaded")
                Exit Sub
            End If

            Dim rawPath2 As String = AxAcroPDF2.src
            Dim sourcePath2 As String = rawPath2.Replace("file://", "").Trim()

            Dim folderpath = link_prefix & folder_directory & referencono.Text & "\"
            Dim filename = referencono.Text & "_OR.pdf"
            Dim filePath = Path.Combine(folderpath, filename)

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
            conn_ms1 = "UPDATE ONLINE.annual_inspection_application SET app_status = 'PAID', orfile =@Orfile, Transaction_no = @transaction, payment_date = @date where id='" & TxtApplicationID.Text & "'"
            cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
            cmd_ms1.Parameters.Add("@date", SqlDbType.DateTime).Value = DateAndTime.Now()
            cmd_ms1.Parameters.Add("@orfile", SqlDbType.VarChar).Value = filename
            cmd_ms1.Parameters.Add("@transaction", SqlDbType.VarChar).Value = TxtTransaction.Text
            cmd_ms1.ExecuteNonQuery()
            Con_ms1.Close()


            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, email, Subject, fullname, referencecode, datesend, officialreceipt_path) " _
               & "VALUES (@userid, @TDN, '" & txt_email.Text & "', 'Construction Payment' ,@applicant, '" & referencono.Text & "', @Date, @filePath)"
            cmd_ms = New SqlCommand(conn, Con_ms)
            cmd_ms.Parameters.Add("@TDN", SqlDbType.VarChar).Value = TxtTDN.Text & "-" & Type_App.Text
            cmd_ms.Parameters.Add("@applicant", SqlDbType.VarChar).Value = Txtapplicant_name.Text
            cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = useraccountid.Text
            cmd_ms.Parameters.Add("@filePath", SqlDbType.VarChar).Value = filePath
            cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
            cmd_ms.ExecuteNonQuery()
            Con_ms.Close()


            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms.Close()
        End Try

    End Sub

   

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "PDF Files|*.pdf"


        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Try
                AxAcroPDF2.src = openFileDialog.FileName
                ORattachment.Text = openFileDialog.FileName
            Catch ex As Exception

                MessageBox.Show("Error loading files: " & ex.Message)
            End Try
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "PDF Files|*.pdf"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ORattachment.Text = openFileDialog.FileName
                ' Optionally preview it in the PDF viewer:
                AxAcroPDF2.src = openFileDialog.FileName
            Catch ex As Exception
                MessageBox.Show("Error loading file: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub AxAcroPDF2_Enter(sender As Object, e As EventArgs) Handles AxAcroPDF2.Enter

    End Sub

  
End Class