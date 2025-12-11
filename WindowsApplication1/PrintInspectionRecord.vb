Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Web



Public Class PrintInspectionRecord
    Dim rpt As New Print_InspectionRecord
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ApplicationRecord_Print()

        Try
            Dim inspector_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Inspector_ApplicationRecord"), Inspector_ApplicationRecord)

            rpt.Load(Application.StartupPath & "\Print_InspectionRecord.rpt")

            'Dim pfields As New ParameterFields

            With inspector_ApplicationRecord


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
                Dim TxtOR_No As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOR_No")
                Dim Txt_Amount As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("Txt_Amount")
                Dim TxtOR_remarks As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOR_remarks")
                Dim TxtInspector As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtInspector")

                Con_ms3 = New SqlConnection(mcs)
                Con_ms3.Open()
                conn_ms3 = "SELECT * FROM ONLINE.annual_inspection_application AS ais " &
                        "LEFT JOIN ONLINE.constr_Sysmngr AS sms ON ais.adminUserID = sms.adminUserID " &
                        "WHERE ais.id = '" & .txt_applicationno.Text & "' "
                cmd_ms3 = New SqlCommand(conn_ms3, Con_ms3)
                rdr_ms3 = cmd_ms3.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms3.Read() Then

                    TxtAccountNo.Text = rdr_ms3("accountNo")
                    TxtBusinessName.Text = rdr_ms3("bussName")
                    TxtBuildingOwner.Text = rdr_ms3("ownerName")
                    TxtBusinessAddress.Text = rdr_ms3("bussAddress")
                    TxtNoStorey.Text = rdr_ms3("noStorey")
                    TxtInspector.Text = If(IsDBNull(rdr_ms3("Fullname")), "", rdr_ms3("Fullname").ToString)

                    TxtBuildingPermit.Text = If(IsDBNull(rdr_ms3("BldgPermit_No")), "", rdr_ms3("BldgPermit_No").ToString)
                    If IsDBNull(rdr_ms3("BldgPermit_IssuedDate")) Then
                        TxtBldg_date.Text = ""
                    Else
                        TxtBldg_date.Text = Format(CDate(rdr_ms3("BldgPermit_IssuedDate")), "yyyy-MM-dd")
                    End If
                    TxtOccupancyPermit.Text = If(IsDBNull(rdr_ms3("OccupPermit_No")), "", rdr_ms3("OccupPermit_No").ToString)
                    If IsDBNull(rdr_ms3("occuPermit_IssuedDate")) Then
                        TxtOccupancy_date.Text = ""
                    Else
                        TxtOccupancy_date.Text = Format(CDate(rdr_ms3("occuPermit_IssuedDate")), "yyyy-MM-dd")
                    End If

                    If Not IsDBNull(rdr_ms3("OR_No")) AndAlso rdr_ms3("OR_No").ToString <> "" Then

                        TxtOR_No.Text = rdr_ms3("OR_No")
                        Txt_Amount.Text = rdr_ms3("payment_amount")
                        TxtOR_remarks.Text = rdr_ms3("OR_remarks")

                        If Not IsDBNull(rdr_ms3("paid_date")) Then
                            TxtOR_date.Text = Format(CDate(rdr_ms3("paid_date")), "yyyy-MM-dd")
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

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms1.Close()
            Con_ms3.Close()
        End Try
        Con_ms1.Close()
        Con_ms3.Close()
    End Sub

    Private Sub IssuedPermit_Print()

        Try
            Dim issuedPermit As IssuedPermit = CType(Application.OpenForms("IssuedPermit"), IssuedPermit)

            rpt.Load(Application.StartupPath & "\Print_InspectionRecord.rpt")
            With issuedPermit

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
                Dim TxtOR_No As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOR_No")
                Dim Txt_Amount As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("Txt_Amount")
                Dim TxtOR_remarks As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtOR_remarks")
                Dim TxtInspector As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.ReportDefinition.Sections(3).ReportObjects("TxtInspector")



                Con_ms3 = New SqlConnection(mcs)
                Con_ms3.Open()
                conn_ms3 = "SELECT * FROM ONLINE.annual_inspection_application as ais " &
                       "LEFT JOIN ONLINE.constr_Sysmngr AS sm ON ais.adminUserID = sm.adminUserID " &
                        "WHERE ais.id = '" & .TxtApplicationID.Text & "' "
                cmd_ms3 = New SqlCommand(conn_ms3, Con_ms3)
                rdr_ms3 = cmd_ms3.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms3.Read() Then

                    TxtAccountNo.Text = rdr_ms3("accountNo")
                    TxtBusinessName.Text = rdr_ms3("bussName")
                    TxtBuildingOwner.Text = rdr_ms3("ownerName")
                    TxtBusinessAddress.Text = rdr_ms3("bussAddress")
                    TxtNoStorey.Text = rdr_ms3("noStorey")
                    TxtInspector.Text = If(IsDBNull(rdr_ms3("Fullname")), "", rdr_ms3("Fullname").ToString)

                    TxtBuildingPermit.Text = If(IsDBNull(rdr_ms3("BldgPermit_No")), "", rdr_ms3("BldgPermit_No").ToString)
                    If IsDBNull(rdr_ms3("BldgPermit_IssuedDate")) Then
                        TxtBldg_date.Text = ""
                    Else
                        TxtBldg_date.Text = Format(CDate(rdr_ms3("BldgPermit_IssuedDate")), "yyyy-MM-dd")
                    End If
                    TxtOccupancyPermit.Text = If(IsDBNull(rdr_ms3("OccupPermit_No")), "", rdr_ms3("OccupPermit_No").ToString)
                    If IsDBNull(rdr_ms3("occuPermit_IssuedDate")) Then
                        TxtOccupancy_date.Text = ""
                    Else
                        TxtOccupancy_date.Text = Format(CDate(rdr_ms3("occuPermit_IssuedDate")), "yyyy-MM-dd")
                    End If


                    If Not IsDBNull(rdr_ms3("OR_No")) AndAlso rdr_ms3("OR_No").ToString <> "" Then

                        TxtOR_No.Text = rdr_ms3("OR_No")
                        Txt_Amount.Text = rdr_ms3("payment_amount")
                        TxtOR_remarks.Text = rdr_ms3("OR_remarks")

                        If Not IsDBNull(rdr_ms3("paid_date")) Then
                            TxtOR_date.Text = Format(CDate(rdr_ms3("paid_date")), "yyyy-MM-dd")
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

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Con_ms1.Close()
            Con_ms3.Close()
        End Try
        Con_ms1.Close()
        Con_ms3.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        Dim inspector_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Inspector_ApplicationRecord"), Inspector_ApplicationRecord)
        Dim issuedPermit As IssuedPermit = CType(Application.OpenForms("IssuedPermit"), IssuedPermit)

        If inspector_ApplicationRecord IsNot Nothing AndAlso
           Not String.IsNullOrWhiteSpace(inspector_ApplicationRecord.txt_applicationno.Text) Then
            ApplicationRecord_Print()

        ElseIf issuedPermit IsNot Nothing AndAlso
               Not String.IsNullOrWhiteSpace(issuedPermit.TxtApplicationID.Text) Then
            IssuedPermit_Print()
        End If
    End Sub

End Class