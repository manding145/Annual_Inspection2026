
Imports System.Data.SqlClient
Public Class ReUpload

  
    Dim file_ocupancy_permit As Integer
    Dim file_as_built_plans As Integer
    Dim file_fire_safety_ins_cert_bfp As Integer
    Dim file_latest_picture_stbmt_inc_sidewalk As Integer
    Dim file_annual_ins_cert As Integer
    Dim file_prev_assess_annual_ins As Integer
    Dim file_cog_struct_sound_stab_struct_engr As Integer
    Dim file_cog_mech_inst As Integer
    Dim file_cog_elec_inst As Integer
    Dim file_cog_san_plumb_inst As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
    End Sub
    Private Sub Clearme()

    
        'REQUIREMENTS
        ck_file_ocupancy_permit.Checked = False
        ck_file_as_built_plans.Checked = False
        ck_file_latest_picture_stbmt_inc_sidewalk.Checked = False
        ck_file_fire_safety_ins_cert_bfp.Checked = False
        ck_file_annual_ins_cert.Checked = False
        ck_file_prev_assess_annual_ins.Checked = False
        ck_file_cog_struct_sound_stab_struct_engr.Checked = False
        ck_file_cog_mech_inst.Checked = False
        ck_file_cog_elec_inst.Checked = False
        ck_file_cog_san_plumb_inst.Checked = False



    End Sub
    Private Sub load_grid()

        'DataGrid.Rows.Clear()

        'Try
        '    conn = "SELECT " & _
        '    "business_application_tbl.applicationid, " & _
        '    "business_record_hdr.accountno, " & _
        '    "business_record_hdr.b_name, " & _
        '    "business_record_hdr.b_username, " & _
        '    "business_record_hdr.b_password, " & _
        '    "business_denytemp.applicationid, " & _
        '    "business_denytemp.deny_status, " & _
        '    "business_denytemp.deny_dt, " & _
        '    "business_denytemp.brgy_clearance_IsLacking, " & _
        '    "business_denytemp.unifiedform_islacking, " & _
        '    "business_denytemp.old_permit_IsLacking, " & _
        '    "business_denytemp.old_plate_IsLacking, " & _
        '    "business_denytemp.old_fire_IsLacking, " & _
        '    "business_denytemp.itr_islacking, " & _
        '    "business_denytemp.marketclr_islacking, " & _
        '    "business_users.Full_name " & _
        '    "FROM " & _
        '    "ONLINE.business_denytemp " & _
        '    "INNER JOIN ONLINE.business_application_tbl ON ONLINE.business_denytemp.applicationid = business_application_tbl.applicationID " & _
        '    "INNER JOIN ONLINE.business_record_hdr ON ONLINE.business_application_tbl.recordID = business_record_hdr.recordID " & _
        '    "INNER JOIN ONLINE.business_users ON ONLINE.business_denytemp.user_id = business_users.system_userid WHERE business_denytemp.deny_status = 'P' ORDER BY business_denytemp.deny_dt DESC "


        '    Con_ms = New SqlConnection(mcs)
        '    Con_ms.Open()
        '    cmd_ms = New SqlCommand(conn_ms, Con_ms)
        '    rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
        '    Do While rdr_ms.Read = True

        '        DataGrid.Rows.Add(rdr_ms("deny_dt"), rdr_ms("accountno"), rdr_ms("applicationID"), rdr_ms("b_name"), rdr_ms("deny_status"), "VIEW")
        '    Loop
        '    Con_ms.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub txt_applicationno_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If MsgBox("Are you sure you want to confirm this reupload request?", vbYesNo + vbInformation, "eBOSS Tacloban") = MsgBoxResult.Yes Then

                'Annual Inspection 
                If ck_file_ocupancy_permit.Checked = True Then file_ocupancy_permit = 1 Else file_ocupancy_permit = 0
                If ck_file_as_built_plans.Checked = True Then file_as_built_plans = 1 Else file_as_built_plans = 0
                If ck_file_latest_picture_stbmt_inc_sidewalk.Checked = True Then file_latest_picture_stbmt_inc_sidewalk = 1 Else file_latest_picture_stbmt_inc_sidewalk = 0
                If ck_file_fire_safety_ins_cert_bfp.Checked = True Then file_fire_safety_ins_cert_bfp = 1 Else file_fire_safety_ins_cert_bfp = 0
                If ck_file_annual_ins_cert.Checked = True Then file_annual_ins_cert = 1 Else file_annual_ins_cert = 0
                If ck_file_cog_struct_sound_stab_struct_engr.Checked = True Then file_cog_struct_sound_stab_struct_engr = 1 Else file_cog_struct_sound_stab_struct_engr = 0
                If ck_file_prev_assess_annual_ins.Checked = True Then file_prev_assess_annual_ins = 1 Else file_prev_assess_annual_ins = 0
                If ck_file_cog_mech_inst.Checked = True Then file_cog_mech_inst = 1 Else file_cog_mech_inst = 0
                If ck_file_cog_elec_inst.Checked = True Then file_cog_elec_inst = 1 Else file_cog_elec_inst = 0
                If ck_file_cog_san_plumb_inst.Checked = True Then file_cog_san_plumb_inst = 1 Else file_cog_san_plumb_inst = 0


                Dim mytimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
             

                conn_ms = "SELECT * FROM ONLINE.annual_inspection_attachment WHERE id = '" + Inspector_ApplicationRecord.txt_applicationno.Text + "'"
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                rdr_ms = cmd_ms.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr_ms.Read = True Then

                    MsgBox("Please Contact your administrator", vbOKOnly & vbInformation, "Management Information System Office")

                Else

                    'if not existed create new
                    Con_ms1 = New SqlConnection(mcs)

                    Con_ms1.Open()
                    conn_ms1 = "INSERT INTO ONLINE.annual_inspection_attachment " &
                      "(id) " &
                      "VALUES( @id)"

                    cmd_ms1 = New SqlCommand(conn_ms1, Con_ms1)
                    cmd_ms1.Parameters.AddWithValue("@id", Convert.ToInt32(Inspector_ApplicationRecord.txt_applicationno.Text))

                    'REQUIREMENTS
                    cmd_ms1.Parameters.AddWithValue("@file_ocupancy_permit", file_ocupancy_permit)
                    cmd_ms1.Parameters.AddWithValue("@file_as_built_plans", file_as_built_plans)
                    cmd_ms1.Parameters.AddWithValue("@file_latest_picture_stbmt_inc_sidewalk", file_latest_picture_stbmt_inc_sidewalk)
                    cmd_ms1.Parameters.AddWithValue("@file_fire_safety_ins_cert_bfp", file_fire_safety_ins_cert_bfp)
                    cmd_ms1.Parameters.AddWithValue("@file_annual_ins_cert", file_annual_ins_cert)
                    cmd_ms1.Parameters.AddWithValue("@file_cog_struct_sound_stab_struct_engr", file_cog_struct_sound_stab_struct_engr)
                    cmd_ms1.Parameters.AddWithValue("@file_prev_assess_annual_ins", file_prev_assess_annual_ins)
                    cmd_ms1.Parameters.AddWithValue("@file_cog_mech_inst", file_cog_mech_inst)
                    cmd_ms1.Parameters.AddWithValue("@ck_file_cog_elec_inst", ck_file_cog_elec_inst)
                    cmd_ms1.Parameters.AddWithValue("@ck_file_cog_san_plumb_inst", ck_file_cog_san_plumb_inst)
                    'end here for requirements

                    cmd_ms1.ExecuteNonQuery()
                    Con_ms1.Close()

                End If
                rdr_ms.Close()
                Con_ms.Close()

                'Update status
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn_ms = "UPDATE ONLINE.annual_inspection_application set app_status = 'R', remark = @remarks, deny_date = @deny_date WHERE id = '" + Inspector_ApplicationRecord.txt_applicationno.Text + "'"
                cmd_ms = New SqlCommand(conn_ms, Con_ms)
                cmd_ms.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txt_remarks.Text
                cmd_ms.Parameters.AddWithValue("@deny_date", DateTime.Now)
                cmd_ms.ExecuteNonQuery()
                Con_ms.Close()

                'Email sent
                Con_ms = New SqlConnection(mcs)
                Con_ms.Open()
                conn = "INSERT INTO ONLINE.email_outbox (userid, accountno, Remarks, email, Subject, fullname, referencecode, datesend) " _
                   & "VALUES (@userid, @fullname,  @Remarks, '" & Inspector_ApplicationRecord.txt_email.Text & "', 'Annual Inspection Re-Upload' ,@fullname, '" & Inspector_ApplicationRecord.TxtRefenceNo.Text & "', @Date)"
                cmd_ms = New SqlCommand(conn, Con_ms)
                cmd_ms.Parameters.Add("@userid", SqlDbType.VarChar).Value = Inspector_ApplicationRecord.useraccountid.Text
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


    Private Sub ck_file_brgy_clearance_bldgpermit_CheckedChanged(sender As Object, e As EventArgs) Handles ck_file_ocupancy_permit.CheckedChanged

    End Sub

 
End Class