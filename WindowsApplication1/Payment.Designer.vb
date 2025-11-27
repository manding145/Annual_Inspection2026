<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.referencono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.BtnSearchRecord = New System.Windows.Forms.Button()
        Me.UploadScannedReceipt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBusinessName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTransaction = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaveNow = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAccountNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tax_amount = New System.Windows.Forms.TextBox()
        Me.AxAcroPDF2 = New AxAcroPDFLib.AxAcroPDF()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ORattachment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.useraccountid = New System.Windows.Forms.TextBox()
        Me.typeofapplication = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_contactno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtOwnerName = New System.Windows.Forms.TextBox()
        Me.Type_App = New System.Windows.Forms.Label()
        Me.TxtApplicationID = New System.Windows.Forms.TextBox()
        Me.Txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.referencono.Location = New System.Drawing.Point(15, 37)
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
        Me.Label1.Location = New System.Drawing.Point(15, 18)
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
        Me.BtnSearchRecord.Text = "&Search Record"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Business Name:"
        '
        'TxtBusinessName
        '
        Me.TxtBusinessName.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtBusinessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusinessName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBusinessName.Enabled = False
        Me.TxtBusinessName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusinessName.Location = New System.Drawing.Point(16, 137)
        Me.TxtBusinessName.Multiline = True
        Me.TxtBusinessName.Name = "TxtBusinessName"
        Me.TxtBusinessName.ReadOnly = True
        Me.TxtBusinessName.Size = New System.Drawing.Size(476, 26)
        Me.TxtBusinessName.TabIndex = 162
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 582)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Amount Paid"
        '
        'TxtTransaction
        '
        Me.TxtTransaction.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTransaction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTransaction.Location = New System.Drawing.Point(14, 84)
        Me.TxtTransaction.Multiline = True
        Me.TxtTransaction.Name = "TxtTransaction"
        Me.TxtTransaction.Size = New System.Drawing.Size(242, 27)
        Me.TxtTransaction.TabIndex = 168
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Official Receipt No."
        '
        'SaveNow
        '
        Me.SaveNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SaveNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveNow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveNow.ForeColor = System.Drawing.Color.White
        Me.SaveNow.Location = New System.Drawing.Point(11, 366)
        Me.SaveNow.Name = "SaveNow"
        Me.SaveNow.Size = New System.Drawing.Size(194, 32)
        Me.SaveNow.TabIndex = 172
        Me.SaveNow.Text = "&Record Payment Now"
        Me.SaveNow.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "Account No."
        '
        'TxtAccountNo
        '
        Me.TxtAccountNo.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccountNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAccountNo.Enabled = False
        Me.TxtAccountNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccountNo.Location = New System.Drawing.Point(16, 42)
        Me.TxtAccountNo.Multiline = True
        Me.TxtAccountNo.Name = "TxtAccountNo"
        Me.TxtAccountNo.ReadOnly = True
        Me.TxtAccountNo.Size = New System.Drawing.Size(242, 26)
        Me.TxtAccountNo.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Owner Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(275, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 89)
        Me.GroupBox1.TabIndex = 182
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assessment Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(269, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "Tax Assessment Amount"
        '
        'tax_amount
        '
        Me.tax_amount.BackColor = System.Drawing.Color.AliceBlue
        Me.tax_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tax_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tax_amount.Enabled = False
        Me.tax_amount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tax_amount.Location = New System.Drawing.Point(273, 85)
        Me.tax_amount.Multiline = True
        Me.tax_amount.Name = "tax_amount"
        Me.tax_amount.ReadOnly = True
        Me.tax_amount.Size = New System.Drawing.Size(212, 26)
        Me.tax_amount.TabIndex = 177
        Me.tax_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AxAcroPDF2
        '
        Me.AxAcroPDF2.Enabled = True
        Me.AxAcroPDF2.Location = New System.Drawing.Point(1112, -11)
        Me.AxAcroPDF2.Name = "AxAcroPDF2"
        Me.AxAcroPDF2.OcxState = CType(resources.GetObject("AxAcroPDF2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF2.Size = New System.Drawing.Size(226, 281)
        Me.AxAcroPDF2.TabIndex = 173
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tax_amount)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ORattachment)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_remarks)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtTransaction)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 191)
        Me.GroupBox2.TabIndex = 183
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 25)
        Me.Button1.TabIndex = 182
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ORattachment
        '
        Me.ORattachment.BackColor = System.Drawing.Color.AliceBlue
        Me.ORattachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ORattachment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ORattachment.Enabled = False
        Me.ORattachment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORattachment.Location = New System.Drawing.Point(13, 38)
        Me.ORattachment.Multiline = True
        Me.ORattachment.Name = "ORattachment"
        Me.ORattachment.Size = New System.Drawing.Size(472, 25)
        Me.ORattachment.TabIndex = 177
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 13)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Official Receipt Attachment"
        '
        'useraccountid
        '
        Me.useraccountid.BackColor = System.Drawing.Color.AliceBlue
        Me.useraccountid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.useraccountid.Enabled = False
        Me.useraccountid.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useraccountid.Location = New System.Drawing.Point(638, 17)
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
        Me.typeofapplication.Controls.Add(Me.TxtOwnerName)
        Me.typeofapplication.Controls.Add(Me.useraccountid)
        Me.typeofapplication.Controls.Add(Me.GroupBox2)
        Me.typeofapplication.Controls.Add(Me.GroupBox1)
        Me.typeofapplication.Controls.Add(Me.Type_App)
        Me.typeofapplication.Controls.Add(Me.Label2)
        Me.typeofapplication.Controls.Add(Me.TxtAccountNo)
        Me.typeofapplication.Controls.Add(Me.Label9)
        Me.typeofapplication.Controls.Add(Me.SaveNow)
        Me.typeofapplication.Controls.Add(Me.Label5)
        Me.typeofapplication.Controls.Add(Me.TxtBusinessName)
        Me.typeofapplication.Controls.Add(Me.Label3)
        Me.typeofapplication.Location = New System.Drawing.Point(15, 81)
        Me.typeofapplication.Name = "typeofapplication"
        Me.typeofapplication.Size = New System.Drawing.Size(876, 418)
        Me.typeofapplication.TabIndex = 159
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.fullname)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_email)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_contactno)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(540, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 126)
        Me.GroupBox3.TabIndex = 191
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Email:"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "Contact Number:"
        '
        'TxtOwnerName
        '
        Me.TxtOwnerName.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtOwnerName.Enabled = False
        Me.TxtOwnerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOwnerName.Location = New System.Drawing.Point(16, 88)
        Me.TxtOwnerName.Multiline = True
        Me.TxtOwnerName.Name = "TxtOwnerName"
        Me.TxtOwnerName.Size = New System.Drawing.Size(242, 26)
        Me.TxtOwnerName.TabIndex = 188
        '
        'Type_App
        '
        Me.Type_App.AutoSize = True
        Me.Type_App.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Type_App.Location = New System.Drawing.Point(19, 8)
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
        Me.TxtApplicationID.Location = New System.Drawing.Point(859, 42)
        Me.TxtApplicationID.Multiline = True
        Me.TxtApplicationID.Name = "TxtApplicationID"
        Me.TxtApplicationID.ReadOnly = True
        Me.TxtApplicationID.Size = New System.Drawing.Size(242, 26)
        Me.TxtApplicationID.TabIndex = 175
        Me.TxtApplicationID.Visible = False
        '
        'Txt_remarks
        '
        Me.Txt_remarks.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_remarks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_remarks.Location = New System.Drawing.Point(13, 129)
        Me.Txt_remarks.Multiline = True
        Me.Txt_remarks.Name = "Txt_remarks"
        Me.Txt_remarks.Size = New System.Drawing.Size(472, 49)
        Me.Txt_remarks.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Remarks"
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 511)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.typeofapplication)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.referencono)
        Me.Controls.Add(Me.AxAcroPDF2)
        Me.Controls.Add(Me.BtnSearchRecord)
        Me.Controls.Add(Me.UploadScannedReceipt)
        Me.Controls.Add(Me.TxtApplicationID)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Online Payment"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtBusinessName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TxtTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents SaveNow As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents TxtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents tax_amount As System.Windows.Forms.TextBox
    Friend WithEvents AxAcroPDF2 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents ORattachment As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents useraccountid As System.Windows.Forms.TextBox
    Friend WithEvents typeofapplication As System.Windows.Forms.Panel
    Public WithEvents TxtApplicationID As System.Windows.Forms.TextBox
    Friend WithEvents TxtOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents Type_App As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents fullname As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_contactno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Txt_remarks As System.Windows.Forms.TextBox
End Class
