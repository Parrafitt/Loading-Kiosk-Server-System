<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManItem))
        Me.gpInfo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gpDet3 = New System.Windows.Forms.GroupBox()
        Me.iiValidity = New DevComponents.Editors.IntegerInput()
        Me.cboValidityUnit = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblReq09 = New DevComponents.DotNetBar.LabelX()
        Me.txtCost = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPrice = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq07 = New DevComponents.DotNetBar.LabelX()
        Me.lblReq08 = New DevComponents.DotNetBar.LabelX()
        Me.txtValidityUnit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpDet2 = New System.Windows.Forms.GroupBox()
        Me.cboPackage = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboNetwork = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtNetwork = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPackage = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq06 = New DevComponents.DotNetBar.LabelX()
        Me.lblReq05 = New DevComponents.DotNetBar.LabelX()
        Me.gpLogo = New System.Windows.Forms.GroupBox()
        Me.lblIndexNo = New DevComponents.DotNetBar.LabelX()
        Me.btnLogoDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnLogoBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.imgLogo = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpDet1 = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblReq00 = New DevComponents.DotNetBar.LabelX()
        Me.cboType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDescription = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq04 = New DevComponents.DotNetBar.LabelX()
        Me.lblReq03 = New DevComponents.DotNetBar.LabelX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq02 = New DevComponents.DotNetBar.LabelX()
        Me.txtType = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq01 = New DevComponents.DotNetBar.LabelX()
        Me.txtStatus = New DevComponents.DotNetBar.Controls.TextBoxX()
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
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.gpInfo.SuspendLayout()
        Me.gpDet3.SuspendLayout()
        CType(Me.iiValidity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDet2.SuspendLayout()
        Me.gpLogo.SuspendLayout()
        Me.gpDet1.SuspendLayout()
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
        Me.gpInfo.Controls.Add(Me.gpDet3)
        Me.gpInfo.Controls.Add(Me.gpDet2)
        Me.gpInfo.Controls.Add(Me.gpLogo)
        Me.gpInfo.Controls.Add(Me.gpDet1)
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
        'gpDet3
        '
        Me.gpDet3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpDet3.BackColor = System.Drawing.Color.Transparent
        Me.gpDet3.Controls.Add(Me.iiValidity)
        Me.gpDet3.Controls.Add(Me.cboValidityUnit)
        Me.gpDet3.Controls.Add(Me.lblReq09)
        Me.gpDet3.Controls.Add(Me.txtCost)
        Me.gpDet3.Controls.Add(Me.txtPrice)
        Me.gpDet3.Controls.Add(Me.lblReq07)
        Me.gpDet3.Controls.Add(Me.lblReq08)
        Me.gpDet3.Controls.Add(Me.txtValidityUnit)
        Me.gpDet3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet3.Location = New System.Drawing.Point(343, 222)
        Me.gpDet3.Name = "gpDet3"
        Me.gpDet3.Size = New System.Drawing.Size(210, 183)
        Me.gpDet3.TabIndex = 2
        Me.gpDet3.TabStop = False
        Me.gpDet3.Text = "PRICE / COST DETAILS"
        '
        'iiValidity
        '
        '
        '
        '
        Me.iiValidity.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.iiValidity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.iiValidity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.iiValidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.iiValidity.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.iiValidity.Location = New System.Drawing.Point(81, 102)
        Me.iiValidity.MaxValue = 999
        Me.iiValidity.MinValue = 0
        Me.iiValidity.Name = "iiValidity"
        Me.iiValidity.ShowUpDown = True
        Me.iiValidity.Size = New System.Drawing.Size(113, 32)
        Me.iiValidity.TabIndex = 2
        Me.iiValidity.Value = 30
        '
        'cboValidityUnit
        '
        Me.cboValidityUnit.DisplayMember = "Text"
        Me.cboValidityUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboValidityUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cboValidityUnit.FormattingEnabled = True
        Me.cboValidityUnit.ItemHeight = 26
        Me.cboValidityUnit.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.cboValidityUnit.Location = New System.Drawing.Point(119, 140)
        Me.cboValidityUnit.Name = "cboValidityUnit"
        Me.cboValidityUnit.Size = New System.Drawing.Size(75, 32)
        Me.cboValidityUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboValidityUnit.TabIndex = 3
        Me.cboValidityUnit.Text = "Days"
        '
        'lblReq09
        '
        Me.lblReq09.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq09.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq09.Location = New System.Drawing.Point(6, 102)
        Me.lblReq09.Name = "lblReq09"
        Me.lblReq09.Size = New System.Drawing.Size(69, 32)
        Me.lblReq09.TabIndex = 189
        Me.lblReq09.Text = "* VALIDITY"
        Me.lblReq09.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtCost.Border.Class = "TextBoxBorder"
        Me.txtCost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtCost.Location = New System.Drawing.Point(81, 64)
        Me.txtCost.MaxLength = 10
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(113, 32)
        Me.txtCost.TabIndex = 1
        Me.txtCost.Text = "9,000.00"
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtPrice.Border.Class = "TextBoxBorder"
        Me.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtPrice.Location = New System.Drawing.Point(81, 26)
        Me.txtPrice.MaxLength = 10
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(113, 32)
        Me.txtPrice.TabIndex = 0
        Me.txtPrice.Text = "9,000.00"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblReq07
        '
        Me.lblReq07.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq07.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq07.Location = New System.Drawing.Point(6, 26)
        Me.lblReq07.Name = "lblReq07"
        Me.lblReq07.Size = New System.Drawing.Size(69, 32)
        Me.lblReq07.TabIndex = 187
        Me.lblReq07.Text = "* PRICE"
        Me.lblReq07.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblReq08
        '
        Me.lblReq08.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq08.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq08.Location = New System.Drawing.Point(6, 64)
        Me.lblReq08.Name = "lblReq08"
        Me.lblReq08.Size = New System.Drawing.Size(69, 32)
        Me.lblReq08.TabIndex = 170
        Me.lblReq08.Text = "* COST"
        Me.lblReq08.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtValidityUnit
        '
        Me.txtValidityUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValidityUnit.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtValidityUnit.Border.Class = "TextBoxBorder"
        Me.txtValidityUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtValidityUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtValidityUnit.Location = New System.Drawing.Point(81, 140)
        Me.txtValidityUnit.MaxLength = 50
        Me.txtValidityUnit.Name = "txtValidityUnit"
        Me.txtValidityUnit.ReadOnly = True
        Me.txtValidityUnit.Size = New System.Drawing.Size(113, 32)
        Me.txtValidityUnit.TabIndex = 191
        '
        'gpDet2
        '
        Me.gpDet2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpDet2.BackColor = System.Drawing.Color.Transparent
        Me.gpDet2.Controls.Add(Me.cboPackage)
        Me.gpDet2.Controls.Add(Me.cboNetwork)
        Me.gpDet2.Controls.Add(Me.txtNetwork)
        Me.gpDet2.Controls.Add(Me.txtPackage)
        Me.gpDet2.Controls.Add(Me.lblReq06)
        Me.gpDet2.Controls.Add(Me.lblReq05)
        Me.gpDet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet2.Location = New System.Drawing.Point(3, 222)
        Me.gpDet2.Name = "gpDet2"
        Me.gpDet2.Size = New System.Drawing.Size(334, 183)
        Me.gpDet2.TabIndex = 1
        Me.gpDet2.TabStop = False
        Me.gpDet2.Text = "TAG DETAILS"
        '
        'cboPackage
        '
        Me.cboPackage.DisplayMember = "Text"
        Me.cboPackage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboPackage.FormattingEnabled = True
        Me.cboPackage.ItemHeight = 14
        Me.cboPackage.Location = New System.Drawing.Point(143, 47)
        Me.cboPackage.Name = "cboPackage"
        Me.cboPackage.Size = New System.Drawing.Size(121, 20)
        Me.cboPackage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboPackage.TabIndex = 1
        '
        'cboNetwork
        '
        Me.cboNetwork.DisplayMember = "Text"
        Me.cboNetwork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNetwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboNetwork.FormattingEnabled = True
        Me.cboNetwork.ItemHeight = 14
        Me.cboNetwork.Location = New System.Drawing.Point(143, 21)
        Me.cboNetwork.Name = "cboNetwork"
        Me.cboNetwork.Size = New System.Drawing.Size(121, 20)
        Me.cboNetwork.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboNetwork.TabIndex = 0
        '
        'txtNetwork
        '
        Me.txtNetwork.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNetwork.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtNetwork.Border.Class = "TextBoxBorder"
        Me.txtNetwork.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNetwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNetwork.Location = New System.Drawing.Point(104, 21)
        Me.txtNetwork.MaxLength = 50
        Me.txtNetwork.Name = "txtNetwork"
        Me.txtNetwork.ReadOnly = True
        Me.txtNetwork.Size = New System.Drawing.Size(214, 20)
        Me.txtNetwork.TabIndex = 188
        '
        'txtPackage
        '
        Me.txtPackage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPackage.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtPackage.Border.Class = "TextBoxBorder"
        Me.txtPackage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPackage.Location = New System.Drawing.Point(104, 47)
        Me.txtPackage.MaxLength = 50
        Me.txtPackage.Name = "txtPackage"
        Me.txtPackage.ReadOnly = True
        Me.txtPackage.Size = New System.Drawing.Size(214, 20)
        Me.txtPackage.TabIndex = 192
        '
        'lblReq06
        '
        Me.lblReq06.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq06.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq06.Location = New System.Drawing.Point(2, 47)
        Me.lblReq06.Name = "lblReq06"
        Me.lblReq06.Size = New System.Drawing.Size(96, 20)
        Me.lblReq06.TabIndex = 193
        Me.lblReq06.Text = "* PACKAGE TYPE"
        Me.lblReq06.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblReq05
        '
        Me.lblReq05.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq05.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq05.Location = New System.Drawing.Point(2, 21)
        Me.lblReq05.Name = "lblReq05"
        Me.lblReq05.Size = New System.Drawing.Size(96, 20)
        Me.lblReq05.TabIndex = 191
        Me.lblReq05.Text = "* NETWORK"
        Me.lblReq05.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gpLogo
        '
        Me.gpLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpLogo.BackColor = System.Drawing.Color.Transparent
        Me.gpLogo.Controls.Add(Me.lblIndexNo)
        Me.gpLogo.Controls.Add(Me.btnLogoDelete)
        Me.gpLogo.Controls.Add(Me.btnLogoBrowse)
        Me.gpLogo.Controls.Add(Me.imgLogo)
        Me.gpLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpLogo.Location = New System.Drawing.Point(343, 6)
        Me.gpLogo.Name = "gpLogo"
        Me.gpLogo.Size = New System.Drawing.Size(210, 210)
        Me.gpLogo.TabIndex = 168
        Me.gpLogo.TabStop = False
        Me.gpLogo.Text = "ITEM LOGO"
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
        'gpDet1
        '
        Me.gpDet1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpDet1.BackColor = System.Drawing.Color.Transparent
        Me.gpDet1.Controls.Add(Me.cboStatus)
        Me.gpDet1.Controls.Add(Me.lblReq00)
        Me.gpDet1.Controls.Add(Me.cboType)
        Me.gpDet1.Controls.Add(Me.txtDescription)
        Me.gpDet1.Controls.Add(Me.lblReq04)
        Me.gpDet1.Controls.Add(Me.lblReq03)
        Me.gpDet1.Controls.Add(Me.txtCode)
        Me.gpDet1.Controls.Add(Me.txtName)
        Me.gpDet1.Controls.Add(Me.lblReq02)
        Me.gpDet1.Controls.Add(Me.txtType)
        Me.gpDet1.Controls.Add(Me.lblReq01)
        Me.gpDet1.Controls.Add(Me.txtStatus)
        Me.gpDet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet1.Location = New System.Drawing.Point(3, 6)
        Me.gpDet1.Name = "gpDet1"
        Me.gpDet1.Size = New System.Drawing.Size(334, 210)
        Me.gpDet1.TabIndex = 0
        Me.gpDet1.TabStop = False
        Me.gpDet1.Text = "ITEM DETAILS"
        '
        'cboStatus
        '
        Me.cboStatus.DisplayMember = "Text"
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.ItemHeight = 14
        Me.cboStatus.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboStatus.Location = New System.Drawing.Point(143, 21)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 20)
        Me.cboStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboStatus.TabIndex = 0
        '
        'lblReq00
        '
        Me.lblReq00.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq00.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq00.Location = New System.Drawing.Point(2, 21)
        Me.lblReq00.Name = "lblReq00"
        Me.lblReq00.Size = New System.Drawing.Size(96, 20)
        Me.lblReq00.TabIndex = 200
        Me.lblReq00.Text = "* STATUS"
        Me.lblReq00.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboType
        '
        Me.cboType.DisplayMember = "Text"
        Me.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboType.FormattingEnabled = True
        Me.cboType.ItemHeight = 14
        Me.cboType.Location = New System.Drawing.Point(143, 99)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 20)
        Me.cboType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboType.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtDescription.Border.Class = "TextBoxBorder"
        Me.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(104, 125)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(214, 56)
        Me.txtDescription.TabIndex = 4
        '
        'lblReq04
        '
        Me.lblReq04.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq04.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq04.Location = New System.Drawing.Point(2, 125)
        Me.lblReq04.Name = "lblReq04"
        Me.lblReq04.Size = New System.Drawing.Size(95, 20)
        Me.lblReq04.TabIndex = 195
        Me.lblReq04.Text = "* DESCRIPTION"
        Me.lblReq04.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblReq03
        '
        Me.lblReq03.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq03.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq03.Location = New System.Drawing.Point(2, 99)
        Me.lblReq03.Name = "lblReq03"
        Me.lblReq03.Size = New System.Drawing.Size(96, 20)
        Me.lblReq03.TabIndex = 189
        Me.lblReq03.Text = "* ITEM TYPE"
        Me.lblReq03.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.txtCode.Location = New System.Drawing.Point(104, 47)
        Me.txtCode.MaxLength = 40
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(214, 20)
        Me.txtCode.TabIndex = 1
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
        Me.txtName.Location = New System.Drawing.Point(104, 73)
        Me.txtName.MaxLength = 40
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(214, 20)
        Me.txtName.TabIndex = 2
        '
        'lblReq02
        '
        Me.lblReq02.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq02.Location = New System.Drawing.Point(2, 73)
        Me.lblReq02.Name = "lblReq02"
        Me.lblReq02.Size = New System.Drawing.Size(96, 20)
        Me.lblReq02.TabIndex = 187
        Me.lblReq02.Text = "* ITEM NAME"
        Me.lblReq02.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtType
        '
        Me.txtType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtType.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtType.Border.Class = "TextBoxBorder"
        Me.txtType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtType.Location = New System.Drawing.Point(104, 99)
        Me.txtType.MaxLength = 50
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(214, 20)
        Me.txtType.TabIndex = 190
        '
        'lblReq01
        '
        Me.lblReq01.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq01.Location = New System.Drawing.Point(2, 47)
        Me.lblReq01.Name = "lblReq01"
        Me.lblReq01.Size = New System.Drawing.Size(96, 20)
        Me.lblReq01.TabIndex = 170
        Me.lblReq01.Text = "* ITEM CODE"
        Me.lblReq01.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtStatus.Border.Class = "TextBoxBorder"
        Me.txtStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtStatus.Location = New System.Drawing.Point(104, 21)
        Me.txtStatus.MaxLength = 50
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(214, 20)
        Me.txtStatus.TabIndex = 203
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
        Me.lblStatus.Location = New System.Drawing.Point(0, 149)
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
        Me.cp1.Location = New System.Drawing.Point(0, 97)
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
        'ComboItem2
        '
        Me.ComboItem2.Text = "ACTIVE"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "INACTIVE"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Hours"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Days"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Month"
        '
        'frmManItem
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
        Me.Name = "frmManItem"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>ITEM MANAGER</h5>"
        Me.gpInfo.ResumeLayout(False)
        Me.gpDet3.ResumeLayout(False)
        CType(Me.iiValidity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDet2.ResumeLayout(False)
        Me.gpLogo.ResumeLayout(False)
        Me.gpDet1.ResumeLayout(False)
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
    Friend WithEvents gpDet1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblReq01 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblIndexNo As DevComponents.DotNetBar.LabelX
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
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNetwork As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq03 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtType As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq05 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPackage As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq06 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescription As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq04 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpDet2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPackage As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboNetwork As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblReq00 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtStatus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents gpDet3 As System.Windows.Forms.GroupBox
    Friend WithEvents iiValidity As DevComponents.Editors.IntegerInput
    Friend WithEvents cboValidityUnit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblReq09 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCost As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPrice As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq07 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblReq08 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtValidityUnit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
End Class
