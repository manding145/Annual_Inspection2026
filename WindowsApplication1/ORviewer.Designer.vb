<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ORviewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ORviewer))
        Me.AxAcroPDF2 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDF2
        '
        Me.AxAcroPDF2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF2.Enabled = True
        Me.AxAcroPDF2.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF2.Name = "AxAcroPDF2"
        Me.AxAcroPDF2.OcxState = CType(resources.GetObject("AxAcroPDF2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF2.Size = New System.Drawing.Size(675, 580)
        Me.AxAcroPDF2.TabIndex = 174
        '
        'ORviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 580)
        Me.Controls.Add(Me.AxAcroPDF2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ORviewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Official Receipt "
        CType(Me.AxAcroPDF2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxAcroPDF2 As AxAcroPDFLib.AxAcroPDF
End Class
