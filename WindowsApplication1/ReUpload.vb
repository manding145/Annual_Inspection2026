
Imports System.Data.SqlClient
Public Class ReUpload

    Dim Construction_ApplicationRecord As Inspector_ApplicationRecord = CType(Application.OpenForms("Construction_ApplicationRecord"), Inspector_ApplicationRecord)

   Dim lack_itr1, lack_itr2, lack_itr3, lack_itr4, lack_gross, lack_firearms, lack_waterpotability, lack_francisetooperate, lack_bsp, lack_slaughter, lack_cityvet, lack_peso, lack_dole, lack_dot, lack_citytourism, lack_licensetooperate, lack_agriculture, lack_pcab, lack_psa, lack_enro, lack_brgyresolution, lack_spa, lack_contractlease, lack_validid, lack_cda, lack_coop, lack_ctc, lack_bfad, lack_unf, lack_brgyclearance, lack_oldpermit, lack_oldplate, lack_oldfire, lack_itr, lack_market_clearance As Integer

    'BUSINESS PERMIT
    Dim file_brgy_clearance_bldgpermit As Integer
    Dim file_brgy_drainage_certificate As Integer
    Dim file_locational_clearance_cityplanning As Integer
    Dim file_latest_tax_declaration As Integer
    Dim file_latest_tax_clearance As Integer
    Dim file_tiltle_property As Integer
    Dim file_skectch_plan_lot As Integer
    Dim file_approved_subdivision_plan As Integer
    Dim file_photocopy_prclicense_ptrsigning_prof As Integer

    'OCCUPANCY PERMIT
    Dim file_application_certification_occupancy As Integer
    Dim file_duly_accomplished_certification As Integer
    Dim file_duly_accomplished_final_electrical_inspection_form As Integer
    Dim file_picture_building_front As Integer
    Dim file_picture_building_side As Integer
    Dim file_recent_tax_clearance As Integer
    Dim file_brgy_clearance_electpermit As Integer
    Dim file_sketchplan_locationmap As Integer
    Dim file_asbuilt_elect_plan_signedsealed As Integer
    Dim file_treesets_asbuilt_plan As Integer
    Dim file_approved_building_plan As Integer
    Dim file_daily_activity_log As Integer
    Dim file_cert_fire_safety_inspection As Integer

    'LOCATIONAL CLEARANCE
    Dim file_inReq_duly_accomplished_notarized_appform As Integer
    Dim file_inReq_truecopy_cert_title As Integer
    Dim file_inReq_rpt_clearance As Integer
    Dim file_inReq_project_cost As Integer
    Dim file_inReq_sketch_subdiv_plan As Integer
    Dim file_inReq_1stpage_plan As Integer
    Dim file_adReq_deedsale_deeddonation_contractlease_auth As Integer
    Dim file_adReq_special_power_attorney As Integer
    Dim file_adReq_nr_2storey_withroofdeck As Integer
    Dim file_adReq_nr_commercial_bldg As Integer
    Dim file_adReq_env_compliance_cert As Integer
    Dim file_approved_building_permit1 As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim userMsg As String
        'userMsg = Microsoft.VisualBasic.InputBox("REMARKS", "CANCEL DENY REQUEST", "Input your remarks here")
        'If userMsg <> "" Then
        '    Try
        '        Con_ms = New SqlConnection(mcs)
        '        Con_ms.Open()
        '        conn_ms = "UPDATE ONLINE.business_applicationstatus_dtl set IsPendingTemp = '0' , IsPendingRemarks='" & userMsg & "' " _
        '            & "WHERE applicationID='" & txt_applicationno.Text & "'"
        '        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        '        cmd_ms.ExecuteNonQuery()
        '        Con_ms.Close()

        '        Con_ms = New SqlConnection(mcs)
        '        Con_ms.Open()
        '        conn_ms = "UPDATE ONLINE.business_denytemp set deny_status = 'C'" _
        '            & "WHERE applicationID='" & txt_applicationno.Text & "'"
        '        cmd_ms = New SqlCommand(conn_ms, Con_ms)
        '        cmd_ms.ExecuteNonQuery()
        '        Con_ms.Close()

        '        MsgBox("Request has been cancelled!")
        '        FormStatus = False

        '        Me.Close()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try

        'Else
        '    MsgBox("Please input reamrks!")
        'End If

        Me.Close()
    End Sub
    Private Sub Clearme()

        txt_applicationno.Text = ""
        txt_accountno.Text = ""
        txt_businessname.Text = ""
        txt_email.Text = ""
        Txt_remarks.Text = ""
        txt_userdeny.Text = ""
        txt_businessline.Text = ""

        'BUSINESS PERMIT
        ck_file_brgy_clearance_bldgpermit.Checked = False
        ck_file_brgy_drainage_certificate.Checked = False
        ck_file_locational_clearance_cityplanning.Checked = False
        ck_file_latest_tax_declaration.Checked = False
        ck_file_latest_tax_clearance.Checked = False
        ck_file_tiltle_property.Checked = False
        ck_file_approved_subdivision_plan.Checked = False
        ck_file_skectch_plan_lot.Checked = False
        ck_file_photocopy_prclicense_ptrsigning_prof.Checked = False

        'OCCUPANCY PERMIT
        ck_file_application_certification_occupancy.Checked = False
        ck_file_duly_accomplished_certification.Checked = False
        ck_file_approved_building_permit.Checked = False
        ck_file_duly_accomplished_final_electrical_inspection_form.Checked = False
        ck_file_picture_building_front.Checked = False
        ck_file_picture_building_side.Checked = False
        ck_file_brgy_clearance_electpermit.Checked = False
        ck_file_recent_tax_clearance.Checked = False
        ck_file_sketchplan_locationmap.Checked = False
        ck_file_asbuilt_elect_plan_signedsealed.Checked = False
        ck_file_approved_building_plan.Checked = False
        ck_file_treesets_asbuilt_plan.Checked = False
        ck_file_daily_activity_log.Checked = False
        ck_file_cert_fire_safety_inspection.Checked = False

        'LOCATIONAL CLEARANCE
        ck_file_inReq_duly_accomplished_notarized_appform.Checked = False
        ck_file_inReq_truecopy_cert_title.Checked = False
        ck_file_inReq_rpt_clearance.Checked = False
        ck_file_inReq_project_cost.Checked = False
        ck_file_inReq_sketch_subdiv_plan.Checked = False
        ck_file_inReq_1stpage_plan.Checked = False
        ck_file_adReq_deedsale_deeddonation_contractlease_auth.Checked = False
        ck_file_adReq_special_power_attorney.Checked = False
        ck_file_adReq_nr_2storey_withroofdeck.Checked = False
        ck_file_adReq_env_compliance_cert.Checked = False




    End Sub
    Private Sub load_grid()
        DataGrid.Rows.Clear()

        Try
            conn = "SELECT " & _
            "business_application_tbl.applicationid, " & _
            "business_record_hdr.accountno, " & _
            "business_record_hdr.b_name, " & _
            "business_record_hdr.b_username, " & _
            "business_record_hdr.b_password, " & _
            "business_denytemp.applicationid, " & _
            "business_denytemp.deny_status, " & _
            "business_denytemp.deny_dt, " & _
            "business_denytemp.brgy_clearance_IsLacking, " & _
            "business_denytemp.unifiedform_islacking, " & _
            "business_denytemp.old_permit_IsLacking, " & _
            "business_denytemp.old_plate_IsLacking, " & _
            "business_denytemp.old_fire_IsLacking, " & _
            "business_denytemp.itr_islacking, " & _
            "business_denytemp.marketclr_islacking, " & _
            "business_users.Full_name " & _
            "FROM " & _
            "ONLINE.business_denytemp " & _
            "INNER JOIN ONLINE.business_application_tbl ON ONLINE.business_denytemp.applicationid = business_application_tbl.applicationID " & _
            "INNER JOIN ONLINE.business_record_hdr ON ONLINE.business_application_tbl.recordID = business_record_hdr.recordID " & _
            "INNER JOIN ONLINE.business_users ON ONLINE.business_denytemp.user_id = business_users.system_userid WHERE business_denytemp.deny_status = 'P' ORDER BY business_denytemp.deny_dt DESC "


            Con_ms = New SqlConnection(mcs)
            Con_ms.Open()
            cmd_ms = New SqlCommand(conn_ms, Con_ms)
            rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
            Do While rdr_ms.Read = True

                DataGrid.Rows.Add(rdr_ms("deny_dt"), rdr_ms("accountno"), rdr_ms("applicationID"), rdr_ms("b_name"), rdr_ms("deny_status"), "VIEW")
            Loop
            Con_ms.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_applicationno_TextChanged(sender As Object, e As EventArgs) Handles txt_applicationno.TextChanged

    End Sub

    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellContentClick
       

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If MsgBox("Are you sure you want to confirm this reupload request?", vbYesNo + vbInformation, "eBOSS Tacloban") = MsgBoxResult.Yes Then

                'BUSINESS PERMIT
                If ck_file_brgy_clearance_bldgpermit.Checked = True Then file_brgy_clearance_bldgpermit = 1 Else file_brgy_clearance_bldgpermit = 0
                If ck_file_brgy_drainage_certificate.Checked = True Then file_brgy_drainage_certificate = 1 Else file_brgy_drainage_certificate = 0
                If ck_file_locational_clearance_cityplanning.Checked = True Then file_locational_clearance_cityplanning = 1 Else file_locational_clearance_cityplanning = 0
                If ck_file_latest_tax_declaration.Checked = True Then file_latest_tax_declaration = 1 Else file_latest_tax_declaration = 0
                If ck_file_latest_tax_clearance.Checked = True Then file_latest_tax_clearance = 1 Else file_latest_tax_clearance = 0
                If ck_file_approved_subdivision_plan.Checked = True Then file_approved_subdivision_plan = 1 Else file_approved_subdivision_plan = 0
                If ck_file_tiltle_property.Checked = True Then file_tiltle_property = 1 Else file_tiltle_property = 0
                If ck_file_skectch_plan_lot.Checked = True Then file_skectch_plan_lot = 1 Else file_skectch_plan_lot = 0
                If ck_file_photocopy_prclicense_ptrsigning_prof.Checked = True Then file_photocopy_prclicense_ptrsigning_prof = 1 Else file_photocopy_prclicense_ptrsigning_prof = 0

                'OCCUPANCY PERMIT
                If ck_file_application_certification_occupancy.Checked = True Then file_application_certification_occupancy = 1 Else file_application_certification_occupancy = 0
                If ck_file_duly_accomplished_certification.Checked = True Then file_duly_accomplished_certification = 1 Else file_duly_accomplished_certification = 0
                If ck_file_approved_building_permit.Checked = True Then file_approved_building_permit1 = 1 Else file_approved_building_permit1 = 0
                If ck_file_duly_accomplished_final_electrical_inspection_form.Checked = True Then file_duly_accomplished_final_electrical_inspection_form = 1 Else file_duly_accomplished_final_electrical_inspection_form = 0
                If ck_file_picture_building_front.Checked = True Then file_picture_building_front = 1 Else file_picture_building_front = 0
                If ck_file_picture_building_side.Checked = True Then file_picture_building_side = 1 Else file_picture_building_side = 0
                If ck_file_brgy_clearance_electpermit.Checked = True Then file_brgy_clearance_electpermit = 1 Else file_brgy_clearance_electpermit = 0
                If ck_file_recent_tax_clearance.Checked = True Then file_recent_tax_clearance = 1 Else file_recent_tax_clearance = 0
                If ck_file_sketchplan_locationmap.Checked = True Then file_sketchplan_locationmap = 1 Else file_sketchplan_locationmap = 0
                If ck_file_asbuilt_elect_plan_signedsealed.Checked = True Then file_asbuilt_elect_plan_signedsealed = 1 Else file_asbuilt_elect_plan_signedsealed = 0
                If ck_file_approved_building_plan.Checked = True Then file_approved_building_plan = 1 Else file_approved_building_plan = 0
                If ck_file_treesets_asbuilt_plan.Checked = True Then file_treesets_asbuilt_plan = 1 Else file_treesets_asbuilt_plan = 0
                If ck_file_daily_activity_log.Checked = True Then file_daily_activity_log = 1 Else file_daily_activity_log = 0
                If ck_file_cert_fire_safety_inspection.Checked = True Then file_cert_fire_safety_inspection = 1 Else file_cert_fire_safety_inspection = 0

                'LOCATIONAL CLEARANCE
                If ck_file_inReq_duly_accomplished_notarized_appform.Checked = True Then file_inReq_duly_accomplished_notarized_appform = 1 Else file_inReq_duly_accomplished_notarized_appform = 0
                If ck_file_inReq_truecopy_cert_title.Checked = True Then file_inReq_truecopy_cert_title = 1 Else file_inReq_truecopy_cert_title = 0
                If ck_file_inReq_rpt_clearance.Checked = True Then file_inReq_rpt_clearance = 1 Else file_inReq_rpt_clearance = 0
                If ck_file_inReq_project_cost.Checked = True Then file_inReq_project_cost = 1 Else file_inReq_project_cost = 0
                If ck_file_inReq_sketch_subdiv_plan.Checked = True Then file_inReq_sketch_subdiv_plan = 1 Else file_inReq_sketch_subdiv_plan = 0
                If ck_file_inReq_1stpage_plan.Checked = True Then file_inReq_1stpage_plan = 1 Else file_inReq_1stpage_plan = 0
                If ck_file_adReq_deedsale_deeddonation_contractlease_auth.Checked = True Then file_adReq_deedsale_deeddonation_contractlease_auth = 1 Else file_adReq_deedsale_deeddonation_contractlease_auth = 0
                If ck_file_adReq_special_power_attorney.Checked = True Then file_adReq_special_power_attorney = 1 Else file_adReq_special_power_attorney = 0
                If ck_file_adReq_nr_2storey_withroofdeck.Checked = True Then file_adReq_nr_2storey_withroofdeck = 1 Else file_adReq_nr_2storey_withroofdeck = 0
                If ck_file_adReq_env_compliance_cert.Checked = True Then file_adReq_env_compliance_cert = 1 Else file_adReq_env_compliance_cert = 0

                Dim mytimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                'update data deny if from assessor or evaluator

                'all
                conn_ms = "SELECT * FROM ONLINE.constr_reupload WHERE id = '" + Construction_ApplicationRecord.txt_applicationno.Text + "'"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms.Read = True Then

                    MsgBox("Please Contact your administrator", vbOKOnly & vbInformation, "Management Information System Office")

                Else

                    'if not existed create new
                    Con_ms1 = New SqlConnection(mcs)

                    'file_inReq_duly_accomplished_notarized_appform,
                    '@file_inReq_duly_accomplished_notarized_appform,

                    Con_ms1.Open()
                    conn_ms1 = "INSERT INTO ONLINE.constr_reupload " &
                      "(file_brgy_clearance_bldgpermit, file_brgy_drainage_certificate, file_locational_clearance_cityplanning, file_latest_tax_declaration, file_latest_tax_clearance, file_approved_subdivision_plan, " &
                      "file_skectch_plan_lot, file_photocopy_prclicense_ptrsigning_prof, file_application_certification_occupancy, file_duly_accomplished_certification, file_approved_building_permit, " &
                      "file_duly_accomplished_final_electrical_inspection_form, file_picture_building_front, file_picture_building_side, file_brgy_clearance_electpermit, file_recent_tax_clearance, file_sketchplan_locationmap, " &
                      "file_asbuilt_elect_plan_signedsealed, file_approved_building_plan, file_treesets_asbuilt_plan, file_daily_activity_log, file_cert_fire_safety_inspection,file_tiltle_property,  " &
                      "file_inReq_truecopy_cert_title, file_inReq_rpt_clearance, file_inReq_project_cost, file_inReq_sketch_subdiv_plan, file_inReq_1stpage_plan, file_adReq_deedsale_deeddonation_contractlease_auth, file_adReq_special_power_attorney," &
                      "file_adReq_nr_2storey_withroofdeck, file_adReq_env_compliance_cert, id) " &
                      "VALUES(@file_brgy_clearance_bldgpermit, @file_brgy_drainage_certificate, @file_locational_clearance_cityplanning, @file_latest_tax_declaration, @file_latest_tax_clearance, @file_approved_subdivision_plan, " &
                      "@file_skectch_plan_lot, @file_photocopy_prclicense_ptrsigning_prof, @file_application_certification_occupancy, @file_duly_accomplished_certification, @file_approved_building_permit, " &
                      "@file_duly_accomplished_final_electrical_inspection_form, @file_picture_building_front, @file_picture_building_side, @file_brgy_clearance_electpermit, @file_recent_tax_clearance, @file_sketchplan_locationmap, " &
                      "@file_asbuilt_elect_plan_signedsealed, @file_approved_building_plan, @file_treesets_asbuilt_plan, @file_daily_activity_log, @file_cert_fire_safety_inspection, @file_tiltle_property, " &
                      "@file_inReq_truecopy_cert_title, @file_inReq_rpt_clearance, @file_inReq_project_cost, @file_inReq_sketch_subdiv_plan, @file_inReq_1stpage_plan, @file_adReq_deedsale_deeddonation_contractlease_auth, @file_adReq_special_power_attorney, " &
                      "@file_adReq_nr_2storey_withroofdeck, @file_adReq_env_compliance_cert, @id)"

                    cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
                    cmd_ms1.Parameters.AddWithValue("@id", Convert.ToInt32(Construction_ApplicationRecord.txt_applicationno.Text))

                    'BUSINESS PERMIT
                    cmd_ms1.Parameters.AddWithValue("@file_brgy_clearance_bldgpermit", file_brgy_clearance_bldgpermit)
                    cmd_ms1.Parameters.AddWithValue("@file_brgy_drainage_certificate", file_brgy_drainage_certificate)
                    cmd_ms1.Parameters.AddWithValue("@file_locational_clearance_cityplanning", file_locational_clearance_cityplanning)
                    cmd_ms1.Parameters.AddWithValue("@file_latest_tax_declaration", file_latest_tax_declaration)
                    cmd_ms1.Parameters.AddWithValue("@file_latest_tax_clearance", file_latest_tax_clearance)
                    cmd_ms1.Parameters.AddWithValue("@file_tiltle_property", file_tiltle_property)
                    cmd_ms1.Parameters.AddWithValue("@file_approved_subdivision_plan", file_approved_subdivision_plan)
                    cmd_ms1.Parameters.AddWithValue("@file_skectch_plan_lot", file_skectch_plan_lot)
                    cmd_ms1.Parameters.AddWithValue("@file_photocopy_prclicense_ptrsigning_prof", file_photocopy_prclicense_ptrsigning_prof)
                    'end here for Business Permit

                    'OCCUPANCY PERMIT
                    cmd_ms1.Parameters.AddWithValue("@file_application_certification_occupancy", file_application_certification_occupancy)
                    cmd_ms1.Parameters.AddWithValue("@file_duly_accomplished_certification", file_duly_accomplished_certification)
                    cmd_ms1.Parameters.AddWithValue("@file_approved_building_permit", file_approved_building_permit1)
                    cmd_ms1.Parameters.AddWithValue("@file_duly_accomplished_final_electrical_inspection_form", file_duly_accomplished_final_electrical_inspection_form)
                    cmd_ms1.Parameters.AddWithValue("@file_picture_building_front", file_picture_building_front)
                    cmd_ms1.Parameters.AddWithValue("@file_picture_building_side", file_picture_building_side)
                    cmd_ms1.Parameters.AddWithValue("@file_brgy_clearance_electpermit", file_brgy_clearance_electpermit)
                    cmd_ms1.Parameters.AddWithValue("@file_recent_tax_clearance", file_recent_tax_clearance)
                    cmd_ms1.Parameters.AddWithValue("@file_sketchplan_locationmap", file_sketchplan_locationmap)
                    cmd_ms1.Parameters.AddWithValue("@file_asbuilt_elect_plan_signedsealed", file_asbuilt_elect_plan_signedsealed)
                    cmd_ms1.Parameters.AddWithValue("@file_approved_building_plan", file_approved_building_plan)
                    cmd_ms1.Parameters.AddWithValue("@file_treesets_asbuilt_plan", file_treesets_asbuilt_plan)
                    cmd_ms1.Parameters.AddWithValue("@file_daily_activity_log", file_daily_activity_log)
                    cmd_ms1.Parameters.AddWithValue("@file_cert_fire_safety_inspection", file_cert_fire_safety_inspection)
                    'end here for occupancy Permit

                    'LOCATIONAL CLEARANCE
                    'cmd_ms1.Parameters.AddWithValue("@file_inReq_duly_accomplished_notarized_appform", file_inReq_duly_accomplished_notarized_appform)
                    cmd_ms1.Parameters.AddWithValue("@file_inReq_truecopy_cert_title", file_inReq_truecopy_cert_title)
                    cmd_ms1.Parameters.AddWithValue("@file_inReq_rpt_clearance", file_inReq_rpt_clearance)
                    cmd_ms1.Parameters.AddWithValue("@file_inReq_project_cost", file_inReq_project_cost)
                    cmd_ms1.Parameters.AddWithValue("@file_inReq_sketch_subdiv_plan", file_inReq_sketch_subdiv_plan)
                    cmd_ms1.Parameters.AddWithValue("@file_inReq_1stpage_plan", file_inReq_1stpage_plan)
                    cmd_ms1.Parameters.AddWithValue("@file_adReq_deedsale_deeddonation_contractlease_auth", file_adReq_deedsale_deeddonation_contractlease_auth)
                    cmd_ms1.Parameters.AddWithValue("@file_adReq_special_power_attorney", file_adReq_special_power_attorney)
                    cmd_ms1.Parameters.AddWithValue("@file_adReq_nr_2storey_withroofdeck", file_adReq_nr_2storey_withroofdeck)
                    cmd_ms1.Parameters.AddWithValue("@file_adReq_env_compliance_cert", file_adReq_env_compliance_cert)
                    'end here for locational clearance

                    cmd_ms1.ExecuteNonQuery()
                    Con_ms1.Close()

                End If
                rdr_ms.Close()
                Con_ms.Close()

                'Update status
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn_ms = "UPDATE ONLINE.annual_inspection_application set app_status = 'R', remark = @remarks, deny_date = @deny_date WHERE id = '" + Construction_ApplicationRecord.txt_applicationno.Text + "'"
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                cmd_ms.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txt_remarks.Text
                cmd_ms.Parameters.AddWithValue("@deny_date", DateTime.Now)
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()

                'Email sent
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, Remarks, email, Subject, fullname, referencecode, datesend) " _
                   & "VALUES (@userid, @fullname,  @Remarks, '" & Construction_ApplicationRecord.txt_email.Text & "', 'Construction Re-Upload' ,@fullname, '" & Construction_ApplicationRecord.TxtRefenceNo.Text & "', @Date)"
                cmd_ms = New SqlCommand(conn, Con_ms)
                'cmd_ms.Parameters.Add("@fullname", SqlDbType.VarChar).Value = Construction_ApplicationRecord.fullname.Text & " - " & Construction_ApplicationRecord.typeofapplication.Text
                cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = Construction_ApplicationRecord.useraccountid.Text
                cmd_ms.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = Txt_remarks.Text
                cmd_ms.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateAndTime.Now()
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()



            End If
            Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormStatus = False
        Me.Close()
    End Sub

    Private Sub ReUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load_grid()
        Clearme()
    End Sub


    Private Sub ck_file_brgy_clearance_bldgpermit_CheckedChanged(sender As Object, e As EventArgs) Handles ck_file_brgy_clearance_bldgpermit.CheckedChanged

    End Sub

 
End Class