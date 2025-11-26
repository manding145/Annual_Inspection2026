Imports System.Data.SqlClient
Public Class SearchPermitRecord

    Private Sub BtnSearchRecord_Click(sender As Object, e As EventArgs) Handles BtnSearchRecord.Click

        Dim inspectorDashBoard As InspectorDashBoard = CType(Application.OpenForms("InspectorDashBoard"), InspectorDashBoard)
        With inspectorDashBoard
            Try
                .DataGrid.Rows.Clear()
                conn = "SELECT * FROM ONLINE.annual_inspection_application where accountNo LIKE '%" & txt_accountno.Text & "%' AND app_status IN ( 'PAID', 'SD', 'S', 'I' ) ORDER BY application_date ASC;"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                Do While rdr_ms.Read = True
                    .DataGrid.Rows.Add(rdr_ms("id"), rdr_ms("refno"), rdr_ms("application_date"), rdr_ms("accountno"), rdr_ms("bussname"), rdr_ms("app_status"), "VIEW")
                Loop

                Con_ms.Close()
                Dim aa As String
                aa = .DataGrid.RowCount
                If .DataGrid.RowCount = 0 Then
                    MsgBox("No Record Found!", vbOKOnly & vbCritical, "Annual Inspection Online")
                    Me.Close()
                Else
                    MsgBox(aa + " Record Found!", vbOKOnly & vbInformation, "Annual Inspection Online")

                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
       
    End Sub

    Private Sub check_controlno_CheckedChanged(sender As Object, e As EventArgs)
        If check_Accuntno.Checked = False Then
            txt_accountno.Enabled = False
            txt_accountno.Text = ""
        Else
            txt_accountno.Enabled = True
            txt_accountno.Text = ""
        End If
    End Sub

    Private Sub txt_accountno_TextChanged(sender As Object, e As EventArgs) Handles txt_accountno.TextChanged

    End Sub
End Class