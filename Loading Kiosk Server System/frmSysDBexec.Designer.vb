<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysDBexec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysDBexec))
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.imgOk = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.imgError = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtErrors = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStatus.Location = New System.Drawing.Point(26, 19)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.PaddingLeft = 5
        Me.lblStatus.Size = New System.Drawing.Size(835, 17)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Please wait while we backup your Database..."
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(752, 222)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "C&ancel"
        '
        'BackgroundWorker1
        '
        '
        'CircularProgress1
        '
        Me.CircularProgress1.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(6, 19)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.Orange
        Me.CircularProgress1.Size = New System.Drawing.Size(20, 17)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.imgOk)
        Me.GroupBox1.Controls.Add(Me.imgError)
        Me.GroupBox1.Controls.Add(Me.CircularProgress1)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 47)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'imgOk
        '
        Me.imgOk.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.imgOk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgOk.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgOk.Image = CType(resources.GetObject("imgOk.Image"), System.Drawing.Image)
        Me.imgOk.Location = New System.Drawing.Point(324, 19)
        Me.imgOk.Name = "imgOk"
        Me.imgOk.Size = New System.Drawing.Size(20, 17)
        Me.imgOk.TabIndex = 131
        Me.imgOk.Visible = False
        '
        'imgError
        '
        Me.imgError.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.imgError.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgError.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgError.Image = CType(resources.GetObject("imgError.Image"), System.Drawing.Image)
        Me.imgError.Location = New System.Drawing.Point(298, 19)
        Me.imgError.Name = "imgError"
        Me.imgError.Size = New System.Drawing.Size(20, 17)
        Me.imgError.TabIndex = 130
        Me.imgError.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtErrors)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 163)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtErrors
        '
        Me.txtErrors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtErrors.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtErrors.Border.Class = "TextBoxBorder"
        Me.txtErrors.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtErrors.ForeColor = System.Drawing.Color.Black
        Me.txtErrors.Location = New System.Drawing.Point(5, 9)
        Me.txtErrors.Multiline = True
        Me.txtErrors.Name = "txtErrors"
        Me.txtErrors.ReadOnly = True
        Me.txtErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErrors.Size = New System.Drawing.Size(861, 151)
        Me.txtErrors.TabIndex = 0
        '
        'frmSysDBexec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 255)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysDBexec"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>DATABASE BACKUP</h5>"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtErrors As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents imgError As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents imgOk As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
