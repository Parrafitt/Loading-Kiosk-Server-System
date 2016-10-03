Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports System.IO
Imports WMPLib

Public Class frmManAdvt

#Region "-=- Local Functions -=-"

    'local variables
    Dim checkCode As String = ""
    Dim checkName As String = ""
    Dim btnAddused As Boolean = False
    Dim typeLocked As Boolean = True

    'data fetching variables
    Dim ds As DataSet = New DataSet()
    Dim myReader As MySqlDataReader
    Dim sql As MySqlCommand

    'pagination variables
    Dim dtDisplay As DataTable
    Dim PageCount As Integer
    Dim maxRec As Integer
    Dim pageSize As Integer = 500 '<= Maximum Number of records per Page =>
    Dim currentPage As Integer
    Dim recNo As Integer
    Dim startRec As Integer
    Dim endRec As Integer

#Region "--(00)-- UI Layout and Other Functions --"

    '--(00A)--INITIALIZE
    Public Sub New()

        InitializeComponent()
        bwQuery.WorkerReportsProgress = True
        bwQuery.WorkerSupportsCancellation = True

        cboStatus.Location = txtStatus.Location
        cboStatus.Size = txtStatus.Size

        cboTimeSlot.Location = txtTimeSlot.Location
        cboTimeSlot.Size = txtTimeSlot.Size

    End Sub

    '--(00B)--Refresh Advtree1 Function
    Private Sub refreshList()

        If btnRefresh.Tooltip = "Refresh" Then
            If advTree1.Enabled = True Then
                If txtSearch.Text <> "" Then
                    txtSearch.Text = ""
                End If
                Call prepBwQuery("fill") '(1A)LocalFunc
            End If
        Else

            If bwQuery.IsBusy = True Then

                Try
                    bwQuery.CancelAsync()
                    sql.Cancel()
                Catch ex As Exception
                End Try
            End If

            advTree1.Enabled = True
            advTree1.Nodes.Clear()
            gpMainList.Text = "No Record(s) Found!"
            cp1.Visible = False
            cp1.IsRunning = False

            btnRefresh.Enabled = True
            btnRefresh.Tooltip = "Refresh"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc

        End If

        txtSearch.Focus()

    End Sub

    '--(00C)--lblRequired Events
    Public Sub markLblRequired(ByVal mark As Boolean)
        If mark = True Then
            lblReq00.Text = "* " & lblReq00.Text
            lblReq01.Text = "* " & lblReq01.Text
            lblReq02.Text = "* " & lblReq02.Text
            lblReq03.Text = "* " & lblReq03.Text
            lblReq04.Text = "* " & lblReq04.Text
            lblReq05.Text = "* " & lblReq05.Text
            lblReq06.Text = "* " & lblReq06.Text
            lblReq07.Text = "* " & lblReq07.Text
        Else
            lblReq00.Text = stripCharOfString(lblReq00.Text, "* ").Trim
            lblReq01.Text = stripCharOfString(lblReq01.Text, "* ").Trim
            lblReq02.Text = stripCharOfString(lblReq02.Text, "* ").Trim
            lblReq03.Text = stripCharOfString(lblReq03.Text, "* ").Trim
            lblReq04.Text = stripCharOfString(lblReq04.Text, "* ").Trim
            lblReq05.Text = stripCharOfString(lblReq05.Text, "* ").Trim
            lblReq06.Text = stripCharOfString(lblReq06.Text, "* ").Trim
            lblReq07.Text = stripCharOfString(lblReq07.Text, "* ").Trim
        End If
    End Sub

    '--(00D)--DEFAULT input
    Private Sub inputDefault()

        '============================================================|
        '-(00D.1)-SUSPEND LAYOUT
        '============================================================|
        Me.SuspendLayout()
        gpList.Visible = False
        gpInfo.Visible = False
        gpInfo.Text = "Advertisement's Information"

        '============================================================|
        '-(00D.2)-SET DEFAULT OBJECTS
        '============================================================|
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSaveNew.Visible = False
        btnSave.Visible = False
        btnSave.Text = "&Save"
        btnCancel.Visible = False

        Call markLblRequired(False) '(0E)localFunc

        '============================================================|
        '-(00D.3)-SET DETAILS 1
        '============================================================|
        txtStatus.Visible = True
        cboStatus.Visible = False

        With txtCode
            .ReadOnly = True
            .FocusHighlightEnabled = False
            .BackColor = Color.LightGoldenrodYellow
        End With

        With txtName
            .ReadOnly = True
            .FocusHighlightEnabled = False
            .BackColor = Color.LightGoldenrodYellow
        End With

        '============================================================|
        '-(00D.4)-SET DETAILS 2
        '============================================================|
        With dtiStartDate
            .IsInputReadOnly = True
            .ButtonDropDown.Visible = False
            .FocusHighlightEnabled = False
            .BackgroundStyle.BackColor = Color.LightGoldenrodYellow
        End With

        With dtiExpiryDate
            .IsInputReadOnly = True
            .ButtonDropDown.Visible = False
            .FocusHighlightEnabled = False
            .BackgroundStyle.BackColor = Color.LightGoldenrodYellow
        End With

        txtTimeSlot.Visible = True
        cboTimeSlot.Visible = False

        With dtiStartTime
            .IsInputReadOnly = True
            .ButtonDropDown.Visible = False
            .FocusHighlightEnabled = False
            .BackgroundStyle.BackColor = Color.LightGoldenrodYellow
        End With

        With dtiEndTime
            .IsInputReadOnly = True
            .ButtonDropDown.Visible = False
            .FocusHighlightEnabled = False
            .BackgroundStyle.BackColor = Color.LightGoldenrodYellow
        End With

        '============================================================|
        '-(00D.5)-SET IMAGE
        '============================================================|
        btnVidBrowse.Visible = False
        btnVidDelete.Visible = False

        '============================================================|
        '-(00D.6)-RESUME LAYOUT
        '============================================================|
        gpList.Visible = True
        gpInfo.Visible = True
        Call collapseView(True, gpList, gpInfo, btnExpand, txtSearch, Me.Width) '(03)mdlDefFrmFunc
        Me.ResumeLayout()

        txtSearch.Select()

    End Sub

    '--(00E)--ADD input
    Private Sub inputAdd()

        '============================================================|
        '-(00E.1)-SUSPEND LAYOUT
        '============================================================|
        Me.SuspendLayout()
        gpList.Visible = False
        With gpInfo
            .Visible = False
            .Text = "Add New Advertisement"
            .Width = (.Left + .Width) - gpList.Left
            .Left = gpList.Left
        End With

        '============================================================|
        '-(00E.2)-SET DEFAULT OBJECTS
        '============================================================|
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSaveNew.Visible = True
        btnSave.Visible = True
        btnSave.Text = "&Save"
        btnCancel.Visible = True

        Call markLblRequired(True) '(0E)localFunc

        btnAddused = True

        '============================================================|
        '-(00E.3)-SET DETAILS 1
        '============================================================|
        checkCode = ""
        checkName = ""

        lblIndexNo.Text = getAdvertisementNo() '(01C)mdlSysFunc

        txtStatus.Visible = False
        With cboStatus
            .SelectedIndex = 0
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        With txtCode
            .Text = lblIndexNo.Text & Date.Now.ToString("-yyMM")
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        With txtName
            .Text = ""
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        '============================================================|
        '-(00E.4)-SET DETAILS 2
        '============================================================|
        With dtiStartDate
            .Text = ""
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        With dtiExpiryDate
            .Text = ""
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        txtTimeSlot.Visible = False
        With cboTimeSlot
            .Text = ""
            .Visible = True
            .FocusHighlightEnabled = True
        End With

        With dtiStartTime
            .Text = ""
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        With dtiEndTime
            .Text = ""
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        '============================================================|
        '-(00E.4)-SET IMAGE
        '============================================================|
        btnVidBrowse.Visible = True
        btnVidDelete.Visible = False

        Call updateVideo("") '(03A.4)localFunc

        '============================================================|
        '-(00E.5)-RESUME LAYOUT
        '============================================================|
        gpInfo.Visible = True
        Me.ResumeLayout()

        Call updateUiTimeSlot(cboTimeSlot.Text) '(03B.1)localFunc

        txtName.Focus()
        txtName.Select()

    End Sub

    '--(00F)--EDIT input
    Public Sub inputEdit()

        '============================================================|
        '-(00F.1)-FILTER
        '============================================================|
        If advTree1.Nodes.Count = 0 Then
            MsgBox("No Record(s) Found!", vbExclamation, "Cannot Edit!")
            Exit Sub
        End If

        '============================================================|
        '-(00F.2)-SUSPEND LAYOUT
        '============================================================|
        Me.SuspendLayout()
        gpList.Visible = False
        With gpInfo
            .Visible = False
            .Text = "Edit Advertisement's Information"
            .Width = (.Left + .Width) - gpList.Left
            .Left = gpList.Left
        End With

        '============================================================|
        '-(00F.3)-SET DEFAULT OBJECTS
        '============================================================|
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Visible = True
        btnSave.Text = "&Update"
        btnCancel.Visible = True
        gpInfo.Visible = True

        Call markLblRequired(True) '(0E)localFunc

        '============================================================|
        '-(00F.4)-SET DETAILS 1
        '============================================================|
        checkCode = convertUpperCase(txtCode.Text)
        checkName = convertUpperCase(txtName.Text)

        txtStatus.Visible = False
        With cboStatus
            .Text = txtStatus.Text
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        With txtCode
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        With txtName
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        '============================================================|
        '-(00F.5)-SET DETAILS 2
        '============================================================|
        With dtiStartDate
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        With dtiExpiryDate
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        txtTimeSlot.Visible = False
        With cboTimeSlot
            .Text = txtTimeSlot.Text
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        With dtiStartTime
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        With dtiEndTime
            .IsInputReadOnly = False
            .ButtonDropDown.Visible = True
            .FocusHighlightEnabled = True
            .BackgroundStyle.BackColor = Color.White
        End With

        '============================================================|
        '-(00F.6)-SET IMAGE
        '============================================================|
        btnVidBrowse.Visible = False
        btnVidDelete.Visible = False

        '============================================================|
        '-(00F.7)-RESUME LAYOUT
        '============================================================|
        gpInfo.Visible = True
        Me.ResumeLayout()

        Call updateUiTimeSlot(cboTimeSlot.Text) '(03B.1)localFunc

    End Sub

    '--(00G)--lblStatus Event Function
    Private Sub lblStatusEvent(ByRef lblStatus As DevComponents.DotNetBar.LabelX,
                               ByRef cp As DevComponents.DotNetBar.Controls.CircularProgress,
                               ByRef isError As Boolean)

        With lblStatus
            If isError = True Then

                .BackColor = Color.IndianRed
                .ForeColor = Color.White

                With cp
                    .Value = 100
                    .ProgressColor = Color.LightSalmon
                    .Visible = True
                End With

            Else

                .BackColor = Color.Gray
                .ForeColor = Color.LightYellow

                With cp
                    .Value = 100
                    .ProgressColor = Color.Yellow
                    .Visible = True
                End With

            End If
        End With

    End Sub

#End Region

#Region "--(01)-- Data Fetching and Display Functions --"

    '--VARIABLES--
    Dim searchFor As String
    Public queryType As String
    Dim dtPrefixList As DataTable

    '--(01A)--Prep for bwQuery
    Private Sub prepBwQuery(ByVal tQueryType As String)

        If bwQuery.IsBusy <> True Then

            lblStatus.Text = "Loading, Please Wait . . . "
            lblStatusEvent(lblStatus, cp1, False) '(00G)localFUnc

            advTree1.Enabled = False
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            cp1.Visible = True
            cp1.IsRunning = True

            lblStatus2.Text = "Loading, Please Wait . . . "

            btnRefresh.Tooltip = "Cancel"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc

            errorMsg = Nothing
            queryType = tQueryType

            'set search
            searchFor = Nothing
            If queryType = "search" Then
                searchFor = txtSearch.Text
            End If

            bwQuery.RunWorkerAsync() '(01B)LocalFunc

        End If

    End Sub

    '--(01B)--bwQuery Function
    Private Sub bwQuery_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwQuery.DoWork

        If (bwQuery.CancellationPending = True) Then
            e.Cancel = True
        Else
            If queryType = "fill" Then
                Call fillDS() '(01C)LocalFunc
            ElseIf queryType = "search" Then
                Call searchDS() '(01D)localFunc
            End If
        End If

    End Sub
    Private Sub bwQuery_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwQuery.RunWorkerCompleted

        advTree1.Enabled = True
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        If e.Cancelled = True Then

            gpMainList.Text = "PROCESS CANCELLED !"
            lblStatus.Text = "Process Cancelled !"
            lblStatus.Visible = True
            lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

        ElseIf e.Error IsNot Nothing Then

            gpMainList.Text = "PROCESS CANCELLED !"
            lblStatus.Text = "An Error Occured: " & Me.Name & "(01B)" & vbNewLine & e.Error.Message
            lblStatus.Visible = True
            lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

        Else

            If errorMsg = "" Then

                cp1.Visible = False
                cp1.IsRunning = False
                lblStatus.Visible = False

                If IsNothing(dtDisplay) Then

                    gpMainList.Text = "No Record(s) Found !"
                    lblStatus.Text = "NO RECORD(S) FOUND !"
                    lblStatus.Visible = True
                    lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

                    lblDisplayPageNo.Text = "Page 0 of 0"

                Else

                    gpMainList.Text = "Displaying " & CStr(startRec + 1) & " to " & endRec.ToString & " of " & maxRec.ToString & " Record(s) . . . "
                    lblDisplayPageNo.Text = "Page " & currentPage.ToString & " of " & PageCount.ToString

                End If

            Else

                gpMainList.Text = "AN ERROR OCCURED !"

                cp1.Visible = True
                cp1.IsRunning = False
                lblStatus.Visible = True
                lblStatus.Text = errorMsg
                lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

            End If

            btnRefresh.Tooltip = "Refresh"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc

        End If

        Call txtDef() '(01C)localFunc
        txtSearch.Focus()

    End Sub

    '--(01C)--FILL Dataset DS
    Private Sub fillDS()

        '=============================================================================|
        '--(01C.1)--GET DATA FROM DB
        '=============================================================================|
        Call connectDB()
        sql = New MySqlCommand("SELECT " & _
                               "man_advertisement.advertisementNo AS '#', " & _
                               "ref_ad_status.adStatusName AS 'STATUS', " & _
                               "man_advertisement.advertisementCode AS 'CODE', " & _
                               "man_advertisement.advertisementName AS 'ADVT. NAME', " & _
                               "DATE_FORMAT(man_advertisement.startDate,'%Y-%m-%d') AS 'START DATE', " & _
                               "DATE_FORMAT(man_advertisement.expiryDate,'%Y-%m-%d') AS 'EXPIRY DATE', " & _
                               "ref_ad_timeslot.timeSlotName AS 'TIMESLOT', " & _
                               "man_advertisement.timeSlotStart AS 'TIME START', " & _
                               "man_advertisement.timeSlotEnd AS 'TIME END', " & _
                               "man_advertisement.typeOfFile AS 'TYPE OF FILE', " & _
                               "man_advertisement.filename AS 'FILENAME', " & _
                               "man_advertisement.sizeOnDisk AS 'SIZE ON DISK', " & _
                               "man_advertisement.length AS 'LENGTH', " & _
                               "man_advertisement.frameWidth AS 'FRAME WIDTH', " & _
                               "man_advertisement.frameHeight AS 'FRAME HEIGHT', " & _
                               "man_advertisement.dataRate AS 'DATA RATE', " & _
                               "man_advertisement.totalBitrate AS 'TOTAL BITRATE', " & _
                               "man_advertisement.frameRate AS 'FRAME RATE', " & _
                               "DATE_FORMAT(man_advertisement.lastUpdated,'%Y-%m-%d %H:%m:%s %p') AS 'LAST UPDATED' " & _
                               "FROM man_advertisement " & _
                               "LEFT JOIN ref_ad_status ON ref_ad_status.adStatusNo=man_advertisement.adStatusNo " & _
                               "LEFT JOIN ref_ad_timeslot ON ref_ad_timeslot.timeSlotNo=man_advertisement.timeSlotNo " & _
                               "WHERE man_advertisement.isVisible='Y' ORDER BY man_advertisement.advertisementName ASC", con)
        ds = New DataSet()
        Try
            con.Open()
            myReader = sql.ExecuteReader
            ds.Load(myReader, LoadOption.Upsert, "table1")
            con.Close()
        Catch myerror As MySqlException
            If myerror.Number.ToString <> "1317" Then
                errorMsg = "An Error Occured: (01C.1)" & Me.Name & vbNewLine & "> " & myerror.Message
            End If
            Exit Sub
        Finally
            con.Dispose()
        End Try

        '=============================================================================|
        '--(01C.2)--SET FOR PAGINATION
        '=============================================================================|
        If ds.Tables.Count <> 0 Then
            If ds.Tables(0).Rows.Count <> 0 Then

                'Set the start and max records.
                maxRec = ds.Tables(0).Rows.Count
                PageCount = maxRec \ pageSize

                If maxRec > pageSize Then
                    ' Adjust the page number if the last page contains a partial page.
                    If (maxRec Mod pageSize) > 0 Then
                        PageCount = PageCount + 1
                    End If
                Else
                    PageCount = 1
                End If

                'Initial seeings
                currentPage = 1
                recNo = 0
            End If
        End If

        '=============================================================================|
        '--(01C.3)--LOAD PAGE
        '=============================================================================|
        Call CallLoadPage() '(01E)LocalFunc
        'Me.BeginInvoke(CallLoadPage) '(01E)LocalFunc

    End Sub

    '--(01D)--SEARCH DatasetS
    Private Sub searchDS()

        Try
            With ds
                If searchFor = "" Then
                    .Tables(0).DefaultView.RowFilter = ""
                Else
                    .Tables(0).DefaultView.RowFilter = "" & _
                    "[CODE] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[ADVT. NAME] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[FILENAME] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[TIMESLOT] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[STATUS] LIKE '%" & cleanStringForDB(searchFor) & "%'"
                End If

                If .Tables.Count <> 0 Then
                    If .Tables(0).DefaultView.Count <> 0 Then

                        'Set the start and max records.
                        maxRec = .Tables(0).DefaultView.Count
                        PageCount = maxRec \ pageSize

                        If maxRec > pageSize Then
                            ' Adjust the page number if the last page contains a partial page.
                            If (maxRec Mod pageSize) > 0 Then
                                PageCount = PageCount + 1
                            End If
                        Else
                            PageCount = 1
                        End If

                        'Initial seeings
                        currentPage = 1
                        recNo = 0

                    End If
                End If
            End With
        Catch ex As Exception
            errorMsg = "An Error Occured: (01D)" & Me.Name & vbNewLine & "> " & ex.Message
        End Try

        Call CallLoadPage() '(01E)LocalFunc
        'Me.BeginInvoke(CallLoadPage) '(01E)LocalFunc

    End Sub

    '--(01E)--LoadPage Function
    Dim CallLoadPage As New MethodInvoker(AddressOf Me.LoadPage)
    Private Sub LoadPage()

        Dim i As Integer

        If ds.Tables(0).DefaultView.Count <> 0 Then

            '=============================================================================|
            '--(01E.1)--Duplicate or clone the source table to create the temporary table.
            '=============================================================================|
            dtDisplay = ds.Tables(0).Clone
            dtDisplay.Constraints.Clear()

            '=============================================================================|
            '--(01E.2)--SET PAGE NO
            '=============================================================================|
            If currentPage = PageCount Then
                endRec = maxRec
            Else
                endRec = pageSize * currentPage
            End If
            startRec = recNo

            '=============================================================================|
            '--(01E.3)--Copy the rows from the source table to fill the temporary table.
            '=============================================================================|
            For i = startRec To endRec - 1
                dtDisplay.ImportRow(ds.Tables(0).DefaultView(i).Row)
                recNo = recNo + 1
            Next

        Else
            dtDisplay = Nothing
        End If

        Me.BeginInvoke(CallFillAdvTree) '(01F)LocalFunc
        'CallFillAdvTree()

    End Sub

    '--(01F)--FillAdvTree THREAD
    Dim CallFillAdvTree As New MethodInvoker(AddressOf Me.FillAdvTree)
    Public Sub FillAdvTree()

        With advTree1

            .Nodes.Clear()
            .DataSource = Nothing

            If IsNothing(dtDisplay) = False Then

                '=============================================================================|
                '--(01F.1)--SET COLUMN VISUAL LAYOUT
                '=============================================================================|
                .DataSource = dtDisplay
                .BeginUpdate()

                .Columns(0).Visible = False '#

                .Columns(1).Width.AutoSize = True 'STATUS
                .Columns(1).Width.AutoSizeMinHeader = 60

                .Columns(2).Width.AutoSize = True 'CODE
                .Columns(2).Width.AutoSizeMinHeader = 80

                .Columns(3).Width.AutoSize = True 'ADVT. NAME
                .Columns(3).Width.AutoSizeMinHeader = 100

                .Columns(4).Width.AutoSize = True 'START DATE
                .Columns(4).Width.AutoSizeMinHeader = 70

                .Columns(5).Width.AutoSize = True 'EXPIRY DATE
                .Columns(5).Width.AutoSizeMinHeader = 70

                .Columns(6).Width.AutoSize = True 'TIMESLOT
                .Columns(6).Width.AutoSizeMinHeader = 80

                .Columns(7).Width.AutoSize = True 'TIME START
                .Columns(7).Width.AutoSizeMinHeader = 60

                .Columns(8).Width.AutoSize = True 'TIME END
                .Columns(8).Width.AutoSizeMinHeader = 60

                .Columns(9).Width.AutoSize = True 'TYPE OF FILE
                .Columns(9).Width.AutoSizeMinHeader = 80

                .Columns(10).Width.AutoSize = True 'LOCATION
                .Columns(10).Width.AutoSizeMinHeader = 80

                .Columns(11).Width.AutoSize = True 'SIZE ON DISK
                .Columns(11).Width.AutoSizeMinHeader = 100

                .Columns(12).Width.AutoSize = True 'LENGTH
                .Columns(12).Width.AutoSizeMinHeader = 60

                .Columns(13).Width.AutoSize = True 'FRAME WIDTH
                .Columns(13).Width.AutoSizeMinHeader = 60

                .Columns(14).Width.AutoSize = True 'FRAME HEIGHT
                .Columns(14).Width.AutoSizeMinHeader = 60

                .Columns(15).Width.AutoSize = True 'DATA RATE
                .Columns(15).Width.AutoSizeMinHeader = 60

                .Columns(16).Width.AutoSize = True 'TOTAL BITRATE
                .Columns(16).Width.AutoSizeMinHeader = 60

                .Columns(17).Width.AutoSize = True 'FRAME RATE
                .Columns(17).Width.AutoSizeMinHeader = 60

                .Columns(18).Width.AutoSize = True 'LAST UPDATED
                .Columns(18).Width.AutoSizeMinHeader = 60

                .EndUpdate()

            End If

        End With

    End Sub

    '--(01G)--SET values in gpInfo
    Private Sub txtDef()

        With advTree1

            '============================================================================|
            '--(01G.1)--PREP VARIABLES
            '============================================================================|
            lblIndexNo.Text = ""
            txtStatus.Text = ""
            txtCode.Text = ""
            txtName.Text = ""

            dtiStartDate.Text = ""
            dtiExpiryDate.Text = ""
            txtTimeSlot.Text = ""
            dtiStartTime.Text = ""
            dtiEndTime.Text = ""

            txtLastUpdated.Text = ""
            txtTypeOfFile.Text = ""
            txtFileName.Text = ""
            txtSizeOnDisk.Text = ""
            txtLength.Text = ""
            txtFrameWidth.Text = ""
            txtFrameHeight.Text = ""
            txtDataRate.Text = ""
            txtTotalBitrate.Text = ""
            txtFrameRate.Text = ""

            Dim videoLocation As String = ""

            '============================================================================|
            '--(01G.2)--SET VALUES
            '============================================================================|
            If .Nodes.Count <> 0 Then
                lblIndexNo.Text = .SelectedNode.Cells(0).Text.ToString
                txtStatus.Text = .SelectedNode.Cells(1).Text.ToString
                txtCode.Text = .SelectedNode.Cells(2).Text.ToString
                txtName.Text = .SelectedNode.Cells(3).Text.ToString
                dtiStartDate.Text = .SelectedNode.Cells(4).Text.ToString
                dtiExpiryDate.Text = .SelectedNode.Cells(5).Text.ToString
                txtTimeSlot.Text = .SelectedNode.Cells(6).Text.ToString
                dtiStartTime.Value = CDate(.SelectedNode.Cells(7).Text.ToString)
                dtiEndTime.Value = CDate(.SelectedNode.Cells(8).Text.ToString)
                txtTypeOfFile.Text = .SelectedNode.Cells(9).Text.ToString
                txtFileName.Text = .SelectedNode.Cells(10).Text.ToString
                txtSizeOnDisk.Text = .SelectedNode.Cells(11).Text.ToString
                txtLength.Text = .SelectedNode.Cells(12).Text.ToString
                txtFrameWidth.Text = .SelectedNode.Cells(13).Text.ToString
                txtFrameHeight.Text = .SelectedNode.Cells(14).Text.ToString
                txtDataRate.Text = .SelectedNode.Cells(15).Text.ToString
                txtTotalBitrate.Text = .SelectedNode.Cells(16).Text.ToString
                txtFrameRate.Text = .SelectedNode.Cells(17).Text.ToString
                txtLastUpdated.Text = .SelectedNode.Cells(18).Text.ToString

                videoLocation = txtFileName.Text & ""

                updateUiTimeSlot(txtTimeSlot.Text) '(03B.1)localFunc

            End If

            '============================================================================|
            '--(01G.3)--FETCH IMAGE
            '============================================================================|
            Call updateVideo(videoLocation) '(03A.4)

        End With

    End Sub

#End Region

#Region "--(02)-- Save / Update Database Functions --"

    '--(02A)--SAVE / UPDATE Record Function
    Private Sub saveUpdateRecord(ByVal btnUsed As String)

        If wmpPreview.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            wmpPreview.Ctlcontrols.stop()
            lblStatus2.Visible = True
            lblStatus2.Text = "** STOPPED **" & vbNewLine & "...CLICK TO PLAY..."
        End If

        '========================================================================================|
        '-(02A.1)- FILTER VALUES
        '========================================================================================|
        If cboStatus.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must select " & convertUpperCase(lblReq00.Text) & "."
            Call popBaloon(cboStatus, Me)
            cboStatus.Focus()
        ElseIf isInCboList(cboStatus) = False Then
            errorCap = "Attention!"
            errorMsg = "Select a registered " & convertUpperCase(lblReq00.Text) & " in list."
            Call popBaloon(cboStatus, Me)
            cboStatus.Focus()
            cboStatus.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf txtCode.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq01.Text) & "."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
        ElseIf hasDbDuplicate("AdvertisementCode", "man_Advertisement", txtCode.Text.Trim) = True And btnSave.Text <> "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq01.Text) & " Detected."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
            txtCode.SelectAll()
        ElseIf (hasDbDuplicate("AdvertisementCode", "man_Advertisement", txtCode.Text.Trim) = True And
                convertUpperCase(txtCode.Text.Trim) <> checkCode.Trim) And
            btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq01.Text) & " Detected."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
            txtCode.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf txtName.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq02.Text) & "."
            Call popBaloon(txtName, Me)
            txtName.Focus()
        ElseIf hasDbDuplicate("AdvertisementName", "man_Advertisement", txtName.Text.Trim) = True And btnSave.Text <> "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtName, Me)
            txtName.Focus()
            txtName.SelectAll()
        ElseIf (hasDbDuplicate("AdvertisementName", "man_Advertisement", txtName.Text.Trim) = True And
                convertUpperCase(txtName.Text.Trim) <> checkName.Trim) And
            btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtName, Me)
            txtName.Focus()
            txtName.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf dtiStartDate.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq03.Text) & "."
            Call popBaloon(dtiStartDate, Me)
            dtiStartDate.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf dtiExpiryDate.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq04.Text) & "."
            Call popBaloon(dtiExpiryDate, Me)
            dtiExpiryDate.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf cboTimeSlot.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must select " & convertUpperCase(lblReq05.Text) & "."
            Call popBaloon(cboTimeSlot, Me)
            cboTimeSlot.Focus()
        ElseIf isInCboList(cboTimeSlot) = False Then
            errorCap = "Attention!"
            errorMsg = "Select a registered " & convertUpperCase(lblReq05.Text) & " in list."
            Call popBaloon(cboTimeSlot, Me)
            cboTimeSlot.Focus()
            cboTimeSlot.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf dtiStartTime.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq06.Text) & "."
            Call popBaloon(dtiStartTime, Me)
            dtiStartTime.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf dtiEndTime.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq07.Text) & "."
            Call popBaloon(dtiEndTime, Me)
            dtiEndTime.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf txtFileName.Text.Trim = "" Then
            MsgBox("You must select a video file!", vbExclamation, "Cannot Save / Update!")
            '-----------------------------------------------------------------------------------|

        Else
            If btnSave.Text = "&Save" Then

                '===============================================================================|
                '-(02A.2)- SAVE
                '===============================================================================|
                If MsgBox("Are You Sure You Want to Add Record?", vbYesNo + vbQuestion) = vbYes Then

                    Dim primaryKey As String = getAdvertisementNo() '(01C)mdlSysFunc

                    '---------------------------------------------------------------------------|
                    '-(02A.2A)- SET STATUS
                    '===========================================================================|
                    Dim isActive As String = "Y"
                    If cboStatus.Text.ToUpper = "INACTIVE" Then
                        isActive = "N"
                    ElseIf cboStatus.Text.ToUpper = "EXPIRED" Then
                        isActive = "E"
                    End If

                    Dim timeSlotNo As String = getPrimaryNo("ref_ad_timeslot", "timeSlotNo", "timeSlotName", cboTimeSlot.Text)
                    Dim adStatusNo As String = getPrimaryNo("ref_ad_status", "adStatusNo", "adStatusName", cboStatus.Text)

                    '---------------------------------------------------------------------------|
                    '-(02A.2B)- SAVE to Database
                    '===========================================================================|
                    Dim tTable As String = "man_Advertisement"
                    Dim tFields As String = "" & _
                        "@AdvertisementNo,@AdvertisementCode,@AdvertisementName,@startDate,@expiryDate,@timeSlotNo,@timeSlotStart,@timeSlotEnd," & _
                        "@lastUpdated,@typeOfFile,@filename,@sizeOnDisk,@length,@frameWidth,@frameHeight,@dataRate,@totalBitrate,@frameRate,@adStatusNo"
                    Dim tValues As String = "" & _
                        primaryKey & "^" & _
                        txtCode.Text.Trim & "^" & _
                        txtName.Text.Trim & "^" & _
                        ToMySqlDate(dtiStartDate.Value) & "^" & _
                        ToMySqlDate(dtiExpiryDate.Value) & "^" & _
                        timeSlotNo & "^" & _
                        dtiStartTime.Value.ToString("hh:mm:ss") & "^" & _
                        dtiEndTime.Value.ToString("hh:mm:ss") & "^" & _
                        ToMySqlDate(DateTime.Now) & "^" & _
                        txtTypeOfFile.Text.Trim & "^" & _
                        txtFileName.Text.Trim & "^" & _
                        txtSizeOnDisk.Text.Trim & "^" & _
                        txtLength.Text.Trim & "^" & _
                        txtFrameWidth.Text.Trim & "^" & _
                        txtFrameHeight.Text.Trim & "^" & _
                        txtDataRate.Text.Trim & "^" & _
                        txtTotalBitrate.Text.Trim & "^" & _
                        txtFrameRate.Text.Trim & "^" & _
                        adStatusNo & ""
                    If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc

                        'If saveDbLogo(primaryKey, Path.GetExtension(videoFileLocation)) = True Then '(03A.2)localFunc
                        'Else
                        '    Exit Sub
                        'End If

                        MsgBox("Record Was Successfully Added.", vbInformation, "Record Added!")
                        If btnUsed = "1" Then
                            Call inputDefault() '(5)localFunc
                            btnRefresh.PerformClick()
                        Else
                            Call markLblRequired(False) '(0E)localFunc
                            Call inputAdd() '(6)localFunc
                        End If

                    Else
                        showErrorMsg(db_error_msg, "(02A.2B)" & Me.Name)
                        Exit Sub
                    End If

                End If

            ElseIf btnSave.Text = "&Update" Then

                '===============================================================================|
                '-(02A.3)- UPDATE
                '===============================================================================|
                If MsgBox("Are You Sure You Want to Update Record Information?", vbYesNo + vbQuestion) = vbYes Then

                    '---------------------------------------------------------------------------|
                    '-(02A.3A)- SET STATUS
                    '===========================================================================|
                    Dim isActive As String = "Y"
                    If cboStatus.Text.ToUpper = "INACTIVE" Then
                        isActive = "N"
                    ElseIf cboStatus.Text.ToUpper = "EXPIRED" Then
                        isActive = "E"
                    End If

                    Dim timeSlotNo As String = getPrimaryNo("ref_ad_timeslot", "timeSlotNo", "timeSlotName", cboTimeSlot.Text)
                    Dim adStatusNo As String = getPrimaryNo("ref_ad_status", "adStatusNo", "adStatusName", cboStatus.Text)

                    '---------------------------------------------------------------------------|
                    '-(02A.3B)- UPDATE Database
                    '===========================================================================|
                    Dim tTable As String = "man_Advertisement"
                    Dim tFields As String = "" & _
                        "@AdvertisementCode,@AdvertisementName,@startDate,@expiryDate,@timeSlotNo,@timeSlotStart,@timeSlotEnd," & _
                        "@lastUpdated,@typeOfFile,@filename,@sizeOnDisk,@length,@frameWidth,@frameHeight,@dataRate,@totalBitrate,@frameRate,@adStatusNo"
                    Dim tValues As String = "" & _
                        txtCode.Text.Trim & "^" & _
                        txtName.Text.Trim & "^" & _
                        ToMySqlDate(dtiStartDate.Value) & "^" & _
                        ToMySqlDate(dtiExpiryDate.Value) & "^" & _
                        timeSlotNo & "^" & _
                        dtiStartTime.Value.ToString("hh:mm:ss") & "^" & _
                        dtiEndTime.Value.ToString("hh:mm:ss") & "^" & _
                        ToMySqlDate(DateTime.Now) & "^" & _
                        txtTypeOfFile.Text.Trim & "^" & _
                        txtFileName.Text.Trim & "^" & _
                        txtSizeOnDisk.Text.Trim & "^" & _
                        txtLength.Text.Trim & "^" & _
                        txtFrameWidth.Text.Trim & "^" & _
                        txtFrameHeight.Text.Trim & "^" & _
                        txtDataRate.Text.Trim & "^" & _
                        txtTotalBitrate.Text.Trim & "^" & _
                        txtFrameRate.Text.Trim & "^" & _
                        adStatusNo & ""
                    Dim tUpdateField As String = "WHERE AdvertisementNo='" & lblIndexNo.Text & "'"

                    If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = True Then '(0D2)mdlGlobalFunc
                        MsgBox("Record Was Successfully Updated.", vbInformation, "Record Updated!")
                        Call inputDefault() '(5)localFunc
                        btnRefresh.PerformClick()
                    Else
                        showErrorMsg(db_error_msg, "(02A.3B)" & Me.Name)
                        Exit Sub
                    End If

                End If

            End If

        End If

    End Sub

    '--(02B)--DELETE Record Function
    Private Sub delRecord()

        If advTree1.Nodes.Count = 0 Then
            MsgBox("No Record(s) Found!", vbExclamation, "Cannot Delete!")
            Exit Sub
        End If

        If userAccessLevel = "Staff" Then
            MsgBox("You have limited Access Level!" & vbNewLine & "Please contact your Supervisor or System Administrator.", vbCritical, "Access Denied!")
        Else
            If MsgBox("Are You Sure You Want to Delete Selected Record?", vbYesNo + vbQuestion, "Delete Selected Record?") = vbYes Then
                Dim SQLStatement As String = "UPDATE man_advertisement SET isVisible='N' " & _
                    "WHERE advertisementNo='" & lblIndexNo.Text & " '"
                If executeMySQLquery(SQLStatement) = True Then '(6)mdlGlobalFUNC
                    MsgBox("Record Was Successfully Deleted.", vbInformation, "Record Deleted!")
                    btnRefresh.PerformClick()
                Else
                    showErrorMsg(db_error_msg, "(02B)" & Me.Name)
                End If
            End If
        End If

    End Sub

#End Region

#Region "--(03)-- Special Functions --"

#Region "--(03A)-- VIDEO Functions --"

    '--VARIABLES--
    Dim videoDefaultDir As String = My.Application.Info.DirectoryPath & "\Advertisements"
    Dim videoFileLocation As String

    '-(03A.1)- Browse for Logo
    Private Sub browseVideo()

        With OpenFileDialog1

            videoFileLocation = ""

            .Title = "Please select a Video File"
            .InitialDirectory = "C:\"
            .Filter = "Video Files|*.wmv;*.wmp;*.mp4;*.mpeg;*.mpg;*.m1v;*.mp2;*.mpa;*.mp2v;*.mpv2;"
            .FilterIndex = 0
            .FileName = ""

            If .ShowDialog = DialogResult.OK Then

                Try

                    videoFileLocation = .FileName

                    Dim objShell As Shell32.Shell
                    Dim objFolder As Shell32.Folder

                    objShell = New Shell32.Shell
                    objFolder = objShell.NameSpace(Path.GetDirectoryName(videoFileLocation))

                    If (Not objFolder Is Nothing) Then
                        Dim objFolderItem As Shell32.FolderItem
                        objFolderItem = objFolder.ParseName(Path.GetFileName(videoFileLocation))

                        If (Not objFolderItem Is Nothing) Then
                            Dim szItem As String
                            szItem = objFolder.GetDetailsOf(objFolderItem, 168)
                        End If

                        txtLastUpdated.Text = DateTime.Now
                        txtTypeOfFile.Text = objFolder.GetDetailsOf(objFolderItem, 2)
                        txtFileName.Text = videoFileLocation
                        txtSizeOnDisk.Text = objFolder.GetDetailsOf(objFolderItem, 1)
                        txtLength.Text = objFolder.GetDetailsOf(objFolderItem, 27)
                        txtFrameWidth.Text = objFolder.GetDetailsOf(objFolderItem, 301)
                        txtFrameHeight.Text = objFolder.GetDetailsOf(objFolderItem, 299)
                        txtDataRate.Text = objFolder.GetDetailsOf(objFolderItem, 298)
                        txtTotalBitrate.Text = objFolder.GetDetailsOf(objFolderItem, 303)
                        txtFrameRate.Text = objFolder.GetDetailsOf(objFolderItem, 300)

                        objFolderItem = Nothing
                    End If

                    objFolder = Nothing
                    objShell = Nothing

                Catch ex As Exception
                    showErrorMsg(ex.Message, "(03A.1)" & Me.Name)
                End Try

                Call updateVideo(videoFileLocation) '(03A.4)localFunc

            End If

        End With

    End Sub

    '-(03A.2)- Save Logo into DB
    Private Function saveVideoFile(ByVal origVideoLocation As String) As Boolean

        '=====================================================================|
        '-(03A.2A)- EXECUTE COPYING OF BACKUP
        '=====================================================================|
        Try
            Dim orgFileExt As String = Path.GetExtension(origVideoLocation)
            Dim newVideoLocation As String = videoDefaultDir & "\" & lblIndexNo.Text & orgFileExt

            Dim copyCompleted As Boolean = False

            Do Until copyCompleted
                Try
                    System.IO.File.Copy(origVideoLocation, newVideoLocation)
                    copyCompleted = True
                Catch ex As Exception
                    showErrorMsg(ex.Message, "(03A.2A1)" & Me.Name)
                    Return False
                End Try
            Loop

            Return True
        Catch ex As Exception
            showErrorMsg(ex.Message, "(03A.2A)" & Me.Name)
            Return False
        End Try

    End Function

    '-(03A.3)- Delete Logo
    Private Sub delLogo()

        ''=========================================================================|
        ''-(03A.3A)- FILTER
        ''=========================================================================|
        'If IsNothing(imgLogo.Image) = True Then
        '    MsgBox("Selected record has no existing Image!", vbInformation, "No Image found!")
        '    Exit Sub
        'ElseIf btnSaveNew.Visible = False Then
        '    If MsgBox("Are you sure you want to delete Image?", vbQuestion + vbYesNoCancel, "Delete Image?") <> vbYes Then
        '        Exit Sub
        '    End If
        'End If

        ''=========================================================================|
        ''-(03A.3B)- EXECUTE DELETE
        ''=========================================================================|
        'Dim queryStatement As String = "UPDATE man_Advertisement SET logoLocation='NULL' " & _
        '      "WHERE AdvertisementNo='" & lblIndexNo.Text & "'"

        'If executeMySQLquery(queryStatement) = True Then
        '    If btnSaveNew.Visible = False Then
        '        MsgBox("Image successfully deleted!", vbInformation, "Image Deleted!")
        '    End If
        'Else
        '    showErrorMsg(db_error_msg, "(03A.3B)" & Me.Name)
        'End If

        videoFileLocation = ""
        Call updateVideo("") '(03A.4)localFunc

    End Sub

    '-(03A.4)-updateVideo Events
    Private Sub updateVideo(ByVal fileLocation As String)

        Try

            If wmpPreview.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                wmpPreview.Ctlcontrols.stop()
                Dim plCollection As IWMPPlaylistArray = wmpPreview.playlistCollection.getAll
                If plCollection.count > 0 Then
                    Dim pl As IWMPPlaylist = plCollection.Item(0)
                    wmpPreview.playlistCollection.remove(pl)
                End If
                wmpPreview.URL = Nothing
            End If

            If fileLocation <> "" Then

                With wmpPreview
                    .URL = fileLocation
                    '.uiMode = "none"
                    .stretchToFit = True
                    .settings.setMode("loop", True)
                    .Ctlcontrols.play()
                End With

                lblStatus2.Visible = False
            Else
                wmpPreview.URL = ""

                txtLastUpdated.Text = ""
                txtTypeOfFile.Text = ""
                txtFileName.Text = ""
                txtSizeOnDisk.Text = ""
                txtLength.Text = ""
                txtFrameWidth.Text = ""
                txtFrameHeight.Text = ""
                txtDataRate.Text = ""
                txtTotalBitrate.Text = ""
                txtFrameRate.Text = ""

                lblStatus2.Visible = True
                lblStatus2.Text = "BROWSE FOR VIDEO"
            End If
        Catch ex As Exception
            lblStatus2.Visible = True
            lblStatus2.Text = "AN ERROR OCCURED: (03A.4)" & Me.Name & vbNewLine & ">" & ex.Message
        End Try

    End Sub

    '-(03A.5)- GET Logo From DB
    Private Function getDBLogoByFile(ByVal fileLocation As String) As Image

        Try

            Dim X As Image

            If My.Computer.FileSystem.FileExists(fileLocation) Then
                X = Image.FromFile(fileLocation)
            Else
                X = Nothing
            End If

            Return X

        Catch ex As Exception
            showErrorMsg(ex.Message, "(03A.5)" & Me.Name)
            Return Nothing
        Finally
            con.Close()
        End Try

    End Function

#End Region

#Region "--(03B)-- TIMESLOT Functions --"

    '-(03B.1)- UPDATE UI FOR Advertisement Type
    Private Sub updateUiTimeSlot(ByVal selectedValue As String)

        If selectedValue = "Custom..." Or selectedValue = "" Then

            With dtiStartTime
                .Text = ""
                .IsInputReadOnly = False
                .ButtonDropDown.Visible = True
                .FocusHighlightEnabled = True
                .BackColor = Color.White
            End With

            With dtiEndTime
                .Text = ""
                .IsInputReadOnly = False
                .ButtonDropDown.Visible = True
                .FocusHighlightEnabled = True
                .BackColor = Color.Azure
            End With

        Else

            With dtiStartTime
                .Text = getDbValue("SELECT timeStart FROM ref_ad_timeslot WHERE timeSlotName='" & selectedValue.Trim & "'", False)
                .IsInputReadOnly = True
                .ButtonDropDown.Visible = False
                .FocusHighlightEnabled = False
                .BackColor = Color.LightGoldenrodYellow
            End With

            With dtiEndTime
                .Text = getDbValue("SELECT timeEnd FROM ref_ad_timeslot WHERE timeSlotName='" & selectedValue.Trim & "'", False)
                .IsInputReadOnly = True
                .ButtonDropDown.Visible = False
                .FocusHighlightEnabled = False
                .BackColor = Color.Azure
            End With

        End If

    End Sub

    '-(03B.2)- UPDATE AdvertisementName
    Private Sub updateAdvertisementName()

        'Try
        '    Dim tFirst As String = txtFirst.Text
        '    Dim tMiddle As String = txtMiddle.Text
        '    Dim tLast As String = txtLast.Text

        '    If tLast <> "" And tMiddle <> "" Then
        '        txtName.Text = tLast & ", " & tFirst & " " & tMiddle.Substring(0, 1) & "."
        '    Else
        '        txtName.Text = tFirst
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

#End Region

#End Region

#End Region

#Region "-=- UI Functions -=-"

    '=-CLOSE
    Private Sub MyBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmMain.btnManAdvertisement.Checked = False
        If frmServer.Enabled = False Then
            frmServer.Enabled = True
        End If
        If bwQuery.IsBusy = True Then
            Try
                sql.Cancel()
            Catch ex As Exception
            End Try
        End If

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '=-LOAD
    Private Sub MyBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Prep Form
        Cursor.Current = Cursors.WaitCursor
        Me.KeyPreview = True
        frmMain.btnManAdvertisement.Checked = True
        gpList.Text = "List of Advertisement"
        If frmServer.Visible = True Then
            frmServer.Enabled = False
        End If

        'populate cboStatus
        Call popCbo("SELECT " & _
                       "ref_ad_status.adStatusName AS 'tValue' " & _
                       "FROM ref_ad_status " & _
                       "WHERE ref_ad_status.isVisible='Y' " & _
                       "ORDER BY ref_ad_status.adStatusNo ASC",
                       "",
                       "tValue",
                       cboStatus) '(07C)mdlGlobalFunc
        With cboStatus
            .DisplayMember = "tvalue"
            .SelectedIndex = 0
            .Refresh()
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With

        'populate cboTimeSlot
        Call popCbo("SELECT " & _
                       "ref_ad_TimeSlot.timeSlotName AS 'tValue' " & _
                       "FROM ref_ad_timeSlot " & _
                       "WHERE ref_ad_timeSlot.isVisible='Y' " & _
                       "ORDER BY ref_ad_timeSlot.timeSlotNo ASC",
                       "",
                       "tValue",
                       cboTimeSlot) '(07C)mdlGlobalFunc
        With cboTimeSlot
            .DisplayMember = "tvalue"
            .SelectedIndex = 0
            .Refresh()
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With

        ' Set view
        Call inputDefault() '(00D)LocalFUNC
        Call txtDef() '(01G)localFunc

        ' Populate
        If quickAddUsed = False Then
            Call prepBwQuery("fill") '(01A)LocalFunc
            txtSearch.Select()
        Else
            quickAddUsed = False
            btnAdd.PerformClick()
        End If

    End Sub

    '=-SHORTCUT Key Functions
    Private Sub MyBase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.KeyPreview = True
            btnClose.PerformClick()
        ElseIf (e.KeyCode = Keys.F3) Then
            Me.KeyPreview = True
            btnSearch.PerformClick()
        ElseIf (e.KeyCode = Keys.F5) Then
            Me.KeyPreview = True
            btnRefresh.PerformClick()
        End If

    End Sub

#Region "-- SPECIAL FUNCTIONS"

    Private Sub wmpPreview_ClickEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles wmpPreview.ClickEvent
        'If wmpPreview.URL <> "" Then
        '    If wmpPreview.playState = WMPLib.WMPPlayState.wmppsPlaying Then
        '        wmpPreview.Ctlcontrols.pause()
        '        'lblStatus2.Visible = True
        '        'lblStatus2.Text = "** PAUSED **" & vbNewLine & "...CLICK TO PLAY..."
        '    Else
        '        wmpPreview.Ctlcontrols.play()
        '        'lblStatus2.Visible = False
        '    End If
        'End If
    End Sub

    Private Sub wmpPreview_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wmpPreview.Enter

    End Sub

    '=-cboTimeSlot Functions
    Private Sub cboTimeSlot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTimeSlot.SelectedIndexChanged
        If cboTimeSlot.Visible = True Then
            updateUiTimeSlot(sender.text) '(03B.1)localFunc
        End If
    End Sub

    '=-Image Functions
    Private Sub btnLogoBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVidBrowse.Click
        Call browseVideo() '(03A.1)localFunc
    End Sub
    Private Sub btnLogoDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVidDelete.Click
        Call delLogo() '(03A.3)localFunc
    End Sub

#End Region

#Region "-- DEFAULT OBJECTS"

    '=-txtSearch Function
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSearch.PerformClick()
        End If
    End Sub

    '=-btnSearch Function
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If advTree1.Enabled = True Then
            Call prepBwQuery("search") '(01A)LocalFunc
        End If
    End Sub

    '=-btnRefresh Function
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call refreshList() '(0D)localFunc
    End Sub

    '=-btnExpand Function
    Private Sub btnExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpand.Click
        If btnExpand.Text = "Expand >|" Then
            Call collapseView(False, gpList, gpInfo, btnExpand, txtSearch, Me.Width) '(03)mdlDefFrmFunc
        Else
            Call collapseView(True, gpList, gpInfo, btnExpand, txtSearch, Me.Width) '(03)mdlDefFrmFunc
        End If
    End Sub

    '=-btnAdd Function
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call inputAdd() '(6)LocalFUNC
    End Sub

    '=-btnEdit FUnction
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call inputEdit() '(7)LocalFUNC
    End Sub

    '=-btnDelete Function
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call delRecord() '(10)localFunc
    End Sub

    '=-btnSaveNew Function
    Private Sub btnSaveNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNew.Click
        Call saveUpdateRecord("2") '(9)LocalFunc
    End Sub

    '=-btnSave Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call saveUpdateRecord("1") '(9)LocalFunc
    End Sub

    '=-btnCancel Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call inputDefault() '(00D)LocalFunc
        Call txtDef() '(8)LocalFunc
        If btnAddused = True Then
            btnRefresh.PerformClick()
            btnAddused = False
        End If
    End Sub

    '=-advTree1 Function
    Private Sub advTree1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advTree1.SelectionChanged
        If advTree1.Enabled = True Then
            Call txtDef() '(8)localFunc
        End If
    End Sub
    Private Sub advTree1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles advTree1.DoubleClick
        If advTree1.Nodes.Count <> 0 Then
            btnEdit.PerformClick()
        End If
    End Sub

#End Region

#Region "-- PAGINATION OBJECTS"

    '=-btnNextPage Function
    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextPage.Click
        currentPage = currentPage + 1
        If currentPage > PageCount Then
            currentPage = PageCount
            If recNo = maxRec Then 'Check if you are already at the last page.
                'MessageBox.Show("You are at the Last Page!")
                Return
            End If
        End If
        Call LoadPage() '(2C)LocalFunc
    End Sub

    '=-btnPreviousPage Function
    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousPage.Click
        currentPage = currentPage - 1
        If currentPage < 1 Then
            'MessageBox.Show("You are at the First Page!")
            currentPage = 1
            Return
        Else
            recNo = pageSize * (currentPage - 1)
        End If

        Call LoadPage() '(2C)LocalFunc
    End Sub

    '=-btnFirstPage Function
    Private Sub btnFirstPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstPage.Click
        If currentPage = 1 Then
            'MessageBox.Show("You are at the First Page!")
            Return
        End If

        currentPage = 1
        recNo = 0

        Call LoadPage() '(2C)LocalFunc
    End Sub

    '=-btnLastPage Function
    Private Sub btnLastPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastPage.Click
        If recNo = maxRec Then
            'MessageBox.Show("You are at the Last Page!")
            Return
        End If

        currentPage = PageCount

        recNo = pageSize * (currentPage - 1)

        Call LoadPage() '(2C)LocalFunc
    End Sub
#End Region

#End Region

End Class