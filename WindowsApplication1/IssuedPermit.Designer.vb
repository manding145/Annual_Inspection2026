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
        Me.BtnSearchRecord = New System.Windows.Forms.Button()
        Me.UploadScannedReceipt = New System.Windows.Forms.Button()
        Me.TxtBusinessName = New System.Windows.Forms.TextBox()
        Me.TxtAmountPaid = New System.Windows.Forms.TextBox()
        Me.B_SentNotification = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAccountNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.useraccountid = New System.Windows.Forms.TextBox()
        Me.label32 = New System.Windows.Forms.Panel()
        Me.Print_Record = New System.Windows.Forms.LinkLabel()
        Me.Or_link = New System.Windows.Forms.LinkLabel()
        Me.TxtOccupancy_date = New System.Windows.Forms.TextBox()
        Me.TxtOccupancyPermit = New System.Windows.Forms.TextBox()
        Me.TxtBldg_date = New System.Windows.Forms.TextBox()
        Me.TxtBldg_permit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBuildingOwnerName = New System.Windows.Forms.TextBox()
        Me.TxtNoStorey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Upload = New System.Windows.Forms.Label()
        Me.B_IssuedAttach = New System.Windows.Forms.Button()
        Me.Issued_file = New System.Windows.Forms.TextBox()
        Me.B_Signed = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_contactno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBuildingAge = New System.Windows.Forms.TextBox()
        Me.TxtBuildingAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Type_App = New System.Windows.Forms.Label()
        Me.B_Issued = New System.Windows.Forms.Button()
        Me.TxtApplicationID = New System.Windows.Forms.TextBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.AxAcroPDF2 = New AxAcroPDFLib.AxAcroPDF()
        Me.Txt_BusinessOwner = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.label32.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'referencono
        '
        Me.referencono.BackColor = System.Drawing.Color.AliceBlue
        Me.referencono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.referencono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.referencono.Enabled = False
        Me.referencono.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.referencono.Location = New System.Drawing.Point(21, 48)
        Me.referencono.Multiline = True
        Me.referencono.Name = "referencono"
        Me.referencono.ReadOnly = True
        Me.referencono.Size = New System.Drawing.Size(620, 31)
        Me.referencono.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Reference No."
        '
        'BtnSearchRecord
        '
        Me.BtnSearchRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnSearchRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchRecord.ForeColor = System.Drawing.Color.White
        Me.BtnSearchRecord.Location = New System.Drawing.Point(688, 48)
        Me.BtnSearchRecord.Name = "BtnSearchRecord"
        Me.BtnSearchRecord.Size = New System.Drawing.Size(166, 31)
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
        Me.UploadScannedReceipt.Location = New System.Drawing.Point(688, 11)
        Me.UploadScannedReceipt.Name = "UploadScannedReceipt"
        Me.UploadScannedReceipt.Size = New System.Drawing.Size(166, 31)
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
        Me.TxtBusinessName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TxtBusinessName.Location = New System.Drawing.Point(575, 94)
        Me.TxtBusinessName.Multiline = True
        Me.TxtBusinessName.Name = "TxtBusinessName"
        Me.TxtBusinessName.ReadOnly = True
        Me.TxtBusinessName.Size = New System.Drawing.Size(271, 22)
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
        'B_SentNotification
        '
        Me.B_SentNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.B_SentNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_SentNotification.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SentNotification.ForeColor = System.Drawing.Color.White
        Me.B_SentNotification.Location = New System.Drawing.Point(10, 290)
        Me.B_SentNotification.Name = "B_SentNotification"
        Me.B_SentNotification.Size = New System.Drawing.Size(241, 32)
        Me.B_SentNotification.TabIndex = 172
        Me.B_SentNotification.Text = "&Send Notification for Signing"
        Me.B_SentNotification.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "Account No:"
        '
        'TxtAccountNo
        '
        Me.TxtAccountNo.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccountNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAccountNo.Enabled = False
        Me.TxtAccountNo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TxtAccountNo.Location = New System.Drawing.Point(123, 38)
        Me.TxtAccountNo.Multiline = True
        Me.TxtAccountNo.Name = "TxtAccountNo"
        Me.TxtAccountNo.ReadOnly = True
        Me.TxtAccountNo.Size = New System.Drawing.Size(243, 22)
        Me.TxtAccountNo.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Building Owner Name;"
        '
        'useraccountid
        '
        Me.useraccountid.BackColor = System.Drawing.Color.AliceBlue
        Me.useraccountid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.useraccountid.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useraccountid.Location = New System.Drawing.Point(704, 48)
        Me.useraccountid.Name = "useraccountid"
        Me.useraccountid.Size = New System.Drawing.Size(197, 22)
        Me.useraccountid.TabIndex = 187
        Me.useraccountid.Visible = False
        '
        'label32
        '
        Me.label32.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label32.Controls.Add(Me.Print_Record)
        Me.label32.Controls.Add(Me.Or_link)
        Me.label32.Controls.Add(Me.TxtOccupancy_date)
        Me.label32.Controls.Add(Me.TxtOccupancyPermit)
        Me.label32.Controls.Add(Me.TxtBldg_date)
        Me.label32.Controls.Add(Me.TxtBldg_permit)
        Me.label32.Controls.Add(Me.Label10)
        Me.label32.Controls.Add(Me.Label11)
        Me.label32.Controls.Add(Me.TxtBuildingOwnerName)
        Me.label32.Controls.Add(Me.TxtNoStorey)
        Me.label32.Controls.Add(Me.Label3)
        Me.label32.Controls.Add(Me.Lbl_Upload)
        Me.label32.Controls.Add(Me.B_IssuedAttach)
        Me.label32.Controls.Add(Me.Issued_file)
        Me.label32.Controls.Add(Me.B_Signed)
        Me.label32.Controls.Add(Me.GroupBox3)
        Me.label32.Controls.Add(Me.Label6)
        Me.label32.Controls.Add(Me.txtBuildingAge)
        Me.label32.Controls.Add(Me.TxtBuildingAddress)
        Me.label32.Controls.Add(Me.Label7)
        Me.label32.Controls.Add(Me.Label15)
        Me.label32.Controls.Add(Me.Label8)
        Me.label32.Controls.Add(Me.Type_App)
        Me.label32.Controls.Add(Me.Label2)
        Me.label32.Controls.Add(Me.TxtAccountNo)
        Me.label32.Controls.Add(Me.Label9)
        Me.label32.Controls.Add(Me.B_Issued)
        Me.label32.Controls.Add(Me.B_SentNotification)
        Me.label32.Controls.Add(Me.TxtAmountPaid)
        Me.label32.Controls.Add(Me.Txt_BusinessOwner)
        Me.label32.Controls.Add(Me.TxtBusinessName)
        Me.label32.Location = New System.Drawing.Point(21, 85)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(880, 368)
        Me.label32.TabIndex = 159
        '
        'Print_Record
        '
        Me.Print_Record.AutoSize = True
        Me.Print_Record.LinkColor = System.Drawing.Color.Black
        Me.Print_Record.Location = New System.Drawing.Point(797, 9)
        Me.Print_Record.Name = "Print_Record"
        Me.Print_Record.Size = New System.Drawing.Size(66, 13)
        Me.Print_Record.TabIndex = 219
        Me.Print_Record.TabStop = True
        Me.Print_Record.Text = "Print Record"
        Me.Print_Record.Visible = False
        '
        'Or_link
        '
        Me.Or_link.AutoSize = True
        Me.Or_link.Location = New System.Drawing.Point(257, 332)
        Me.Or_link.Name = "Or_link"
        Me.Or_link.Size = New System.Drawing.Size(109, 13)
        Me.Or_link.TabIndex = 218
        Me.Or_link.TabStop = True
        Me.Or_link.Text = "Show Official Receipt"
        Me.Or_link.Visible = False
        '
        'TxtOccupancy_date
        '
        Me.TxtOccupancy_date.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtOccupancy_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOccupancy_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOccupancy_date.Enabled = False
        Me.TxtOccupancy_date.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TxtOccupancy_date.Location = New System.Drawing.Point(245, 238)
        Me.TxtOccupancy_date.Multiline = True
        Me.TxtOccupancy_date.Name = "TxtOccupancy_date"
        Me.TxtOccupancy_date.Size = New System.Drawing.Size(215, 22)
        Me.TxtOccupancy_date.TabIndex = 216
        '
        'TxtOccupancyPermit
        '
        Me.TxtOccupancyPermit.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtOccupancyPermit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOccupancyPermit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOccupancyPermit.Enabled = False
        Me.TxtOccupancyPermit.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TxtOccupancyPermit.Location = New System.Drawing.Point(14, 239)
        Me.TxtOccupancyPermit.Multiline = True
        Me.TxtOccupancyPermit.Name = "TxtOccupancyPermit"
        Me.TxtOccupancyPermit.Size = New System.Drawing.Size(225, 22)
        Me.TxtOccupancyPermit.TabIndex = 217
        '
        'TxtBldg_date
        '
        Me.TxtBldg_date.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtBldg_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBldg_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBldg_date.Enabled = False
        Me.TxtBldg_date.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBldg_date.Location = New System.Drawing.Point(245, 197)
        Me.TxtBldg_date.Multiline = True
        Me.TxtBldg_date.Name = "TxtBldg_date"
        Me.TxtBldg_date.Size = New System.Drawing.Size(215, 22)
        Me.TxtBldg_date.TabIndex = 214
        '
        'TxtBldg_permit
        '
        Me.TxtBldg_permit.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtBldg_permit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBldg_permit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBldg_permit.Enabled = False
        Me.TxtBldg_permit.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TxtBldg_permit.Location = New System.Drawing.Point(14, 198)
        Me.TxtBldg_permit.Multiline = True
        Me.TxtBldg_permit.Name = "TxtBldg_permit"
        Me.TxtBldg_permit.Size = New System.Drawing.Size(225, 22)
        Me.TxtBldg_permit.TabIndex = 215
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 213
        Me.Label10.Text = "Occupancy Permit No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 212
        Me.Label11.Text = "Building Permit No."
        '
        'TxtBuildingOwnerName
        '
        Me.TxtBuildingOwnerName.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtBuildingOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuildingOwnerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuildingOwnerName.Enabled = False
        Me.TxtBuildingOwnerName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuildingOwnerName.Location = New System.Drawing.Point(123, 66)
        Me.TxtBuildingOwnerName.Name = "TxtBuildingOwnerName"
        Me.TxtBuildingOwnerName.Size = New System.Drawing.Size(338, 22)
        Me.TxtBuildingOwnerName.TabIndex = 210
        '
        'TxtNoStorey
        '
        Me.TxtNoStorey.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtNoStorey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNoStorey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNoStorey.Enabled = False
        Me.TxtNoStorey.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoStorey.Location = New System.Drawing.Point(123, 154)
        Me.TxtNoStorey.Name = "TxtNoStorey"
        Me.TxtNoStorey.Size = New System.Drawing.Size(337, 22)
        Me.TxtNoStorey.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "Storey No:"
        '
        'Lbl_Upload
        '
        Me.Lbl_Upload.AutoSize = True
        Me.Lbl_Upload.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Upload.Location = New System.Drawing.Point(11, 278)
        Me.Lbl_Upload.Name = "Lbl_Upload"
        Me.Lbl_Upload.Size = New System.Drawing.Size(139, 13)
        Me.Lbl_Upload.TabIndex = 209
        Me.Lbl_Upload.Text = "Upload your File Issuance"
        '
        'B_IssuedAttach
        '
        Me.B_IssuedAttach.Enabled = False
        Me.B_IssuedAttach.Location = New System.Drawing.Point(431, 294)
        Me.B_IssuedAttach.Name = "B_IssuedAttach"
        Me.B_IssuedAttach.Size = New System.Drawing.Size(62, 24)
        Me.B_IssuedAttach.TabIndex = 208
        Me.B_IssuedAttach.Text = "Upload"
        Me.B_IssuedAttach.UseVisualStyleBackColor = True
        '
        'Issued_file
        '
        Me.Issued_file.BackColor = System.Drawing.Color.AliceBlue
        Me.Issued_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Issued_file.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Issued_file.Enabled = False
        Me.Issued_file.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Issued_file.Location = New System.Drawing.Point(12, 294)
        Me.Issued_file.Multiline = True
        Me.Issued_file.Name = "Issued_file"
        Me.Issued_file.Size = New System.Drawing.Size(481, 22)
        Me.Issued_file.TabIndex = 207
        '
        'B_Signed
        '
        Me.B_Signed.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.B_Signed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Signed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Signed.ForeColor = System.Drawing.Color.White
        Me.B_Signed.Location = New System.Drawing.Point(11, 290)
        Me.B_Signed.Name = "B_Signed"
        Me.B_Signed.Size = New System.Drawing.Size(240, 32)
        Me.B_Signed.TabIndex = 206
        Me.B_Signed.Text = "&Signed Client"
        Me.B_Signed.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.fullname)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_email)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_contactno)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(499, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 126)
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
        Me.fullname.Size = New System.Drawing.Size(238, 22)
        Me.fullname.TabIndex = 185
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(46, 21)
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
        Me.txt_email.Size = New System.Drawing.Size(238, 22)
        Me.txt_email.TabIndex = 181
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 59)
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
        Me.txt_contactno.Size = New System.Drawing.Size(238, 22)
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
        Me.Label6.Location = New System.Drawing.Point(41, 130)
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
        Me.txtBuildingAge.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtBuildingAge.Location = New System.Drawing.Point(123, 125)
        Me.txtBuildingAge.Multiline = True
        Me.txtBuildingAge.Name = "txtBuildingAge"
        Me.txtBuildingAge.Size = New System.Drawing.Size(338, 22)
        Me.txtBuildingAge.TabIndex = 203
        '
        'TxtBuildingAddress
        '
        Me.TxtBuildingAddress.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtBuildingAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuildingAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuildingAddress.Enabled = False
        Me.TxtBuildingAddress.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TxtBuildingAddress.Location = New System.Drawing.Point(123, 94)
        Me.TxtBuildingAddress.Multiline = True
        Me.TxtBuildingAddress.Name = "TxtBuildingAddress"
        Me.TxtBuildingAddress.Size = New System.Drawing.Size(338, 22)
        Me.TxtBuildingAddress.TabIndex = 201
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "Locational / Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(477, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "Business Name:"
        '
        'Type_App
        '
        Me.Type_App.AutoSize = True
        Me.Type_App.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type_App.Location = New System.Drawing.Point(47, 9)
        Me.Type_App.Name = "Type_App"
        Me.Type_App.Size = New System.Drawing.Size(145, 18)
        Me.Type_App.TabIndex = 174
        Me.Type_App.Text = "type of application"
        '
        'B_Issued
        '
        Me.B_Issued.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.B_Issued.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Issued.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Issued.ForeColor = System.Drawing.Color.White
        Me.B_Issued.Location = New System.Drawing.Point(11, 322)
        Me.B_Issued.Name = "B_Issued"
        Me.B_Issued.Size = New System.Drawing.Size(240, 32)
        Me.B_Issued.TabIndex = 172
        Me.B_Issued.Text = "&Issued"
        Me.B_Issued.UseVisualStyleBackColor = False
        '
        'TxtApplicationID
        '
        Me.TxtApplicationID.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtApplicationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApplicationID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApplicationID.Enabled = False
        Me.TxtApplicationID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApplicationID.Location = New System.Drawing.Point(659, 47)
        Me.TxtApplicationID.Multiline = True
        Me.TxtApplicationID.Name = "TxtApplicationID"
        Me.TxtApplicationID.ReadOnly = True
        Me.TxtApplicationID.Size = New System.Drawing.Size(242, 22)
        Me.TxtApplicationID.TabIndex = 175
        Me.TxtApplicationID.Visible = False
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
        'AxAcroPDF2
        '
        Me.AxAcroPDF2.Enabled = True
        Me.AxAcroPDF2.Location = New System.Drawing.Point(1015, 141)
        Me.AxAcroPDF2.Name = "AxAcroPDF2"
        Me.AxAcroPDF2.OcxState = CType(resources.GetObject("AxAcroPDF2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF2.Size = New System.Drawing.Size(192, 202)
        Me.AxAcroPDF2.TabIndex = 210
        Me.AxAcroPDF2.Visible = False
        '
        'Txt_BusinessOwner
        '
        Me.Txt_BusinessOwner.BackColor = System.Drawing.Color.AliceBlue
        Me.Txt_BusinessOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_BusinessOwner.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_BusinessOwner.Enabled = False
        Me.Txt_BusinessOwner.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Txt_BusinessOwner.Location = New System.Drawing.Point(575, 66)
        Me.Txt_BusinessOwner.Multiline = True
        Me.Txt_BusinessOwner.Name = "Txt_BusinessOwner"
        Me.Txt_BusinessOwner.ReadOnly = True
        Me.Txt_BusinessOwner.Size = New System.Drawing.Size(271, 22)
        Me.Txt_BusinessOwner.TabIndex = 162
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(477, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 200
        Me.Label15.Text = "Business Owner:"
        '
        'IssuedPermit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(924, 474)
        Me.Controls.Add(Me.AxAcroPDF2)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.label32)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.referencono)
        Me.Controls.Add(Me.BtnSearchRecord)
        Me.Controls.Add(Me.UploadScannedReceipt)
        Me.Controls.Add(Me.useraccountid)
        Me.Controls.Add(Me.TxtApplicationID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IssuedPermit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Issuance Permit"
        Me.label32.ResumeLayout(False)
        Me.label32.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents referencono As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchRecord As System.Windows.Forms.Button
    Friend WithEvents UploadScannedReceipt As System.Windows.Forms.Button
    Public WithEvents TxtBusinessName As System.Windows.Forms.TextBox
    Public WithEvents TxtAmountPaid As System.Windows.Forms.TextBox
    Public WithEvents B_SentNotification As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents TxtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents useraccountid As System.Windows.Forms.TextBox
    Friend WithEvents label32 As System.Windows.Forms.Panel
    Public WithEvents TxtApplicationID As System.Windows.Forms.TextBox
    Friend WithEvents Type_App As System.Windows.Forms.Label
    Public WithEvents B_Issued As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtBuildingAge As System.Windows.Forms.TextBox
    Public WithEvents TxtBuildingAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_contactno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents B_Signed As System.Windows.Forms.Button
    Friend WithEvents Lbl_Upload As System.Windows.Forms.Label
    Friend WithEvents B_IssuedAttach As System.Windows.Forms.Button
    Public WithEvents Issued_file As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoStorey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtOccupancy_date As System.Windows.Forms.TextBox
    Public WithEvents TxtOccupancyPermit As System.Windows.Forms.TextBox
    Public WithEvents TxtBldg_date As System.Windows.Forms.TextBox
    Public WithEvents TxtBldg_permit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents AxAcroPDF2 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents TxtBuildingOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents Or_link As System.Windows.Forms.LinkLabel
    Friend WithEvents Print_Record As System.Windows.Forms.LinkLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Txt_BusinessOwner As System.Windows.Forms.TextBox
End Class
