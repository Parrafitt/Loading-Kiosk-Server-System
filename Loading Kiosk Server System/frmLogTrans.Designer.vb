<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogTrans))
        Me.bwQuery = New System.ComponentModel.BackgroundWorker()
        Me.gpOption1 = New System.Windows.Forms.GroupBox()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.dtSortFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtSortTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnRefresh = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboSortMach = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.gpItemList = New System.Windows.Forms.GroupBox()
        Me.cp1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ReflectionImage2 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.gpOption1.SuspendLayout()
        CType(Me.dtSortFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSortTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gpItemList.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bwQuery
        '
        '
        'gpOption1
        '
        Me.gpOption1.BackColor = System.Drawing.Color.Transparent
        Me.gpOption1.Controls.Add(Me.LabelX7)
        Me.gpOption1.Controls.Add(Me.LabelX15)
        Me.gpOption1.Controls.Add(Me.dtSortFrom)
        Me.gpOption1.Controls.Add(Me.dtSortTo)
        Me.gpOption1.Controls.Add(Me.btnRefresh)
        Me.gpOption1.Controls.Add(Me.LabelX1)
        Me.gpOption1.Controls.Add(Me.cboSortMach)
        Me.gpOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpOption1.Location = New System.Drawing.Point(116, 3)
        Me.gpOption1.Name = "gpOption1"
        Me.gpOption1.Size = New System.Drawing.Size(573, 110)
        Me.gpOption1.TabIndex = 231
        Me.gpOption1.TabStop = False
        Me.gpOption1.Text = "SORT / SEARCH RECORDS"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(1, 50)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(81, 20)
        Me.LabelX7.TabIndex = 227
        Me.LabelX7.Text = "DATE  FROM"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.ForeColor = System.Drawing.Color.Black
        Me.LabelX15.Location = New System.Drawing.Point(62, 76)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(20, 20)
        Me.LabelX15.TabIndex = 226
        Me.LabelX15.Text = "TO"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dtSortFrom
        '
        Me.dtSortFrom.AutoSelectDate = True
        Me.dtSortFrom.BackColor = System.Drawing.Color.Khaki
        '
        '
        '
        Me.dtSortFrom.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.dtSortFrom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtSortFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtSortFrom.ButtonDropDown.Visible = True
        Me.dtSortFrom.CustomFormat = "yyyy-MM-dd"
        Me.dtSortFrom.DisabledBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dtSortFrom.DisabledForeColor = System.Drawing.Color.Black
        Me.dtSortFrom.FocusHighlightEnabled = True
        Me.dtSortFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtSortFrom.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtSortFrom.IsPopupCalendarOpen = False
        Me.dtSortFrom.Location = New System.Drawing.Point(88, 50)
        '
        '
        '
        Me.dtSortFrom.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtSortFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortFrom.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtSortFrom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtSortFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtSortFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtSortFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortFrom.MonthCalendar.DisplayMonth = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.dtSortFrom.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtSortFrom.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtSortFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtSortFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortFrom.MonthCalendar.TodayButtonVisible = True
        Me.dtSortFrom.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtSortFrom.Name = "dtSortFrom"
        Me.dtSortFrom.Size = New System.Drawing.Size(120, 20)
        Me.dtSortFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtSortFrom.TabIndex = 224
        '
        'dtSortTo
        '
        Me.dtSortTo.AutoSelectDate = True
        Me.dtSortTo.BackColor = System.Drawing.Color.Khaki
        '
        '
        '
        Me.dtSortTo.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.dtSortTo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtSortTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtSortTo.ButtonDropDown.Visible = True
        Me.dtSortTo.CustomFormat = "yyyy-MM-dd"
        Me.dtSortTo.DisabledBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dtSortTo.DisabledForeColor = System.Drawing.Color.Black
        Me.dtSortTo.FocusHighlightEnabled = True
        Me.dtSortTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtSortTo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtSortTo.IsPopupCalendarOpen = False
        Me.dtSortTo.Location = New System.Drawing.Point(88, 76)
        '
        '
        '
        Me.dtSortTo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtSortTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortTo.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtSortTo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtSortTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtSortTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtSortTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortTo.MonthCalendar.DisplayMonth = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.dtSortTo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtSortTo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtSortTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtSortTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtSortTo.MonthCalendar.TodayButtonVisible = True
        Me.dtSortTo.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtSortTo.Name = "dtSortTo"
        Me.dtSortTo.Size = New System.Drawing.Size(120, 20)
        Me.dtSortTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtSortTo.TabIndex = 225
        '
        'btnRefresh
        '
        Me.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRefresh.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.refresh
        Me.btnRefresh.Location = New System.Drawing.Point(436, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(125, 72)
        Me.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRefresh.TabIndex = 221
        Me.btnRefresh.Text = "Refresh <font color=""#1F497D"">( F5 )</font>"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(70, 20)
        Me.LabelX1.TabIndex = 220
        Me.LabelX1.Text = "MACHINE"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboSortMach
        '
        Me.cboSortMach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSortMach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSortMach.DisplayMember = "Text"
        Me.cboSortMach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSortMach.FocusHighlightEnabled = True
        Me.cboSortMach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboSortMach.FormattingEnabled = True
        Me.cboSortMach.ItemHeight = 14
        Me.cboSortMach.Location = New System.Drawing.Point(88, 24)
        Me.cboSortMach.Name = "cboSortMach"
        Me.cboSortMach.Size = New System.Drawing.Size(342, 20)
        Me.cboSortMach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboSortMach.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(695, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 110)
        Me.GroupBox2.TabIndex = 232
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPTIONS"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(212, 22)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(148, 72)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print <font color=""#1F497D"">( Ctrl+P )</font>"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(366, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 72)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'gpItemList
        '
        Me.gpItemList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpItemList.BackColor = System.Drawing.Color.Transparent
        Me.gpItemList.Controls.Add(Me.cp1)
        Me.gpItemList.Controls.Add(Me.lblStatus)
        Me.gpItemList.Controls.Add(Me.superGridControl1)
        Me.gpItemList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.gpItemList.Location = New System.Drawing.Point(3, 119)
        Me.gpItemList.Name = "gpItemList"
        Me.gpItemList.Size = New System.Drawing.Size(1179, 362)
        Me.gpItemList.TabIndex = 233
        Me.gpItemList.TabStop = False
        Me.gpItemList.Text = "-- Record(s) Found"
        '
        'cp1
        '
        Me.cp1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cp1.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.cp1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderBottomWidth = 2
        Me.cp1.BackgroundStyle.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.cp1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderLeftWidth = 2
        Me.cp1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderRightWidth = 2
        Me.cp1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cp1.BackgroundStyle.BorderTopWidth = 2
        Me.cp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cp1.Location = New System.Drawing.Point(323, 133)
        Me.cp1.Name = "cp1"
        Me.cp1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
        Me.cp1.ProgressColor = System.Drawing.Color.Gold
        Me.cp1.Size = New System.Drawing.Size(100, 100)
        Me.cp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.cp1.TabIndex = 132
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.BackColor = System.Drawing.Color.Gray
        '
        '
        '
        Me.lblStatus.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderBottomWidth = 2
        Me.lblStatus.BackgroundStyle.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.lblStatus.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderLeftWidth = 2
        Me.lblStatus.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderRightWidth = 2
        Me.lblStatus.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lblStatus.BackgroundStyle.BorderTopWidth = 2
        Me.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(323, 133)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.PaddingLeft = 110
        Me.lblStatus.Size = New System.Drawing.Size(574, 100)
        Me.lblStatus.TabIndex = 133
        Me.lblStatus.Text = "Loading Data, Please Wait . . ."
        Me.lblStatus.WordWrap = True
        '
        'superGridControl1
        '
        Me.superGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.superGridControl1.FilterUseExtendedCustomDialog = True
        Me.superGridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.superGridControl1.Location = New System.Drawing.Point(3, 14)
        Me.superGridControl1.Name = "superGridControl1"
        Me.superGridControl1.PrimaryGrid.AllowEdit = False
        Me.superGridControl1.PrimaryGrid.EnableColumnFiltering = True
        Me.superGridControl1.PrimaryGrid.EnableFiltering = True
        Me.superGridControl1.PrimaryGrid.EnableRowFiltering = True
        Me.superGridControl1.PrimaryGrid.Filter.Visible = True
        Me.superGridControl1.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.superGridControl1.PrimaryGrid.LevelIndentSize = New System.Drawing.Size(10, 10)
        Me.superGridControl1.PrimaryGrid.MultiSelect = False
        Me.superGridControl1.PrimaryGrid.RowHeaderWidth = 20
        Me.superGridControl1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.superGridControl1.PrimaryGrid.ShowTreeButtons = True
        Me.superGridControl1.PrimaryGrid.ShowTreeLines = True
        Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.superGridControl1.Size = New System.Drawing.Size(1173, 345)
        Me.superGridControl1.TabIndex = 179
        Me.superGridControl1.Text = "superGridControl1"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ReflectionImage2)
        Me.GroupPanel1.Controls.Add(Me.gpOption1)
        Me.GroupPanel1.Controls.Add(Me.gpItemList)
        Me.GroupPanel1.Controls.Add(Me.GroupBox2)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1191, 490)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 235
        '
        'ReflectionImage2
        '
        Me.ReflectionImage2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionImage2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ReflectionImage2.BackgroundStyle.BorderBottomWidth = 1
        Me.ReflectionImage2.BackgroundStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.ReflectionImage2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ReflectionImage2.BackgroundStyle.BorderLeftWidth = 1
        Me.ReflectionImage2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ReflectionImage2.BackgroundStyle.BorderRightWidth = 1
        Me.ReflectionImage2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ReflectionImage2.BackgroundStyle.BorderTopWidth = 1
        Me.ReflectionImage2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage2.BackgroundStyle.PaddingTop = 10
        Me.ReflectionImage2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage2.Image = CType(resources.GetObject("ReflectionImage2.Image"), System.Drawing.Image)
        Me.ReflectionImage2.Location = New System.Drawing.Point(3, 8)
        Me.ReflectionImage2.Name = "ReflectionImage2"
        Me.ReflectionImage2.ReflectionEnabled = False
        Me.ReflectionImage2.Size = New System.Drawing.Size(107, 105)
        Me.ReflectionImage2.TabIndex = 234
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(83, 436)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(35, 30)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Tooltip = "Delete . . ."
        '
        'frmLogTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 514)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1225, 547)
        Me.Name = "frmLogTrans"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleText = "<h5>TRANSACTION LOG</h5>"
        Me.gpOption1.ResumeLayout(False)
        CType(Me.dtSortFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSortTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gpItemList.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bwQuery As System.ComponentModel.BackgroundWorker
    Public WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpOption1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Public WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSortMach As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnRefresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpItemList As System.Windows.Forms.GroupBox
    Friend WithEvents cp1 As DevComponents.DotNetBar.Controls.CircularProgress
    Public WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ReflectionImage2 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtSortFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtSortTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
