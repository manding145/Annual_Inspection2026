Imports System.Data.SqlClient
Imports System.IO


Public Class IssuedPermit


    Private Sub BtnSearchRecord_Click(sender As Object, e As EventArgs) Handles BtnSearchRecord.Click


        'Try
        '    InspectorDashBoard.DataGrid.Rows.Clear()
        '    conn = "SELECT ONLINE.business_application_tbl.applicationID as applicationID , ONLINE.business_application_tbl.accountno AS act, ONLINE.business_record_hdr.b_name as bname, ONLINE.business_assessment_dtl.Total_amt as amt " _
        '    & "FROM " _
        '    & "ONLINE.business_application_tbl INNER JOIN ONLINE.business_assessment_dtl ON ONLINE.business_assessment_dtl.applicationID= ONLINE.business_application_tbl.applicationID INNER JOIN ONLINE.business_applicationstatus_dtl ON ONLINE.business_applicationstatus_dtl.ApplicationID = ONLINE.business_application_tbl.applicationID INNER JOIN ONLINE.business_record_hdr ON ONLINE.business_record_hdr.recordID =  ONLINE.business_application_tbl.recordID " & _
        '    "where ONLINE.business_application_tbl.accountno LIKE '%" & referencono.Text & "' and YEAR(ONLINE.business_application_tbl.application_date)='" & Date.Now.Year & "' AND ONLINE.business_applicationstatus_dtl.payment_status='P'"
        '    Con_ms = New SqlConnection(mcs)
        '    Con_ms.Open()
        '    cmd_ms = New SqlCommand(conn, Con_ms)
        '    rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        '    If rdr_ms.Read = True Then

        '        TxtBusinessName.Text = rdr_ms("bname").ToString
        '        'TotalAssessmentAmount.Text = rdr_ms("amt").ToString
        '        TxtAccountNo.Text = rdr_ms("id").ToString

        '    Else

        '        MsgBox("Business Record Not Found!")
        '    End If


        '    Con_ms.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
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



    Private Sub Button2_Click(sender As Object, e As EventArgs)

        'Dim openFileDialog As New OpenFileDialog()

        'openFileDialog.Filter = "PDF Files|*.pdf"


        'If openFileDialog.ShowDialog() = DialogResult.OK Then

        '    Try
        '        AxAcroPDF2.src = openFileDialog.FileName
        '        Issued_attachment.Text = openFileDialog.FileName
        '    Catch ex As Exception

        '        MessageBox.Show("Error loading files: " & ex.Message)
        '    End Try
        'End If


    End Sub

    Private Sub B_upload_Click(sender As Object, e As EventArgs)

        'Dim openFileDialog As New OpenFileDialog()
        'openFileDialog.Filter = "PDF Files|*.pdf"

        'If openFileDialog.ShowDialog() = DialogResult.OK Then
        '    Try
        '        Issued_attachment.Text = openFileDialog.FileName
        '        ' Optionally preview it in the PDF viewer:
        '        AxAcroPDF2.src = openFileDialog.FileName
        '    Catch ex As Exception
        '        MessageBox.Show("Error loading file: " & ex.Message)
        '    End Try
        'End If

    End Sub

    Private Sub IssuedPermit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub B_Signed_Click(sender As Object, e As EventArgs) Handles B_Signed.Click

        Try
            Con_ms1 = New SqlConnection(mcs)
            Con_ms1.Open()
            conn_ms1 = "UPDATE ONLINE.annual_inspection_application SET app_status = 'S', signing_date = @signing_date where id='" & TxtApplicationID.Text & "'"
            cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
            cmd_ms1.Parameters.Add("@signing_date", SqlDbType.DateTime).Value = DateAndTime.Now()
            cmd_ms1.ExecuteNonQuery()
            Con_ms1.Close()

            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, email, Subject, fullname, referencecode, datesend) " _
               & "VALUES (@userid, @accountno, @txt_email, 'Annual Inspection Signed' ,@fullname, @referencono, @Date)"
            cmd_ms = New SqlCommand(conn, Con_ms)
            cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = useraccountid.Text
            cmd_ms.Parameters.Add("@accountno", SqlDbType.VarChar).Value = TxtAccountNo.Text & "-" & TxtOwnerName.Text
            cmd_ms.Parameters.Add("@txt_email", SqlDbType.VarChar).Value = txt_email.Text
            cmd_ms.Parameters.Add("@applicant", SqlDbType.VarChar).Value = fullname.Text
            cmd_ms.Parameters.Add("@applicant", SqlDbType.VarChar).Value = referencono.Text
            cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
            cmd_ms.ExecuteNonQuery()
            Con_ms.Close()

            MsgBox("Annual Inspection Signed successfully", vbOKOnly & vbInformation, "Annual Inspection Online")
       
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms.Close()
        End Try

    End Sub

    Private Sub B_Issued_Click(sender As Object, e As EventArgs) Handles B_Issued.Click


        Try
            Con_ms1 = New SqlConnection(mcs)
            Con_ms1.Open()
            conn_ms1 = "UPDATE ONLINE.annual_inspection_application SET app_status = 'I', issuance_date = @issuance_date where id='" & TxtApplicationID.Text & "'"
            cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
            cmd_ms1.Parameters.Add("@issuance_date", SqlDbType.DateTime).Value = DateAndTime.Now()
            cmd_ms1.ExecuteNonQuery()
            Con_ms1.Close()


            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, email, Subject, fullname, referencecode, datesend) " _
               & "VALUES (@userid, @accountno, @txt_email, 'Annual Inspection Issuance' ,@fullname, @referencono, @Date)"
            cmd_ms = New SqlCommand(conn, Con_ms)
            cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = useraccountid.Text
            cmd_ms.Parameters.Add("@accountno", SqlDbType.VarChar).Value = TxtAccountNo.Text & "-" & TxtOwnerName.Text
            cmd_ms.Parameters.Add("@txt_email", SqlDbType.VarChar).Value = txt_email.Text
            cmd_ms.Parameters.Add("@applicant", SqlDbType.VarChar).Value = fullname.Text
            cmd_ms.Parameters.Add("@applicant", SqlDbType.VarChar).Value = referencono.Text
            cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
            cmd_ms.ExecuteNonQuery()
            Con_ms.Close()

            MsgBox("Annual Inspection Issued successfully", vbOKOnly & vbInformation, "Annual Inspection Online")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms.Close()
        End Try


    End Sub
End Class