<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssuedPermit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssuedPermit))
        Me.referencono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.BtnSearchRecord = New System.Windows.Forms.Button()
        Me.UploadScannedReceipt = New System.Windows.Forms.Button()
        Me.TxtBusinessName = New System.Windows.Forms.TextBox()
        Me.TxtAmountPaid = New System.Windows.Forms.TextBox()
        Me.B_Signed = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAccountNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.useraccountid = New System.Windows.Forms.TextBox()
        Me.typeofapplication = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_contactno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBuildingAge = New System.Windows.Forms.TextBox()
        Me.TxtBusinessAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtOwnerName = New System.Windows.Forms.TextBox()
        Me.Type_App = New System.Windows.Forms.Label()
        Me.TxtApplicationID = New System.Windows.Forms.TextBox()
        Me.B_Issued = New System.Windows.Forms.Button()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.typeofapplication.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'referencono
        '
        Me.referencono.BackColor = System.Drawing.Color.AliceBlue
        Me.referencono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.referencono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.referencono.Enabled = False
        Me.referencono.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.referencono.Location = New System.Drawing.Point(22, 37)
        Me.referencono.Multiline = True
        Me.referencono.Name = "referencono"
        Me.referencono.ReadOnly = True
        Me.referencono.Size = New System.Drawing.Size(511, 31)
        Me.referencono.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Reference No."
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(1133, 3)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(192, 192)
        Me.AxAcroPDF1.TabIndex = 172
        Me.AxAcroPDF1.Visible = False
        '
        'BtnSearchRecord
        '
        Me.BtnSearchRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnSearchRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchRecord.ForeColor = System.Drawing.Color.White
        Me.BtnSearchRecord.Location = New System.Drawing.Point(615, 37)
        Me.BtnSearchRecord.Name = "BtnSearchRecord"
        Me.BtnSearchRecord.Size = New System.Drawing.Size(184, 31)
        Me.BtnSearchRecord.TabIndex = 156
        Me.BtnSearchRecord.Text = "Search &Record"
        Me.BtnSearchRecord.UseVisualStyleBackColor = False
        Me.BtnSearchRecord.Visible = False
        '
        'UploadScannedReceipt
        '
        Me.UploadScannedReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.UploadScannedReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadScannedReceipt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadScannedReceipt.ForeColor = System.Drawing.Color.White
        Me.UploadScannedReceipt.Location = New System.Drawing.Point(615, 0)
        Me.UploadScannedReceipt.Name = "UploadScannedReceipt"
        Me.UploadScannedReceipt.Size = New System.Drawing.Size(184, 31)
        Me.UploadScannedReceipt.TabIndex = 171
        Me.UploadScannedReceipt.Text = "&Upload Scanned Receipt"
        Me.UploadScannedReceipt.UseVisualStyleBackColor = False
        Me.UploadScannedReceipt.Visible = False
        '
        'TxtBusinessName
        '
        Me.TxtBusinessName.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtBusinessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusinessName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBusinessName.Enabled = False
        Me.TxtBusinessName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusinessName.Location = New System.Drawing.Point(14, 170)
        Me.TxtBusinessName.Multiline = True
        Me.TxtBusinessName.Name = "TxtBusinessName"
        Me.TxtBusinessName.ReadOnly = True
        Me.TxtBusinessName.Size = New System.Drawing.Size(456, 26)
        Me.TxtBusinessName.TabIndex = 162
        '
        'TxtAmountPaid
        '
        Me.TxtAmountPaid.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAmountPaid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAmountPaid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmountPaid.Location = New System.Drawing.Point(159, 553)
        Me.TxtAmountPaid.Multiline = True
        Me.TxtAmountPaid.Name = "TxtAmountPaid"
        Me.TxtAmountPaid.Size = New System.Drawing.Size(242, 26)
        Me.TxtAmountPaid.TabIndex = 166
        '
        'B_Signed
        '
        Me.B_Signed.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.B_Signed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Signed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Signed.ForeColor = System.Drawing.Color.White
        Me.B_Signed.Location = New System.Drawing.Point(20, 308)
        Me.B_Signed.Name = "B_Signed"
        Me.B_Signed.Size = New System.Drawing.Size(153, 32)
        Me.B_Signed.TabIndex = 172
        Me.B_Signed.Text = "&Signed"
        Me.B_Signed.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "Account No"
        '
        'TxtAccountNo
        '
        Me.TxtAccountNo.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccountNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAccountNo.Enabled = False
        Me.TxtAccountNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccountNo.Location = New System.Drawing.Point(14, 81)
        Me.TxtAccountNo.Multiline = True
        Me.TxtAccountNo.Name = "TxtAccountNo"
        Me.TxtAccountNo.ReadOnly = True
        Me.TxtAccountNo.Size = New System.Drawing.Size(242, 26)
        Me.TxtAccountNo.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Owner Name;"
        '
        'useraccountid
        '
        Me.useraccountid.BackColor = System.Drawing.Color.AliceBlue
        Me.useraccountid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.useraccountid.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useraccountid.Location = New System.Drawing.Point(579, 45)
        Me.useraccountid.Name = "useraccountid"
        Me.useraccountid.Size = New System.Drawing.Size(197, 22)
        Me.useraccountid.TabIndex = 187
        Me.useraccountid.Visible = False
        '
        'typeofapplication
        '
        Me.typeofapplication.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.typeofapplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.typeofapplication.Controls.Add(Me.GroupBox3)
        Me.typeofapplication.Controls.Add(Me.Label6)
        Me.typeofapplication.Controls.Add(Me.txtBuildingAge)
        Me.typeofapplication.Controls.Add(Me.TxtBusinessAddress)
        Me.typeofapplication.Controls.Add(Me.Label7)
        Me.typeofapplication.Controls.Add(Me.Label8)
        Me.typeofapplication.Controls.Add(Me.TxtOwnerName)
        Me.typeofapplication.Controls.Add(Me.useraccountid)
        Me.typeofapplication.Controls.Add(Me.Type_App)
        Me.typeofapplication.Controls.Add(Me.TxtApplicationID)
        Me.typeofapplication.Controls.Add(Me.Label2)
        Me.typeofapplication.Controls.Add(Me.TxtAccountNo)
        Me.typeofapplication.Controls.Add(Me.Label9)
        Me.typeofapplication.Controls.Add(Me.B_Issued)
        Me.typeofapplication.Controls.Add(Me.B_Signed)
        Me.typeofapplication.Controls.Add(Me.TxtAmountPaid)
        Me.typeofapplication.Controls.Add(Me.TxtBusinessName)
        Me.typeofapplication.Location = New System.Drawing.Point(22, 98)
        Me.typeofapplication.Name = "typeofapplication"
        Me.typeofapplication.Size = New System.Drawing.Size(814, 371)
        Me.typeofapplication.TabIndex = 159
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.fullname)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_email)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_contactno)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(490, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 126)
        Me.GroupBox3.TabIndex = 205
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Client Info"
        '
        'fullname
        '
        Me.fullname.BackColor = System.Drawing.Color.AliceBlue
        Me.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullname.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.Location = New System.Drawing.Point(109, 19)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(197, 22)
        Me.fullname.TabIndex = 185
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Fullname:"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(109, 50)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(197, 22)
        Me.txt_email.TabIndex = 181
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Email:"
        '
        'txt_contactno
        '
        Me.txt_contactno.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_contactno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contactno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_contactno.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contactno.Location = New System.Drawing.Point(109, 84)
        Me.txt_contactno.Name = "txt_contactno"
        Me.txt_contactno.Size = New System.Drawing.Size(197, 22)
        Me.txt_contactno.TabIndex = 183
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Contact Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "Building Age:"
        '
        'txtBuildingAge
        '
        Me.txtBuildingAge.BackColor = System.Drawing.Color.AliceBlue
        Me.txtBuildingAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuildingAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuildingAge.Enabled = False
        Me.txtBuildingAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuildingAge.Location = New System.Drawing.Point(14, 260)
        Me.txtBuildingAge.Multiline = True
        Me.txtBuildingAge.Name = "txtBuildingAge"
        Me.txtBuildingAge.Size = New System.Drawing.Size(456, 26)
        Me.txtBuildingAge.TabIndex = 203
        '
        'TxtBusinessAddress
        '
        Me.TxtBusinessAddress.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtBusinessAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusinessAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBusinessAddress.Enabled = False
        Me.TxtBusinessAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusinessAddress.Location = New System.Drawing.Point(14, 215)
        Me.TxtBusinessAddress.Multiline = True
        Me.TxtBusinessAddress.Name = "TxtBusinessAddress"
        Me.TxtBusinessAddress.Size = New System.Drawing.Size(456, 26)
        Me.TxtBusinessAddress.TabIndex = 201
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "Business Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "Business Name:"
        '
        'TxtOwnerName
        '
        Me.TxtOwnerName.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtOwnerName.Enabled = False
        Me.TxtOwnerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOwnerName.Location = New System.Drawing.Point(14, 126)
        Me.TxtOwnerName.Multiline = True
        Me.TxtOwnerName.Name = "TxtOwnerName"
        Me.TxtOwnerName.Size = New System.Drawing.Size(242, 26)
        Me.TxtOwnerName.TabIndex = 188
        '
        'Type_App
        '
        Me.Type_App.AutoSize = True
        Me.Type_App.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type_App.Location = New System.Drawing.Point(19, 21)
        Me.Type_App.Name = "Type_App"
        Me.Type_App.Size = New System.Drawing.Size(145, 18)
        Me.Type_App.TabIndex = 174
        Me.Type_App.Text = "type of application"
        '
        'TxtApplicationID
        '
        Me.TxtApplicationID.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtApplicationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApplicationID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApplicationID.Enabled = False
        Me.TxtApplicationID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApplicationID.Location = New System.Drawing.Point(534, 13)
        Me.TxtApplicationID.Multiline = True
        Me.TxtApplicationID.Name = "TxtApplicationID"
        Me.TxtApplicationID.ReadOnly = True
        Me.TxtApplicationID.Size = New System.Drawing.Size(242, 26)
        Me.TxtApplicationID.TabIndex = 175
        Me.TxtApplicationID.Visible = False
        '
        'B_Issued
        '
        Me.B_Issued.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.B_Issued.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Issued.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Issued.ForeColor = System.Drawing.Color.White
        Me.B_Issued.Location = New System.Drawing.Point(191, 308)
        Me.B_Issued.Name = "B_Issued"
        Me.B_Issued.Size = New System.Drawing.Size(153, 32)
        Me.B_Issued.TabIndex = 172
        Me.B_Issued.Text = "&Issued"
        Me.B_Issued.UseVisualStyleBackColor = False
        '
        'IssuedPermit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 481)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.typeofapplication)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.referencono)
        Me.Controls.Add(Me.BtnSearchRecord)
        Me.Controls.Add(Me.UploadScannedReceipt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IssuedPermit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issuance Permit"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.typeofapplication.ResumeLayout(False)
        Me.typeofapplication.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents referencono As System.Windows.Forms.TextBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents BtnSearchRecord As System.Windows.Forms.Button
    Friend WithEvents UploadScannedReceipt As System.Windows.Forms.Button
    Public WithEvents TxtBusinessName As System.Windows.Forms.TextBox
    Public WithEvents TxtAmountPaid As System.Windows.Forms.TextBox
    Public WithEvents B_Signed As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents TxtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents useraccountid As System.Windows.Forms.TextBox
    Friend WithEvents typeofapplication As System.Windows.Forms.Panel
    Public WithEvents TxtApplicationID As System.Windows.Forms.TextBox
    Friend WithEvents TxtOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents Type_App As System.Windows.Forms.Label
    Public WithEvents B_Issued As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtBuildingAge As System.Windows.Forms.TextBox
    Public WithEvents TxtBusinessAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_contactno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
