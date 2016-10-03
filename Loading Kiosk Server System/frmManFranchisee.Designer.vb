<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManFranchisee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManFranchisee))
        Me.gpInfo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gpDet3 = New System.Windows.Forms.GroupBox()
        Me.txtMachStat = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.txtSimImeiNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtDateDeploy = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.txtMachNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.gpDet2 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq11 = New DevComponents.DotNetBar.LabelX()
        Me.txtEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq10 = New DevComponents.DotNetBar.LabelX()
        Me.txtContactNo2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq09 = New DevComponents.DotNetBar.LabelX()
        Me.txtContactNo1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq08 = New DevComponents.DotNetBar.LabelX()
        Me.txtContactPerson = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq07 = New DevComponents.DotNetBar.LabelX()
        Me.gpLogo = New System.Windows.Forms.GroupBox()
        Me.lblIndexNo = New DevComponents.DotNetBar.LabelX()
        Me.btnLogoDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnLogoBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.imgLogo = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpDet1 = New System.Windows.Forms.GroupBox()
        Me.txtLast = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq06 = New DevComponents.DotNetBar.LabelX()
        Me.txtMiddle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq05 = New DevComponents.DotNetBar.LabelX()
        Me.txtFirst = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq04 = New DevComponents.DotNetBar.LabelX()
        Me.cboStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.lblReq00 = New DevComponents.DotNetBar.LabelX()
        Me.cboType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblReq01 = New DevComponents.DotNetBar.LabelX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq03 = New DevComponents.DotNetBar.LabelX()
        Me.txtType = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq02 = New DevComponents.DotNetBar.LabelX()
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
        Me.gpInfo.SuspendLayout()
        Me.gpDet3.SuspendLayout()
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
        Me.gpDet3.Controls.Add(Me.txtMachStat)
        Me.gpDet3.Controls.Add(Me.LabelX12)
        Me.gpDet3.Controls.Add(Me.txtSimImeiNo)
        Me.gpDet3.Controls.Add(Me.LabelX11)
        Me.gpDet3.Controls.Add(Me.txtDateDeploy)
        Me.gpDet3.Controls.Add(Me.LabelX10)
        Me.gpDet3.Controls.Add(Me.txtMachNo)
        Me.gpDet3.Controls.Add(Me.LabelX9)
        Me.gpDet3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet3.Location = New System.Drawing.Point(343, 222)
        Me.gpDet3.Name = "gpDet3"
        Me.gpDet3.Size = New System.Drawing.Size(210, 183)
        Me.gpDet3.TabIndex = 2
        Me.gpDet3.TabStop = False
        Me.gpDet3.Text = "DEPLOYED MACHINE DETAILS"
        '
        'txtMachStat
        '
        Me.txtMachStat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMachStat.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtMachStat.Border.Class = "TextBoxBorder"
        Me.txtMachStat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMachStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtMachStat.Location = New System.Drawing.Point(6, 143)
        Me.txtMachStat.MaxLength = 50
        Me.txtMachStat.Name = "txtMachStat"
        Me.txtMachStat.ReadOnly = True
        Me.txtMachStat.Size = New System.Drawing.Size(198, 20)
        Me.txtMachStat.TabIndex = 211
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(3, 159)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(204, 20)
        Me.LabelX12.TabIndex = 210
        Me.LabelX12.Text = "MACHINE STATUS"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtSimImeiNo
        '
        Me.txtSimImeiNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSimImeiNo.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtSimImeiNo.Border.Class = "TextBoxBorder"
        Me.txtSimImeiNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSimImeiNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSimImeiNo.Location = New System.Drawing.Point(6, 59)
        Me.txtSimImeiNo.MaxLength = 50
        Me.txtSimImeiNo.Name = "txtSimImeiNo"
        Me.txtSimImeiNo.ReadOnly = True
        Me.txtSimImeiNo.Size = New System.Drawing.Size(198, 20)
        Me.txtSimImeiNo.TabIndex = 209
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(3, 75)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(204, 20)
        Me.LabelX11.TabIndex = 208
        Me.LabelX11.Text = "SIM IMEI NO."
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtDateDeploy
        '
        Me.txtDateDeploy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDateDeploy.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtDateDeploy.Border.Class = "TextBoxBorder"
        Me.txtDateDeploy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDateDeploy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDateDeploy.Location = New System.Drawing.Point(6, 101)
        Me.txtDateDeploy.MaxLength = 50
        Me.txtDateDeploy.Name = "txtDateDeploy"
        Me.txtDateDeploy.ReadOnly = True
        Me.txtDateDeploy.Size = New System.Drawing.Size(198, 20)
        Me.txtDateDeploy.TabIndex = 207
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(3, 117)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(204, 20)
        Me.LabelX10.TabIndex = 206
        Me.LabelX10.Text = "DATE OF DEPLOYMENT"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtMachNo
        '
        Me.txtMachNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMachNo.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtMachNo.Border.Class = "TextBoxBorder"
        Me.txtMachNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMachNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtMachNo.Location = New System.Drawing.Point(6, 17)
        Me.txtMachNo.MaxLength = 50
        Me.txtMachNo.Name = "txtMachNo"
        Me.txtMachNo.ReadOnly = True
        Me.txtMachNo.Size = New System.Drawing.Size(198, 20)
        Me.txtMachNo.TabIndex = 205
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(3, 33)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(204, 20)
        Me.LabelX9.TabIndex = 204
        Me.LabelX9.Text = "MACHINE NO."
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpDet2
        '
        Me.gpDet2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpDet2.BackColor = System.Drawing.Color.Transparent
        Me.gpDet2.Controls.Add(Me.txtAddress)
        Me.gpDet2.Controls.Add(Me.lblReq11)
        Me.gpDet2.Controls.Add(Me.txtEmail)
        Me.gpDet2.Controls.Add(Me.lblReq10)
        Me.gpDet2.Controls.Add(Me.txtContactNo2)
        Me.gpDet2.Controls.Add(Me.lblReq09)
        Me.gpDet2.Controls.Add(Me.txtContactNo1)
        Me.gpDet2.Controls.Add(Me.lblReq08)
        Me.gpDet2.Controls.Add(Me.txtContactPerson)
        Me.gpDet2.Controls.Add(Me.lblReq07)
        Me.gpDet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet2.Location = New System.Drawing.Point(3, 222)
        Me.gpDet2.Name = "gpDet2"
        Me.gpDet2.Size = New System.Drawing.Size(334, 183)
        Me.gpDet2.TabIndex = 1
        Me.gpDet2.TabStop = False
        Me.gpDet2.Text = "CONTACT DETAILS"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtAddress.Border.Class = "TextBoxBorder"
        Me.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtAddress.Location = New System.Drawing.Point(117, 127)
        Me.txtAddress.MaxLength = 250
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(201, 42)
        Me.txtAddress.TabIndex = 4
        '
        'lblReq11
        '
        Me.lblReq11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq11.Location = New System.Drawing.Point(2, 127)
        Me.lblReq11.Name = "lblReq11"
        Me.lblReq11.Size = New System.Drawing.Size(109, 20)
        Me.lblReq11.TabIndex = 219
        Me.lblReq11.Text = "* ADDRESS"
        Me.lblReq11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtEmail.Border.Class = "TextBoxBorder"
        Me.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(117, 101)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(201, 20)
        Me.txtEmail.TabIndex = 3
        '
        'lblReq10
        '
        Me.lblReq10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq10.Location = New System.Drawing.Point(2, 101)
        Me.lblReq10.Name = "lblReq10"
        Me.lblReq10.Size = New System.Drawing.Size(109, 20)
        Me.lblReq10.TabIndex = 217
        Me.lblReq10.Text = "* EMAIL"
        Me.lblReq10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtContactNo2
        '
        Me.txtContactNo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactNo2.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtContactNo2.Border.Class = "TextBoxBorder"
        Me.txtContactNo2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContactNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtContactNo2.Location = New System.Drawing.Point(117, 75)
        Me.txtContactNo2.MaxLength = 25
        Me.txtContactNo2.Name = "txtContactNo2"
        Me.txtContactNo2.ReadOnly = True
        Me.txtContactNo2.Size = New System.Drawing.Size(201, 20)
        Me.txtContactNo2.TabIndex = 2
        '
        'lblReq09
        '
        Me.lblReq09.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq09.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq09.Location = New System.Drawing.Point(2, 75)
        Me.lblReq09.Name = "lblReq09"
        Me.lblReq09.Size = New System.Drawing.Size(109, 20)
        Me.lblReq09.TabIndex = 215
        Me.lblReq09.Text = "* CONTACT NO. 2"
        Me.lblReq09.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtContactNo1
        '
        Me.txtContactNo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactNo1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtContactNo1.Border.Class = "TextBoxBorder"
        Me.txtContactNo1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContactNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtContactNo1.Location = New System.Drawing.Point(117, 49)
        Me.txtContactNo1.MaxLength = 25
        Me.txtContactNo1.Name = "txtContactNo1"
        Me.txtContactNo1.ReadOnly = True
        Me.txtContactNo1.Size = New System.Drawing.Size(201, 20)
        Me.txtContactNo1.TabIndex = 1
        '
        'lblReq08
        '
        Me.lblReq08.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq08.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq08.Location = New System.Drawing.Point(2, 49)
        Me.lblReq08.Name = "lblReq08"
        Me.lblReq08.Size = New System.Drawing.Size(109, 20)
        Me.lblReq08.TabIndex = 213
        Me.lblReq08.Text = "* CONTACT NO. 1"
        Me.lblReq08.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactPerson.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtContactPerson.Border.Class = "TextBoxBorder"
        Me.txtContactPerson.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContactPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtContactPerson.Location = New System.Drawing.Point(117, 23)
        Me.txtContactPerson.MaxLength = 50
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.ReadOnly = True
        Me.txtContactPerson.Size = New System.Drawing.Size(201, 20)
        Me.txtContactPerson.TabIndex = 0
        '
        'lblReq07
        '
        Me.lblReq07.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq07.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq07.Location = New System.Drawing.Point(2, 23)
        Me.lblReq07.Name = "lblReq07"
        Me.lblReq07.Size = New System.Drawing.Size(109, 20)
        Me.lblReq07.TabIndex = 211
        Me.lblReq07.Text = "* CONTACT PERSON"
        Me.lblReq07.TextAlignment = System.Drawing.StringAlignment.Far
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
        '
        'lblIndexNo
        '
        Me.lblIndexNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.gpDet1.Controls.Add(Me.txtLast)
        Me.gpDet1.Controls.Add(Me.lblReq06)
        Me.gpDet1.Controls.Add(Me.txtMiddle)
        Me.gpDet1.Controls.Add(Me.lblReq05)
        Me.gpDet1.Controls.Add(Me.txtFirst)
        Me.gpDet1.Controls.Add(Me.lblReq04)
        Me.gpDet1.Controls.Add(Me.cboStatus)
        Me.gpDet1.Controls.Add(Me.lblReq00)
        Me.gpDet1.Controls.Add(Me.cboType)
        Me.gpDet1.Controls.Add(Me.lblReq01)
        Me.gpDet1.Controls.Add(Me.txtCode)
        Me.gpDet1.Controls.Add(Me.txtName)
        Me.gpDet1.Controls.Add(Me.lblReq03)
        Me.gpDet1.Controls.Add(Me.txtType)
        Me.gpDet1.Controls.Add(Me.lblReq02)
        Me.gpDet1.Controls.Add(Me.txtStatus)
        Me.gpDet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet1.Location = New System.Drawing.Point(3, 6)
        Me.gpDet1.Name = "gpDet1"
        Me.gpDet1.Size = New System.Drawing.Size(334, 210)
        Me.gpDet1.TabIndex = 0
        Me.gpDet1.TabStop = False
        Me.gpDet1.Text = "BASIC DETAILS"
        '
        'txtLast
        '
        Me.txtLast.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLast.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtLast.Border.Class = "TextBoxBorder"
        Me.txtLast.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLast.Location = New System.Drawing.Point(117, 177)
        Me.txtLast.MaxLength = 25
        Me.txtLast.Name = "txtLast"
        Me.txtLast.ReadOnly = True
        Me.txtLast.Size = New System.Drawing.Size(201, 20)
        Me.txtLast.TabIndex = 6
        '
        'lblReq06
        '
        Me.lblReq06.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq06.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq06.Location = New System.Drawing.Point(2, 177)
        Me.lblReq06.Name = "lblReq06"
        Me.lblReq06.Size = New System.Drawing.Size(109, 20)
        Me.lblReq06.TabIndex = 209
        Me.lblReq06.Text = "* LAST"
        Me.lblReq06.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtMiddle
        '
        Me.txtMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMiddle.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtMiddle.Border.Class = "TextBoxBorder"
        Me.txtMiddle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtMiddle.Location = New System.Drawing.Point(117, 151)
        Me.txtMiddle.MaxLength = 25
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.ReadOnly = True
        Me.txtMiddle.Size = New System.Drawing.Size(201, 20)
        Me.txtMiddle.TabIndex = 5
        '
        'lblReq05
        '
        Me.lblReq05.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq05.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq05.Location = New System.Drawing.Point(2, 151)
        Me.lblReq05.Name = "lblReq05"
        Me.lblReq05.Size = New System.Drawing.Size(109, 20)
        Me.lblReq05.TabIndex = 207
        Me.lblReq05.Text = "* MIDDLE"
        Me.lblReq05.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFirst
        '
        Me.txtFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirst.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtFirst.Border.Class = "TextBoxBorder"
        Me.txtFirst.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFirst.Location = New System.Drawing.Point(117, 125)
        Me.txtFirst.MaxLength = 25
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.ReadOnly = True
        Me.txtFirst.Size = New System.Drawing.Size(201, 20)
        Me.txtFirst.TabIndex = 4
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
        Me.lblReq04.Size = New System.Drawing.Size(109, 20)
        Me.lblReq04.TabIndex = 205
        Me.lblReq04.Text = "* FIRST"
        Me.lblReq04.TextAlignment = System.Drawing.StringAlignment.Far
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
        'ComboItem2
        '
        Me.ComboItem2.Text = "ACTIVE"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "INACTIVE"
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
        Me.lblReq00.Size = New System.Drawing.Size(109, 20)
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
        Me.cboType.Location = New System.Drawing.Point(143, 73)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 20)
        Me.cboType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboType.TabIndex = 1
        '
        'lblReq01
        '
        Me.lblReq01.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq01.Location = New System.Drawing.Point(2, 73)
        Me.lblReq01.Name = "lblReq01"
        Me.lblReq01.Size = New System.Drawing.Size(109, 20)
        Me.lblReq01.TabIndex = 189
        Me.lblReq01.Text = "* FRANCHISEE TYPE"
        Me.lblReq01.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtCode.Border.Class = "TextBoxBorder"
        Me.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCode.Location = New System.Drawing.Point(117, 47)
        Me.txtCode.MaxLength = 25
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(201, 20)
        Me.txtCode.TabIndex = 2
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
        Me.txtName.Location = New System.Drawing.Point(117, 99)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(201, 20)
        Me.txtName.TabIndex = 3
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
        Me.lblReq03.Size = New System.Drawing.Size(109, 20)
        Me.lblReq03.TabIndex = 187
        Me.lblReq03.Text = "* FRANCHISEE NAME"
        Me.lblReq03.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.txtType.Location = New System.Drawing.Point(117, 73)
        Me.txtType.MaxLength = 50
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(201, 20)
        Me.txtType.TabIndex = 190
        '
        'lblReq02
        '
        Me.lblReq02.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq02.Location = New System.Drawing.Point(2, 47)
        Me.lblReq02.Name = "lblReq02"
        Me.lblReq02.Size = New System.Drawing.Size(109, 20)
        Me.lblReq02.TabIndex = 170
        Me.lblReq02.Text = "* FRANCHISEE CODE"
        Me.lblReq02.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.txtStatus.Location = New System.Drawing.Point(117, 21)
        Me.txtStatus.MaxLength = 50
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(201, 20)
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
        'frmManFranchisee
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
        Me.Name = "frmManFranchisee"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>FRANCHISEE MANAGER</h5>"
        Me.gpInfo.ResumeLayout(False)
        Me.gpDet3.ResumeLayout(False)
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
    Friend WithEvents lblReq02 As DevComponents.DotNetBar.LabelX
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
    Friend WithEvents lblReq03 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gpDet2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblReq00 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtStatus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents gpDet3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents cboType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblReq01 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtType As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtLast As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq06 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMiddle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq05 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFirst As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq04 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtContactNo2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq09 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtContactNo1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq08 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtContactPerson As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq07 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMachNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDateDeploy As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMachStat As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSimImeiNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
End Class
