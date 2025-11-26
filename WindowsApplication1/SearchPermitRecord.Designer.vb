<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPermitRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchPermitRecord))
        Me.txtquery = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.check_Accuntno = New System.Windows.Forms.CheckBox()
        Me.txt_accountno = New System.Windows.Forms.TextBox()
        Me.BtnSearchRecord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtquery
        '
        Me.txtquery.BackColor = System.Drawing.Color.AliceBlue
        Me.txtquery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtquery.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtquery.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquery.Location = New System.Drawing.Point(26, 224)
        Me.txtquery.Name = "txtquery"
        Me.txtquery.Size = New System.Drawing.Size(359, 23)
        Me.txtquery.TabIndex = 189
        Me.txtquery.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 15)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "SEARCH BY:"
        '
        'check_Accuntno
        '
        Me.check_Accuntno.AutoSize = True
        Me.check_Accuntno.Checked = True
        Me.check_Accuntno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_Accuntno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.check_Accuntno.Location = New System.Drawing.Point(48, 32)
        Me.check_Accuntno.Name = "check_Accuntno"
        Me.check_Accuntno.Size = New System.Drawing.Size(90, 19)
        Me.check_Accuntno.TabIndex = 184
        Me.check_Accuntno.Text = "Account No"
        Me.check_Accuntno.UseVisualStyleBackColor = True
        '
        'txt_accountno
        '
        Me.txt_accountno.BackColor = System.Drawing.Color.AliceBlue
        Me.txt_accountno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_accountno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_accountno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_accountno.Location = New System.Drawing.Point(160, 31)
        Me.txt_accountno.Name = "txt_accountno"
        Me.txt_accountno.Size = New System.Drawing.Size(184, 23)
        Me.txt_accountno.TabIndex = 180
        '
        'BtnSearchRecord
        '
        Me.BtnSearchRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnSearchRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchRecord.ForeColor = System.Drawing.Color.White
        Me.BtnSearchRecord.Location = New System.Drawing.Point(160, 60)
        Me.BtnSearchRecord.Name = "BtnSearchRecord"
        Me.BtnSearchRecord.Size = New System.Drawing.Size(184, 31)
        Me.BtnSearchRecord.TabIndex = 179
        Me.BtnSearchRecord.Text = "&Search"
        Me.BtnSearchRecord.UseVisualStyleBackColor = False
        '
        'SearchPermitRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 113)
        Me.Controls.Add(Me.txtquery)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.check_Accuntno)
        Me.Controls.Add(Me.txt_accountno)
        Me.Controls.Add(Me.BtnSearchRecord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchPermitRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Application Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtquery As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents check_Accuntno As System.Windows.Forms.CheckBox
    Friend WithEvents txt_accountno As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchRecord As System.Windows.Forms.Button
End Class
