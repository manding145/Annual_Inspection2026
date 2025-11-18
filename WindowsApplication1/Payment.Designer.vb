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
        Me.TxtProjectName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAmountPaid = New System.Windows.Forms.TextBox()
        Me.TxtTransaction = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaveNow = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTDN = New System.Windows.Forms.TextBox()
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
        Me.Txtapplicant_name = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Type_App = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApplicationID = New System.Windows.Forms.TextBox()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.typeofapplication.SuspendLayout()
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
        Me.Label3.Location = New System.Drawing.Point(13, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Project Name:"
        '
        'TxtProjectName
        '
        Me.TxtProjectName.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProjectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProjectName.Enabled = False
        Me.TxtProjectName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProjectName.Location = New System.Drawing.Point(17, 181)
        Me.TxtProjectName.Multiline = True
        Me.TxtProjectName.Name = "TxtProjectName"
        Me.TxtProjectName.ReadOnly = True
        Me.TxtProjectName.Size = New System.Drawing.Size(493, 26)
        Me.TxtProjectName.TabIndex = 162
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
        'TxtTransaction
        '
        Me.TxtTransaction.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTransaction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTransaction.Location = New System.Drawing.Point(22, 338)
        Me.TxtTransaction.Multiline = True
        Me.TxtTransaction.Name = "TxtTransaction"
        Me.TxtTransaction.Size = New System.Drawing.Size(242, 27)
        Me.TxtTransaction.TabIndex = 168
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "TransactionNo"
        '
        'SaveNow
        '
        Me.SaveNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SaveNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveNow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveNow.ForeColor = System.Drawing.Color.White
        Me.SaveNow.Location = New System.Drawing.Point(22, 392)
        Me.SaveNow.Name = "SaveNow"
        Me.SaveNow.Size = New System.Drawing.Size(194, 32)
        Me.SaveNow.TabIndex = 172
        Me.SaveNow.Text = "&Record Payment Now"
        Me.SaveNow.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "TDN no."
        '
        'TxtTDN
        '
        Me.TxtTDN.BackColor = System.Drawing.Color.AliceBlue
        Me.TxtTDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTDN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTDN.Enabled = False
        Me.TxtTDN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTDN.Location = New System.Drawing.Point(16, 81)
        Me.TxtTDN.Multiline = True
        Me.TxtTDN.Name = "TxtTDN"
        Me.TxtTDN.ReadOnly = True
        Me.TxtTDN.Size = New System.Drawing.Size(242, 26)
        Me.TxtTDN.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Applicant Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tax_amount)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 89)
        Me.GroupBox1.TabIndex = 182
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assessment Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 13)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "Construction Tax Assessment Amount"
        '
        'tax_amount
        '
        Me.tax_amount.BackColor = System.Drawing.Color.AliceBlue
        Me.tax_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tax_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tax_amount.Enabled = False
        Me.tax_amount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tax_amount.Location = New System.Drawing.Point(6, 42)
        Me.tax_amount.Multiline = True
        Me.tax_amount.Name = "tax_amount"
        Me.tax_amount.ReadOnly = True
        Me.tax_amount.Size = New System.Drawing.Size(242, 26)
        Me.tax_amount.TabIndex = 177
        Me.tax_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AxAcroPDF2
        '
        Me.AxAcroPDF2.Enabled = True
        Me.AxAcroPDF2.Location = New System.Drawing.Point(836, 21)
        Me.AxAcroPDF2.Name = "AxAcroPDF2"
        Me.AxAcroPDF2.OcxState = CType(resources.GetObject("AxAcroPDF2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF2.Size = New System.Drawing.Size(226, 281)
        Me.AxAcroPDF2.TabIndex = 173
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ORattachment)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 89)
        Me.GroupBox2.TabIndex = 183
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 26)
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
        Me.ORattachment.Location = New System.Drawing.Point(19, 42)
        Me.ORattachment.Multiline = True
        Me.ORattachment.Name = "ORattachment"
        Me.ORattachment.Size = New System.Drawing.Size(466, 26)
        Me.ORattachment.TabIndex = 177
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 25)
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
        Me.useraccountid.Location = New System.Drawing.Point(592, 58)
        Me.useraccountid.Name = "useraccountid"
        Me.useraccountid.Size = New System.Drawing.Size(197, 22)
        Me.useraccountid.TabIndex = 187
        Me.useraccountid.Visible = False
        '
        'typeofapplication
        '
        Me.typeofapplication.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.typeofapplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.typeofapplication.Controls.Add(Me.Txtapplicant_name)
        Me.typeofapplication.Controls.Add(Me.txt_email)
        Me.typeofapplication.Controls.Add(Me.useraccountid)
        Me.typeofapplication.Controls.Add(Me.GroupBox2)
        Me.typeofapplication.Controls.Add(Me.AxAcroPDF2)
        Me.typeofapplication.Controls.Add(Me.GroupBox1)
        Me.typeofapplication.Controls.Add(Me.Type_App)
        Me.typeofapplication.Controls.Add(Me.Label4)
        Me.typeofapplication.Controls.Add(Me.Label2)
        Me.typeofapplication.Controls.Add(Me.TxtTDN)
        Me.typeofapplication.Controls.Add(Me.Label9)
        Me.typeofapplication.Controls.Add(Me.SaveNow)
        Me.typeofapplication.Controls.Add(Me.Label7)
        Me.typeofapplication.Controls.Add(Me.TxtTransaction)
        Me.typeofapplication.Controls.Add(Me.TxtAmountPaid)
        Me.typeofapplication.Controls.Add(Me.Label5)
        Me.typeofapplication.Controls.Add(Me.TxtProjectName)
        Me.typeofapplication.Controls.Add(Me.Label3)
        Me.typeofapplication.Location = New System.Drawing.Point(22, 83)
        Me.typeofapplication.Name = "typeofapplication"
        Me.typeofapplication.Size = New System.Drawing.Size(1084, 430)
        Me.typeofapplication.TabIndex = 159
        '
        'Txtapplicant_name
        '
        Me.Txtapplicant_name.BackColor = System.Drawing.Color.AliceBlue
        Me.Txtapplicant_name.Enabled = False
        Me.Txtapplicant_name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txtapplicant_name.Location = New System.Drawing.Point(16, 126)
        Me.Txtapplicant_name.Multiline = True
        Me.Txtapplicant_name.Name = "Txtapplicant_name"
        Me.Txtapplicant_name.Size = New System.Drawing.Size(242, 26)
        Me.Txtapplicant_name.TabIndex = 188
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_email.Enabled = False
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email.Location = New System.Drawing.Point(268, 124)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(242, 26)
        Me.txt_email.TabIndex = 188
        '
        'Type_App
        '
        Me.Type_App.AutoSize = True
        Me.Type_App.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Type_App.Location = New System.Drawing.Point(19, 21)
        Me.Type_App.Name = "Type_App"
        Me.Type_App.Size = New System.Drawing.Size(145, 18)
        Me.Type_App.TabIndex = 174
        Me.Type_App.Text = "type of application"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Email:"
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
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 520)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.typeofapplication)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.referencono)
        Me.Controls.Add(Me.BtnSearchRecord)
        Me.Controls.Add(Me.UploadScannedReceipt)
        Me.Controls.Add(Me.TxtApplicationID)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Online Payment"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.typeofapplication.ResumeLayout(False)
        Me.typeofapplication.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents referencono As System.Windows.Forms.TextBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents BtnSearchRecord As System.Windows.Forms.Button
    Friend WithEvents UploadScannedReceipt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents TxtAmountPaid As System.Windows.Forms.TextBox
    Public WithEvents TxtTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents SaveNow As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents TxtTDN As System.Windows.Forms.TextBox
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Txtapplicant_name As System.Windows.Forms.TextBox
    Friend WithEvents Type_App As System.Windows.Forms.Label
End Class
