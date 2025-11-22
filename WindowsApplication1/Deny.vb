Imports System.Data.SqlClient
Public Class Deny

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Inspector_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Inspector_ApplicationRecord"), Inspector_ApplicationRecord)
        With Inspector_ApplicationRecord

            Dim mytimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Try
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, Remarks, email, Subject, fullname, referencecode, datesend) " _
                   & "VALUES (@userid, @fullname,  @Remarks, '" & .txt_email.Text & "', 'Annual Inspection Deny Application' ,@fullname, '" & .TxtRefenceNo.Text & "', @Date)"
                cmd_ms = New SqlCommand(conn, Con_ms)
                cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = .useraccountid.Text
                cmd_ms.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txt_remarks.Text
                cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()

                Con_ms1 = New SqlConnection(mcs)
                Con_ms1.Open()
                conn_ms1 = "UPDATE ONLINE.annual_inspection_application set app_status = 'D', remark = @Remarks, denied_date = @date WHERE id='" & .txt_applicationno.Text & "'"
                cmd_ms = New SqlCommand(conn_ms1, Con_ms1)
                cmd_ms1.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txt_remarks.Text
                cmd_ms1.Parameters.Add("@date", SqlDbType.DateTime).Value = Date.Now
                cmd_ms1.ExecuteNonQuery()
                Con_ms1.Close()

                MsgBox("Application successully denied. This client will received notification to his email.", vbOKOnly & vbInformation, "Annual Inspection Online")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Con_ms.Close()
                Con_ms1.Close()
            End Try
        End With
        Con_ms.Close()
        Con_ms1.Close()
    End Sub

    Private Sub BtnSearchRecord_Click(sender As Object, e As EventArgs) Handles BtnSearchRecord.Click
        Me.Close()
    End Sub

End Class