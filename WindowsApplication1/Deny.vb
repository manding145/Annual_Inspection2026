Imports System.Data.SqlClient
Public Class Deny
    Dim lack_itr1, lack_itr2, lack_itr3, lack_itr4, lack_gross, lack_firearms, lack_waterpotability, lack_francisetooperate, lack_bsp, lack_slaughter, lack_cityvet, lack_peso, lack_dole, lack_dot, lack_citytourism, lack_licensetooperate, lack_agriculture, lack_pcab, lack_psa, lack_enro, lack_brgyresolution, lack_spa, lack_contractlease, lack_validid, lack_cda, lack_coop, lack_ctc, lack_bfad, lack_unf, lack_brgyclearance, lack_oldpermit, lack_oldplate, lack_oldfire, lack_itr, lack_market_clearance As Integer
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ck_brgyclearance.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Inspector_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Inspector_ApplicationRecord"), Inspector_ApplicationRecord)

        With Inspector_ApplicationRecord

            Dim mytimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Try
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, Remarks, email, Subject, fullname, referencecode, datesend) " _
                   & "VALUES (@userid, @fullname,  @Remarks, '" & .txt_email.Text & "', 'Construction Permit Deny Application' ,@fullname, '" & .TxtRefenceNo.Text & "', @Date)"
                cmd_ms = New SqlCommand(conn, Con_ms)
                cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = .useraccountid.Text
                cmd_ms.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txt_remarks.Text
                cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()

                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn_ms = "UPDATE ONLINE.annual_inspection_application set app_status = 'D', remark = @Remarks, deny_date = @date, user_deny='" & .fullname.Text & "' WHERE id='" & .txt_applicationno.Text & "'"
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                cmd_ms.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txt_remarks.Text
                cmd_ms.Parameters.Add("@date", SqlDbType.DateTime).Value = Date.Now
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()

                MsgBox("Application successully denied. This client will received notification to his email.", vbOKOnly & vbInformation, "Annual Inspection Online")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Con.Close()
            End Try


        End With

    End Sub

    Private Sub BtnSearchRecord_Click(sender As Object, e As EventArgs) Handles BtnSearchRecord.Click
        Me.Close()
    End Sub

End Class