<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManAdvt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManAdvt))
        Me.gpInfo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtiExpiryDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiStartDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiEndTime = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblReq03 = New DevComponents.DotNetBar.LabelX()
        Me.dtiStartTime = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblReq04 = New DevComponents.DotNetBar.LabelX()
        Me.lblReq07 = New DevComponents.DotNetBar.LabelX()
        Me.lblReq06 = New DevComponents.DotNetBar.LabelX()
        Me.lblReq05 = New DevComponents.DotNetBar.LabelX()
        Me.cboTimeSlot = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtTimeSlot = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpDet3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalBitrate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtFrameRate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtDataRate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtFrameHeight = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtFrameWidth = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtLength = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.txtFileName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtSizeOnDisk = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.txtTypeOfFile = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.gpLogo = New System.Windows.Forms.GroupBox()
        Me.lblStatus2 = New DevComponents.DotNetBar.LabelX()
        Me.btnVidDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnVidBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.wmpPreview = New AxWMPLib.AxWindowsMediaPlayer()
        Me.gpDet1 = New System.Windows.Forms.GroupBox()
        Me.lblIndexNo = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.lblReq00 = New DevComponents.DotNetBar.LabelX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblReq02 = New DevComponents.DotNetBar.LabelX()
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
        Me.txtLastUpdated = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.gpInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtiExpiryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiEndTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiStartTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDet3.SuspendLayout()
        Me.gpLogo.SuspendLayout()
        CType(Me.wmpPreview, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpInfo.Controls.Add(Me.GroupBox1)
        Me.gpInfo.Controls.Add(Me.gpDet3)
        Me.gpInfo.Controls.Add(Me.gpLogo)
        Me.gpInfo.Controls.Add(Me.gpDet1)
        Me.gpInfo.Location = New System.Drawing.Point(372, 12)
        Me.gpInfo.Name = "gpInfo"
        Me.gpInfo.Size = New System.Drawing.Size(906, 611)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtiExpiryDate)
        Me.GroupBox1.Controls.Add(Me.dtiStartDate)
        Me.GroupBox1.Controls.Add(Me.dtiEndTime)
        Me.GroupBox1.Controls.Add(Me.lblReq03)
        Me.GroupBox1.Controls.Add(Me.dtiStartTime)
        Me.GroupBox1.Controls.Add(Me.lblReq04)
        Me.GroupBox1.Controls.Add(Me.lblReq07)
        Me.GroupBox1.Controls.Add(Me.lblReq06)
        Me.GroupBox1.Controls.Add(Me.lblReq05)
        Me.GroupBox1.Controls.Add(Me.cboTimeSlot)
        Me.GroupBox1.Controls.Add(Me.txtTimeSlot)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 151)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BROADCAST SETTINGS"
        '
        'dtiExpiryDate
        '
        '
        '
        '
        Me.dtiExpiryDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiExpiryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiryDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiExpiryDate.ButtonDropDown.Visible = True
        Me.dtiExpiryDate.CustomFormat = "yyyy-MM-dd "
        Me.dtiExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtiExpiryDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtiExpiryDate.IsPopupCalendarOpen = False
        Me.dtiExpiryDate.Location = New System.Drawing.Point(93, 43)
        '
        '
        '
        Me.dtiExpiryDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiExpiryDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiryDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiExpiryDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiExpiryDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiExpiryDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiExpiryDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiExpiryDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiExpiryDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiExpiryDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiExpiryDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiryDate.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtiExpiryDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiExpiryDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiExpiryDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiExpiryDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiExpiryDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiExpiryDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiExpiryDate.MonthCalendar.TodayButtonVisible = True
        Me.dtiExpiryDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiExpiryDate.Name = "dtiExpiryDate"
        Me.dtiExpiryDate.Size = New System.Drawing.Size(208, 20)
        Me.dtiExpiryDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiExpiryDate.TabIndex = 1
        '
        'dtiStartDate
        '
        '
        '
        '
        Me.dtiStartDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiStartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiStartDate.ButtonDropDown.Visible = True
        Me.dtiStartDate.CustomFormat = "yyyy-MM-dd "
        Me.dtiStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtiStartDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtiStartDate.IsPopupCalendarOpen = False
        Me.dtiStartDate.Location = New System.Drawing.Point(93, 17)
        '
        '
        '
        Me.dtiStartDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiStartDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiStartDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiStartDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiStartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiStartDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiStartDate.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtiStartDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiStartDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiStartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiStartDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiStartDate.MonthCalendar.TodayButtonVisible = True
        Me.dtiStartDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiStartDate.Name = "dtiStartDate"
        Me.dtiStartDate.Size = New System.Drawing.Size(208, 20)
        Me.dtiStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiStartDate.TabIndex = 0
        '
        'dtiEndTime
        '
        '
        '
        '
        Me.dtiEndTime.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiEndTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiEndTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiEndTime.ButtonDropDown.Visible = True
        Me.dtiEndTime.CustomFormat = "hh:mm:ss t"
        Me.dtiEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtiEndTime.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.dtiEndTime.IsPopupCalendarOpen = False
        Me.dtiEndTime.Location = New System.Drawing.Point(169, 121)
        '
        '
        '
        Me.dtiEndTime.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiEndTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.dtiEndTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiEndTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiEndTime.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtiEndTime.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiEndTime.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiEndTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiEndTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiEndTime.MonthCalendar.Visible = False
        Me.dtiEndTime.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiEndTime.Name = "dtiEndTime"
        Me.dtiEndTime.Size = New System.Drawing.Size(132, 20)
        Me.dtiEndTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiEndTime.TabIndex = 4
        '
        'lblReq03
        '
        Me.lblReq03.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq03.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq03.Location = New System.Drawing.Point(6, 17)
        Me.lblReq03.Name = "lblReq03"
        Me.lblReq03.Size = New System.Drawing.Size(81, 20)
        Me.lblReq03.TabIndex = 211
        Me.lblReq03.Text = "* START DATE"
        Me.lblReq03.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtiStartTime
        '
        '
        '
        '
        Me.dtiStartTime.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiStartTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiStartTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiStartTime.ButtonDropDown.Visible = True
        Me.dtiStartTime.CustomFormat = "hh:mm:ss t"
        Me.dtiStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtiStartTime.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.dtiStartTime.IsPopupCalendarOpen = False
        Me.dtiStartTime.Location = New System.Drawing.Point(169, 95)
        '
        '
        '
        Me.dtiStartTime.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiStartTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.dtiStartTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiStartTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiStartTime.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtiStartTime.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiStartTime.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiStartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiStartTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiStartTime.MonthCalendar.Visible = False
        Me.dtiStartTime.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiStartTime.Name = "dtiStartTime"
        Me.dtiStartTime.Size = New System.Drawing.Size(132, 20)
        Me.dtiStartTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiStartTime.TabIndex = 3
        '
        'lblReq04
        '
        Me.lblReq04.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq04.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq04.Location = New System.Drawing.Point(6, 43)
        Me.lblReq04.Name = "lblReq04"
        Me.lblReq04.Size = New System.Drawing.Size(81, 20)
        Me.lblReq04.TabIndex = 212
        Me.lblReq04.Text = "* EXPIRY DATE"
        Me.lblReq04.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblReq07
        '
        Me.lblReq07.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq07.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq07.Location = New System.Drawing.Point(6, 121)
        Me.lblReq07.Name = "lblReq07"
        Me.lblReq07.Size = New System.Drawing.Size(157, 20)
        Me.lblReq07.TabIndex = 207
        Me.lblReq07.Text = "END TIME"
        Me.lblReq07.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblReq06
        '
        Me.lblReq06.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq06.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq06.Location = New System.Drawing.Point(6, 95)
        Me.lblReq06.Name = "lblReq06"
        Me.lblReq06.Size = New System.Drawing.Size(157, 20)
        Me.lblReq06.TabIndex = 205
        Me.lblReq06.Text = "START TIME"
        Me.lblReq06.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblReq05
        '
        Me.lblReq05.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq05.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq05.Location = New System.Drawing.Point(6, 69)
        Me.lblReq05.Name = "lblReq05"
        Me.lblReq05.Size = New System.Drawing.Size(81, 20)
        Me.lblReq05.TabIndex = 189
        Me.lblReq05.Text = "* TIME SLOT"
        Me.lblReq05.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboTimeSlot
        '
        Me.cboTimeSlot.DisplayMember = "Text"
        Me.cboTimeSlot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTimeSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboTimeSlot.FormattingEnabled = True
        Me.cboTimeSlot.ItemHeight = 14
        Me.cboTimeSlot.Location = New System.Drawing.Point(147, 69)
        Me.cboTimeSlot.Name = "cboTimeSlot"
        Me.cboTimeSlot.Size = New System.Drawing.Size(121, 20)
        Me.cboTimeSlot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTimeSlot.TabIndex = 2
        '
        'txtTimeSlot
        '
        Me.txtTimeSlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTimeSlot.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtTimeSlot.Border.Class = "TextBoxBorder"
        Me.txtTimeSlot.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTimeSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTimeSlot.Location = New System.Drawing.Point(93, 69)
        Me.txtTimeSlot.MaxLength = 50
        Me.txtTimeSlot.Name = "txtTimeSlot"
        Me.txtTimeSlot.ReadOnly = True
        Me.txtTimeSlot.Size = New System.Drawing.Size(208, 20)
        Me.txtTimeSlot.TabIndex = 190
        '
        'gpDet3
        '
        Me.gpDet3.BackColor = System.Drawing.Color.Transparent
        Me.gpDet3.Controls.Add(Me.txtLastUpdated)
        Me.gpDet3.Controls.Add(Me.LabelX2)
        Me.gpDet3.Controls.Add(Me.txtTotalBitrate)
        Me.gpDet3.Controls.Add(Me.LabelX8)
        Me.gpDet3.Controls.Add(Me.txtFrameRate)
        Me.gpDet3.Controls.Add(Me.LabelX7)
        Me.gpDet3.Controls.Add(Me.txtDataRate)
        Me.gpDet3.Controls.Add(Me.LabelX6)
        Me.gpDet3.Controls.Add(Me.txtFrameHeight)
        Me.gpDet3.Controls.Add(Me.LabelX5)
        Me.gpDet3.Controls.Add(Me.txtFrameWidth)
        Me.gpDet3.Controls.Add(Me.LabelX4)
        Me.gpDet3.Controls.Add(Me.txtLength)
        Me.gpDet3.Controls.Add(Me.LabelX12)
        Me.gpDet3.Controls.Add(Me.txtFileName)
        Me.gpDet3.Controls.Add(Me.LabelX11)
        Me.gpDet3.Controls.Add(Me.txtSizeOnDisk)
        Me.gpDet3.Controls.Add(Me.LabelX10)
        Me.gpDet3.Controls.Add(Me.txtTypeOfFile)
        Me.gpDet3.Controls.Add(Me.LabelX9)
        Me.gpDet3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet3.Location = New System.Drawing.Point(3, 296)
        Me.gpDet3.Name = "gpDet3"
        Me.gpDet3.Size = New System.Drawing.Size(314, 287)
        Me.gpDet3.TabIndex = 2
        Me.gpDet3.TabStop = False
        Me.gpDet3.Text = "VIDEO DETAILS"
        '
        'txtTotalBitrate
        '
        Me.txtTotalBitrate.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtTotalBitrate.Border.Class = "TextBoxBorder"
        Me.txtTotalBitrate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalBitrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTotalBitrate.Location = New System.Drawing.Point(93, 229)
        Me.txtTotalBitrate.MaxLength = 50
        Me.txtTotalBitrate.Name = "txtTotalBitrate"
        Me.txtTotalBitrate.ReadOnly = True
        Me.txtTotalBitrate.Size = New System.Drawing.Size(208, 20)
        Me.txtTotalBitrate.TabIndex = 221
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(3, 229)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(84, 20)
        Me.LabelX8.TabIndex = 220
        Me.LabelX8.Text = "TOTAL BITRATE"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFrameRate
        '
        Me.txtFrameRate.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtFrameRate.Border.Class = "TextBoxBorder"
        Me.txtFrameRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFrameRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFrameRate.Location = New System.Drawing.Point(93, 255)
        Me.txtFrameRate.MaxLength = 50
        Me.txtFrameRate.Name = "txtFrameRate"
        Me.txtFrameRate.ReadOnly = True
        Me.txtFrameRate.Size = New System.Drawing.Size(208, 20)
        Me.txtFrameRate.TabIndex = 219
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(3, 255)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(84, 20)
        Me.LabelX7.TabIndex = 218
        Me.LabelX7.Text = "FRAME RATE"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtDataRate
        '
        Me.txtDataRate.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtDataRate.Border.Class = "TextBoxBorder"
        Me.txtDataRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDataRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDataRate.Location = New System.Drawing.Point(93, 205)
        Me.txtDataRate.MaxLength = 50
        Me.txtDataRate.Name = "txtDataRate"
        Me.txtDataRate.ReadOnly = True
        Me.txtDataRate.Size = New System.Drawing.Size(208, 20)
        Me.txtDataRate.TabIndex = 217
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(3, 205)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(84, 20)
        Me.LabelX6.TabIndex = 216
        Me.LabelX6.Text = "DATA RATE"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFrameHeight
        '
        Me.txtFrameHeight.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtFrameHeight.Border.Class = "TextBoxBorder"
        Me.txtFrameHeight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFrameHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFrameHeight.Location = New System.Drawing.Point(93, 179)
        Me.txtFrameHeight.MaxLength = 50
        Me.txtFrameHeight.Name = "txtFrameHeight"
        Me.txtFrameHeight.ReadOnly = True
        Me.txtFrameHeight.Size = New System.Drawing.Size(208, 20)
        Me.txtFrameHeight.TabIndex = 215
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(3, 179)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(84, 20)
        Me.LabelX5.TabIndex = 214
        Me.LabelX5.Text = "FRAME HEIGHT"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFrameWidth
        '
        Me.txtFrameWidth.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtFrameWidth.Border.Class = "TextBoxBorder"
        Me.txtFrameWidth.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFrameWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFrameWidth.Location = New System.Drawing.Point(93, 153)
        Me.txtFrameWidth.MaxLength = 50
        Me.txtFrameWidth.Name = "txtFrameWidth"
        Me.txtFrameWidth.ReadOnly = True
        Me.txtFrameWidth.Size = New System.Drawing.Size(208, 20)
        Me.txtFrameWidth.TabIndex = 213
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(3, 153)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(84, 20)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "FRAME WIDTH"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtLength
        '
        Me.txtLength.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtLength.Border.Class = "TextBoxBorder"
        Me.txtLength.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLength.Location = New System.Drawing.Point(93, 127)
        Me.txtLength.MaxLength = 50
        Me.txtLength.Name = "txtLength"
        Me.txtLength.ReadOnly = True
        Me.txtLength.Size = New System.Drawing.Size(208, 20)
        Me.txtLength.TabIndex = 211
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(3, 127)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(84, 20)
        Me.LabelX12.TabIndex = 210
        Me.LabelX12.Text = "LENGTH"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtFileName
        '
        Me.txtFileName.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtFileName.Border.Class = "TextBoxBorder"
        Me.txtFileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFileName.Location = New System.Drawing.Point(93, 49)
        Me.txtFileName.MaxLength = 50
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(208, 20)
        Me.txtFileName.TabIndex = 209
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(3, 49)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(84, 20)
        Me.LabelX11.TabIndex = 208
        Me.LabelX11.Text = "FILENAME"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtSizeOnDisk
        '
        Me.txtSizeOnDisk.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtSizeOnDisk.Border.Class = "TextBoxBorder"
        Me.txtSizeOnDisk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSizeOnDisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSizeOnDisk.Location = New System.Drawing.Point(93, 101)
        Me.txtSizeOnDisk.MaxLength = 50
        Me.txtSizeOnDisk.Name = "txtSizeOnDisk"
        Me.txtSizeOnDisk.ReadOnly = True
        Me.txtSizeOnDisk.Size = New System.Drawing.Size(208, 20)
        Me.txtSizeOnDisk.TabIndex = 207
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(0, 101)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(87, 20)
        Me.LabelX10.TabIndex = 206
        Me.LabelX10.Text = "SIZE ON DISK"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtTypeOfFile
        '
        Me.txtTypeOfFile.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtTypeOfFile.Border.Class = "TextBoxBorder"
        Me.txtTypeOfFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTypeOfFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTypeOfFile.Location = New System.Drawing.Point(93, 75)
        Me.txtTypeOfFile.MaxLength = 50
        Me.txtTypeOfFile.Name = "txtTypeOfFile"
        Me.txtTypeOfFile.ReadOnly = True
        Me.txtTypeOfFile.Size = New System.Drawing.Size(208, 20)
        Me.txtTypeOfFile.TabIndex = 205
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(6, 75)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(81, 20)
        Me.LabelX9.TabIndex = 204
        Me.LabelX9.Text = "TYPE OF FILE"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gpLogo
        '
        Me.gpLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpLogo.BackColor = System.Drawing.Color.Transparent
        Me.gpLogo.Controls.Add(Me.lblStatus2)
        Me.gpLogo.Controls.Add(Me.btnVidDelete)
        Me.gpLogo.Controls.Add(Me.btnVidBrowse)
        Me.gpLogo.Controls.Add(Me.wmpPreview)
        Me.gpLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpLogo.Location = New System.Drawing.Point(323, 6)
        Me.gpLogo.Name = "gpLogo"
        Me.gpLogo.Size = New System.Drawing.Size(574, 577)
        Me.gpLogo.TabIndex = 3
        Me.gpLogo.TabStop = False
        Me.gpLogo.Text = "VIDEO PREVIEW"
        '
        'lblStatus2
        '
        Me.lblStatus2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus2.BackColor = System.Drawing.Color.IndianRed
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
        Me.lblStatus2.ForeColor = System.Drawing.Color.White
        Me.lblStatus2.Location = New System.Drawing.Point(3, 256)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.PaddingLeft = 2
        Me.lblStatus2.PaddingRight = 2
        Me.lblStatus2.Size = New System.Drawing.Size(568, 65)
        Me.lblStatus2.TabIndex = 141
        Me.lblStatus2.Text = "VIDEO NOT AVAILABLE !"
        Me.lblStatus2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblStatus2.Visible = False
        Me.lblStatus2.WordWrap = True
        '
        'btnVidDelete
        '
        Me.btnVidDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVidDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVidDelete.Image = CType(resources.GetObject("btnVidDelete.Image"), System.Drawing.Image)
        Me.btnVidDelete.Location = New System.Drawing.Point(11, 51)
        Me.btnVidDelete.Name = "btnVidDelete"
        Me.btnVidDelete.Size = New System.Drawing.Size(25, 25)
        Me.btnVidDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVidDelete.TabIndex = 139
        Me.btnVidDelete.Tooltip = "Delete picture . . ."
        Me.btnVidDelete.Visible = False
        '
        'btnVidBrowse
        '
        Me.btnVidBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVidBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVidBrowse.Image = CType(resources.GetObject("btnVidBrowse.Image"), System.Drawing.Image)
        Me.btnVidBrowse.Location = New System.Drawing.Point(11, 24)
        Me.btnVidBrowse.Name = "btnVidBrowse"
        Me.btnVidBrowse.Size = New System.Drawing.Size(25, 25)
        Me.btnVidBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVidBrowse.TabIndex = 138
        Me.btnVidBrowse.Tooltip = "Browse for picture . . ."
        Me.btnVidBrowse.Visible = False
        '
        'wmpPreview
        '
        Me.wmpPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wmpPreview.Enabled = True
        Me.wmpPreview.Location = New System.Drawing.Point(3, 14)
        Me.wmpPreview.Name = "wmpPreview"
        Me.wmpPreview.OcxState = CType(resources.GetObject("wmpPreview.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpPreview.Size = New System.Drawing.Size(568, 560)
        Me.wmpPreview.TabIndex = 140
        '
        'gpDet1
        '
        Me.gpDet1.BackColor = System.Drawing.Color.Transparent
        Me.gpDet1.Controls.Add(Me.lblIndexNo)
        Me.gpDet1.Controls.Add(Me.LabelX1)
        Me.gpDet1.Controls.Add(Me.cboStatus)
        Me.gpDet1.Controls.Add(Me.lblReq00)
        Me.gpDet1.Controls.Add(Me.txtCode)
        Me.gpDet1.Controls.Add(Me.txtName)
        Me.gpDet1.Controls.Add(Me.lblReq02)
        Me.gpDet1.Controls.Add(Me.lblReq01)
        Me.gpDet1.Controls.Add(Me.txtStatus)
        Me.gpDet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpDet1.Location = New System.Drawing.Point(3, 6)
        Me.gpDet1.Name = "gpDet1"
        Me.gpDet1.Size = New System.Drawing.Size(314, 127)
        Me.gpDet1.TabIndex = 0
        Me.gpDet1.TabStop = False
        Me.gpDet1.Text = "BASIC DETAILS"
        '
        'lblIndexNo
        '
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
        Me.lblIndexNo.Location = New System.Drawing.Point(93, 17)
        Me.lblIndexNo.Name = "lblIndexNo"
        Me.lblIndexNo.Size = New System.Drawing.Size(208, 20)
        Me.lblIndexNo.TabIndex = 145
        Me.lblIndexNo.Text = "0000"
        Me.lblIndexNo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 17)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(81, 20)
        Me.LabelX1.TabIndex = 210
        Me.LabelX1.Text = "ADVT. NO."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboStatus
        '
        Me.cboStatus.DisplayMember = "Text"
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.ItemHeight = 14
        Me.cboStatus.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboStatus.Location = New System.Drawing.Point(147, 43)
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
        Me.lblReq00.Location = New System.Drawing.Point(6, 43)
        Me.lblReq00.Name = "lblReq00"
        Me.lblReq00.Size = New System.Drawing.Size(81, 20)
        Me.lblReq00.TabIndex = 200
        Me.lblReq00.Text = "* STATUS"
        Me.lblReq00.TextAlignment = System.Drawing.StringAlignment.Far
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
        Me.txtCode.Location = New System.Drawing.Point(93, 69)
        Me.txtCode.MaxLength = 25
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(208, 20)
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
        Me.txtName.Location = New System.Drawing.Point(93, 95)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(208, 20)
        Me.txtName.TabIndex = 2
        '
        'lblReq02
        '
        Me.lblReq02.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq02.Location = New System.Drawing.Point(6, 95)
        Me.lblReq02.Name = "lblReq02"
        Me.lblReq02.Size = New System.Drawing.Size(81, 20)
        Me.lblReq02.TabIndex = 187
        Me.lblReq02.Text = "* ADVT. NAME"
        Me.lblReq02.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblReq01
        '
        Me.lblReq01.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblReq01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReq01.Location = New System.Drawing.Point(6, 69)
        Me.lblReq01.Name = "lblReq01"
        Me.lblReq01.Size = New System.Drawing.Size(81, 20)
        Me.lblReq01.TabIndex = 170
        Me.lblReq01.Text = "* ADVT. CODE"
        Me.lblReq01.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.txtStatus.Border.Class = "TextBoxBorder"
        Me.txtStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtStatus.Location = New System.Drawing.Point(93, 43)
        Me.txtStatus.MaxLength = 50
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(208, 20)
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
        Me.gpList.Size = New System.Drawing.Size(354, 646)
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
        Me.btnFirstPage.Location = New System.Drawing.Point(231, 592)
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
        Me.btnPreviousPage.Location = New System.Drawing.Point(260, 592)
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
        Me.btnNextPage.Location = New System.Drawing.Point(289, 592)
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
        Me.btnLastPage.Location = New System.Drawing.Point(318, 592)
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
        Me.btnDelete.Location = New System.Drawing.Point(80, 592)
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
        Me.btnEdit.Location = New System.Drawing.Point(39, 592)
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
        Me.btnAdd.Location = New System.Drawing.Point(3, 592)
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
        Me.lblDisplayPageNo.Location = New System.Drawing.Point(108, 592)
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
        Me.gpMainList.Size = New System.Drawing.Size(338, 554)
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
        Me.advTree1.Size = New System.Drawing.Size(332, 535)
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
        Me.lblStatus.Location = New System.Drawing.Point(0, 240)
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
        Me.cp1.Location = New System.Drawing.Point(0, 188)
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
        Me.btnSaveNew.Location = New System.Drawing.Point(798, 629)
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
        Me.btnSave.Location = New System.Drawing.Point(915, 629)
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
        Me.btnCancel.Location = New System.Drawing.Point(1032, 629)
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
        Me.btnClose.Location = New System.Drawing.Point(1158, 629)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 29)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close  <font color=""#1F497D"">( Esc )</font>"
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.BackColor = System.Drawing.Color.Azure
        '
        '
        '
        Me.txtLastUpdated.Border.Class = "TextBoxBorder"
        Me.txtLastUpdated.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLastUpdated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLastUpdated.Location = New System.Drawing.Point(93, 23)
        Me.txtLastUpdated.MaxLength = 50
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(208, 20)
        Me.txtLastUpdated.TabIndex = 223
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 23)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(84, 20)
        Me.LabelX2.TabIndex = 222
        Me.LabelX2.Text = "LAST UPDATED"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'frmManAdvt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 670)
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
        Me.MinimumSize = New System.Drawing.Size(1300, 703)
        Me.Name = "frmManAdvt"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>ADVERTISEMENT MANAGER</h5>"
        Me.gpInfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtiExpiryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiEndTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiStartTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDet3.ResumeLayout(False)
        Me.gpLogo.ResumeLayout(False)
        CType(Me.wmpPreview, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents btnVidDelete As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnVidBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq02 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblReq00 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtStatus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents gpDet3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents cboTimeSlot As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblReq05 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTimeSlot As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblReq07 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblReq06 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTypeOfFile As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSizeOnDisk As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLength As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFileName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiEndTime As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiStartTime As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiExpiryDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiStartDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblReq04 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblReq03 As DevComponents.DotNetBar.LabelX
    Friend WithEvents wmpPreview As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFrameRate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDataRate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFrameHeight As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFrameWidth As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotalBitrate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Public WithEvents lblStatus2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtLastUpdated As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
