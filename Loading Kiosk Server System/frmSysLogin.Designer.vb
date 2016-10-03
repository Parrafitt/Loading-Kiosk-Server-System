<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysLogin))
        Me.txtUser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.lblVersion = New DevComponents.DotNetBar.LabelX()
        Me.lblCp1 = New DevComponents.DotNetBar.LabelX()
        Me.cp1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.bwLoad = New System.ComponentModel.BackgroundWorker()
        Me.imgError = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgCritical = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgOk = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.SuspendLayout()
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.Border.Class = "TextBoxBorder"
        Me.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUser.FocusHighlightEnabled = True
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(368, 96)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(279, 26)
        Me.txtUser.TabIndex = 0
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.Border.Class = "TextBoxBorder"
        Me.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPass.FocusHighlightEnabled = True
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(368, 151)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(279, 26)
        Me.txtPass.TabIndex = 1
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.HoverImage = CType(resources.GetObject("btnLogin.HoverImage"), System.Drawing.Image)
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(547, 185)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.btnLogin.Size = New System.Drawing.Size(50, 42)
        Me.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Tooltip = "Login"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.HoverImage = CType(resources.GetObject("btnExit.HoverImage"), System.Drawing.Image)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(597, 185)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.btnExit.Size = New System.Drawing.Size(50, 42)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 3
        Me.btnExit.TextColor = System.Drawing.Color.Transparent
        Me.btnExit.Tooltip = "Exit"
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
        Me.lblVersion.Location = New System.Drawing.Point(10, 238)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(309, 24)
        Me.lblVersion.TabIndex = 17
        Me.lblVersion.Text = "< System Version >"
        Me.lblVersion.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblCp1
        '
        Me.lblCp1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblCp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCp1.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.lblCp1.ForeColor = System.Drawing.Color.Linen
        Me.lblCp1.Location = New System.Drawing.Point(368, 242)
        Me.lblCp1.Name = "lblCp1"
        Me.lblCp1.Size = New System.Drawing.Size(279, 17)
        Me.lblCp1.TabIndex = 128
        Me.lblCp1.Text = "Authenticating, Please Wait..."
        Me.lblCp1.Visible = False
        '
        'cp1
        '
        Me.cp1.AnimationSpeed = 50
        Me.cp1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.cp1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.cp1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cp1.Location = New System.Drawing.Point(342, 242)
        Me.cp1.Name = "cp1"
        Me.cp1.PieBorderLight = System.Drawing.Color.White
        Me.cp1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cp1.ProgressColor = System.Drawing.Color.Gold
        Me.cp1.Size = New System.Drawing.Size(20, 17)
        Me.cp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cp1.TabIndex = 127
        Me.cp1.Visible = False
        '
        'bwLoad
        '
        '
        'imgError
        '
        Me.imgError.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.imgError.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgError.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgError.Image = CType(resources.GetObject("imgError.Image"), System.Drawing.Image)
        Me.imgError.Location = New System.Drawing.Point(342, 219)
        Me.imgError.Name = "imgError"
        Me.imgError.Size = New System.Drawing.Size(20, 17)
        Me.imgError.TabIndex = 129
        Me.imgError.Visible = False
        '
        'imgCritical
        '
        Me.imgCritical.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.imgCritical.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgCritical.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgCritical.Image = CType(resources.GetObject("imgCritical.Image"), System.Drawing.Image)
        Me.imgCritical.Location = New System.Drawing.Point(394, 219)
        Me.imgCritical.Name = "imgCritical"
        Me.imgCritical.Size = New System.Drawing.Size(20, 17)
        Me.imgCritical.TabIndex = 133
        Me.imgCritical.Visible = False
        '
        'imgOk
        '
        Me.imgOk.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.imgOk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgOk.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgOk.Image = CType(resources.GetObject("imgOk.Image"), System.Drawing.Image)
        Me.imgOk.Location = New System.Drawing.Point(368, 219)
        Me.imgOk.Name = "imgOk"
        Me.imgOk.Size = New System.Drawing.Size(20, 17)
        Me.imgOk.TabIndex = 132
        Me.imgOk.Visible = False
        '
        'frmSysLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(670, 266)
        Me.Controls.Add(Me.imgCritical)
        Me.Controls.Add(Me.imgOk)
        Me.Controls.Add(Me.imgError)
        Me.Controls.Add(Me.lblCp1)
        Me.Controls.Add(Me.cp1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblVersion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCp1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents bwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents imgError As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgCritical As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgOk As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
