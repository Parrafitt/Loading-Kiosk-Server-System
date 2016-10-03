Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports System.IO

Public Class frmManNetwork

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
            lblReq01.Text = "* " & lblReq01.Text
            lblReq02.Text = "* " & lblReq02.Text
        Else
            lblReq01.Text = stripCharOfString(lblReq01.Text, "* ").Trim
            lblReq02.Text = stripCharOfString(lblReq02.Text, "* ").Trim
        End If
    End Sub

    '--(00D)--DEFAULT input
    Private Sub inputDefault()

        Me.SuspendLayout()

        gpList.Visible = False
        gpInfo.Visible = False
        gpInfo.Text = "Network's Information"

        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSaveNew.Visible = False
        btnSave.Visible = False
        btnSave.Text = "&Save"
        btnCancel.Visible = False

        Call markLblRequired(False) '(0E)localFunc

        'Item Attributes
        txtCode.ReadOnly = True
        txtName.ReadOnly = True
        txtPrefix.ReadOnly = True

        txtCode.FocusHighlightEnabled = False
        txtName.FocusHighlightEnabled = False
        txtPrefix.FocusHighlightEnabled = False

        txtCode.BackColor = Color.LightGoldenrodYellow
        txtName.BackColor = Color.LightGoldenrodYellow
        txtPrefix.BackColor = Color.LightGoldenrodYellow

        btnLogoBrowse.Visible = False
        btnLogoDelete.Visible = False

        lblPrefix.Visible = False
        txtPrefix.Visible = False
        btnPrefixAdd.Visible = False
        btnPrefixEdit.Visible = False
        btnPrefixDel.Visible = False

        gpList.Visible = True
        gpInfo.Visible = True
        Call collapseView(True, gpList, gpInfo, btnExpand, txtSearch, Me.Width) '(03)mdlDefFrmFunc

        Me.ResumeLayout()
        txtSearch.Select()

    End Sub

    '--(00E)--ADD input
    Private Sub inputAdd()

        Me.SuspendLayout()

        btnAddused = True
        checkCode = ""
        checkName = ""

        gpList.Visible = False
        gpInfo.Visible = False
        gpInfo.Text = "Add New Network"
        gpInfo.Width = (gpInfo.Left + gpInfo.Width) - gpList.Left
        gpInfo.Left = gpList.Left

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSaveNew.Visible = True
        btnSave.Visible = True
        btnSave.Text = "&Save"
        btnCancel.Visible = True

        Call markLblRequired(True) '(0E)localFunc

        'Item Attributes
        lblIndexNo.Text = getNextPrimaryNo("networkNo", "man_network", 2, False, "") '(00)mdlSystemFunc

        imgLogo.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources._network180x
        imgLogo.BackColor = Color.White

        txtCode.Text = ""
        txtName.Text = ""
        txtPrefix.Text = ""

        AdvTree2.Nodes.Clear()

        txtCode.ReadOnly = False
        txtName.ReadOnly = False

        txtCode.FocusHighlightEnabled = True
        txtName.FocusHighlightEnabled = True

        txtCode.BackColor = Color.White
        txtName.BackColor = Color.White

        btnLogoBrowse.Visible = True
        btnLogoDelete.Visible = True

        execPrefix = ""
        Call exePrefixList() '(03B.2)localFunc

        gpInfo.Visible = True

        Me.ResumeLayout()
        txtCode.Select()

    End Sub

    '--(00F)--EDIT input
    Public Sub inputEdit()

        If advTree1.Nodes.Count = 0 Then
            MsgBox("No Record(s) Found!", vbExclamation, "Cannot Edit!")
            Exit Sub
        End If

        Me.SuspendLayout()

        checkCode = convertUpperCase(txtCode.Text)
        checkName = convertUpperCase(txtName.Text)

        gpList.Visible = False
        gpInfo.Visible = False
        gpInfo.Text = "Edit Network's Information"
        gpInfo.Width = (gpInfo.Left + gpInfo.Width) - gpList.Left
        gpInfo.Left = gpList.Left

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Visible = True
        btnSave.Text = "&Update"
        btnCancel.Visible = True
        gpInfo.Visible = True

        Call markLblRequired(True) '(0E)localFunc

        'Item Attributes
        txtCode.ReadOnly = False
        txtName.ReadOnly = False
        txtPrefix.ReadOnly = False

        txtCode.FocusHighlightEnabled = True
        txtName.FocusHighlightEnabled = True
        txtPrefix.FocusHighlightEnabled = True

        txtCode.BackColor = Color.White
        txtName.BackColor = Color.White
        txtPrefix.BackColor = Color.White

        btnLogoBrowse.Visible = True
        btnLogoDelete.Visible = True

        execPrefix = ""
        Call exePrefixList() '(03B.2)localFunc

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

            lblStatus2.Text = "Loading, Please Wait . . . "
            AdvTree2.Enabled = False
            cp2.Visible = True
            cp2.IsRunning = True
            lblStatusEvent(lblStatus2, cp2, False) '(00G)localFUnc

            btnRefresh.Tooltip = "Cancel"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc

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

        AdvTree2.Enabled = True

        If e.Cancelled = True Then

            gpMainList.Text = "PROCESS CANCELLED !"
            lblStatus.Text = "Process Cancelled !"
            lblStatus.Visible = True
            lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

            lblStatus2.Text = "Process Cancelled !"
            lblStatus2.Visible = True
            lblStatusEvent(lblStatus2, cp2, True) '(00G)localFUnc

        ElseIf e.Error IsNot Nothing Then

            gpMainList.Text = "PROCESS CANCELLED !"
            lblStatus.Text = "An Error Occured: frmManNetwork(01B)" & vbNewLine & e.Error.Message
            lblStatus.Visible = True
            lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

            lblStatus2.Text = "<h5>Process Cancelled ! </h5>"
            lblStatus2.Visible = True
            lblStatusEvent(lblStatus2, cp2, True) '(00G)localFUnc

        Else

            If errorMsg = "" Then

                cp1.Visible = False
                cp1.IsRunning = False
                lblStatus.Visible = False

                cp2.Visible = False
                cp2.IsRunning = False
                lblStatus2.Visible = False

                If IsNothing(dtDisplay) Then

                    gpMainList.Text = "No Record(s) Found !"
                    lblStatus.Text = "NO RECORD(S) FOUND !"
                    lblStatus.Visible = True
                    lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

                    lblDisplayPageNo.Text = "Page 0 of 0"

                    lblStatus2.Text = "NO RECORD(S) FOUND !"
                    lblStatus2.Visible = True
                    lblStatusEvent(lblStatus2, cp2, True) '(00G)localFUnc

                Else

                    gpMainList.Text = "Displaying " & CStr(startRec + 1) & " to " & endRec.ToString & " of " & maxRec.ToString & " Record(s) . . . "
                    lblDisplayPageNo.Text = "Page " & currentPage.ToString & " of " & PageCount.ToString

                End If

            Else

                gpMainList.Text = "AN ERROR OCCURED !"
                lblStatus.Text = errorMsg
                lblStatusEvent(lblStatus, cp1, True) '(00G)localFUnc

                lblStatus2.Text = "Process Cancelled !"
                lblStatusEvent(lblStatus2, cp2, True) '(00G)localFUnc

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
                               "man_Network.NetworkNo AS '# ', " & _
                               "man_Network.NetworkCode AS 'NETWORK CODE', " & _
                               "man_Network.NetworkName AS 'NETWORK NAME', " & _
                               "man_Network.prefixList AS 'PREFIX' " & _
                               "FROM man_Network " & _
                               "WHERE man_Network.isVisible='Y' ORDER BY man_Network.NetworkName ASC", con)
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
        Me.BeginInvoke(CallLoadPage) '(01E)LocalFunc

    End Sub

    '--(01D)--SEARCH DatasetS
    Private Sub searchDS()

        Try
            With ds
                If searchFor = "" Then
                    .Tables(0).DefaultView.RowFilter = ""
                Else
                    .Tables(0).DefaultView.RowFilter = "" & _
                    "[NETWORK CODE] LIKE '%" & cleanStringForDB(searchFor) & "%' OR " & _
                    "[NETWORK NAME] LIKE '%" & cleanStringForDB(searchFor) & "%'"
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

        Me.BeginInvoke(CallLoadPage) '(01E)LocalFunc

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

        'Me.BeginInvoke(CallFillAdvTree) '(01F)LocalFunc
        CallFillAdvTree()

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
                .Columns(0).Visible = False
                .Columns(1).Width.AutoSize = True
                .Columns(1).Width.AutoSizeMinHeader = 100
                .Columns(2).Width.AutoSize = True
                .Columns(2).Width.AutoSizeMinHeader = 100
                .Columns(3).Visible = False
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
            txtCode.Text = ""
            txtName.Text = ""
            Dim tempList As String = ""

            '============================================================================|
            '--(01G.2)--SET VALUES
            '============================================================================|
            If .Nodes.Count <> 0 Then
                lblIndexNo.Text = .SelectedNode.Cells(0).Text.ToString
                txtCode.Text = .SelectedNode.Cells(1).Text.ToString
                txtName.Text = .SelectedNode.Cells(2).Text.ToString
                tempList = .SelectedNode.Cells(3).Text.ToString.Trim
            End If

            '============================================================================|
            '--(01G.3)--FILL SUB LIST
            '============================================================================|
            Call fillPrefixList(tempList) '(03B.1)localFunc

            '============================================================================|
            '--(01G.4)--FETCH IMAGE
            '============================================================================|
            Call updateLogo() '(03A.4)localFunc

        End With

    End Sub

#End Region

#Region "--(02)-- Save / Update Database Functions --"

    '--(02A)--SAVE / UPDATE Record Function
    Private Sub saveUpdateRecord(ByVal btnUsed As String)

        '========================================================================================|
        '-(02A.1)- FILTER VALUES
        '========================================================================================|
        If txtCode.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq01.Text) & "."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
        ElseIf hasDbDuplicate("networkCode", "man_network", txtCode.Text.Trim) = True And btnSave.Text <> "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq01.Text) & " Detected."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
            txtCode.SelectAll()
        ElseIf (hasDbDuplicate("networkCode", "man_network", txtCode.Text.Trim) = True And
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
        ElseIf hasDbDuplicate("networkName", "man_network", txtName.Text.Trim) = True And btnSave.Text <> "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtName, Me)
            txtName.Focus()
            txtName.SelectAll()
        ElseIf (hasDbDuplicate("networkName", "man_network", txtName.Text.Trim) = True And
                convertUpperCase(txtName.Text.Trim) <> checkName.Trim) And
            btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtName, Me)
            txtName.Focus()
            txtName.SelectAll()
            '-----------------------------------------------------------------------------------|

        Else
            If btnSave.Text = "&Save" Then

                '===============================================================================|
                '-(02A.2)- SAVE
                '===============================================================================|
                If MsgBox("Are You Sure You Want to Add Record?", vbYesNo + vbQuestion) = vbYes Then

                    Dim primaryKey As String = getNextPrimaryNo("networkNo", "man_network", 2, False, "")

                    '---------------------------------------------------------------------------|
                    '-(02A.2A)- GET Prefix List
                    '===========================================================================|
                    Dim tPrefixList As String = ""
                    Try
                        With AdvTree2
                            If .Nodes.Count > 0 Then
                                For x = 0 To .Nodes.Count - 1
                                    If x > 0 Then
                                        tPrefixList += "," & .Nodes(x).Cells(1).Text.ToString
                                    Else
                                        tPrefixList = .Nodes(x).Cells(1).Text.ToString
                                    End If
                                Next
                            End If
                        End With
                    Catch ex As Exception
                        showErrorMsg(ex.Message, "(02A.2A)" & Me.Name)
                        Exit Sub
                    End Try

                    '---------------------------------------------------------------------------|
                    '-(02A.2B)- SAVE to Database
                    '===========================================================================|
                    Dim tTable As String = "man_network"
                    Dim tFields As String = "" & _
                        "@networkNo,@networkCode,@networkName,@prefixList"
                    Dim tValues As String = "" & _
                        primaryKey & "^" & _
                        txtCode.Text.Trim & "^" & _
                        txtName.Text.Trim & "^" & _
                        tPrefixList.Trim & ""
                    If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc

                        If saveDbLogo(primaryKey, Path.GetExtension(imgFileExt)) = True Then '(03A.2)localFunc

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
                    '-(02A.3A)- GET Prefix List
                    '===========================================================================|
                    Dim tPrefixList As String = ""
                    Try
                        With AdvTree2
                            If .Nodes.Count > 0 Then
                                For x = 0 To .Nodes.Count - 1
                                    If x > 0 Then
                                        tPrefixList += "," & .Nodes(x).Cells(1).Text.ToString
                                    Else
                                        tPrefixList = .Nodes(x).Cells(1).Text.ToString
                                    End If
                                Next
                            End If
                        End With
                    Catch ex As Exception
                        showErrorMsg(ex.Message, "(02A.3A)" & Me.Name)
                        Exit Sub
                    End Try

                    '---------------------------------------------------------------------------|
                    '-(02A.3B)- UPDATE Database
                    '===========================================================================|
                    Dim tTable As String = "man_network"
                    Dim tFields As String = "" & _
                        "@networkCode,@networkName,@prefixList"
                    Dim tValues As String = "" & _
                        txtCode.Text.Trim & "^" & _
                        txtName.Text.Trim & "^" & _
                        tPrefixList.Trim & ""
                    Dim tUpdateField As String = "WHERE NetworkNo='" & lblIndexNo.Text & "'"

                    If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = True Then '(0D2)mdlGlobalFunc

                        If imgFileExt <> "" Then
                            If saveDbLogo(lblIndexNo.Text, Path.GetExtension(imgFileExt)) = False Then '(03A.2)localFunc
                                Exit Sub
                            End If
                        End If

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
                Dim SQLStatement As String = "UPDATE man_network SET isVisible='N' " & _
                    "WHERE networkNo='" & lblIndexNo.Text & " '"
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
    Dim imgFileExt As String

    '-(03A.1)- Browse for Logo
    Private Sub browseLogo(ByVal primaryKey As String)

        With OpenFileDialog1

            imgFileExt = ""

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
                    imgLogo.Image = resized
                    imgFileExt = .FileName

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
        Dim queryStatement As String = "UPDATE man_network SET logo='NULL' " & _
              "WHERE networkNo='" & lblIndexNo.Text & "'"

        If executeMySQLquery(queryStatement) = True Then
            If btnSaveNew.Visible = False Then
                MsgBox("Image successfully deleted!", vbInformation, "Image Deleted!")
            End If
        Else
            showErrorMsg(db_error_msg, "(03A.3B)" & Me.Name)
        End If

        Call updateLogo() '(03A.4)localFunc

    End Sub

    '-(03A.4)-updateLogo Events
    Private Sub updateLogo()

        Try

            imgLogo.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources._network180x
            imgLogo.BackColor = Color.White
            Dim X As Image = getDBLogo(lblIndexNo.Text) '(03A.5)localFunc
            If IsNothing(X) = False Then
                X = ResizeImage(X, New Size(imgLogo.Width - 2, imgLogo.Height - 2))
                imgLogo.Image = X
            End If

        Catch ex As Exception
            showErrorMsg(ex.Message, "(03A.4)" & Me.Name)
        End Try

    End Sub

    '-(03A.5)- GET Logo From DB
    Private Function getDBLogo(ByVal primaryKey As String) As Image

        Try

            Call connectDB()

            Dim Query As String = "SELECT logo FROM man_network WHERE networkNo = '" & primaryKey & "'"
            con.Open()
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
            adapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(Query, con)

            Dim Data As New DataTable
            Dim commandbuild As New MySql.Data.MySqlClient.MySqlCommandBuilder(adapter)
            adapter.Fill(Data)

            If Data.Rows.Count = 0 Then
                Return Nothing
            End If

            Dim lb() As Byte = Data.Rows(Data.Rows.Count - 1).Item("Logo")
            Dim lstr As New System.IO.MemoryStream(lb)
            Dim X As Image = Image.FromStream(lstr)
            lstr.Close()

            Return X

        Catch ex As Exception
            showErrorMsg(ex.Message, "(03A.5)" & Me.Name)
            Return Nothing
        Finally
            con.Close()
        End Try

    End Function

#End Region

#Region "--(03B)-- Prefix List Functions --"

    '--VARIABLES--
    Dim execPrefix As String
    Dim prefixSelectedRowIndex As Integer

    '-(03B.1)- FILL Prefix List
    Private Sub fillPrefixList(ByVal tPrefixList As String)

        AdvTree2.DataSource = Nothing
        AdvTree2.Nodes.Clear()

        If tPrefixList <> "" Then

            dtPrefixList = New DataTable
            dtPrefixList.Columns.Add("INDEX", GetType(String)) '0
            dtPrefixList.Columns.Add("PREFIX", GetType(String)) '1
            dtPrefixList.AcceptChanges()

            If tPrefixList.Contains(",") Then

                Dim prefixItm() As String = Split(tPrefixList, ",")
                Dim ctrIndex As Integer = 0
                For Each itm As String In prefixItm
                    ctrIndex += 1
                    dtPrefixList.Rows.Add(ctrIndex, itm)
                    dtPrefixList.AcceptChanges()
                Next

            Else
                dtPrefixList.Rows.Add(tPrefixList)
                dtPrefixList.AcceptChanges()
            End If

            With AdvTree2

                .DataSource = dtPrefixList

                .Columns(0).Text = "#"
                .Columns(0).Width.Absolute = 40
                .Columns(0).CellsBackColor = Color.Azure

                .Columns(1).Text = "PREFIX"
                .Columns(1).Width.Absolute = 100
                .Columns(1).CellsBackColor = Color.LightGoldenrodYellow

            End With

        End If

    End Sub

    '-(03B.2)- EXECUTE Prefix List Command
    Private Sub exePrefixList()

        Select Case execPrefix

            Case "Add"

                '========================================================|
                '-(03B.2A)- ADD -Layout
                '========================================================|
                With txtPrefix
                    .Text = ""
                    .ReadOnly = False
                    .FocusHighlightEnabled = True
                    .BackColor = Color.White
                    .Focus()
                End With
                AdvTree2.Enabled = False
                btnPrefixAdd.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.yes
                btnPrefixAdd.Tooltip = "OK"
                btnPrefixEdit.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.cancel
                btnPrefixEdit.Tooltip = "CANCEL"
                btnPrefixDel.Visible = False

            Case "Edit"

                '========================================================|
                '-(03B.2B)- EDIT -Layout
                '========================================================|
                AdvTree2.Enabled = False
                btnPrefixAdd.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.yes
                btnPrefixAdd.Tooltip = "OK"
                btnPrefixEdit.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.cancel
                btnPrefixEdit.Tooltip = "CANCEL"
                btnPrefixDel.Visible = False
                With txtPrefix
                    .ReadOnly = False
                    .FocusHighlightEnabled = True
                    .BackColor = Color.White
                    .Focus()
                    .SelectAll()
                End With

            Case "AddItm"

                '========================================================|
                '-(03B.2C)- ADD ITEM
                '========================================================|
                If okPrefix(txtPrefix) = False Then
                    Exit Sub
                End If

                dtPrefixList.Rows.Add(AdvTree2.Nodes.Count + 1, txtPrefix.Text)
                dtPrefixList.AcceptChanges()

                AdvTree2.DataSource = dtPrefixList

                If cp2.Visible = True Then
                    cp2.Visible = False
                    lblStatus2.Visible = False
                End If

                execPrefix = ""
                Call exePrefixList()

            Case "EditItm"

                '========================================================|
                '-(03B.2D)- EDIT ITEM
                '========================================================|
                If okPrefix(txtPrefix) = False Then
                    Exit Sub
                End If

                dtPrefixList.Rows(prefixSelectedRowIndex).Item(1) = txtPrefix.Text
                dtPrefixList.AcceptChanges()

                AdvTree2.DataSource = dtPrefixList

                execPrefix = ""
                Call exePrefixList()

            Case "DelItm"

                '========================================================|
                '-(03B.2E)- DELETE ITEM
                '========================================================|
                If AdvTree2.Nodes.Count = 0 Then
                    MsgBox("List is empty!", vbExclamation, "Cannot Delete!")
                    Exit Sub
                ElseIf MsgBox("Are you sure you want to delete item?" & vbNewLine & "> " & txtPrefix.Text, vbQuestion + vbYesNoCancel, "Delete Item?") <> vbYes Then
                    Exit Sub
                End If

                dtPrefixList.Rows(prefixSelectedRowIndex).Delete()
                dtPrefixList.AcceptChanges()

                If dtPrefixList.Rows.Count = 0 Then
                    cp2.Visible = True
                    lblStatus2.Text = "NO RECORD(S) FOUND !"
                    lblStatus2.Visible = True
                    lblStatusEvent(lblStatus2, cp2, True) '(00G)localFUnc
                Else
                    For x = 0 To dtPrefixList.Rows.Count - 1
                        dtPrefixList.Rows(x).Item(0) = x + 1
                        dtPrefixList.AcceptChanges()
                    Next
                End If

                AdvTree2.DataSource = dtPrefixList

                execPrefix = ""
                Call exePrefixList()

            Case Else

                '========================================================|
                '-(03B.2F)- DEFAULT -Layout
                '========================================================|
                lblPrefix.Visible = True
                With txtPrefix
                    .Visible = True
                    .Text = ""
                    .ReadOnly = True
                    .FocusHighlightEnabled = False
                    .BackColor = Color.LightGoldenrodYellow
                End With

                AdvTree2.Enabled = True

                btnPrefixAdd.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.add
                btnPrefixAdd.Tooltip = "ADD"
                btnPrefixEdit.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.edit
                btnPrefixEdit.Tooltip = "EDIT"

                btnPrefixAdd.Visible = True
                btnPrefixEdit.Visible = True
                btnPrefixDel.Visible = True

        End Select

    End Sub

    '-(03B.3)- SET values in Advtree
    Private Sub txtDef2()

        With AdvTree2

            txtPrefix.Text = ""
            If .Nodes.Count <> 0 And IsNothing(.SelectedNode) = False Then
                txtPrefix.Text = .SelectedNode.Cells(1).Text.ToString
                prefixSelectedRowIndex = .SelectedNode.Index
            End If

        End With

    End Sub

    '-(03B.4)- CHECK PREFIX
    Private Function okPrefix(ByVal prefix As DevComponents.DotNetBar.Controls.TextBoxX) As Boolean

        okPrefix = True
        Try

            Dim number As Integer

            If prefix.Text.Length <> 4 Then 'CHECK character length

                errorCap = "Attention!"
                errorMsg = "Prefixes should be 4 characters long (ex. 0911)"
                popBaloon(prefix, Me)
                prefix.Focus()
                prefix.SelectAll()
                Return False

            ElseIf Integer.TryParse(prefix.Text, number) = False Then 'CHECK if numeric

                errorCap = "Attention!"
                errorMsg = "Prefixes should be Numeric."
                popBaloon(prefix, Me)
                prefix.Focus()
                prefix.SelectAll()
                Return False

            End If

            For x = 0 To AdvTree2.Nodes.Count - 1

                If prefix.Text = AdvTree2.Nodes(x).Cells(1).Text Then 'CHECK for duplicate

                    errorCap = "Attention!"
                    errorMsg = "Entered prefix already exists!"
                    popBaloon(prefix, Me)
                    prefix.Focus()
                    prefix.SelectAll()
                    Return False

                End If

            Next

        Catch ex As Exception
            Return False
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

        ' Set view
        Call inputDefault() '(00D)LocalFUNC
        Call txtDef() '(01G)localFunc

        ' Populate
        If quickAddUsed = False Then
            Call prepBwQuery("fill") '(01A)LocalFunc
        Else
            quickAddUsed = False
            btnAdd.PerformClick()
        End If

        txtSearch.Select()

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

    '=-Prefix List Functions
    Private Sub btnPrefixAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrefixAdd.Click

        If AdvTree2.Enabled = True Then
            execPrefix = "Add"
        Else
            If execPrefix.Contains("Edit") Then
                execPrefix = "EditItm"
            Else
                execPrefix = "AddItm"
            End If
        End If

        Call exePrefixList() '(03B)LocalFunc

    End Sub
    Private Sub btnPrefixEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrefixEdit.Click
        If AdvTree2.Enabled = True Then
            If execPrefix <> "Edit" Then
                execPrefix = "Edit"
            Else
                execPrefix = "EditItm"
            End If
        Else
            execPrefix = ""
        End If
        Call exePrefixList() '(03B)LocalFunc
    End Sub
    Private Sub btnPrefixDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrefixDel.Click
        execPrefix = "DelItm"
        Call exePrefixList() '(03B)LocalFunc
    End Sub

    '=-AdvTree2 Function
    Private Sub AdvTree2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvTree2.SelectionChanged
        If AdvTree2.Enabled = True Then
            Call txtDef2() '(8)localFunc
        End If
    End Sub
    Private Sub AdvTree2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvTree2.DoubleClick
        If AdvTree2.Nodes.Count <> 0 Then
            btnPrefixEdit.PerformClick()
        End If
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