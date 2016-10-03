<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysAbout
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysAbout))
        Me.lblVersion = New DevComponents.DotNetBar.LabelX()
        Me.lblCopyright = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.lblVersion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVersion.Location = New System.Drawing.Point(12, 237)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(309, 24)
        Me.lblVersion.TabIndex = 18
        Me.lblVersion.Text = "< System Version >"
        Me.lblVersion.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblCopyright
        '
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblCopyright.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCopyright.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblCopyright.ForeColor = System.Drawing.Color.Linen
        Me.lblCopyright.Location = New System.Drawing.Point(352, 239)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(304, 22)
        Me.lblCopyright.TabIndex = 129
        Me.lblCopyright.Text = "<Copyright>"
        Me.lblCopyright.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmSysAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(670, 266)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblVersion As DevComponents.DotNetBar.LabelX
    Private WithEvents lblCopyright As DevComponents.DotNetBar.LabelX
End Class
