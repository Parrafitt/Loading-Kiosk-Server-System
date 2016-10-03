Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports DevComponents.DotNetBar.SuperGrid

Public Class frmLogMachine

#Region "-=- Local Functions -=-"

    'local variables
    Public selectedPanel As String
    Public selectedRowIndex As Integer
    Public selectedGridIndex As Integer

    'data fetching variables
    Dim myReader As MySqlDataReader
    Dim sql As MySqlCommand

    'cboSort Object variables
    Dim sortSplitChar As String = ":"

#Region "--(01)-- UI LAYOUT and OTHER Functions"

    '--(01A)--INITIALIZE
    Public Sub New()
        InitializeComponent()
        bwQuery.WorkerReportsProgress = True
        bwQuery.WorkerSupportsCancellation = True
    End Sub

    '--(01B)--Refresh Advtree1 Function
    Private Sub refreshList()

        If btnRefresh.Tooltip = "Refresh" Then
            If lockFunction = False Then
                Call prepBwQuery("fill") '(02A)LocalFunc
            End If
        Else

            If bwQuery.IsBusy = True Then
                Try
                    bwQuery.CancelAsync()
                    'sql.Cancel()
                Catch ex As Exception
                End Try
            End If
            superGridControl1.Enabled = True
            superGridControl1.PrimaryGrid.DataSource = Nothing
            gpItemList.Text = "No Record(s) Found!"

            btnRefresh.Enabled = True
            btnRefresh.Tooltip = "Refresh"
            btnRefresh.Text = "&Refresh"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlUiFormObjects

            cp1.IsRunning = False
            cp1.Value = 100
            cp1.ProgressColor = Color.LightCoral
            cp1.Visible = True

            lblStatus.Text = "<h5>Process Cancelled ! </h5>"
            lblStatus.Visible = True

            cboSortMach.Enabled = True

        End If
        cboSortMach.Focus()

    End Sub

    '--(01C)--lblStatus Event Function
    Private Sub lblStatusEvent()
        With lblStatus
            If .Text.Contains("No ") = True Or .Text.Contains("NO ") = True Or .Text.Contains("Error") = True Then

                .BackColor = Color.IndianRed
                .ForeColor = Color.White

                cp1.Value = 100
                cp1.ProgressColor = Color.Salmon
                cp1.Visible = True

            Else
                .BackColor = Color.Gray
                .ForeColor = Color.White
            End If
        End With
    End Sub

#End Region

#Region "--(02)-- DATA FETCHING AND DISPLAY Functions"

    '--VARIABLES--
    Dim tQueryType As String
    Dim hasQueryError As Boolean

    Dim dtList As DataTable
    Dim sortByMach As String

    '--(02A)--Prep for bwQuery
    Public Sub prepBwQuery(ByVal pQueryType As String)

        '===============================================|
        '-(02A.1)- FILTER cboSearch
        '===============================================|
        If lockFunction = True Then
            MsgBox("System is currently processing a request, please cancel active process to continue.", vbExclamation, "Attention!")
            Exit Sub
        End If

        '===============================================|
        '-(02A.2)- START bwQuery
        '===============================================|
        If bwQuery.IsBusy <> True Then

            gpItemList.Text = "Loading Records, Please Wait . . . "
            superGridControl1.Enabled = False
            globalDtFrom = dtSortFrom.Value.ToString("MM/dd/yyyy")
            globalDtTo = dtSortTo.Value.ToString("MM/dd/yyyy")

            lblStatus.Text = "Loading Records, Please Wait . . . "
            lblStatus.Visible = True
            cp1.ProgressColor = Color.Gold
            cp1.Visible = True
            cp1.IsRunning = True
            lblStatusEvent()

            btnRefresh.Text = "&Cancel"
            btnRefresh.Tooltip = "Cancel"
            Call btnRefreshIco(Me.btnRefresh) '(0B)localFunc

            'SORT
            sortByMach = ""
            If cboSortMach.Text <> "All" Then
                sortByMach = cboSortMach.Text
            End If

            'lock comboboxes
            cboSortMach.Enabled = False

            tQueryType = pQueryType
            bwQuery.RunWorkerAsync() '(02B)LocalFunc

        End If

    End Sub

    '--(02B)--bwQuery Function
    Private Sub bwQuery_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwQuery.DoWork

        'Prepare Values
        hasQueryError = False
        errorMsg = ""

        '===============================================|
        '-(02B.1A)-Get LIST
        '===============================================|
        If (bwQuery.CancellationPending = True) Then
            e.Cancel = True
        Else
            TxtLabel(lblStatus, "Loading Machine Status Log . . . ")
            If getLog() = False Then '(02C)localFunc
                hasQueryError = True
                Exit Sub
            End If
        End If

        '===============================================|
        '-(02B.6)-Fill SuperGrid1
        '===============================================|
        If (bwQuery.CancellationPending = True) Then
            e.Cancel = True
        Else
            TxtLabel(lblStatus, "Preparing for display . . . ")
            InitializeGrid() '(05A)localFunc
            Me.BeginInvoke(CallBindPunchData) '(3C)LocalFunc '(05B)localFunc
        End If

    End Sub
    Private Sub bwQuery_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwQuery.RunWorkerCompleted

        'lock comboboxes
        lockFunction = False
        cboSortMach.Enabled = True

        If e.Cancelled = True Then
            gpItemList.Text = "PROCESS CANCELLED !"
            lblStatus.Text = "<h5>Process Cancelled ! </h5>"
            lblStatus.Visible = True
        ElseIf e.Error IsNot Nothing Then
            gpItemList.Text = "PROCESS CANCELLED !"
            lblStatus.Text = "An Error Occured: (02B)" & Me.Name & " " & e.Error.Message
            lblStatus.Visible = True
        Else

            cp1.Visible = False
            cp1.IsRunning = False
            lblStatus.Visible = False

            btnRefresh.Tooltip = "Refresh"
            btnRefresh.Text = "&Refresh"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc

            If errorMsg <> "" Then
                gpItemList.Text = "AN ERROR OCCURED !"
                lblStatus.Text = errorMsg
                lblStatus.Visible = True
            Else
                If dtList.Rows.Count = 0 Then
                    gpItemList.Text = "NO RECORD(S) FOUND! . . ."
                    lblStatus.Text = "No Record(s) Found!"
                    lblStatus.Visible = True
                Else
                    superGridControl1.Enabled = True
                    gpItemList.Text = "DISPLAYING " & dtList.Rows.Count & " RECORD(S) . . ."
                End If
            End If
            lblStatusEvent()
        End If

    End Sub

    '--(02C)--GET LOG
    Private Function getLog() As Boolean

        getLog = True

        '=================================================================|
        '-(02C.1)- PREP Filter Statements
        '=================================================================|
        Dim filterQuery As String = "WHERE (log_mach_status.logDateTime >= '" & convertToDateDB(globalDtFrom) & " 00:00:00' " & _
                                   "AND log_mach_status.logDateTime <= '" & convertToDateDB(globalDtTo) & " 23:59:59') "
        If sortByMach <> "" Then
            filterQuery = filterQuery & " AND man_machine.machNo='" & sortByMach & "'"
        End If

        '=================================================================|
        '-(02C.1)- FETCH VALUES
        '=================================================================|
        Call connectDB()
        sql = New MySqlCommand("SELECT " & _
                             "log_mach_status.logNo AS 'LOG NO', " & _
                             "DATE_FORMAT(log_mach_status.logDateTime,'%Y-%m-%d %h:%i %p') AS 'DATETIME', " & _
                             "man_machine.machName AS 'MACHINE', " & _
                             "log_mach_status.machStat AS 'STATUS', " & _
                             "log_mach_status.machCtrl AS 'CONTROL', " & _
                             "log_mach_status.machUtil AS 'UTILITY' " & _
                             "FROM log_mach_status " & _
                             "LEFT JOIN man_machine ON man_machine.machNo = log_mach_status.machNo " & _
                             "" & filterQuery & " " & _
                             "", con)
        If IsNothing(dtList) = False Then
            dtList.Clear()
        End If
        dtList = New DataTable("table1")
        Try
            con.Open()
            myReader = sql.ExecuteReader
            dtList.Load(myReader, LoadOption.Upsert)
            con.Close()
        Catch myerror As MySqlException
            errorMsg = "An Error Occured: (02C.1)" & Me.Name & vbNewLine & " > " & myerror.Message
            getLog = False
            Exit Function
        Finally
            con.Dispose()
        End Try

    End Function

    '--(02D)--GET latest DateRange
    Private Sub getLatestDates()

        Try
            Dim dateFrom As String = getDbValue("SELECT logDateTime FROM log_mach_status ORDER BY logDateTime DESC LIMIT 0,1", False)
            If dateFrom <> "" Then
                dtSortFrom.Value = CDate(dateFrom)
            Else
                dtSortFrom.Value = DateTime.Now
            End If
            dtSortTo.Value = dtSortFrom.Value
        Catch ex As Exception
            showErrorMsg(ex.Message, "(02D)" & Me.Name)
        End Try

    End Sub

#End Region

#Region "--(03)-- SuperGridControl1 Functions"

    '--VARIABLE--
    Private _DataSet As DataSet
    Private _Background1 As New Background(Color.White, Color.FromArgb(238, 244, 251), 45)
    Private _Background2 As New Background(Color.FromArgb(249, 249, 234))
    Private _Background3 As New Background(Color.FromArgb(255, 247, 250))

    '--(03A)-- Initialize Grid
    Private Sub InitializeGrid()
        Dim panel As GridPanel = superGridControl1.PrimaryGrid

        panel.Name = "panel1"
        panel.ShowToolTips = True

        panel.MinRowHeight = 20
        panel.AutoGenerateColumns = True

        panel.DefaultVisualStyles.GroupByStyles.Default.Background = _Background1

        panel.SelectionGranularity = SelectionGranularity.RowWithCellHighlight

        AddHandler superGridControl1.CellValueChanged, AddressOf SuperGridControl1CellValueChanged
        AddHandler superGridControl1.DataBindingComplete, AddressOf SuperGridControl1DataBindingComplete '(03D)localFunc
    End Sub

    '--(03B)-- Bind Punch Data
    Dim CallBindPunchData As New MethodInvoker(AddressOf Me.BindPunchData)
    Private Sub BindPunchData()

        superGridControl1.PrimaryGrid.DataSource = Nothing
        superGridControl1.ContextMenuStrip = Nothing

        If IsNothing(dtList) = False Then

            _DataSet = New DataSet()
            With _DataSet

                .Tables.Add(dtList.Copy)

                '.Tables(0).DefaultView.Sort = "[EMPLOYEE] ASC" '<= SORTS 1st level by EMPLOYEE ASC **
                '.Tables(2).DefaultView.Sort = "[ctrlNo] ASC" '<= SORTS 3rd level by ctrlNo ASC **
                .AcceptChanges()

            End With

            superGridControl1.PrimaryGrid.DataSource = _DataSet
            superGridControl1.PrimaryGrid.DataMember = "table1"

        End If

    End Sub

    '--(03C)-- SuperGridControl1CellValueChanged
    Private Sub SuperGridControl1CellValueChanged(ByVal sender As Object, ByVal e As GridCellValueChangedEventArgs)

        Dim panel As GridPanel = e.GridPanel

        If panel.Name.Equals("table2") = True Or panel.Name.Equals("table3") = True Then
            UpdatePanelFooter(panel) '(03D5)localFunc

            'If panel.Name.Equals("table2") Then

            '    For Each rows As GridRow In panel.Rows
            '        If rows.Cells(14).ToString = "GridCell 14: {< error >}" Then
            '            rows.Cells(14).CellStyles.Default.TextColor = Color.Red
            '            rows.Cells(14).CellStyles.Default.Alignment = Alignment.MiddleCenter
            '        Else
            '            rows.Cells(14).CellStyles.Default.TextColor = Color.Black
            '            rows.Cells(14).CellStyles.Default.Alignment = Alignment.MiddleLeft
            '        End If
            '        If rows.Cells(11).ToString = "GridCell 11: {< error >}" Then
            '            rows.Cells(11).CellStyles.Default.TextColor = Color.Red
            '            rows.Cells(11).CellStyles.Default.Alignment = Alignment.MiddleCenter
            '        Else
            '            rows.Cells(11).CellStyles.Default.TextColor = Color.Black
            '            rows.Cells(11).CellStyles.Default.Alignment = Alignment.MiddleLeft
            '        End If
            '    Next rows

            'End If

        End If

    End Sub

#Region "--(03D)-- SuperGridControl1DataBindingComplete"

    '--(03D1)-- SuperGridControl1DataBindingComplete
    Private Sub SuperGridControl1DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        Dim panel As GridPanel = e.GridPanel

        panel.GroupByRow.Visible = True

        Select Case panel.DataMember
            Case "table1"
                CustomizePanel1(panel) '(03D2)localFunc

            Case "table2"
                CustomizePanel2(panel) '(03D3)localFunc

            Case "table3"
                CustomizePanel3(panel) '(03D4)localFunc
        End Select
    End Sub

    '--(03D2)-- CustomizePanel1
    Private Sub CustomizePanel1(ByVal panel As GridPanel)

        With panel

            .FrozenColumnCount = 1
            .ColumnHeader.RowHeight = 25
            .RowHeaderWidth = 20
            .AllowEdit = False
            .GroupByRow.Visible = False
            .ShowTreeLines = False
            .ShowRowHeaders = False
            .Columns(0).GroupBoxEffects = GroupBoxEffects.None
            .DefaultVisualStyles.GroupByStyles.Default.Background = _Background1
            .InitialSelection = Nothing
            .SelectionGranularity = SelectionGranularity.RowWithCellHighlight
            .DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New Font("Microsoft Sans Serif", 7)
            .DefaultVisualStyles.CellStyles.SelectedMouseOver.Background = New Background(Color.Yellow)
            .DefaultVisualStyles.CellStyles.MouseOver.Background = New Background(Color.Yellow)

            .Columns(0).Width = 70
            .Columns(1).Width = 120
            .Columns(2).Width = 100
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 80

            .Columns(0).CellStyles.Default.Alignment = Alignment.MiddleCenter
            .Columns(1).CellStyles.Default.Alignment = Alignment.MiddleCenter
            .Columns(2).CellStyles.Default.Alignment = Alignment.MiddleLeft
            .Columns(3).CellStyles.Default.Alignment = Alignment.MiddleCenter
            .Columns(4).CellStyles.Default.Alignment = Alignment.MiddleCenter
            .Columns(5).CellStyles.Default.Alignment = Alignment.MiddleCenter

            '.Columns(0).CellStyles.Default.Background = New Background(Color.AliceBlue)
            '.Columns(1).CellStyles.Default.Background = New Background(Color.LightYellow)
            '.Columns(2).CellStyles.Default.Background = New Background(Color.LightYellow)
            '.Columns(3).CellStyles.Default.Background = New Background(Color.LightYellow)
            '.Columns(4).CellStyles.Default.Background = New Background(Color.Honeydew)
            '.Columns(5).CellStyles.Default.Background = New Background(Color.LavenderBlush)

            'For Each rows As GridRow In panel.Rows
            '    If rows.Cells(6).ToString.Contains("-") Then
            '        rows.Cells(6).CellStyles.Default.TextColor = Color.Red
            '    End If
            'Next rows

            For Each column As GridColumn In panel.Columns
                column.ColumnSortMode = ColumnSortMode.Multiple
            Next column

        End With

    End Sub

    '--(03D3)-- CustomizePanel2
    Private Sub CustomizePanel2(ByVal panel As GridPanel)

        With panel

            .Caption = New GridCaption()
            .Caption.Text = String.Format("<h5> Loan Record(s) for ""{1}""</h5> Displaying ({0}) record(s) . . .", .Rows.Count, CType(.Parent, GridRow)("EMPLOYEE").Value)

            .FrozenColumnCount = 2
            .ShowRowDirtyMarker = True
            .ColumnHeader.RowHeight = 25
            .RowHeaderWidth = 20
            .GroupByRow.Visible = False
            .AllowEdit = False
            .DefaultVisualStyles.GroupByStyles.Default.Background = _Background2
            .InitialSelection = Nothing
            .SelectionGranularity = SelectionGranularity.RowWithCellHighlight
            .DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New Font("Microsoft Sans Serif", 7)
            .DefaultVisualStyles.CellStyles.SelectedMouseOver.Background = New Background(Color.Yellow)
            .DefaultVisualStyles.CellStyles.MouseOver.Background = New Background(Color.Yellow)

            .AddSort(.Columns(1), DevComponents.DotNetBar.SuperGrid.SortDirection.Ascending)

            .Columns(1).HeaderText = "LOAN NO."

            .Columns(0).Visible = False
            .Columns(1).Width = 90
            .Columns(2).Width = 200
            .Columns(3).Width = 120
            .Columns(4).Width = 120
            .Columns(5).Width = 120

            .Columns(1).CellStyles.Default.Alignment = Alignment.MiddleCenter
            .Columns(2).CellStyles.Default.Alignment = Alignment.MiddleLeft
            .Columns(3).CellStyles.Default.Alignment = Alignment.MiddleRight
            .Columns(4).CellStyles.Default.Alignment = Alignment.MiddleRight
            .Columns(5).CellStyles.Default.Alignment = Alignment.MiddleRight

            .Columns(1).CellStyles.Default.Background = New Background(Color.AliceBlue)
            .Columns(2).CellStyles.Default.Background = New Background(Color.LightYellow)
            .Columns(3).CellStyles.Default.Background = New Background(Color.Honeydew)
            .Columns(4).CellStyles.Default.Background = New Background(Color.LavenderBlush)
            .Columns(5).CellStyles.Default.Background = New Background(Color.LightYellow)

            For Each rows As GridRow In panel.Rows
                If rows.Cells(5).ToString.Contains("-") Then
                    rows.Cells(5).CellStyles.Default.TextColor = Color.Red
                End If
            Next rows

            UpdatePanelFooter(panel) '(03D5)localFunc

        End With

    End Sub

    '--(03D4)-- CustomizePanel3
    Private Sub CustomizePanel3(ByVal panel As GridPanel)

        With panel

            .Caption = New GridCaption()
            .Caption.Text = String.Format("<h5> Transactions for ( {1} )</h5> Displaying ({0}) record(s) . . .", .Rows.Count, CType(.Parent, GridRow)("ctrlNo").Value)

            .FrozenColumnCount = 3
            .ShowRowDirtyMarker = True
            .ColumnHeader.RowHeight = 25
            .RowHeaderWidth = 20
            .GroupByRow.Visible = False
            .AllowEdit = False
            .DefaultVisualStyles.GroupByStyles.Default.Background = _Background2
            .InitialSelection = Nothing
            .SelectionGranularity = SelectionGranularity.RowWithCellHighlight
            .DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New Font("Microsoft Sans Serif", 7)
            .DefaultVisualStyles.CellStyles.SelectedMouseOver.Background = New Background(Color.Yellow)
            .DefaultVisualStyles.CellStyles.MouseOver.Background = New Background(Color.Yellow)

            '.AddSort(.Columns(0), DevComponents.DotNetBar.SuperGrid.SortDirection.Ascending)

            .Columns(0).Visible = False '.Width = 60
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Width = 80
            .Columns(4).Width = 120
            .Columns(5).Width = 120
            .Columns(6).Visible = False
            .Columns(7).AutoSizeMode = ColumnAutoSizeMode.DisplayedCells

            .Columns(2).CellStyles.Default.Alignment = Alignment.MiddleCenter
            .Columns(3).CellStyles.Default.Alignment = Alignment.MiddleCenter
            .Columns(4).CellStyles.Default.Alignment = Alignment.MiddleRight
            .Columns(5).CellStyles.Default.Alignment = Alignment.MiddleRight
            .Columns(7).CellStyles.Default.Alignment = Alignment.MiddleLeft

            .Columns(2).CellStyles.Default.Background = New Background(Color.AliceBlue)
            .Columns(3).CellStyles.Default.Background = New Background(Color.AliceBlue)
            .Columns(4).CellStyles.Default.Background = New Background(Color.Honeydew)
            .Columns(5).CellStyles.Default.Background = New Background(Color.LavenderBlush)
            .Columns(7).CellStyles.Default.Background = New Background(Color.LightYellow)

            '.Columns(0).HeaderText = "CTRL NO."
            'For Each rows As GridRow In panel.Rows
            '    If rows.Cells(5).ToString.Contains("-") Then
            '        rows.Cells(5).CellStyles.Default.TextColor = Color.Red
            '    End If
            'Next rows

            UpdatePanelFooter(panel) '(03D5)localFunc

        End With

    End Sub

    '--(03D5)-- UpdatePanelFooter
    Private Sub UpdatePanelFooter(ByVal panel As GridPanel)
        If panel.Footer Is Nothing Then
            panel.Footer = New GridFooter()
        End If

        Dim total As Integer = panel.Rows.Count

        If total <> 0 Then
            panel.Footer.Text = String.Format("Total record(s) : {0}", panel.Rows.Count)
        Else
            panel.Footer.Text = String.Format("No record(s) found . . .")
        End If

    End Sub

    '--(03D6)-- TotalRows
    Private Function TotalRows(ByVal rows As IEnumerable(Of GridElement)) As Decimal
        Dim total As Decimal = 0

        'For Each item As GridContainer In rows
        '    If TypeOf item Is GridRow Then
        '        Dim row As GridRow = CType(item, GridRow)

        '        Dim unitPrice As Decimal = DirectCast(IIf(row("UnitPrice").Value Is Nothing, 0D, row("UnitPrice").Value), Decimal)
        '        Dim discount As Single = CSng(IIf(row("Discount").Value Is Nothing, 0D, row("Discount").Value))
        '        Dim quantity As Short = CShort(Fix(IIf(row("Quantity").Value Is Nothing, 0D, row("Quantity").Value)))

        '        total += (unitPrice - CDec(discount)) * quantity
        '    End If

        '    If item.Rows.Count > 0 Then
        '        total += TotalRows(item.Rows)
        '    End If
        'Next item

        Return (total)
    End Function

#End Region

#Region "--(03E)-- DataTable Structures"

    '--(VARIABLES)--
    Dim dt1stLevel As DataTable
    Dim dt2ndLevel As DataTable
    Dim dt3rdLevel As DataTable

    '--(03E1)--SET dt1stLevel
    Private Function setdt1stLevel() As DataTable

        Dim table As New DataTable("table1")
        table.Columns.Add("EMP NO.", GetType(String)) '0
        table.Columns.Add("EMPLOYEE", GetType(String)) '1
        table.Columns.Add("DEPARTMENT", GetType(String)) '2
        table.Columns.Add("COMPANY", GetType(String)) '3
        table.Columns.Add("DEBIT", GetType(String)) '4
        table.Columns.Add("CREDIT", GetType(String)) '5
        table.Columns.Add("BALANCE", GetType(String)) '6
        Return table

    End Function

    '--(03E2)--SET dt2ndLevel
    Private Function setdt2ndLevel() As DataTable

        Dim table As New DataTable("table2")
        table.Columns.Add("EMP NO.", GetType(String)) '0
        table.Columns.Add("ctrlNo", GetType(String)) '1
        table.Columns.Add("ITEM", GetType(String)) '2
        table.Columns.Add("DEBIT", GetType(String)) '3
        table.Columns.Add("CREDIT", GetType(String)) '4
        table.Columns.Add("BALANCE", GetType(String)) '5
        Return table

    End Function

    '--(03E3)--SET dt3rdLevel
    Private Function setdt3rdLevel() As DataTable

        Dim table As New DataTable("table3")
        table.Columns.Add("ctrlNo", GetType(String)) '0
        table.Columns.Add("ITEM", GetType(String)) '1
        table.Columns.Add("LOAN #", GetType(String)) '2
        table.Columns.Add("DATE", GetType(String)) '3
        table.Columns.Add("DEBIT", GetType(String)) '4
        table.Columns.Add("CREDIT", GetType(String)) '5
        table.Columns.Add("BALANCE", GetType(String)) '6
        table.Columns.Add("REMARKS", GetType(String)) '7
        Return table

    End Function

#End Region

#End Region

#End Region

#Region "-=- UI Functions -=-"

    '=-CLOSE
    Private Sub MyBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If cp1.IsRunning = True Then
            If MsgBox("System is currently processing a request, are you sure you want to close form?" & vbNewLine & _
                      "* Unsaved changes will be discarded.", vbExclamation + vbYesNoCancel, "Attention!") <> vbYes Then
                e.Cancel = True
                Exit Sub
            Else
                If bwQuery.IsBusy = True Then
                    Try
                        bwQuery.CancelAsync()
                        sql.Cancel()
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If

        frmMain.btnLogMachine.Checked = False
        frmServer.Enabled = True
        If frmMain.MainRibbon.Expanded = True Then
            frmMain.MainRibbon.Expanded = False
        End If

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '=-LOAD
    Private Sub MyBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'set values
        Cursor.Current = Cursors.WaitCursor
        frmMain.btnLogMachine.Checked = True
        frmServer.Enabled = False

        lockFunction = True

        'populate cboSortMach
        Call popCbo("SELECT " & _
                       "CONCAT(man_machine.machNo, ' " & sortSplitChar & " ', man_machine.machName) AS 'tValue' " & _
                       "FROM man_machine " & _
                       "WHERE man_machine.isVisible='Y' " & _
                       "ORDER BY man_machine.machNo ASC",
                       "All",
                       "tValue",
                       cboSortMach) '(07C)mdlGlobalFunc
        With cboSortMach
            .DisplayMember = "tvalue"
            .SelectedIndex = 0
            .Refresh()
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            AddHandler .Validating, AddressOf cboSortMach_Validating
        End With
        autoCompleteListCboBox(cboSortMach, sortSplitChar) '(8)mdlGlobalFunc

        'set date
        getLatestDates() '(02D)localFunc

        lockFunction = False

        ' Populate
        Call prepBwQuery("fill") '(02A)localFunc

        Me.KeyPreview = True
        cboSortMach.Focus()

    End Sub

    '=-SHORTCUT Key Functions
    Private Sub MyBase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.KeyPreview = True
            btnClose.PerformClick()
        ElseIf (e.KeyCode = Keys.F5) Then
            Me.KeyPreview = True
            btnRefresh.PerformClick()
        ElseIf (e.KeyCode = Keys.P AndAlso e.Modifiers = Keys.Control) Then
            Me.KeyPreview = True
            btnPrint.PerformClick()
        End If
    End Sub

#Region "-- SPECIAL OBJECTS"

    '=-btnPrintRemit Functions
    Private Sub btnPrintSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Call previewRpt(sender.name) '(07B)localFunc
    End Sub

#End Region

#Region "-- DEFAULT OBJECTS"

    '=-btnRefresh Functions
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call refreshList() '(01B)localFunc
    End Sub

#Region "-SORT OBJECTS"

    '=-cboSortMach Functions
    Private Sub cboSortMach_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSortMach.KeyDown
        If e.KeyCode = Keys.Return Then
            gpOption1.Focus()
            If isInCboList(cboSortMach) = False Then
                errorCap = "Attention!"
                errorMsg = "Entered Machine is not Registered!"
                popBaloon(cboSortMach, Me)
                cboSortMach.Focus()
                Exit Sub
            End If
            cboSortMach.Focus()
        End If
    End Sub
    Private Sub cboSortMach_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSortMach.SelectedIndexChanged
        If lockFunction = False Then
            lockFunction = True
            Call prepBwQuery("fill") '(02A)localFunc
            lockFunction = False
        End If
    End Sub
    Private Sub cboSortMach_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSortMach.Validating
        Dim selectedComboBox As ComboBox = CType(sender, ComboBox)
        Dim itm As String
        For x = 0 To selectedComboBox.Items.Count - 1
            itm = selectedComboBox.Items(x).item(0).ToString()
            If itm <> "" Then
                If convertUpperCase(itm.Substring(itm.IndexOf(sortSplitChar) + 2)) = convertUpperCase(selectedComboBox.Text) Then '// locate the .Substring that matches the .Text.
                    selectedComboBox.Text = itm '// set .Text of ComboBox item.
                    Exit For '// exit loop since done locating item.
                End If
                itm = selectedComboBox.Items(x).item(0).ToString()
            End If
        Next
    End Sub
    Private Sub cboSortMach_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cboSortMach.MouseWheel
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
    End Sub

#End Region

#End Region

#End Region

End Class