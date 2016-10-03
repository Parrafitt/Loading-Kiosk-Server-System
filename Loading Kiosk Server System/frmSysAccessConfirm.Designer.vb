<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysAccessConfirm
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysAccessConfirm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnDone = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.txtTitle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cp1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.imgDenied = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgLock = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.bwLoad = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(135, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USERNAME"
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtUser.Border.Class = "TextBoxBorder"
        Me.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUser.FocusHighlightEnabled = True
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(7, 17)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(319, 26)
        Me.txtUser.TabIndex = 0
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtPass)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(135, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 55)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PASSWORD"
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtPass.Border.Class = "TextBoxBorder"
        Me.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPass.FocusHighlightEnabled = True
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(7, 17)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(319, 26)
        Me.txtPass.TabIndex = 0
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDone
        '
        Me.btnDone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnDone.Image = CType(resources.GetObject("btnDone.Image"), System.Drawing.Image)
        Me.btnDone.Location = New System.Drawing.Point(135, 192)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(164, 30)
        Me.btnDone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "&Done <font color=""#1F497D"">( F3 )</font>"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(305, 192)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 30)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close  <font color=""#1F497D"">( Esc )</font>"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.BackColor = System.Drawing.Color.Brown
        '
        '
        '
        Me.txtTitle.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTitle.Border.BorderBottomWidth = 1
        Me.txtTitle.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.txtTitle.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTitle.Border.BorderLeftWidth = 1
        Me.txtTitle.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTitle.Border.BorderRightWidth = 1
        Me.txtTitle.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTitle.Border.BorderTopWidth = 1
        Me.txtTitle.Border.Class = "TextBoxBorder"
        Me.txtTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTitle.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.Snow
        Me.txtTitle.Location = New System.Drawing.Point(2, 10)
        Me.txtTitle.MaxLength = 10
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(477, 41)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.TabStop = False
        Me.txtTitle.Text = "* * AUTHENTICATION REQUIRED * *"
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cp1.Location = New System.Drawing.Point(6, 14)
        Me.cp1.Name = "cp1"
        Me.cp1.PieBorderLight = System.Drawing.Color.White
        Me.cp1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cp1.ProgressColor = System.Drawing.Color.Salmon
        Me.cp1.Size = New System.Drawing.Size(105, 109)
        Me.cp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cp1.TabIndex = 128
        Me.cp1.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(6, 129)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(105, 20)
        Me.lblStatus.TabIndex = 145
        Me.lblStatus.Text = "Authenticating . . ."
        Me.lblStatus.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cp1)
        Me.GroupBox3.Controls.Add(Me.lblStatus)
        Me.GroupBox3.Controls.Add(Me.imgDenied)
        Me.GroupBox3.Controls.Add(Me.imgLock)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(117, 159)
        Me.GroupBox3.TabIndex = 146
        Me.GroupBox3.TabStop = False
        '
        'imgDenied
        '
        '
        '
        '
        Me.imgDenied.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgDenied.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgDenied.Image = CType(resources.GetObject("imgDenied.Image"), System.Drawing.Image)
        Me.imgDenied.Location = New System.Drawing.Point(7, 73)
        Me.imgDenied.Name = "imgDenied"
        Me.imgDenied.Size = New System.Drawing.Size(105, 139)
        Me.imgDenied.TabIndex = 148
        '
        'imgLock
        '
        '
        '
        '
        Me.imgLock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgLock.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgLock.Image = CType(resources.GetObject("imgLock.Image"), System.Drawing.Image)
        Me.imgLock.Location = New System.Drawing.Point(6, 14)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.Size = New System.Drawing.Size(105, 139)
        Me.imgLock.TabIndex = 147
        '
        'bwLoad
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 800
        '
        'frmAccessConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(481, 234)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccessConfirm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>ACCESS RESTRICTED</h5>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnDone As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTitle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents imgLock As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgDenied As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents bwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
