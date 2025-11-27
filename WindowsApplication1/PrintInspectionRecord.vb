Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Web



Public Class PrintInspectionRecord
    Dim rpt As New InspectionRecord
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GetReport()
        Try

    
        Dim inspector_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Inspector_ApplicationRecord"), Inspector_ApplicationRecord)

            rpt.Load(Application.StartupPath & "\InspectionRecord.rpt")

            'Dim pfields As New ParameterFields


        Dim TxtAccountNo As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtAccountNo")
        Dim TxtBusinessName As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtBusinessName")
        Dim TxtBuildingOwner As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtBuildingOwner")
        Dim TxtBusinessAddress As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtBusinessAddress")
        Dim TxtContact As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtContactNo")
        Dim TxtNoStorey As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtNoStorey")
        Dim TxtBuildingPermit As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtBuildingPermit")
        Dim TxtBldg_date As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtBldg_date")
        Dim TxtOccupancyPermit As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOccupancyPermit")
        Dim TxtOccupancy_date As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOccupancy_date")

        Dim TxtOR_date As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOR_date")
        Dim TxtOR_no As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOR_no")
        Dim TxtAmount As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtAmount")
        Dim TxtOR_remarks As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOR_remarks")

        With inspector_ApplicationRecord

                TxtAccountNo.Text = .txt_applicationno.Text
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn = "SELECT * FROM ONLINE.annual_inspection_application WHERE id = '" & TxtAccountNo.Text & "' "
                cmd_ms = New SqlCommand(conn, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms.Read() Then

                    TxtBusinessName.Text = rdr_ms("bussName")
                    TxtBuildingOwner.Text = rdr_ms("ownerName")
                    TxtBusinessAddress.Text = rdr_ms("bussAddress")

                    TxtNoStorey.Text = rdr_ms("noStorey")
                    TxtBuildingPermit.Text = rdr_ms("BldgPermit_No")
                    TxtBldg_date.Text = rdr_ms("BldgPermit_IssuedDate")
                    TxtOccupancyPermit.Text = rdr_ms("OccupPermit_No")
                    TxtOccupancy_date.Text = rdr_ms("occuPermit_IssuedDate")

                    If Not IsDBNull(rdr_ms("OR_No")) AndAlso rdr_ms("OR_No").ToString <> "" Then

                        TxtOR_no.Text = rdr_ms("OR_No")
                        TxtAmount.Text = rdr_ms("payment_amount")
                        TxtOR_remarks.Text = rdr_ms("OR_remarks")

                        If Not IsDBNull(rdr_ms("paid_date")) Then
                            TxtOR_date.Text = Format(CDate(rdr_ms("paid_date")), "yyyy-MM-dd")
                        End If

                    End If

                    Con_ms1 = New SqlConnection(mcs)
                    Con_ms1.Open()
                    conn1 = "SELECT * FROM ONLINE.Sysmngr WHERE userId = '" & .useraccountid.Text & "' "
                    cmd_ms1 = New SqlCommand(conn1, Con_ms1)
                    rdr_ms1 = cmd_ms1.ExecuteReader(CommandBehavior.CloseConnection)
                    If rdr_ms1.Read() Then
                        TxtContact.Text = rdr_ms1("ContactNo")
                    End If
                    Con_ms1.Close()
                End If

        End With

            'rpt.SetDatabaseLogon("sa", "@dm1n1str@t0r")
            CrystalReportViewer1.ReportSource = rpt
            'CrystalReportViewer1.ParameterFieldInfo = pfields
            CrystalReportViewer1.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms1.Close()
            Con_ms.Close()
        End Try
        Con_ms1.Close()
        Con_ms.Close()
    End Sub

    Private Sub B_print_Click(sender As Object, e As EventArgs) Handles B_print.Click
        Call GetReport()
    End Sub


End Class