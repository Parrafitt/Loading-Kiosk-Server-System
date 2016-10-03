Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class frmManMachine

#Region "-=- Local Functions -=-"

    'local variables
    Dim checkCode As String = ""
    Dim checkName As String = ""
    Dim checkSN As String = ""

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
                txtSearch.Text = ""
                Call prepBwQuery() '(1A)LocalFunc
            End If
        Else
            If bwQuery.IsBusy = True Then
                Try
                    sql.Cancel()
                Catch ex As Exception
                End Try
            End If
            advTree1.Enabled = True
            advTree1.Nodes.Clear()
            gpItemList.Text = "No Record(s) Found!"
            lblDisplayPageNo.Text = "Page 0 to 0"
            lblNoRecords.Visible = True
            btnRefresh.Enabled = True
            btnFirstPage.Enabled = True
            btnNextPage.Enabled = True
            btnPreviousPage.Enabled = True
            btnLastPage.Enabled = True
            cp1.Visible = False
            cp1.IsRunning = False
            btnRefresh.Tooltip = "Refresh"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc
        End If
    End Sub

    '--(00C)--lblRequired Events
    Private Sub markLblRequired(ByVal mark As Boolean)
        If mark = True Then
            lblReq01.Text = "* " & lblReq01.Text
            lblReq02.Text = "* " & lblReq02.Text
        Else
            lblReq01.Text = stripCharOfString(lblReq01.Text, "*").Trim
            lblReq02.Text = stripCharOfString(lblReq02.Text, "*").Trim
        End If
    End Sub

    '--(00D)--DEFAULT input
    Private Sub inputDefault()

        Me.SuspendLayout()

        gpList.Visible = False
        gpInfo.Visible = False
        gpInfo.Text = "MACHINE'S INFORMATION"

        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSaveNew.Visible = False
        btnSave.Visible = False
        btnSave.Text = "&Save"
        btnCancel.Visible = False

        Call markLblRequired(False) '(0E)localFunc

        'Item Attributes
        txtMachCode.ReadOnly = True
        txtMachName.ReadOnly = True
        txtSN.ReadOnly = True

        txtMachCode.FocusHighlightEnabled = False
        txtMachName.FocusHighlightEnabled = False
        txtSN.FocusHighlightEnabled = False

        txtMachCode.BackColor = Color.LightGoldenrodYellow
        txtMachName.BackColor = Color.LightGoldenrodYellow
        txtSN.BackColor = Color.LightGoldenrodYellow

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
        gpInfo.Text = "ADD NEW MACHINE"
        gpInfo.Width = (gpInfo.Left + gpInfo.Width) - gpList.Left
        gpInfo.Left = gpList.Left

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSaveNew.Visible = True
        btnSave.Visible = True
        btnSave.Text = "&Save"
        btnCancel.Visible = True
        gpInfo.Visible = True

        Call markLblRequired(True) '(0E)localFunc

        'Item Attributes
        lblIndexNo.Text = getMachNo() '(01A)mdlSysFunc
        txtMachCode.Text = lblIndexNo.Text
        txtMachName.Text = ""
        txtSN.Text = ""

        txtMachCode.ReadOnly = False
        txtMachName.ReadOnly = False
        txtSN.ReadOnly = False

        txtMachCode.FocusHighlightEnabled = True
        txtMachName.FocusHighlightEnabled = True
        txtSN.FocusHighlightEnabled = True

        txtMachCode.BackColor = Color.White
        txtMachName.BackColor = Color.White
        txtSN.BackColor = Color.White

        gpInfo.Visible = True

        Me.ResumeLayout()
        txtMachName.Select()

    End Sub

    '--(00F)--EDIT input
    Private Sub inputEdit()

        If advTree1.Nodes.Count = 0 Then
            MsgBox("No Record(s) Found!", vbExclamation, "Cannot Edit!")
            txtSearch.Focus()
            Exit Sub
        End If

        Me.SuspendLayout()

        checkCode = convertUpperCase(txtMachCode.Text)
        checkName = convertUpperCase(txtMachName.Text)

        gpList.Visible = False
        gpInfo.Visible = False
        gpInfo.Text = "EDIT MACHINE'S INFORMATION"
        gpInfo.Width = (gpInfo.Left + gpInfo.Width) - gpList.Left
        gpInfo.Left = gpList.Left

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Visible = True
        btnSave.Text = "&Update"
        btnCancel.Visible = True

        Call markLblRequired(True) '(0E)localFunc

        'Item Attributes
        txtMachCode.ReadOnly = False
        txtMachName.ReadOnly = False
        txtSN.ReadOnly = False

        txtMachCode.FocusHighlightEnabled = True
        txtMachName.FocusHighlightEnabled = True
        txtSN.FocusHighlightEnabled = True

        txtMachCode.BackColor = Color.White
        txtMachName.BackColor = Color.White
        txtSN.BackColor = Color.White

        gpInfo.Visible = True

        Me.ResumeLayout()

        txtMachName.Focus()
        txtMachName.SelectAll()

    End Sub

    '--(00G)--UPDATE OBJECT DISPLAY
    Private Sub updateObjectDisplay(ByVal tTextBox As DevComponents.DotNetBar.Controls.TextBoxX)

        Me.SuspendLayout()
        With tTextBox
            If .Text = "ON" Then
                .ForeColor = Color.Black
                .BackColor = Color.Lime
            ElseIf .Text = "OFF" Then
                .ForeColor = Color.White
                .BackColor = Color.Red
            Else
                .ForeColor = Color.Black
                .BackColor = Color.Azure
            End If
            GroupBox1.Focus()
            .Focus()
        End With
        Me.ResumeLayout()

    End Sub

#End Region

#Region "--(01)-- Data Fetching and Display Functions --"

    '--(01A)--Prep for bwQuery
    Private Sub prepBwQuery()
        If bwQuery.IsBusy <> True Then
            gpItemList.Text = "Loading Records, Please Wait . . . "
            lblDisplayPageNo.Text = ""
            advTree1.Enabled = False
            btnFirstPage.Enabled = False
            btnNextPage.Enabled = False
            btnPreviousPage.Enabled = False
            btnLastPage.Enabled = False
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            cp1.Visible = True
            cp1.IsRunning = True
            btnRefresh.Tooltip = "Cancel"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc
            bwQuery.RunWorkerAsync() '(01B)LocalFunc
        End If
    End Sub

    '--(01B)--bwQuery Function
    Private Sub bwQuery_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwQuery.DoWork
        If (bwQuery.CancellationPending = True) Then
            e.Cancel = True
        Else
            Call fillDS() '(01C)LocalFunc
        End If
    End Sub
    Private Sub bwQuery_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwQuery.RunWorkerCompleted
        If e.Cancelled = True Then
            'Cancelled
        ElseIf e.Error IsNot Nothing Then
            MsgBox(e.Error.Message)
        Else
            advTree1.Enabled = True
            btnRefresh.Enabled = True
            btnFirstPage.Enabled = True
            btnNextPage.Enabled = True
            btnPreviousPage.Enabled = True
            btnLastPage.Enabled = True
            btnAdd.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            cp1.Visible = False
            cp1.IsRunning = False
            btnRefresh.Tooltip = "Refresh"
            Call btnRefreshIco(Me.btnRefresh) '(01)mdlDefFrmFunc 
        End If
        Call txtDef() '(01G)LocalFunc
        txtSearch.Focus()
    End Sub

    '--(01C)--FILL Dataset DS
    Private Sub fillDS()
        Cursor.Current = Cursors.WaitCursor

        Call connectDB()
        sql = New MySqlCommand("SELECT " & _
                               "man_machine.machNo AS '#_', " & _
                               "man_machine.machCode AS 'CODE_', " & _
                               "man_machine.machName AS 'MACHINE_', " & _
                               "man_machine.serialNo AS 'SERIAL NO', " & _
                               "man_machine.simNo AS 'SIM NO', " & _
                               "man_machine.firmwareVer AS 'FIRMWARE_', " & _
                               "man_machine.softwareVer AS 'SOFTWARE_', " & _
                               "ref_mach_status.machStatName AS 'status' " & _
                               "FROM man_machine " & _
                               "LEFT JOIN ref_mach_status ON ref_mach_status.machStat = man_machine.machStat " & _
                               "WHERE man_machine.isVisible='Y' ORDER BY man_machine.machName ASC", con)
        ds = New DataSet()
        Try
            con.Open()
            myReader = sql.ExecuteReader
            ds.Load(myReader, LoadOption.Upsert, "table1")
            con.Close()
        Catch myerror As MySqlException
            If myerror.Number.ToString <> "1317" Then
                MsgBox("An Error Occured: (01C)" & Me.Name & vbNewLine & "> " & myerror.Message, vbExclamation, "Attention!")
            End If
            Exit Sub
        Finally
            con.Dispose()
        End Try

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

        Me.BeginInvoke(CallLoadPage) '(01E)LocalFunc
        Cursor.Current = Cursors.Default
    End Sub

    '--(01D)--SEARCH DatasetS
    Private Sub searchDS()
        Cursor.Current = Cursors.WaitCursor

        Try
            With ds
                If txtSearch.Text = "" Then
                    .Tables(0).DefaultView.RowFilter = ""
                Else
                    .Tables(0).DefaultView.RowFilter = "" & _
                    "[#_] LIKE '%" & cleanStringForDB(txtSearch.Text) & "%' OR " & _
                    "[CODE_] LIKE '%" & cleanStringForDB(txtSearch.Text) & "%' OR " & _
                    "[MACHINE_] LIKE '%" & cleanStringForDB(txtSearch.Text) & "%' OR " & _
                    "[SERIAL NO] LIKE '%" & cleanStringForDB(txtSearch.Text) & "%' OR " & _
                    "[SIM NO] LIKE '%" & cleanStringForDB(txtSearch.Text) & "%' OR " & _
                    "[FIRMWARE_] LIKE '%" & cleanStringForDB(txtSearch.Text) & "%' OR " & _
                    "[SOFTWARE_] LIKE '%" & cleanStringForDB(txtSearch.Text) & "%'"
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
            MsgBox("An Error Occured: (01D)" & Me.Name & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
        End Try

        Me.BeginInvoke(CallLoadPage) '(01E)LocalFunc
        txtSearch.Focus()
        Cursor.Current = Cursors.Default
    End Sub

    '--(01E)--LoadPage Function
    Dim CallLoadPage As New MethodInvoker(AddressOf Me.LoadPage)
    Private Sub LoadPage()
        Dim i As Integer

        If ds.Tables(0).DefaultView.Count <> 0 Then
            'Duplicate or clone the source table to create the temporary table.
            dtDisplay = ds.Tables(0).Clone
            dtDisplay.Constraints.Clear()

            If currentPage = PageCount Then
                endRec = maxRec
            Else
                endRec = pageSize * currentPage
            End If

            startRec = recNo
            gpItemList.Text = "Displaying " & CStr(startRec + 1) & " to " & endRec.ToString & " of " & maxRec.ToString & " Record(s) . . . "

            'Copy the rows from the source table to fill the temporary table.
            For i = startRec To endRec - 1
                dtDisplay.ImportRow(ds.Tables(0).DefaultView(i).Row)
                recNo = recNo + 1
            Next
        Else
            dtDisplay = Nothing
        End If

        Me.BeginInvoke(CallFillDataGridView) '(01F)LocalFunc
        lblDisplayPageNo.Text = "Page " & currentPage.ToString & " of " & PageCount.ToString
    End Sub

    '--(01F)--FillDataGridView THREAD
    Dim CallFillDataGridView As New MethodInvoker(AddressOf Me.FillDataGridView)
    Public Sub FillDataGridView()
        With advTree1
            .Nodes.Clear()
            .DataSource = Nothing
            If IsNothing(dtDisplay) = False Then
                lblNoRecords.Visible = False
                .DataSource = dtDisplay
                .BeginUpdate()
                .Columns(0).Visible = False 'machNo
                .Columns(1).Width.AutoSize = True 'machCode
                .Columns(1).Width.AutoSizeMinHeader = 80
                .Columns(2).Width.AutoSize = True 'machName
                .Columns(2).Width.AutoSizeMinHeader = 100
                .Columns(3).Width.AutoSize = True 'serialNo
                .Columns(3).Width.AutoSizeMinHeader = 100
                .Columns(4).Width.AutoSize = True 'simNo
                .Columns(4).Width.AutoSizeMinHeader = 70
                .Columns(5).Width.AutoSize = True 'firmwareVer
                .Columns(5).Width.AutoSizeMinHeader = 70
                .Columns(6).Width.AutoSize = True 'softwareVer
                .Columns(6).Width.AutoSizeMinHeader = 70
                .Columns(7).Visible = False 'status
                .EndUpdate()
            Else
                lblNoRecords.Visible = True
                gpItemList.Text = "No Record(s) Found"
            End If
        End With
    End Sub

    '--(01G)--SET values in gpInfo
    Private Sub txtDef()
        With advTree1
            If .Nodes.Count = 0 Then
                lblIndexNo.Text = ""
                txtMachCode.Text = ""
                txtMachName.Text = ""
                txtStatus.Text = ""
                txtSN.Text = ""
                txtSimNo.Text = ""
                txtFirmVer.Text = ""
                txtSoftVer.Text = ""
            Else
                lblIndexNo.Text = .SelectedNode.Cells(0).Text.ToString
                txtMachCode.Text = .SelectedNode.Cells(1).Text.ToString
                txtMachName.Text = .SelectedNode.Cells(2).Text.ToString
                txtSN.Text = .SelectedNode.Cells(3).Text.ToString
                txtSimNo.Text = .SelectedNode.Cells(4).Text.ToString
                txtFirmVer.Text = .SelectedNode.Cells(5).Text.ToString
                txtSoftVer.Text = .SelectedNode.Cells(6).Text.ToString
                txtStatus.Text = .SelectedNode.Cells(7).Text.ToString
            End If
            getMachineStatus() '(03A)localFunc
            getfranchiseeInfo() '(03C)localFunc
        End With
    End Sub

#End Region

#Region "--(02)-- Save / Update Database Functions --"

    '--(02A)--SAVE / UPDATE Record Function
    Private Sub saveUpdateRecord(ByVal btnUsed As String)

        '-----------------------------------------------------------------------------------------------------|
        '-(02A.1)- FILTER VALUES
        '=====================================================================================================|
        If txtMachCode.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq01.Text) & "."
            Call popBaloon(txtMachCode, Me)
            txtMachCode.Focus()
        ElseIf hasDbDuplicate("machCode", "man_machine", txtMachCode.Text.Trim) = True And btnSave.Text = "&Save" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq01.Text) & " Detected."
            Call popBaloon(txtMachCode, Me)
            txtMachCode.Focus()
            txtMachCode.SelectAll()
        ElseIf (hasDbDuplicate("machCode", "man_machine", txtMachCode.Text.Trim) = True And convertUpperCase(txtMachCode.Text.Trim) <> checkCode.Trim) And btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq01.Text) & " Detected."
            Call popBaloon(txtMachCode, Me)
            txtMachCode.Focus()
            txtMachCode.SelectAll()
            '-------------------------------------------------------------------------------------------------|

        ElseIf txtMachName.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq02.Text) & "."
            Call popBaloon(txtMachName, Me)
            txtMachName.Focus()
        ElseIf hasDbDuplicate("machCode", "man_machine", txtMachName.Text.Trim) = True And btnSave.Text = "&Save" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtMachName, Me)
            txtMachName.Focus()
            txtMachName.SelectAll()
        ElseIf (hasDbDuplicate("machCode", "man_machine", txtMachName.Text.Trim) = True And convertUpperCase(txtMachName.Text.Trim) <> checkCode.Trim) And btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq02.Text) & " Detected."
            Call popBaloon(txtMachName, Me)
            txtMachName.Focus()
            txtMachName.SelectAll()
            '-------------------------------------------------------------------------------------------------|

        ElseIf txtSN.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter " & convertUpperCase(lblReq03.Text) & "."
            Call popBaloon(txtSN, Me)
            txtSN.Focus()
        ElseIf hasDbDuplicate("serialNo", "man_machine", txtSN.Text.Trim) = True And btnSave.Text = "&Save" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq03.Text) & " Detected."
            Call popBaloon(txtSN, Me)
            txtSN.Focus()
            txtSN.SelectAll()
        ElseIf (hasDbDuplicate("serialNo", "man_machine", txtSN.Text.Trim) = True And convertUpperCase(txtSN.Text.Trim) <> checkSN.Trim) And btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate " & convertUpperCase(lblReq03.Text) & " Detected."
            Call popBaloon(txtSN, Me)
            txtSN.Focus()
            txtSN.SelectAll()
            '-------------------------------------------------------------------------------------------------|

        Else
            If btnSave.Text = "&Save" Then

                '---------------------------------------------------------------------------------------------|
                '-(02A.2)- SAVE
                '=============================================================================================|
                If MsgBox("Are You Sure You Want to Add Record?", vbYesNo + vbQuestion) = vbYes Then

                    Dim tTable As String = "man_machine"
                    Dim tFields As String = "" & _
                        "@machNo,@machCode,@machName,@serialNo"
                    Dim tValues As String = "" & _
                        getMachNo() & "^" & _
                        txtMachCode.Text.Trim & "^" & _
                        txtMachName.Text.Trim & "^" & _
                        txtSN.Text.Trim & "" '(01A)mdlSysFunc
                    If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc
                        MsgBox("Record Was Successfully Added.", vbInformation, "Record Added!")
                        If btnUsed = "1" Then
                            Call inputDefault() '(5)localFunc
                            btnRefresh.PerformClick()
                        Else
                            Call markLblRequired(False) '(0E)localFunc
                            Call inputAdd() '(6)localFunc
                        End If
                    Else
                        showErrorMsg(db_error_msg, "(02A.2)" & Me.Name)
                    End If

                End If

            ElseIf btnSave.Text = "&Update" Then
                
                '---------------------------------------------------------------------------------------------|
                '-(02A.3)- UPDATE
                '=============================================================================================|
                If MsgBox("Are You Sure You Want to Update Record Information?", vbYesNo + vbQuestion) = vbYes Then

                    Dim tTable As String = "man_machine"
                    Dim tFields As String = "" & _
                        "@machCode,@machName,@serialNo"
                    Dim tValues As String = "" & _
                        txtMachCode.Text.Trim & "^" & _
                        txtMachName.Text.Trim & "^" & _
                        txtSN.Text.Trim & ""
                    Dim tUpdateField As String = "WHERE machNo='" & lblIndexNo.Text & "'"

                    If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = True Then '(0D2)mdlGlobalFunc
                        MsgBox("Record Was Successfully Updated.", vbInformation, "Record Updated!")
                        Call inputDefault() '(5)localFunc
                        btnRefresh.PerformClick()
                    Else
                        showErrorMsg(db_error_msg, "(02A.3)" & Me.Name)
                    End If

                End If

            End If
        End If

    End Sub

    '--(02B)--DELETE Record Function
    Private Sub delRecord()

        If advTree1.Nodes.Count = 0 Then
            MsgBox("No Record(s) Found!", vbExclamation, "Cannot Delete!")
            txtSearch.Focus()
            Exit Sub
        End If

        If userAccessLevel = "Staff" Then
            MsgBox("You have limited Access Level!" & vbNewLine & "Please contact your Supervisor or System Administrator.", vbCritical, "Access Denied!")
        Else
            If MsgBox("Are You Sure You Want to Delete Selected Record?", vbYesNo + vbQuestion, "Delete Selected Record?") = vbYes Then
                Dim SQLStatement As String = "UPDATE man_machine SET isVisible='N' " & _
                    "WHERE machNo='" & lblIndexNo.Text & " '"
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

#Region "--(03)-- SPECIAL FUNCTIONS --"

    '--(03A)--GET MACHINE STATUS
    Private Sub getMachineStatus()

        '==============================================================|
        '--(03A.1)--PREP VALUES
        '==============================================================|
        txtStatLastUpdate.Text = "NO UPDATE"
        txtStatBa.Text = ""
        txtStatCa.Text = ""
        txtStatDL.Text = ""
        txtStatCl.Text = ""
        txtStatAkd.Text = ""
        txtStatPwr.Text = ""
        txtStatKl.Text = ""
        txtStatTmp.Text = ""

        Dim logDateTime As String = Nothing
        Dim machStat As String = Nothing
        Dim machCtrl As String = Nothing
        Dim machUtil As String = Nothing

        '==============================================================|
        '--(03A.2)--GET latest machine status
        '==============================================================|
        Call connectDB()
        sql = New MySqlCommand("SELECT " & _
                               "log_mach_status.logDateTime, " & _
                               "log_mach_status.machNo, " & _
                               "log_mach_status.machStat, " & _
                               "log_mach_status.machCtrl, " & _
                               "log_mach_status.machUtil " & _
                               "FROM log_mach_status " & _
                               "WHERE log_mach_status.machNo='" & lblIndexNo.Text & "' " & _
                               "ORDER BY log_mach_status.logNo DESC LIMIT 0,1", con)
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    logDateTime = myReader.GetValue(0).ToString
                    machStat = myReader.GetValue(2).ToString
                    machCtrl = myReader.GetValue(3).ToString
                    machUtil = myReader.GetValue(4).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            If myerror.Number.ToString <> "1317" Then
                showErrorMsg(myerror.Message, "(03A.2)" & Me.Name)
            End If
            Exit Sub
        Finally
            con.Dispose()
        End Try

        '==============================================================|
        '--(03A.3)--SET VALUES FOR DISPLAY
        '==============================================================|
        Try
            Call convertMachStatus(CInt(machStat)) '(02A)mdlSysFunc
        Catch ex As Exception
            Exit Sub
        End Try

        If logDateTime <> "" Then txtStatLastUpdate.Text = logDateTime
        txtStatBa.Text = convertReadable(inp_bill) '(03B)localFunc
        txtStatCa.Text = convertReadable(inp_coin) '(03B)localFunc
        txtStatDL.Text = convertReadable(inp_doorlock) '(03B)localFunc
        txtStatCl.Text = convertReadable(inp_cashlock) '(03B)localFunc
        txtStatAkd.Text = convertReadable(inp_akd) '(03B)localFunc
        txtStatPwr.Text = convertReadable(inp_power) '(03B)localFunc
        txtStatKl.Text = convertReadable(inp_keylock) '(03B)localFunc
        txtStatTmp.Text = convertReadable(inp_temp) '(03B)localFunc

    End Sub

    '--(03B)--CONVERT TO READABLE
    Private Function convertReadable(ByVal tStatus As String) As String

        convertReadable = ""
        Select Case tStatus
            Case "0"
                Return "OFF"
            Case "1"
                Return "ON"
            Case Else
                Return "NO UPDATE"
        End Select

    End Function

    '--(03C)--GET franchisee INFO
    Private Sub getfranchiseeInfo()

        '==============================================================|
        '--(03C.1)--PREP VALUES
        '==============================================================|
        txtfranchiseeNo.Text = ""
        txtFranchisee.Text = ""
        txtContactNo1.Text = ""
        txtContactNo2.Text = ""
        txtEmail.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""

        If lblIndexNo.Text = "" Then
            Exit Sub
        End If

        '==============================================================|
        '--(03C.2)--GET latest machine status
        '==============================================================|
        Call connectDB()
        sql = New MySqlCommand("SELECT " & _
                               "man_franchisee.franchiseeNo, " & _
                               "man_franchisee.franchiseeName, " & _
                               "man_franchisee.contactNo1, " & _
                               "man_franchisee.contactNo2, " & _
                               "man_franchisee.email, " & _
                               "man_franchisee.username, " & _
                               "man_franchisee.password " & _
                               "FROM man_franchisee " & _
                               "WHERE man_franchisee.machNo='" & lblIndexNo.Text & "' " & _
                               "", con)
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    txtfranchiseeNo.Text = myReader.GetValue(0).ToString
                    txtFranchisee.Text = myReader.GetValue(1).ToString
                    txtContactNo1.Text = myReader.GetValue(2).ToString
                    txtContactNo2.Text = myReader.GetValue(3).ToString
                    txtEmail.Text = myReader.GetValue(4).ToString
                    txtUserName.Text = myReader.GetValue(5).ToString
                    txtPassword.Text = myReader.GetValue(6).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            If myerror.Number.ToString <> "1317" Then
                showErrorMsg(myerror.Message, "(03C.2)" & Me.Name)
            End If
            Exit Sub
        Finally
            con.Dispose()
        End Try

    End Sub

#End Region

#End Region

#Region "-=- UI Functions -=-"

    '=-CLOSE
    Private Sub MyBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.btnManMachine.Checked = False
        frmServer.Enabled = True
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
        frmMain.btnManMachine.Checked = True
        frmServer.Enabled = False
        cp1.Dock = DockStyle.Fill
        gpList.Text = "LIST OF MACHINES"

        ' Set view
        Call inputDefault() '(5)LocalFUNC

        ' Populate
        If quickAddUsed = False Then
            Call prepBwQuery() '(1A)LocalFunc
        Else
            quickAddUsed = False
            btnAdd.PerformClick()
        End If

        txtSearch.Focus()

    End Sub

    '=-SHORTCUT Key Functions
    Private Sub MyBase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.KeyPreview = True
            btnClose.PerformClick()
        ElseIf (e.KeyCode = Keys.F1) Then
            Me.KeyPreview = True
            btnAdd.PerformClick()
        ElseIf (e.KeyCode = Keys.F3) Then
            Me.KeyPreview = True
            btnEdit.PerformClick()
        ElseIf (e.KeyCode = Keys.F5) Then
            Me.KeyPreview = True
            btnDelete.PerformClick()
        End If
    End Sub

#Region "-- SPECIAL OBJECTS "

    Private Sub txtStatBa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatBa.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtStatCa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatCa.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtStatDL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatDL.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtStatCl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatCl.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtStatAkd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatAkd.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtStatPwr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatPwr.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtStatKl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatKl.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtStatTmp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatTmp.TextChanged
        updateObjectDisplay(sender)
    End Sub
    Private Sub txtTemperature_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTemperature.TextChanged
        updateObjectDisplay(sender)
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
            Call searchDS() '(2B)LocalFUNC
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

    Private Sub txtSN_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSN.MouseDoubleClick
        txtSN.Text = CpuId()
    End Sub

End Class