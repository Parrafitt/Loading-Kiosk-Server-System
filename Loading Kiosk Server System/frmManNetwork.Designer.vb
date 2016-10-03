<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManNetwork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManNetwork))
        Me.gpInfo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gpLogo = New System.Windows.Forms.GroupBox()
        Me.lblIndexNo = New DevComponents.DotNetBar.LabelX()
        Me.btnLogoDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnLogoBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.imgLogo = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpSubList = New System.Windows.Forms.GroupBox()
        Me.AdvTree2 = New DevComponents.AdvTree.AdvTree()
        Me.lblStatus2 = New DevComponents.DotNetBar.LabelX()
        Me.cp2 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.ElementStyle5 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle6 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle7 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle8 = New DevComponents.DotNetBar.ElementStyle()
        Me.btnPrefixDel = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrefixEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrefixAdd = New DevComponents.DotNetBar.ButtonX()
        Me.txtPrefix = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPrefix = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq02 = New DevComponents.DotNetBar.LabelX()
        Me.lblReq01 = New DevComponents.DotNetBar.LabelX()
        Me.btnHisEndSel = New DevComponents.DotNetBar.ButtonItem()
        Me.btnHisStartSel = New DevComponents.DotNetBar.ButtonItem()
        Me.btnHisDrivSel = New DevComponents.DotNetBar.ButtonItem()
        Me.btnHisDateSel = New DevComponents.DotNetBar.ButtonItem()
        Me.gpList = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnFirstPage = New DevComponents.DotNetBar.ButtonX()
        Me.btnPreviousPage = New DevComponents.DotNetBar.ButtonX()
        Me.btnNextPage = New DevComponents.DotNetBar.ButtonX()
        Me.btnLastPage = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.lblDisplayPageNo = New DevComponents.DotNetBar.LabelX()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.btnRefresh = New DevComponents.DotNetBar.ButtonX()
        Me.btnExpand = New DevComponents.DotNetBar.ButtonX()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.gpMainList = New System.Windows.Forms.GroupBox()
        Me.advTree1 = New DevComponents.AdvTree.AdvTree()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.cp1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.ElementStyle4 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle3 = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.bwQuery = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSaveNew = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.gpInfo.SuspendLayout()
        Me.gpLogo.SuspendLayout()
        Me.gpSubList.SuspendLayout()
        CType(Me.AdvTree2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdvTree2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpList.SuspendLayout()
        Me.gpMainList.SuspendLayout()
        CType(Me.advTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.advTree1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpInfo
        '
        Me.gpInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpInfo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpInfo.Controls.Add(Me.gpLogo)
        Me.gpInfo.Controls.Add(Me.gpSubList)
        Me.gpInfo.Controls.Add(Me.GroupBox2)
        Me.gpInfo.Location = New System.Drawing.Point(372, 12)
        Me.gpInfo.Name = "gpInfo"
        Me.gpInfo.Size = New System.Drawing.Size(562, 429)
        '
        '
        '
        Me.gpInfo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpInfo.Style.BackColorGradientAngle = 90
        Me.gpInfo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpInfo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpInfo.Style.BorderBottomWidth = 1
        Me.gpInfo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpInfo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpInfo.Style.BorderLeftWidth = 1
        Me.gpInfo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpInfo.Style.BorderRightWidth = 1
        Me.gpInfo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpInfo.Style.BorderTopWidth = 1
        Me.gpInfo.Style.CornerDiameter = 4
        Me.gpInfo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpInfo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpInfo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpInfo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpInfo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpInfo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpInfo.TabIndex = 0
        Me.gpInfo.Text = "Information"
        '
        'gpLogo
        '
        Me.gpLogo.BackColor = System.Drawing.Color.Transparent
        Me.gpLogo.Controls.Add(Me.lblIndexNo)
        Me.gpLogo.Controls.Add(Me.btnLogoDelete)
        Me.gpLogo.Controls.Add(Me.btnLogoBrowse)
        Me.gpLogo.Controls.Add(Me.imgLogo)
        Me.gpLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpLogo.Location = New System.Drawing.Point(3, 6)
        Me.gpLogo.Name = "gpLogo"
        Me.gpLogo.Size = New System.Drawing.Size(210, 210)
        Me.gpLogo.TabIndex = 168
        Me.gpLogo.TabStop = False
        Me.gpLogo.Text = "NETWORK LOGO"
        '
        'lblIndexNo
        '
        Me.lblIndexNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIndexNo.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.lblIndexNo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblIndexNo.BackgroundStyle.BorderBottomWidth = 1
        Me.lblIndexNo.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.lblIndexNo.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblIndexNo.BackgroundStyle.BorderLeftWidth = 1
        Me.lblIndexNo.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblIndexNo.BackgroundStyle.BorderRightWidth = 1
        Me.lblIndexNo.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblIndexNo.BackgroundStyle.BorderTopWidth = 1
        Me.lblIndexNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblIndexNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndexNo.Location = New System.Drawing.Point(3, 190)
        Me.lblIndexNo.Name = "lblIndexNo"
        Me.lblIndexNo.Size = New System.Drawing.Size(204, 17)
        Me.lblIndexNo.TabIndex = 145
        Me.lblIndexNo.Text = "0000"
        Me.lblIndexNo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnLogoDelete
        '
        Me.btnLogoDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogoDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogoDelete.Image = CType(resources.GetObject("btnLogoDelete.Image"), System.Drawing.Image)
        Me.btnLogoDelete.Location = New System.Drawing.Point(11, 51)
        Me.btnLogoDelete.Name = "btnLogoDelete"
        Me.btnLogoDelete.Size = New System.Drawing.Size(25, 25)
        Me.btnLogoDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogoDelete.TabIndex = 139
        Me.btnLogoDelete.Tooltip = "Delete picture . . ."
        Me.btnLogoDelete.Visible = False
        '
        'btnLogoBrowse
        '
        Me.btnLogoBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogoBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogoBrowse.Image = CType(resources.GetObject("btnLogoBrowse.Image"), System.Drawing.Image)
        Me.btnLogoBrowse.Location = New System.Drawing.Point(11, 24)
        Me.btnLogoBrowse.Name = "btnLogoBrowse"
        Me.btnLogoBrowse.Size = New System.Drawing.Size(25, 25)
        Me.btnLogoBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogoBrowse.TabIndex = 138
        Me.btnLogoBrowse.Tooltip = "Browse for picture . . ."
        Me.btnLogoBrowse.Visible = False
        '
        'imgLogo
        '
        '
        '
        '
        Me.imgLogo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.imgLogo.BackgroundStyle.BorderBottomWidth = 1
        Me.imgLogo.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.imgLogo.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.imgLogo.BackgroundStyle.BorderLeftWidth = 1
        Me.imgLogo.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.imgLogo.BackgroundStyle.BorderRightWidth = 1
        Me.imgLogo.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.imgLogo.BackgroundStyle.BorderTopWidth = 1
        Me.imgLogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imgLogo.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.imgLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(3, 14)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.ReflectionEnabled = False
        Me.imgLogo.Size = New System.Drawing.Size(204, 193)
        Me.imgLogo.TabIndex = 134
        '
        'gpSubList
        '
        Me.gpSubList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpSubList.BackColor = System.Drawing.Color.Transparent
        Me.gpSubList.Controls.Add(Me.AdvTree2)
        Me.gpSubList.Controls.Add(Me.btnPrefixDel)
        Me.gpSubList.Controls.Add(Me.btnPrefixEdit)
        Me.gpSubList.Controls.Add(Me.btnPrefixAdd)
        Me.gpSubList.Controls.Add(Me.txtPrefix)
        Me.gpSubList.Controls.Add(Me.lblPrefix)
        Me.gpSubList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpSubList.Location = New System.Drawing.Point(219, 6)
        Me.gpSubList.Name = "gpSubList"
        Me.gpSubList.Size = New System.Drawing.Size(329, 395)
        Me.gpSubList.TabIndex = 1
        Me.gpSubList.TabStop = False
        Me.gpSubList.Text = "PREFIX LIST"
        '
        'AdvTree2
        '
        Me.AdvTree2.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree2.AllowDrop = True
        Me.AdvTree2.AlternateRowColor = System.Drawing.Color.Gainsboro
        Me.AdvTree2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.AdvTree2.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree2.Controls.Add(Me.lblStatus2)
        Me.AdvTree2.Controls.Add(Me.cp2)
        Me.AdvTree2.DragDropEnabled = False
        Me.AdvTree2.DragDropNodeCopyEnabled = False
        Me.AdvTree2.ExpandButtonSize = New System.Drawing.Size(0, 0)
        Me.AdvTree2.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Ellipse
        Me.AdvTree2.ExpandWidth = 0
        Me.AdvTree2.GridColumnLines = False
        Me.AdvTree2.Location = New System.Drawing.Point(6, 50)
        Me.AdvTree2.MultiSelect = True
        Me.AdvTree2.Name = "AdvTree2"
        Me.AdvTree2.NodeStyle = Me.ElementStyle5
        Me.AdvTree2.PathSeparator = ";"
        Me.AdvTree2.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect
        Me.AdvTree2.Size = New System.Drawing.Size(317, 339)
        Me.AdvTree2.Styles.Add(Me.ElementStyle6)
        Me.AdvTree2.Styles.Add(Me.ElementStyle7)
        Me.AdvTree2.Styles.Add(Me.ElementStyle5)
        Me.AdvTree2.Styles.Add(Me.ElementStyle8)
        Me.AdvTree2.TabIndex = 178
        Me.AdvTree2.Text = "advTree4"
        '
        'lblStatus2
        '
        Me.lblStatus2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus2.BackColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.lblStatus2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus2.BackgroundStyle.BorderBottomWidth = 1
        Me.lblStatus2.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus2.BackgroundStyle.BorderLeftWidth = 1
        Me.lblStatus2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus2.BackgroundStyle.BorderRightWidth = 1
        Me.lblStatus2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus2.BackgroundStyle.BorderTopWidth = 1
        Me.lblStatus2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStatus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.lblStatus2.ForeColor = System.Drawing.Color.LightYellow
        Me.lblStatus2.Location = New System.Drawing.Point(0, 141)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.PaddingLeft = 2
        Me.lblStatus2.PaddingRight = 2
        Me.lblStatus2.Size = New System.Drawing.Size(317, 65)
        Me.lblStatus2.TabIndex = 141
        Me.lblStatus2.Text = "Loading, please wait . . ."
        Me.lblStatus2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblStatus2.Visible = False
        Me.lblStatus2.WordWrap = True
        '
        'cp2
        '
        Me.cp2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cp2.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.cp2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderBottomWidth = 1
        Me.cp2.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.cp2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderLeftWidth = 1
        Me.cp2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderRightWidth = 1
        Me.cp2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp2.BackgroundStyle.BorderTopWidth = 1
        Me.cp2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cp2.Location = New System.Drawing.Point(0, 89)
        Me.cp2.Name = "cp2"
        Me.cp2.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cp2.ProgressColor = System.Drawing.Color.Yellow
        Me.cp2.Size = New System.Drawing.Size(317, 167)
        Me.cp2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.cp2.TabIndex = 140
        Me.cp2.Value = 100
        Me.cp2.Visible = False
        '
        'ElementStyle5
        '
        Me.ElementStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ElementStyle5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ElementStyle5.BackColorGradientAngle = 90
        Me.ElementStyle5.BorderBottomWidth = 1
        Me.ElementStyle5.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle5.BorderLeftWidth = 1
        Me.ElementStyle5.BorderRightWidth = 1
        Me.ElementStyle5.BorderTopWidth = 1
        Me.ElementStyle5.CornerDiameter = 4
        Me.ElementStyle5.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle5.Description = "Green"
        Me.ElementStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle5.Name = "ElementStyle5"
        Me.ElementStyle5.PaddingBottom = 1
        Me.ElementStyle5.PaddingLeft = 1
        Me.ElementStyle5.PaddingRight = 1
        Me.ElementStyle5.PaddingTop = 1
        Me.ElementStyle5.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle6
        '
        Me.ElementStyle6.BackColor = System.Drawing.Color.Yellow
        Me.ElementStyle6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ElementStyle6.BackColorGradientAngle = 90
        Me.ElementStyle6.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderBottomWidth = 1
        Me.ElementStyle6.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle6.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderLeftWidth = 1
        Me.ElementStyle6.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderRightWidth = 1
        Me.ElementStyle6.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle6.BorderTopWidth = 1
        Me.ElementStyle6.CornerDiameter = 4
        Me.ElementStyle6.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle6.Description = "Lemon"
        Me.ElementStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle6.Name = "ElementStyle6"
        Me.ElementStyle6.PaddingBottom = 1
        Me.ElementStyle6.PaddingLeft = 1
        Me.ElementStyle6.PaddingRight = 1
        Me.ElementStyle6.PaddingTop = 1
        Me.ElementStyle6.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ElementStyle6.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle7
        '
        Me.ElementStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ElementStyle7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ElementStyle7.BackColorGradientAngle = 90
        Me.ElementStyle7.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderBottomWidth = 1
        Me.ElementStyle7.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle7.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderLeftWidth = 1
        Me.ElementStyle7.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderRightWidth = 1
        Me.ElementStyle7.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle7.BorderTopWidth = 1
        Me.ElementStyle7.CornerDiameter = 4
        Me.ElementStyle7.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle7.Description = "Yellow"
        Me.ElementStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle7.Name = "ElementStyle7"
        Me.ElementStyle7.PaddingBottom = 1
        Me.ElementStyle7.PaddingLeft = 1
        Me.ElementStyle7.PaddingRight = 1
        Me.ElementStyle7.PaddingTop = 1
        Me.ElementStyle7.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle8
        '
        Me.ElementStyle8.BackColor = System.Drawing.Color.White
        Me.ElementStyle8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ElementStyle8.BackColorGradientAngle = 90
        Me.ElementStyle8.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderBottomWidth = 1
        Me.ElementStyle8.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle8.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderLeftWidth = 1
        Me.ElementStyle8.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderRightWidth = 1
        Me.ElementStyle8.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle8.BorderTopWidth = 1
        Me.ElementStyle8.CornerDiameter = 4
        Me.ElementStyle8.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle8.Description = "Gray"
        Me.ElementStyle8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ElementStyle8.Name = "ElementStyle8"
        Me.ElementStyle8.PaddingBottom = 1
        Me.ElementStyle8.PaddingLeft = 1
        Me.ElementStyle8.PaddingRight = 1
        Me.ElementStyle8.PaddingTop = 1
        Me.ElementStyle8.TextColor = System.Drawing.Color.Black
        '
        'btnPrefixDel
        '
        Me.btnPrefixDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrefixDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrefixDel.Image = CType(resources.GetObject("btnPrefixDel.Image"), System.Drawing.Image)
        Me.btnPrefixDel.Location = New System.Drawing.Point(290, 24)
        Me.btnPrefixDel.Name = "btnPrefixDel"
        Me.btnPrefixDel.Size = New System.Drawing.Size(33, 20)
        Me.btnPrefixDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrefixDel.TabIndex = 175
        Me.btnPrefixDel.Tooltip = "Delete"
        '
        'btnPrefixEdit
        '
        Me.btnPrefixEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrefixEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrefixEdit.Image = CType(resources.GetObject("btnPrefixEdit.Image"), System.Drawing.Image)
        Me.btnPrefixEdit.Location = New System.Drawing.Point(249, 24)
        Me.btnPrefixEdit.Name = "btnPrefixEdit"
        Me.btnPrefixEdit.Size = New System.Drawing.Size(35, 20)
        Me.btnPrefixEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrefixEdit.TabIndex = 174
        Me.btnPrefixEdit.Tooltip = "Edit"
        '
        'btnPrefixAdd
        '
        Me.btnPrefixAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrefixAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrefixAdd.Image = CType(resources.GetObject("btnPrefixAdd.Image"), System.Drawing.Image)
        Me.btnPrefixAdd.Location = New System.Drawing.Point(213, 24)
        Me.btnPrefixAdd.Name = "btnPrefixAdd"
        Me.btnPrefixAdd.Size = New System.Drawing.Size(30, 20)
        Me.btnPrefixAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrefixAdd.TabIndex = 173
        Me.btnPrefixAdd.Tooltip = "Add"
        '
        'txtPrefix
        '
        Me.txtPrefix.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtPrefix.Border.Class = "TextBoxBorder"
        Me.txtPrefix.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrefix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPrefix.Location = New System.Drawing.Point(60, 24)
        Me.txtPrefix.MaxLength = 50
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.ReadOnly = True
        Me.txtPrefix.Size = New System.Drawing.Size(147, 20)
        Me.txtPrefix.TabIndex = 0
        '
        'lblPrefix
        '
        Me.lblPrefix.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblPrefix.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPrefix.Location = New System.Drawing.Point(6, 24)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(50, 20)
        Me.lblPrefix.TabIndex = 172
        Me.lblPrefix.Text = "PREFIX"
        Me.lblPrefix.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.lblReq02)
        Me.GroupBox2.Controls.Add(Me.lblReq01)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 179)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NETWORK DETAILS"
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtCode.Border.Class = "TextBoxBorder"
        Me.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCode.Location = New System.Drawing.Point(11, 33)
        Me.txtCode.MaxLength = 50
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(193, 20)
        Me.txtCode.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtName.Location = New System.Drawing.Point(11, 83)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(193, 20)
        Me.txtName.TabIndex = 1
        '
        'lblReq02
        '
        Me.lblReq02.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq02.Location = New System.Drawing.Point(3, 100)
        Me.lblReq02.Name = "lblReq02"
        Me.lblReq02.Size = New System.Drawing.Size(204, 20)
        Me.lblReq02.TabIndex = 187
        Me.lblReq02.Text = "* NETWORK NAME"
        Me.lblReq02.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblReq01
        '
        Me.lblReq01.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq01.Location = New System.Drawing.Point(6, 50)
        Me.lblReq01.Name = "lblReq01"
        Me.lblReq01.Size = New System.Drawing.Size(201, 20)
        Me.lblReq01.TabIndex = 170
        Me.lblReq01.Text = "* NETWORK CODE"
        Me.lblReq01.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnHisEndSel
        '
        Me.btnHisEndSel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnHisEndSel.Name = "btnHisEndSel"
        Me.btnHisEndSel.Text = "FirstName"
        '
        'btnHisStartSel
        '
        Me.btnHisStartSel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnHisStartSel.Name = "btnHisStartSel"
        Me.btnHisStartSel.Text = "Title"
        '
        'btnHisDrivSel
        '
        Me.btnHisDrivSel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnHisDrivSel.Name = "btnHisDrivSel"
        Me.btnHisDrivSel.Text = "ID No"
        '
        'btnHisDateSel
        '
        Me.btnHisDateSel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.btnHisDateSel.Name = "btnHisDateSel"
        Me.btnHisDateSel.Text = "LastName"
        '
        'gpList
        '
        Me.gpList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpList.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpList.Controls.Add(Me.btnFirstPage)
        Me.gpList.Controls.Add(Me.btnPreviousPage)
        Me.gpList.Controls.Add(Me.btnNextPage)
        Me.gpList.Controls.Add(Me.btnLastPage)
        Me.gpList.Controls.Add(Me.btnDelete)
        Me.gpList.Controls.Add(Me.btnEdit)
        Me.gpList.Controls.Add(Me.btnAdd)
        Me.gpList.Controls.Add(Me.lblDisplayPageNo)
        Me.gpList.Controls.Add(Me.btnSearch)
        Me.gpList.Controls.Add(Me.btnRefresh)
        Me.gpList.Controls.Add(Me.btnExpand)
        Me.gpList.Controls.Add(Me.txtSearch)
        Me.gpList.Controls.Add(Me.LabelX13)
        Me.gpList.Controls.Add(Me.gpMainList)
        Me.gpList.Location = New System.Drawing.Point(12, 12)
        Me.gpList.Name = "gpList"
        Me.gpList.Size = New System.Drawing.Size(354, 464)
        '
        '
        '
        Me.gpList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpList.Style.BackColorGradientAngle = 90
        Me.gpList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpList.Style.BorderBottomWidth = 1
        Me.gpList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpList.Style.BorderLeftWidth = 1
        Me.gpList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpList.Style.BorderRightWidth = 1
        Me.gpList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpList.Style.BorderTopWidth = 1
        Me.gpList.Style.CornerDiameter = 4
        Me.gpList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpList.TabIndex = 26
        Me.gpList.Text = "List"
        '
        'btnFirstPage
        '
        Me.btnFirstPage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFirstPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFirstPage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFirstPage.Image = CType(resources.GetObject("btnFirstPage.Image"), System.Drawing.Image)
        Me.btnFirstPage.Location = New System.Drawing.Point(231, 410)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(23, 30)
        Me.btnFirstPage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFirstPage.TabIndex = 160
        Me.btnFirstPage.Tooltip = "First Page"
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPreviousPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreviousPage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPreviousPage.Image = CType(resources.GetObject("btnPreviousPage.Image"), System.Drawing.Image)
        Me.btnPreviousPage.Location = New System.Drawing.Point(260, 410)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(23, 30)
        Me.btnPreviousPage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPreviousPage.TabIndex = 159
        Me.btnPreviousPage.Tooltip = "Previous Page"
        '
        'btnNextPage
        '
        Me.btnNextPage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNextPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNextPage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNextPage.Image = CType(resources.GetObject("btnNextPage.Image"), System.Drawing.Image)
        Me.btnNextPage.Location = New System.Drawing.Point(289, 410)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(23, 30)
        Me.btnNextPage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNextPage.TabIndex = 158
        Me.btnNextPage.Tooltip = "Next Page"
        '
        'btnLastPage
        '
        Me.btnLastPage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLastPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLastPage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLastPage.Image = CType(resources.GetObject("btnLastPage.Image"), System.Drawing.Image)
        Me.btnLastPage.Location = New System.Drawing.Point(318, 410)
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(23, 30)
        Me.btnLastPage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLastPage.TabIndex = 157
        Me.btnLastPage.Tooltip = "Last Page"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(80, 410)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(35, 30)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 155
        Me.btnDelete.Tooltip = "(F5) Delete . . ."
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(39, 410)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 30)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 154
        Me.btnEdit.Tooltip = "(F3) Edit . . ."
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(3, 410)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 30)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 153
        Me.btnAdd.Tooltip = "(F1) Add New . . ."
        '
        'lblDisplayPageNo
        '
        Me.lblDisplayPageNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisplayPageNo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblDisplayPageNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDisplayPageNo.ForeColor = System.Drawing.Color.Black
        Me.lblDisplayPageNo.Location = New System.Drawing.Point(108, 410)
        Me.lblDisplayPageNo.Name = "lblDisplayPageNo"
        Me.lblDisplayPageNo.Size = New System.Drawing.Size(117, 30)
        Me.lblDisplayPageNo.TabIndex = 156
        Me.lblDisplayPageNo.Text = "Page 0000 of 0000"
        Me.lblDisplayPageNo.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnSearch.Location = New System.Drawing.Point(194, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 20)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 149
        Me.btnSearch.Tooltip = "Refresh"
        '
        'btnRefresh
        '
        Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRefresh.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.refresh
        Me.btnRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnRefresh.Location = New System.Drawing.Point(235, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(35, 20)
        Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRefresh.TabIndex = 148
        Me.btnRefresh.Tooltip = "Refresh"
        '
        'btnExpand
        '
        Me.btnExpand.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExpand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpand.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExpand.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnExpand.Location = New System.Drawing.Point(276, 6)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(65, 20)
        Me.btnExpand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExpand.TabIndex = 146
        Me.btnExpand.Text = "Expand >|"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtSearch.Border.Class = "TextBoxBorder"
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.FocusHighlightEnabled = True
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(58, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(130, 20)
        Me.txtSearch.TabIndex = 145
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(3, 3)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(50, 23)
        Me.LabelX13.TabIndex = 147
        Me.LabelX13.Text = "Search"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gpMainList
        '
        Me.gpMainList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpMainList.BackColor = System.Drawing.Color.Transparent
        Me.gpMainList.Controls.Add(Me.advTree1)
        Me.gpMainList.Location = New System.Drawing.Point(3, 32)
        Me.gpMainList.Name = "gpMainList"
        Me.gpMainList.Size = New System.Drawing.Size(338, 372)
        Me.gpMainList.TabIndex = 137
        Me.gpMainList.TabStop = False
        Me.gpMainList.Text = "-- Record(s) Found"
        '
        'advTree1
        '
        Me.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.advTree1.AllowDrop = True
        Me.advTree1.AlternateRowColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.advTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.advTree1.Controls.Add(Me.lblStatus)
        Me.advTree1.Controls.Add(Me.cp1)
        Me.advTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.advTree1.DragDropEnabled = False
        Me.advTree1.DragDropNodeCopyEnabled = False
        Me.advTree1.ExpandButtonSize = New System.Drawing.Size(0, 0)
        Me.advTree1.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Ellipse
        Me.advTree1.ExpandWidth = 0
        Me.advTree1.GridColumnLines = False
        Me.advTree1.Location = New System.Drawing.Point(3, 16)
        Me.advTree1.Name = "advTree1"
        Me.advTree1.NodeStyle = Me.ElementStyle4
        Me.advTree1.PathSeparator = ";"
        Me.advTree1.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect
        Me.advTree1.Size = New System.Drawing.Size(332, 353)
        Me.advTree1.Styles.Add(Me.ElementStyle2)
        Me.advTree1.Styles.Add(Me.ElementStyle3)
        Me.advTree1.Styles.Add(Me.ElementStyle4)
        Me.advTree1.Styles.Add(Me.ElementStyle1)
        Me.advTree1.TabIndex = 125
        Me.advTree1.Text = "advTree4"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.IndianRed
        '
        '
        '
        Me.lblStatus.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderBottomWidth = 1
        Me.lblStatus.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderLeftWidth = 1
        Me.lblStatus.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderRightWidth = 1
        Me.lblStatus.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderTopWidth = 1
        Me.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(0, 152)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.PaddingLeft = 2
        Me.lblStatus.PaddingRight = 2
        Me.lblStatus.Size = New System.Drawing.Size(332, 65)
        Me.lblStatus.TabIndex = 139
        Me.lblStatus.Text = "No Record(s) Found !"
        Me.lblStatus.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblStatus.Visible = False
        Me.lblStatus.WordWrap = True
        '
        'cp1
        '
        Me.cp1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cp1.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.cp1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderBottomWidth = 1
        Me.cp1.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.cp1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderLeftWidth = 1
        Me.cp1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderRightWidth = 1
        Me.cp1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderTopWidth = 1
        Me.cp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cp1.Location = New System.Drawing.Point(0, 100)
        Me.cp1.Name = "cp1"
        Me.cp1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cp1.ProgressColor = System.Drawing.Color.LightSalmon
        Me.cp1.Size = New System.Drawing.Size(332, 167)
        Me.cp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.cp1.TabIndex = 138
        Me.cp1.Value = 100
        Me.cp1.Visible = False
        '
        'ElementStyle4
        '
        Me.ElementStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ElementStyle4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ElementStyle4.BackColorGradientAngle = 90
        Me.ElementStyle4.BorderBottomWidth = 1
        Me.ElementStyle4.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle4.BorderLeftWidth = 1
        Me.ElementStyle4.BorderRightWidth = 1
        Me.ElementStyle4.BorderTopWidth = 1
        Me.ElementStyle4.CornerDiameter = 4
        Me.ElementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle4.Description = "Green"
        Me.ElementStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle4.Name = "ElementStyle4"
        Me.ElementStyle4.PaddingBottom = 1
        Me.ElementStyle4.PaddingLeft = 1
        Me.ElementStyle4.PaddingRight = 1
        Me.ElementStyle4.PaddingTop = 1
        Me.ElementStyle4.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle2
        '
        Me.ElementStyle2.BackColor = System.Drawing.Color.Yellow
        Me.ElementStyle2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ElementStyle2.BackColorGradientAngle = 90
        Me.ElementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderBottomWidth = 1
        Me.ElementStyle2.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderLeftWidth = 1
        Me.ElementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderRightWidth = 1
        Me.ElementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle2.BorderTopWidth = 1
        Me.ElementStyle2.CornerDiameter = 4
        Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle2.Description = "Lemon"
        Me.ElementStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle2.Name = "ElementStyle2"
        Me.ElementStyle2.PaddingBottom = 1
        Me.ElementStyle2.PaddingLeft = 1
        Me.ElementStyle2.PaddingRight = 1
        Me.ElementStyle2.PaddingTop = 1
        Me.ElementStyle2.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ElementStyle2.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle3
        '
        Me.ElementStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ElementStyle3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ElementStyle3.BackColorGradientAngle = 90
        Me.ElementStyle3.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderBottomWidth = 1
        Me.ElementStyle3.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle3.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderLeftWidth = 1
        Me.ElementStyle3.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderRightWidth = 1
        Me.ElementStyle3.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle3.BorderTopWidth = 1
        Me.ElementStyle3.CornerDiameter = 4
        Me.ElementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle3.Description = "Yellow"
        Me.ElementStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle3.Name = "ElementStyle3"
        Me.ElementStyle3.PaddingBottom = 1
        Me.ElementStyle3.PaddingLeft = 1
        Me.ElementStyle3.PaddingRight = 1
        Me.ElementStyle3.PaddingTop = 1
        Me.ElementStyle3.TextColor = System.Drawing.Color.Black
        '
        'ElementStyle1
        '
        Me.ElementStyle1.BackColor = System.Drawing.Color.White
        Me.ElementStyle1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ElementStyle1.BackColorGradientAngle = 90
        Me.ElementStyle1.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderBottomWidth = 1
        Me.ElementStyle1.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle1.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderLeftWidth = 1
        Me.ElementStyle1.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderRightWidth = 1
        Me.ElementStyle1.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ElementStyle1.BorderTopWidth = 1
        Me.ElementStyle1.CornerDiameter = 4
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Description = "Gray"
        Me.ElementStyle1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.PaddingBottom = 1
        Me.ElementStyle1.PaddingLeft = 1
        Me.ElementStyle1.PaddingRight = 1
        Me.ElementStyle1.PaddingTop = 1
        Me.ElementStyle1.TextColor = System.Drawing.Color.Black
        '
        'bwQuery
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSaveNew
        '
        Me.btnSaveNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveNew.Image = CType(resources.GetObject("btnSaveNew.Image"), System.Drawing.Image)
        Me.btnSaveNew.Location = New System.Drawing.Point(454, 447)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(111, 29)
        Me.btnSaveNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSaveNew.TabIndex = 152
        Me.btnSaveNew.Text = "Save && &New"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(571, 447)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 29)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(688, 447)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 29)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(814, 447)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 29)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close  <font color=""#1F497D"">( Esc )</font>"
        '
        'frmManNetwork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 488)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.gpList)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gpInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(956, 521)
        Me.Name = "frmManNetwork"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>NETWORK MANAGER</h5>"
        Me.gpInfo.ResumeLayout(False)
        Me.gpLogo.ResumeLayout(False)
        Me.gpSubList.ResumeLayout(False)
        CType(Me.AdvTree2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdvTree2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gpList.ResumeLayout(False)
        Me.gpMainList.ResumeLayout(False)
        CType(Me.advTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.advTree1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpInfo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnHisEndSel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHisStartSel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHisDrivSel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHisDateSel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Public WithEvents gpList As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gpMainList As System.Windows.Forms.GroupBox
    Private WithEvents advTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents ElementStyle4 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle3 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents bwQuery As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblReq01 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblIndexNo As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpSubList As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveNew As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnExpand As DevComponents.DotNetBar.ButtonX
    Public WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Public WithEvents btnFirstPage As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnPreviousPage As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnNextPage As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnLastPage As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Public WithEvents lblDisplayPageNo As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpLogo As System.Windows.Forms.GroupBox
    Public WithEvents btnLogoDelete As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnLogoBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents imgLogo As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq02 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPrefix As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPrefix As DevComponents.DotNetBar.LabelX
    Public WithEvents btnPrefixDel As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnPrefixEdit As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnPrefixAdd As DevComponents.DotNetBar.ButtonX
    Private WithEvents AdvTree2 As DevComponents.AdvTree.AdvTree
    Friend WithEvents ElementStyle5 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle6 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle7 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyle8 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Public WithEvents lblStatus2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cp2 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
