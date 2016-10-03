<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysPatcher
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
        Me.bwLoad = New System.ComponentModel.BackgroundWorker()
        Me.cp1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.lblMainStat = New DevComponents.DotNetBar.LabelX()
        Me.txtProcess = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuspendLayout()
        '
        'bwLoad
        '
        '
        'cp1
        '
        Me.cp1.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.cp1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderBottomWidth = 2
        Me.cp1.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.cp1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderLeftWidth = 2
        Me.cp1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderRightWidth = 2
        Me.cp1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderTopWidth = 2
        Me.cp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cp1.Location = New System.Drawing.Point(12, 12)
        Me.cp1.Name = "cp1"
        Me.cp1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cp1.ProgressColor = System.Drawing.Color.Orange
        Me.cp1.ProgressTextColor = System.Drawing.Color.WhiteSmoke
        Me.cp1.ProgressTextFormat = "{0}"
        Me.cp1.ProgressTextVisible = True
        Me.cp1.Size = New System.Drawing.Size(185, 185)
        Me.cp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.cp1.TabIndex = 136
        Me.cp1.Value = 50
        '
        'lblMainStat
        '
        Me.lblMainStat.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.lblMainStat.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblMainStat.BackgroundStyle.BorderBottomWidth = 2
        Me.lblMainStat.BackgroundStyle.BorderColor = System.Drawing.Color.DimGray
        Me.lblMainStat.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblMainStat.BackgroundStyle.BorderLeftWidth = 2
        Me.lblMainStat.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblMainStat.BackgroundStyle.BorderRightWidth = 2
        Me.lblMainStat.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblMainStat.BackgroundStyle.BorderTopWidth = 2
        Me.lblMainStat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMainStat.BackgroundStyle.PaddingLeft = 5
        Me.lblMainStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblMainStat.ForeColor = System.Drawing.Color.Gold
        Me.lblMainStat.Location = New System.Drawing.Point(194, 12)
        Me.lblMainStat.Name = "lblMainStat"
        Me.lblMainStat.Size = New System.Drawing.Size(713, 67)
        Me.lblMainStat.TabIndex = 137
        Me.lblMainStat.Text = "Loading Data, Please Wait . . ."
        Me.lblMainStat.WordWrap = True
        '
        'txtProcess
        '
        Me.txtProcess.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.txtProcess.Border.BorderBottomWidth = 2
        Me.txtProcess.Border.BorderColor = System.Drawing.Color.Black
        Me.txtProcess.Border.BorderLeftWidth = 2
        Me.txtProcess.Border.BorderRightWidth = 2
        Me.txtProcess.Border.BorderTopWidth = 2
        Me.txtProcess.Border.Class = "TextBoxBorder"
        Me.txtProcess.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtProcess.Border.PaddingLeft = 6
        Me.txtProcess.Border.PaddingTop = 6
        Me.txtProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.txtProcess.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtProcess.Location = New System.Drawing.Point(194, 77)
        Me.txtProcess.Multiline = True
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.ReadOnly = True
        Me.txtProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProcess.Size = New System.Drawing.Size(713, 120)
        Me.txtProcess.TabIndex = 138
        Me.txtProcess.Text = "> Testing process . . ."
        '
        'frmSysPatcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 209)
        Me.Controls.Add(Me.cp1)
        Me.Controls.Add(Me.lblMainStat)
        Me.Controls.Add(Me.txtProcess)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysPatcher"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>UPDATING DATABASE STRUCTURE</h5>"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Public WithEvents lblMainStat As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtProcess As DevComponents.DotNetBar.Controls.TextBoxX
End Class
