Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports System.IO

Public Class frmManItem

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

        cboType.Location = txtType.Location
        cboType.Size = txtType.Size

        cboNetwork.Location = txtNetwork.Location
        cboNetwork.Size = txtNetwork.Size

        cboPackage.Location = txtPackage.Location
        cboPackage.Size = txtPackage.Size

        cboValidityUnit.Location = txtValidityUnit.Location
        cboValidityUnit.Size = txtValidityUnit.Size

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
            lblReq04.Text = "* " & lblReq04.Text
            lblReq05.Text = "* " & lblReq05.Text
            lblReq03.Text = "* " & lblReq03.Text
            lblReq06.Text = "* " & lblReq06.Text
            lblReq07.Text = "* " & lblReq07.Text
            lblReq08.Text = "* " & lblReq08.Text
            lblReq09.Text = "* " & lblReq09.Text
        Else
            lblReq00.Text = stripCharOfString(lblReq00.Text, "* ").Trim
            lblReq01.Text = stripCharOfString(lblReq01.Text, "* ").Trim
            lblReq02.Text = stripCharOfString(lblReq02.Text, "* ").Trim
            lblReq04.Text = stripCharOfString(lblReq04.Text, "* ").Trim
            lblReq05.Text = stripCharOfString(lblReq05.Text, "* ").Trim
            lblReq03.Text = stripCharOfString(lblReq03.Text, "* ").Trim
            lblReq06.Text = stripCharOfString(lblReq06.Text, "* ").Trim
            lblReq07.Text = stripCharOfString(lblReq07.Text, "* ").Trim
            lblReq08.Text = stripCharOfString(lblReq08.Text, "* ").Trim
            lblReq09.Text = stripCharOfString(lblReq09.Text, "* ").Trim
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
        gpInfo.Text = "Item's Information"

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

        txtType.Visible = True
        cboType.Visible = False

        With txtDescription
            .ReadOnly = True
            .FocusHighlightEnabled = False
            .BackColor = Color.LightGoldenrodYellow
        End With

        '============================================================|
        '-(00D.4)-SET DETAILS 2
        '============================================================|
        txtNetwork.Visible = True
        cboNetwork.Visible = False

        txtPackage.Visible = True
        cboPackage.Visible = False

        '============================================================|
        '-(00D.5)-SET DETAILS 3
        '============================================================|
        With txtCost
            .ReadOnly = True
            .FocusHighlightEnabled = False
            .BackColor = Color.LightGoldenrodYellow
        End With

        With txtPrice
            .ReadOnly = True
            .FocusHighlightEnabled = False
            .BackColor = Color.LightGoldenrodYellow
        End With

        With iiValidity
            .Enabled = False
            .ShowUpDown = False
            .FocusHighlightEnabled = False
            .DisabledForeColor = Color.Black
            .DisabledBackColor = Color.LightGoldenrodYellow
        End With

        txtValidityUnit.Visible = True
        cboValidityUnit.Visible = False

        '============================================================|
        '-(00D.6)-SET IMAGE
        '============================================================|
        btnLogoBrowse.Visible = False
        btnLogoDelete.Visible = False

        '============================================================|
        '-(00D.7)-RESUME LAYOUT
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
            .Text = "Add New Item"
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

        lblIndexNo.Text = getNextPrimaryNo("itmNo", "man_item", 2, False, "") '(00)mdlSystemFunc

        txtStatus.Visible = False
        With cboStatus
            .SelectedIndex = 1
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        With txtCode
            .Text = ""
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

        txtType.Visible = False
        With cboType
            .Text = ""
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        With txtDescription
            .Text = ""
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        '============================================================|
        '-(00E.4)-SET DETAILS 2
        '============================================================|
        txtNetwork.Visible = False
        With cboNetwork
            .Text = ""
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        txtPackage.Visible = False
        With cboPackage
            .Text = ""
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        '============================================================|
        '-(00E.4)-SET DETAILS 3
        '============================================================|
        With txtPrice
            .Text = ""
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        With txtCost
            .Text = ""
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        With iiValidity
            .Text = ""
            .Enabled = True
            .ShowUpDown = True
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        txtValidityUnit.Visible = False
        With cboValidityUnit
            .Text = ""
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        '============================================================|
        '-(00E.5)-SET IMAGE
        '============================================================|
        With imgLogo
            .Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources._product180x
            .BackColor = Color.White
        End With
        btnLogoBrowse.Visible = True
        btnLogoDelete.Visible = True

        '============================================================|
        '-(00E.6)-RESUME LAYOUT
        '============================================================|
        gpInfo.Visible = True
        Me.ResumeLayout()

        txtCode.Focus()
        txtCode.Select()

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
            .Text = "Edit Item's Information"
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

        With txtDescription
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        '============================================================|
        '-(00F.5)-SET DETAILS 2
        '============================================================|
        txtNetwork.Visible = False
        With cboNetwork
            .Text = txtNetwork.Text
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        txtPackage.Visible = False
        With cboPackage
            .Text = txtPackage.Text
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        '============================================================|
        '-(00F.6)-SET DETAILS 3
        '============================================================|
        With txtPrice
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        With txtCost
            .ReadOnly = False
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        With iiValidity
            .Enabled = True
            .ShowUpDown = True
            .FocusHighlightEnabled = True
            .BackColor = Color.White
        End With

        txtValidityUnit.Visible = False
        With cboValidityUnit
            .Text = txtValidityUnit.Text
            .FocusHighlightEnabled = True
            .Visible = True
        End With

        '============================================================|
        '-(00F.7)-SET IMAGE
        '============================================================|
        btnLogoBrowse.Visible = True
        btnLogoDelete.Visible = True

        '============================================================|
        '-(00F.8)-RESUME LAYOUT
        '============================================================|
        gpInfo.Visible = True
        Me.ResumeLayout()

        txtCode.Focus()
        txtCode.SelectAll()

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
            advTree1.Enabled = False
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            cp1.Visible = True
            cp1.IsRunning = True
            lblStatusEvent(lblStatus, cp1, False) '(00G)localFUnc

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
            lblStatus.Text = "An Error Occured: frmManNetwork(01B)" & vbNewLine & e.Error.Message
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
                               "man_item.itmNo AS '#', " & _
                               "man_item.itmCode AS 'CODE', " & _
                               "man_item.itmName AS 'ITEM', " & _
                               "man_item.description AS 'DESCRIPTION', " & _
                               "ref_itm_type.itmTypeName AS 'TYPE', " & _
                               "man_network.networkName AS 'NETWORK', " & _
                               "ref_itm_package.packageName AS 'PACKAGE', " & _
                               "man_item.price AS 'PRICE', " & _
                               "man_item.cost AS 'COST', " & _
                               "CONCAT(man_item.validity, ' / ',man_item.validityUnit) AS 'VALIDITY', " & _
                               "man_item.logoLocation AS 'LOGO', " & _
                               "man_item.isActive AS 'STATUS' " & _
                               "FROM man_item " & _
                               "LEFT JOIN ref_itm_type ON ref_itm_type.itmTypeNo=man_item.itmTypeNo " & _
                               "LEFT JOIN man_network ON man_network.networkNo=man_item.networkNo " & _
                               "LEFT JOIN ref_itm_package ON ref_itm_package.packageNo=man_item.packageNo " & _
                               "WHERE man_item.isVisible='Y' ORDER BY man_item.itmName ASC", con)
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
                    "[ITEM] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[TYPE] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[NETWORK] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[PACKAGE] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[PRICE] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[COST] LIKE '%" & cleanStringForDB(searchFor) & "%'"
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

                .Columns(1).Width.AutoSize = True 'CODE
                .Columns(1).Width.AutoSizeMinHeader = 50

                .Columns(2).Width.AutoSize = True 'ITEM
                .Columns(2).Width.AutoSizeMinHeader = 100

                .Columns(3).Width.AutoSize = True 'TYPE
                .Columns(3).Width.AutoSizeMinHeader = 100

                .Columns(4).Width.AutoSize = True 'NETWORK
                .Columns(4).Width.AutoSizeMinHeader = 100

                .Columns(5).Width.AutoSize = True 'PACKAGE
                .Columns(5).Width.AutoSizeMinHeader = 100

                .Columns(6).Width.AutoSize = True 'PRICE
                .Columns(6).Width.AutoSizeMinHeader = 60

                .Columns(7).Width.AutoSize = True 'COST
                .Columns(7).Width.AutoSizeMinHeader = 60

                .Columns(8).Visible = False 'LOGO

                .Columns(9).Width.AutoSize = True  'STATUS
                .Columns(9).Width.AutoSizeMinHeader = 60

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
            txtType.Text = ""
            txtDescription.Text = ""
            txtNetwork.Text = ""
            txtPackage.Text = ""
            txtCost.Text = ""
            txtPrice.Text = ""
            iiValidity.Text = ""
            txtValidityUnit.Text = ""

            Dim logoLocation As String = ""

            '============================================================================|
            '--(01G.2)--SET VALUES
            '============================================================================|
            If .Nodes.Count <> 0 Then
                lblIndexNo.Text = .SelectedNode.Cells(0).Text.ToString
                txtCode.Text = .SelectedNode.Cells(1).Text.ToString
                txtName.Text = .SelectedNode.Cells(2).Text.ToString
                txtDescription.Text = .SelectedNode.Cells(3).Text.ToString
                txtType.Text = .SelectedNode.Cells(4).Text.ToString
                txtNetwork.Text = .SelectedNode.Cells(5).Text.ToString
                txtPackage.Text = .SelectedNode.Cells(6).Text.ToString
                txtPrice.Text = .SelectedNode.Cells(7).Text.ToString
                txtCost.Text = .SelectedNode.Cells(8).Text.ToString

                Dim tempValidity As String = .SelectedNode.Cells(9).Text.ToString
                If tempValidity.Contains("/") Then
                    Dim temp() As String = Split(tempValidity, "/")
                    iiValidity.Text = temp(0).ToString.Trim
                    txtValidityUnit.Text = temp(1).ToString.Trim
                End If

                logoLocation = .SelectedNode.Cells(10).Text.ToString

                If .SelectedNode.Cells(11).Text.ToString = "Y" Then
                    txtStatus.Text = "ACTIVE"
                Else
                    txtStatus.Text = "INACTIVE"
                End If

            End If

            '============================================================================|
            '--(01G.3)--FETCH IMAGE
            '============================================================================|
            Call updateLogo(logoLocation) '(03A.4)

        End With

    End Sub

#End Region

#Region "--(02)-- Save / Update Database Functions --"

    '--(02A)--SAVE / UPDATE Record Function
    Private Sub saveUpdateRecord(ByVal btnUsed As String)

        '========================================================================================|
        '-(02A.1)- FILTER VALUES
        '========================================================================================|
        If cboStatus.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq00.Text) & "."
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
        ElseIf hasDbDuplicate("itmCode", "man_item", txtCode.Text.Trim) = True And btnSave.Text <> "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq01.Text) & " Detected."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
            txtCode.SelectAll()
        ElseIf (hasDbDuplicate("itmCode", "man_item", txtCode.Text.Trim) = True And
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
        ElseIf hasDbDuplicate("itmName", "man_item", txtName.Text.Trim) = True And btnSave.Text <> "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtName, Me)
            txtName.Focus()
            txtName.SelectAll()
        ElseIf (hasDbDuplicate("itmName", "man_item", txtName.Text.Trim) = True And
                convertUpperCase(txtName.Text.Trim) <> checkName.Trim) And
            btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtName, Me)
            txtName.Focus()
            txtName.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf cboType.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq03.Text) & "."
            Call popBaloon(cboType, Me)
            cboType.Focus()
        ElseIf isInCboList(cboType) = False Then
            errorCap = "Attention!"
            errorMsg = "Select a registered " & convertUpperCase(lblReq03.Text) & " in list."
            Call popBaloon(cboType, Me)
            cboType.Focus()
            cboType.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf txtDescription.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq04.Text) & "."
            Call popBaloon(txtDescription, Me)
            txtDescription.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf cboNetwork.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq05.Text) & "."
            Call popBaloon(cboNetwork, Me)
            cboNetwork.Focus()
        ElseIf isInCboList(cboNetwork) = False Then
            errorCap = "Attention!"
            errorMsg = "Select a registered " & convertUpperCase(lblReq05.Text) & " in list."
            Call popBaloon(cboNetwork, Me)
            cboNetwork.Focus()
            cboNetwork.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf cboPackage.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq06.Text) & "."
            Call popBaloon(cboPackage, Me)
            cboPackage.Focus()
        ElseIf isInCboList(cboPackage) = False Then
            errorCap = "Attention!"
            errorMsg = "Select a registered " & convertUpperCase(lblReq06.Text) & " in list."
            Call popBaloon(cboPackage, Me)
            cboPackage.Focus()
            cboPackage.SelectAll()
            '-----------------------------------------------------------------------------------|

        ElseIf txtPrice.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq07.Text) & "."
            Call popBaloon(txtPrice, Me)
            txtPrice.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf txtCost.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq08.Text) & "."
            Call popBaloon(txtCost, Me)
            txtCost.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf iiValidity.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq09.Text) & "."
            Call popBaloon(iiValidity, Me)
            iiValidity.Focus()
            '-----------------------------------------------------------------------------------|

        ElseIf cboValidityUnit.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must select " & convertUpperCase(lblReq09.Text) & "."
            Call popBaloon(cboValidityUnit, Me)
            cboValidityUnit.Focus()
            '-----------------------------------------------------------------------------------|

        Else
            If btnSave.Text = "&Save" Then

                '===============================================================================|
                '-(02A.2)- SAVE
                '===============================================================================|
                If MsgBox("Are You Sure You Want to Add Record?", vbYesNo + vbQuestion) = vbYes Then

                    Dim primaryKey As String = getNextPrimaryNo("itmNo", "man_item", 2, False, "")

                    '---------------------------------------------------------------------------|
                    '-(02A.2A)- SET STATUS
                    '===========================================================================|
                    Dim isActive As String = "Y"
                    If cboStatus.Text = "INACTIVE" Then
                        isActive = "N"
                    End If

                    '---------------------------------------------------------------------------|
                    '-(02A.2B)- SAVE to Database
                    '===========================================================================|
                    Dim tTable As String = "man_item"
                    Dim tFields As String = "" & _
                        "@itmNo,@itmCode,@itmName,@itmTypeNo,@description,@networkNo,@packageNo,@cost,@price,@validity,@validityUnit,@logoLocation,@isActive"
                    Dim tValues As String = "" & _
                        primaryKey & "^" & _
                        txtCode.Text.Trim & "^" & _
                        txtName.Text.Trim & "^" & _
                        getPrimaryNo("ref_itm_type", "itmTypeNo", "itmTypeName", cboType.Text.Trim) & "^" & _
                        txtDescription.Text.Trim & "^" & _
                        getPrimaryNo("man_network", "networkNo", "networkName", cboNetwork.Text.Trim) & "^" & _
                        getPrimaryNo("ref_itm_package", "packageNo", "packageName", cboPackage.Text.Trim) & "^" & _
                        txtCost.Text.Trim.Replace(",", "") & "^" & _
                        txtPrice.Text.Trim.Replace(",", "") & "^" & _
                        iiValidity.Text.Trim & "^" & _
                        cboValidityUnit.Text.Trim & "^" & _
                        imgFileLocation & "^" & _
                        isActive & ""
                    If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc

                        If saveDbLogo(primaryKey, Path.GetExtension(imgFileLocation)) = True Then '(03A.2)localFunc

                            MsgBox("Record Was Successfully Added.", vbInformation, "Record Added!")
                            If btnUsed = "1" Then
                                Call inputDefault() '(5)localFunc
                                btnRefresh.PerformClick()
                            Else
                                Call markLblRequired(False) '(0E)localFunc
                                Call inputAdd() '(6)localFunc
                            End If

                        Else
                            Exit Sub
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
                    If cboStatus.Text = "INACTIVE" Then
                        isActive = "N"
                    End If

                    '---------------------------------------------------------------------------|
                    '-(02A.3B)- UPDATE Database
                    '===========================================================================|
                    Dim tTable As String = "man_item"
                    Dim tFields As String = "" & _
                        "@itmCode,@itmName,@itmTypeNo,@description,@networkNo,@packageNo,@cost,@price,@validity,@validityUnit,@logoLocation,@isActive"
                    Dim tValues As String = "" & _
                        txtCode.Text.Trim & "^" & _
                        txtName.Text.Trim & "^" & _
                        getPrimaryNo("ref_itm_type", "itmTypeNo", "itmTypeName", cboType.Text.Trim) & "^" & _
                        txtDescription.Text.Trim & "^" & _
                        getPrimaryNo("man_network", "networkNo", "networkName", cboNetwork.Text.Trim) & "^" & _
                        getPrimaryNo("ref_itm_package", "packageNo", "packageName", cboPackage.Text.Trim) & "^" & _
                        txtCost.Text.Trim.Replace(",", "") & "^" & _
                        txtPrice.Text.Trim.Replace(",", "") & "^" & _
                        iiValidity.Text.Trim & "^" & _
                        cboValidityUnit.Text.Trim & "^" & _
                        imgFileLocation & "^" & _
                        isActive & ""
                    Dim tUpdateField As String = "WHERE itmNo='" & lblIndexNo.Text & "'"

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
                Dim SQLStatement As String = "UPDATE man_itm SET isVisible='N' " & _
                    "WHERE itmNo='" & lblIndexNo.Text & " '"
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

#Region "--(03A)-- Logo Functions --"

    '--VARIABLES--
    Dim imgFileLocation As String

    '-(03A.1)- Browse for Logo
    Private Sub browseLogo(ByVal primaryKey As String)

        With OpenFileDialog1

            imgFileLocation = ""

            .Title = "Please select an image File"
            .InitialDirectory = "C:\"
            .Filter = "(Image Files)|*.jpeg;*.jpg;*.png;*.bmp;|JPEG Files (.jpeg) | *.jpg|JPG Files (.jpg) | *.jpg|PNG Files (.png)| *.png|BMP Files (.bmp)| *.bmp"
            .FilterIndex = 0
            .FileName = ""

            If .ShowDialog = DialogResult.OK Then

                Try

                    Dim original As Image = System.Drawing.Bitmap.FromFile(.FileName)
                    Dim resized As Image = ResizeImage(original, New Size(imgLogo.Width - 5, imgLogo.Height - 5)) '(05D)mdlGlboalFunc

                    imgLogo.BackColor = Color.White
                    If original.Width > resized.Width - 5 Or original.Height > resized.Height - 5 Then
                        imgLogo.Image = resized
                    Else
                        imgLogo.Image = original
                    End If
                    imgFileLocation = .FileName

                Catch ex As Exception
                    showErrorMsg(ex.Message, "(03A.1)" & Me.Name)
                End Try

                'Call updateLogo() '(03A.4)localFunc

            End If

        End With

    End Sub

    '-(03A.2)- Save Logo into DB
    Private Function saveDbLogo(ByVal networkNo As String, ByVal picFormat As String) As Boolean

        saveDbLogo = True

        Try

            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream()

            If picFormat = ".jpg" Or picFormat = ".jpeg" Then
                imgLogo.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf picFormat = ".png" Then
                imgLogo.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
            End If
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()

            Dim queryStatement As String = "INSERT INTO man_network " & _
                   "(networkNo,logo) VALUES(@networkNo,@File) " & _
                   "ON DUPLICATE KEY UPDATE networkNo=@networkNo, logo=@File"

            Try
                Call connectDB() '(00A)mdlGlobalFunc
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(queryStatement, con)
                With cmd
                    .Parameters.AddWithValue("@networkNo", networkNo)
                    .Parameters.AddWithValue("@File", arrImage)
                    .ExecuteNonQuery()
                End With
                con.Close()
            Catch ex As Exception
                saveDbLogo = False
                showErrorMsg(ex.Message, "(03A.2)" & Me.Name)
            Finally
                con.Close()
            End Try

        Catch ex As Exception
            saveDbLogo = False
            showErrorMsg(ex.Message, "(03A.2)" & Me.Name)
        End Try

    End Function

    '-(03A.3)- Delete Logo
    Private Sub delLogo()

        '=========================================================================|
        '-(03A.3A)- FILTER
        '=========================================================================|
        If IsNothing(imgLogo.Image) = True Then
            MsgBox("Selected record has no existing Image!", vbInformation, "No Image found!")
            Exit Sub
        ElseIf btnSaveNew.Visible = False Then
            If MsgBox("Are you sure you want to delete Image?", vbQuestion + vbYesNoCancel, "Delete Image?") <> vbYes Then
                Exit Sub
            End If
        End If

        '=========================================================================|
        '-(03A.3B)- EXECUTE DELETE
        '=========================================================================|
        Dim queryStatement As String = "UPDATE man_item SET logoLocation='NULL' " & _
              "WHERE itmNo='" & lblIndexNo.Text & "'"

        If executeMySQLquery(queryStatement) = True Then
            If btnSaveNew.Visible = False Then
                MsgBox("Image successfully deleted!", vbInformation, "Image Deleted!")
            End If
        Else
            showErrorMsg(db_error_msg, "(03A.3B)" & Me.Name)
        End If

        imgFileLocation = ""
        Call updateLogo("") '(03A.4)localFunc

    End Sub

    '-(03A.4)-updateLogo Events
    Private Sub updateLogo(ByVal fileLocation As String)

        Try

            imgLogo.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources._product180x
            imgLogo.BackColor = Color.White
            Dim X As Image = getDBLogoByFile(fileLocation) '(03A.5)localFunc
            If IsNothing(X) = False Then

                If X.Width > imgLogo.Width - 2 Or X.Height > imgLogo.Height - 2 Then
                    X = ResizeImage(X, New Size(imgLogo.Width - 2, imgLogo.Height - 2))
                End If
                imgLogo.Image = X
            End If

        Catch ex As Exception
            showErrorMsg(ex.Message, "(03A.4)" & Me.Name)
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

#End Region

#End Region

#Region "-=- UI Functions -=-"

    '=-CLOSE
    Private Sub MyBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        frmMain.btnManNetwork.Checked = False
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
        frmMain.btnManNetwork.Checked = True
        gpList.Text = "List of Networks"
        If frmServer.Visible = True Then
            frmServer.Enabled = False
        End If

        'populate cboType
        Call popCbo("SELECT " & _
                       "ref_itm_type.itmTypeName AS 'tValue' " & _
                       "FROM ref_itm_type " & _
                       "WHERE ref_itm_type.isVisible='Y' " & _
                       "ORDER BY ref_itm_type.itmTypeNo ASC",
                       "",
                       "tValue",
                       cboType) '(07C)mdlGlobalFunc
        With cboType
            .DisplayMember = "tvalue"
            .SelectedIndex = 0
            .Refresh()
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With

        'populate cboNetwork
        Call popCbo("SELECT " & _
                       "man_network.networkName AS 'tValue' " & _
                       "FROM man_network " & _
                       "WHERE man_network.isVisible='Y' " & _
                       "ORDER BY man_network.networkName ASC",
                       "",
                       "tValue",
                       cboNetwork) '(07C)mdlGlobalFunc
        With cboNetwork
            .DisplayMember = "tvalue"
            .SelectedIndex = 0
            .Refresh()
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With

        'populate cboPackage
        Call popCbo("SELECT " & _
                       "ref_itm_package.PackageName AS 'tValue' " & _
                       "FROM ref_itm_package " & _
                       "WHERE ref_itm_package.isVisible='Y' " & _
                       "ORDER BY ref_itm_package.PackageName ASC",
                       "",
                       "tValue",
                       cboPackage) '(07C)mdlGlobalFunc
        With cboPackage
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
    Private Sub frmManClassifier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

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

    '=-Image Functions
    Private Sub btnLogoBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogoBrowse.Click
        Call browseLogo(lblIndexNo.Text) '(03A.1)localFunc
    End Sub
    Private Sub btnLogoDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogoDelete.Click
        Call delLogo() '(03A.3)localFunc
    End Sub

    '=-txtCost Functions
    Private Sub txtCost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.Click
        If txtCost.ReadOnly = False Then
            txtCost.SelectAll()
        End If
    End Sub
    Private Sub txtCost_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.LostFocus
        Call checkAmountValue(txtCost, Me, True) '(11)mdlDefFrmFunc
    End Sub
    Private Sub txtCost_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.TextChanged
        Call checkAmountValue(txtCost, Me, False) '(11)mdlDefFrmFunc
    End Sub
    Private Sub txtCost_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.GotFocus
        Call checkAmountValue(txtCost, Me, True) '(11)mdlDefFrmFunc
    End Sub

    '=-txtPrice Functions
    Private Sub txtPrice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.Click
        If txtPrice.ReadOnly = False Then
            txtPrice.SelectAll()
        End If
    End Sub
    Private Sub txtPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.LostFocus
        Call checkAmountValue(txtPrice, Me, True) '(11)mdlDefFrmFunc
    End Sub
    Private Sub txtPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        Call checkAmountValue(txtPrice, Me, False) '(11)mdlDefFrmFunc
    End Sub
    Private Sub txtPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.GotFocus
        Call checkAmountValue(txtPrice, Me, True) '(11)mdlDefFrmFunc
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