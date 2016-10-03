Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports System.IO
Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports System.Management

Public Class frmSysSettings

#Region "-=- Local Functions -=-"

    'data retrieval variables
    Dim ds As DataSet = New DataSet()
    Dim myReader As MySqlDataReader
    Dim sql As MySqlCommand

    'database variables
    Dim sDbSource As String
    Dim sDbName As String
    Dim sDbUser As String
    Dim sDbPw As String

    'pagination variables
    Dim dtDisplay As DataTable
    Dim PageCount As Integer
    Dim maxRec As Integer
    Dim pageSize As Integer = 100
    Dim currentPage As Integer
    Dim recNo As Integer
    Dim startRec As Integer
    Dim endRec As Integer

    'local variables
    Dim checkName As String = ""
    Dim queryOption As String
    Dim activationCode As String
    Dim cancelPw As Boolean
    Dim storePw As String

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
                Call prepBwQuery() '(8)LocalFunc
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
            cp1.Visible = False
            cp1.IsRunning = False
            btnRefresh.Tooltip = "Refresh"
            Call btnRefreshIco(btnRefresh) '(0C)localFunc
        End If

    End Sub

#End Region

#Region "--(01)-- Data Fetching and Display Functions --"

    '--(01A)--Prep for bwQuery
    Private Sub prepBwQuery()
        If bwQuery.IsBusy <> True Then
            gpList.Text = "Loading Records, Please Wait . . . "
            advTree1.Enabled = False
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            cp1.Visible = True
            cp1.IsRunning = True
            queryOption = "user"
            bwQuery.RunWorkerAsync() '(1B)LocalFunc
        End If
    End Sub

    '--(01B)--bwQuery Function
    Private Sub bwQuery_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwQuery.DoWork
        If (bwQuery.CancellationPending = True) Then
            e.Cancel = True
        Else
            If queryOption = "user" Then
                Call fillDS() '(1C)LocalFunc
            ElseIf queryOption = "activation" Then
                activationCode = CpuId() '(0D3)mdlGlobalFunc
            ElseIf queryOption = "testConn" Then
                If updateDBconnStringInfo(sDbSource, sDbName, sDbUser, sDbPw) = True Then '(00C)mdlGlobalFunc

                End If
            End If
        End If
    End Sub
    Private Sub bwQuery_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwQuery.RunWorkerCompleted
        If e.Cancelled = True Then
            'Cancelled
        ElseIf e.Error IsNot Nothing Then
            showErrorMsg(e.Error.Message, "(01B)" & Me.Name)
        Else
            If queryOption = "user" Then
                advTree1.Enabled = True
                btnAdd.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                cp1.Visible = False
                cp1.IsRunning = False
            ElseIf queryOption = "activation" Then
                cp2.Visible = False
                cp2.IsRunning = False
                txtCode.Text = activationCode '(0D3)mdlGlobalFunc
                txtKey.Text = ""
                Timer1.Enabled = True
                Timer1.Start()
            ElseIf queryOption = "testConn" Then
                btnDBtest.Text = "&Test Connection"
                btnDBtest.Enabled = True
                cpDb.Visible = False
                cpDb.IsRunning = False
                If db_connected = True Then
                    MsgBox("Test and Update Successful!", vbInformation)
                Else
                    showErrorMsg(db_error_msg, "(01B)" & Me.Name)
                End If
                lockFunction = False
            End If
        End If
        Call txtDef() '(3)LocalFunc
    End Sub

    '--(01C)--LoadPage Function
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

            'Copy the rows from the source table to fill the temporary table.
            For i = startRec To endRec - 1
                dtDisplay.ImportRow(ds.Tables(0).DefaultView(i).Row)
                recNo = recNo + 1
            Next
        Else
            dtDisplay = Nothing
        End If

        Me.BeginInvoke(CallFillDataGridView) '(2D)LocalFunc
    End Sub

    '--(01D)--FillDataGridView THREAD
    Dim CallFillDataGridView As New MethodInvoker(AddressOf Me.FillDataGridView)
    Public Sub FillDataGridView()
        With advTree1
            If IsNothing(dtDisplay) = False Then
                .DataSource = dtDisplay
                .BeginUpdate()
                .Columns(0).Width.Absolute = 100
                .Columns(1).Width.Absolute = 100
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .EndUpdate()
                lblNoRecords.Visible = False
                gpList.Text = "Displaying " & CStr(startRec + 1) & " to " & endRec.ToString & " of " & maxRec.ToString & " User(s) . . . "
            Else
                .Nodes.Clear()
                .DataSource = Nothing
                lblNoRecords.Visible = True
                gpList.Text = "No User(s) Found"
            End If
        End With
    End Sub

#End Region

#Region "--(02)-- USER ACCOUNTS"

    '--(02A)--FILL Dataset DS
    Private Sub fillDS()

        Call connectDB()
        sql = New MySqlCommand("SELECT " & _
                               "man_user.Username AS 'Username', " & _
                               "man_user_access.accessName AS 'Access Level', " & _
                               "man_user.Title AS 'Title', " & _
                               "man_user.LName AS 'Last Name', " & _
                               "man_user.FName AS 'First Name', " & _
                               "man_user.Password, " & _
                               "man_user.EmpCode " & _
                               "FROM man_user " & _
                               "LEFT JOIN man_user_access ON man_user_access.accessNo = man_user.accessNo " & _
                               "WHERE man_user.isVisible='Y' " & _
                               "ORDER BY man_user_access.accessNo ASC", con)
        ds = New DataSet()
        Try
            con.Open()
            myReader = sql.ExecuteReader
            ds.Load(myReader, LoadOption.Upsert, "table1")
            con.Close()
        Catch myerror As MySqlException
            If myerror.Number.ToString <> "1317" Then
                showErrorMsg(myerror.Message, "(02A)" & Me.Name)
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

        Me.BeginInvoke(CallLoadPage) '(2C)LocalFunc

    End Sub

    '--(02B)--SET values in gpInfo
    Private Sub txtDef()

        With advTree1
            Try
                If .Nodes.Count = 0 Then
                    cboTitle.Text = ""
                    txtLname.Text = ""
                    txtFname.Text = ""
                    txtAccessLevel.Text = ""
                    txtLogName.Text = ""
                    txtPass.Text = ""
                    txtPass1.Text = ""
                    txtEmpNo.Text = ""
                Else
                    txtLogName.Text = .SelectedNode.Cells(0).Text.ToString
                    cboAccessLevel.Text = .SelectedNode.Cells(1).Text.ToString
                    txtAccessLevel.Text = .SelectedNode.Cells(1).Text.ToString
                    cboTitle.Text = .SelectedNode.Cells(2).Text.ToString
                    txtTitle.Text = .SelectedNode.Cells(2).Text.ToString
                    txtLname.Text = .SelectedNode.Cells(2).Text.ToString
                    txtFname.Text = .SelectedNode.Cells(4).Text.ToString
                    txtPass.Text = base64Decode(.SelectedNode.Cells(5).Text.ToString)
                    txtEmpNo.Text = .SelectedNode.Cells(6).Text.ToString
                End If
                storePw = ""
            Catch ex As Exception
                showErrorMsg(ex.Message, "(02B)" & Me.Name)
            End Try
        End With

    End Sub

    '--(02C)--DEFAULT input
    Private Sub inputDefault()

        Me.SuspendLayout()

        checkName = ""

        gpList.Visible = True
        gpInfo.Text = "User's Information"
        gpInfo.Left = 254
        gpInfo.Width = SuperTabControlPanel4.Width - gpList.Width - (16 * 2)

        cboAccessLevel.Size = txtAccessLevel.Size
        txtAccessLevel.Location = cboAccessLevel.Location
        cboTitle.Size = txtTitle.Size
        txtTitle.Location = cboTitle.Location

        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        btnSave.Visible = False
        btnSave.Text = "&Save"
        btnCancel.Visible = False

        'Item Attributes
        txtLogName.ReadOnly = True
        txtFname.ReadOnly = True
        txtLname.ReadOnly = True
        cboTitle.Visible = False
        txtTitle.Visible = True
        cboAccessLevel.Visible = False
        txtAccessLevel.Visible = True
        btnChangePass.Visible = False
        Call btnChangePassEvent() '(9)LocalFunc

        txtLogName.FocusHighlightEnabled = False
        txtFname.FocusHighlightEnabled = False
        txtLname.FocusHighlightEnabled = False
        cboTitle.FocusHighlightEnabled = False
        cboAccessLevel.FocusHighlightEnabled = False

        txtLogName.BackColor = Color.LightGoldenrodYellow
        txtFname.BackColor = Color.LightGoldenrodYellow
        txtLname.BackColor = Color.LightGoldenrodYellow
        txtTitle.BackColor = Color.LightGoldenrodYellow
        txtAccessLevel.BackColor = Color.LightGoldenrodYellow

        Me.ResumeLayout()

    End Sub

    '--(02D)--ADD input
    Private Sub inputAdd()

        If userAccessLevel <> "Administrator" Then
            MsgBox("You have limited access rights!" & vbNewLine & _
                   "Only an Administrator can Add, Edit or Delete User Accounts.", vbCritical, "Access Denied!")
            Exit Sub
        End If

        Me.SuspendLayout()

        gpList.Visible = False
        gpInfo.Visible = False
        gpInfo.Text = "Add User Information"
        gpInfo.Left = 13 '220
        gpInfo.Width = SuperTabControlPanel4.Width - (14 * 2)

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        btnSave.Visible = True
        btnSave.Text = "&Save"
        btnCancel.Visible = True
        gpInfo.Visible = True

        Call popCboAccessLevel() '(02J)localFunc
        txtEmpNo.Text = getNextEmpCode() '(02F)LocalFunc
        txtLogName.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        cboTitle.Text = ""
        cboAccessLevel.Text = ""

        'Item Attributes
        txtLogName.ReadOnly = False
        txtFname.ReadOnly = False
        txtLname.ReadOnly = False
        cboTitle.Visible = True
        txtTitle.Visible = False
        cboAccessLevel.Visible = True
        txtAccessLevel.Visible = False
        btnChangePass.Visible = False

        lblPass.Visible = True
        txtPass.Visible = True
        txtPass.ReadOnly = False
        txtPass.Text = ""

        lblPass1.Visible = True
        txtPass1.Visible = True
        txtPass1.Text = ""

        txtLogName.FocusHighlightEnabled = True
        txtFname.FocusHighlightEnabled = True
        txtLname.FocusHighlightEnabled = True
        cboTitle.FocusHighlightEnabled = True
        cboAccessLevel.FocusHighlightEnabled = True
        txtPass.FocusHighlightEnabled = True
        txtPass1.FocusHighlightEnabled = True

        txtLogName.BackColor = Color.White
        txtFname.BackColor = Color.White
        txtLname.BackColor = Color.White
        cboTitle.BackColor = Color.White
        cboAccessLevel.BackColor = Color.White
        txtPass.BackColor = Color.White
        txtPass1.BackColor = Color.White

        Me.ResumeLayout()

        txtLogName.Focus()
        txtLogName.Select()

    End Sub

    '--(02E)--EDIT input
    Private Sub inputEdit()

        '* non-admin users can only edit own account information, administrators can do all!
        If userAccessLevel = "Administrator" Or txtLogName.Text = userLogName Then

            Me.SuspendLayout()

            gpList.Visible = False
            gpInfo.Visible = False
            gpInfo.Text = "Edit User Information"
            gpInfo.Left = 13 '220
            gpInfo.Width = SuperTabControlPanel4.Width - (14 * 2)

            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False

            btnSave.Visible = True
            btnSave.Text = "&Update"
            btnCancel.Visible = True
            gpInfo.Visible = True

            'Item Attributes
            Call popCboAccessLevel() '(02J)localFunc
            txtLogName.ReadOnly = False
            txtFname.ReadOnly = False
            txtLname.ReadOnly = False
            cboTitle.Visible = True
            txtTitle.Visible = False
            cboAccessLevel.Visible = True
            cboAccessLevel.Text = txtAccessLevel.Text
            txtAccessLevel.Visible = False
            btnChangePass.Visible = True
            Call btnChangePassEvent() '(9)LocalFunc

            txtLogName.FocusHighlightEnabled = True
            txtFname.FocusHighlightEnabled = True
            txtLname.FocusHighlightEnabled = True
            cboTitle.FocusHighlightEnabled = True
            cboAccessLevel.FocusHighlightEnabled = True

            txtLogName.BackColor = Color.White
            txtFname.BackColor = Color.White
            txtLname.BackColor = Color.White
            cboTitle.BackColor = Color.White
            cboAccessLevel.BackColor = Color.White

            If userAccessLevel = "Administrator" And cboAccessLevel.Text = "Administrator" Then
                cboAccessLevel.Visible = False
                txtAccessLevel.Visible = True
            End If

            If txtLogName.Text = userLogName And cboAccessLevel.Text <> "Administrator" Then
                cboAccessLevel.Visible = False
                txtAccessLevel.Visible = True
            End If

            Me.ResumeLayout()

            txtLogName.Focus()
            txtLogName.SelectAll()
        Else
            MsgBox("You have limited access rights!" & vbNewLine & _
                   "* You can only edit your own account information. " & vbNewLine & _
                   "* Only an Administrator can Add, Edit or Delete User Accounts.", vbCritical, "Access Denied!")
        End If

    End Sub

    '--(02F)--btnChangePass Events
    Private Sub btnChangePassEvent()

        If btnChangePass.Visible = True Then

            If btnChangePass.Checked = False Then

                lblPass.Visible = True
                txtPass.Visible = True
                txtPass.ReadOnly = True
                txtPass.FocusHighlightEnabled = False
                txtPass.BackColor = Color.LightGoldenrodYellow

                lblPass1.Visible = False
                txtPass1.Visible = False
                txtPass1.Text = ""

                txtPass.Focus()

            Else

                lblPass.Visible = True
                txtPass.Visible = True
                txtPass.ReadOnly = False
                txtPass.FocusHighlightEnabled = True
                txtPass.BackColor = Color.White

                lblPass1.Visible = True
                txtPass1.Visible = True
                txtPass1.Text = ""
                txtPass1.FocusHighlightEnabled = True
                txtPass1.BackColor = Color.White

                txtPass.Focus()

            End If

        Else

            txtPass.Visible = False
            txtPass1.Visible = False

            lblPass.Visible = False
            lblPass1.Visible = False

        End If

    End Sub

    '--(02G)--GET NEXT EmpCode
    Private Function getNextEmpCode() As String

        getNextEmpCode = "1"
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT EmpCode FROM man_user ORDER BY EmpCode DESC LIMIT 0,1", con)
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    getNextEmpCode = CInt(myReader.Item(0).ToString) + 1
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(02G)" & Me.Name)
        Finally
            con.Dispose()
        End Try

    End Function

    '--(02H)--CHECK if Login name is available
    Private Function isUserAvailable(ByRef tempUserName As String) As Boolean

        isUserAvailable = True
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT Username FROM man_user " & _
                                                   "WHERE Username='" & tempUserName & "' AND isVisible='Y'", con)
        Try
            con.Dispose()
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    isUserAvailable = False
                End While
            Else
                isUserAvailable = True
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(02H)" & Me.Name)
        Finally
            con.Dispose()
        End Try

    End Function

    '--(02I)--SAVE / UPDATE Function
    Private Sub saveUpdateInfo(ByVal btnUsed As String)

        '=====================================================================================================|
        '--(02I.1) FILTER VALUES
        '=====================================================================================================|
        If txtLogName.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter a Login Name."
            Call popBaloon(txtLogName, Me)
            txtLogName.Focus()
        ElseIf hasDbDuplicate("empCode", "man_user", txtCode.Text.Trim) = True And btnSave.Text <> "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate Login Name Detected."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
            txtCode.SelectAll()
        ElseIf (hasDbDuplicate("empCode", "man_user", txtCode.Text.Trim) = True And
                convertUpperCase(txtCode.Text.Trim) <> checkName.Trim) And
            btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Duplicate Login Name Detected."
            Call popBaloon(txtCode, Me)
            txtCode.Focus()
            txtCode.SelectAll()
        ElseIf cboAccessLevel.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter an Access Level."
            Call popBaloon(cboAccessLevel, Me)
            cboAccessLevel.Focus()
        ElseIf txtPass.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter a Password."
            Call popBaloon(txtPass, Me)
            txtPass.Focus()
        ElseIf txtPass.Text <> txtPass1.Text And btnChangePass.Visible = False Then
            errorCap = "Attention!"
            errorMsg = "Password Mismatch!"
            Call popBaloon(txtPass, Me)
            txtPass.Focus()
            txtPass.Text = ""
            txtPass1.Text = ""
        ElseIf txtPass.Text <> txtPass1.Text And btnChangePass.Checked = True Then
            errorCap = "Attention!"
            errorMsg = "Password Mismatch!"
            Call popBaloon(txtPass, Me)
            txtPass.Focus()
            txtPass.Text = ""
            txtPass1.Text = ""
        ElseIf cboTitle.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter a Title."
            Call popBaloon(cboTitle, Me)
            cboTitle.Focus()
        ElseIf txtFname.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter a First Name."
            Call popBaloon(txtFname, Me)
            txtFname.Focus()
        ElseIf txtLname.Text = "" Then
            errorCap = "Attention!"
            errorMsg = "You must enter a Last Name."
            Call popBaloon(txtLname, Me)
            txtLname.Focus()
        Else
            If btnSave.Text = "&Save" Then

                '-----------------------------------------------------------------------------------------------------
                '--(02I.2) SAVE
                '=====================================================================================================
                If MsgBox("Are You Sure You Want to Add Record?", vbYesNo + vbQuestion) = vbYes Then

                    Dim tTable As String = "man_user"
                    Dim tFields As String = "" & _
                        "@empCode,@username,@password,@title,@accessNo,@lName,@fName"
                    Dim tValues As String = "" & _
                        getNextEmpCode() & "^" & _
                        txtLogName.Text.Trim & "^" & _
                        base64Encode(txtPass.Text) & "^" & _
                        cboTitle.Text & "^" & _
                        getUserAccessNo(cboAccessLevel.Text) & "^" & _
                        txtLname.Text.Trim & "^" & _
                        txtFname.Text.Trim & "" '(12)localFunc, (01)mdlSystemFunc
                    If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc
                        MsgBox("Record Was Successfully Added.", vbInformation, "Record Added!")
                        If btnUsed = "1" Then
                            Call inputDefault() '(5)localFunc
                            btnRefresh.PerformClick()
                        End If
                    Else
                        showErrorMsg(db_error_msg, "(02I.2)" & Me.Name)
                    End If

                End If

            ElseIf btnSave.Text = "&Update" Then

                '-----------------------------------------------------------------------------------------------------
                '--(02I.B) UPDATE
                '=====================================================================================================
                If MsgBox("Are You Sure You Want to Update Record Information?", vbYesNo + vbQuestion) = vbYes Then

                    Dim tTable As String = "man_user"
                    Dim tFields As String = "" & _
                        "@Password,@Title,@Lname,@Fname,@accessNo,@Username"
                    Dim tValues As String = "" & _
                        base64Encode(txtPass.Text) & "^" & _
                        cboTitle.Text.Trim & "^" & _
                        txtLname.Text.Trim & "^" & _
                        txtFname.Text.Trim & "^" & _
                        getUserAccessNo(cboAccessLevel.Text) & "^" & _
                        txtLogName.Text.Trim & ""
                    Dim tUpdateField As String = "WHERE empCode='" & txtEmpNo.Text & "'"

                    If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = True Then '(0D2)mdlGlobalFunc
                        MsgBox("Record Was Successfully Updated.", vbInformation, "Record Updated!")
                        Call inputDefault() '(5)localFunc
                        btnRefresh.PerformClick()
                    Else
                        showErrorMsg(db_error_msg, "(02I.2)" & Me.Name)
                    End If

                End If

            End If
        End If
    End Sub

    '--(02J)--deleteRecord
    Private Sub delRecord()

        If userAccessLevel <> "Administrator" Then
            Call showAccessDenied()
            Exit Sub
        End If

        If advTree1.Nodes.Count <> 0 Then
            If txtLogName.Text = userLogName Then
                MsgBox("You Cannot Delete Your Own Account.", vbExclamation, "Error!") '=-Prevents deletion of own account-=
            Else
                If MsgBox("Are You Sure You Want to Delete Selected Record?", vbYesNo + vbQuestion, "Delete Selected Record?") = vbYes Then
                    Dim SQLStatement As String = "UPDATE man_user SET isVisible='N' WHERE EmpCode='" & txtEmpNo.Text & " '"
                    If executeMySQLquery(SQLStatement) = True Then
                        MsgBox("Record Was Successfully Deleted.", vbInformation, "Record Deleted!")
                    Else
                        showErrorMsg(db_error_msg, "(02J)" & Me.Name)
                    End If
                    btnRefresh.PerformClick()
                End If
            End If
        Else
            MsgBox("No Record(s) Found!", vbExclamation, "Cannot Delete!")
        End If

    End Sub

    '--(02K)--POP cboAccessLevel
    Private Sub popCboAccessLevel()
        
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT accessName FROM man_user_access " & _
                                                   "WHERE isVisible='Y' " & _
                                                   "ORDER BY accessNo ASC", con)
        Dim dsT As DataSet = New DataSet()
        Dim DataAdapter1 As MySqlDataAdapter = New MySqlDataAdapter()
        Try
            con.Open()
            DataAdapter1.SelectCommand = sql
            DataAdapter1.Fill(dsT)
            con.Close()
            With cboAccessLevel
                .Items.Clear()
                .Items.Add("")
                If dsT.Tables(0).Rows.Count <> 0 Then
                    For x = 0 To dsT.Tables(0).Rows.Count - 1
                        .Items.Add(dsT.Tables(0).Rows(x).Item(0).ToString)
                    Next
                End If
            End With
        Catch myerror As MySqlException
            MsgBox("An Error Occured: (02K)" & Me.Name & vbNewLine & "> " & myerror.Message, vbExclamation, "Attention!")
        Finally
            con.Dispose()
        End Try

    End Sub

#End Region

#Region "--(03)-- DATABASE SETTINGS"

    '--(03A)--CHECK backup Location
    Private Function okDBloc(ByVal dbLoc As String) As Boolean

        okDBloc = True
        If Directory.Exists(dbLoc) = False Then
            okDBloc = False
        End If

    End Function

    '--(03B)--GET dbBackupSet Function
    Private Sub getDbBackupInfo()

        Dim FileText As String
        Dim FileLines As String()
        Dim OneLine As String()
        Dim SeparatorChar As String = ","
        Try
            If My.Computer.FileSystem.FileExists(db_backupSetFile) Then
                FileText = My.Computer.FileSystem.ReadAllText(db_backupSetFile)
                FileLines = FileText.Split(CChar(Environment.NewLine))

                OneLine = FileLines(0).Split(CChar(SeparatorChar))

                txtBackupLocation.Text = base64Decode(OneLine(0)) '(03)mdlGlobalFunc
                Dim backupLoc As String = base64Decode(OneLine(1))
                If backupLoc = "Y" Then
                    cbBackupOnExit.Checked = True
                Else : cbBackupOnExit.Checked = False
                End If
            Else
                cbBackupOnExit.Checked = False
                txtBackupLocation.Text = My.Application.Info.DirectoryPath & "\Database Backups\"
            End If
        Catch ex As Exception
            showErrorMsg(ex.Message, "(03B)" & Me.Name)
        End Try

    End Sub

    '--(03C)--SET dbBackupSet Function
    Private Sub setDbBackupInfo()

        Dim sw As StreamWriter
        Dim backupOnExit As String = "N"
        If cbBackupOnExit.Checked = True Then
            backupOnExit = "Y"
        End If
        Try
            If System.IO.File.Exists(db_backupSetFile) = True Then
                System.IO.File.Delete(db_backupSetFile)
            End If
            sw = File.CreateText(db_backupSetFile)
            sw.WriteLine(base64Encode(txtBackupLocation.Text) & _
                             "," & base64Encode(backupOnExit)) '(3)mdlGlobalFunc
            SetAttr(db_backupSetFile, vbHidden)
            sw.Close()
        Catch ex As Exception
            showErrorMsg(ex.Message, "(03C)" & Me.Name)
        End Try

    End Sub

    '--(03D)--Prep for bwQuery DB Test Connection
    Private Sub prepBwQueryDb()

        If bwQuery.IsBusy <> True Then

            lockFunction = True

            sDbSource = txtDBsource.Text.Trim
            sDbName = txtDBname.Text.Trim
            sDbUser = txtDBuser.Text.Trim
            sDbPw = txtDBpw.Text

            btnDBtest.Text = "Connecting to database . . . "
            btnDBtest.Enabled = False
            cpDb.Visible = True
            cpDb.IsRunning = True
            queryOption = "testConn"
            bwQuery.RunWorkerAsync() '(1B)LocalFunc

        End If

    End Sub

#End Region

#Region "--(04)-- PRODUCT ACTIVATION"

    '--(04A)--ACTIVATE Function
    Private Sub checkActivation()

        If txtKey.Text <> "" Then
            Dim tempKey As String = scrambleSN(txtCode.Text) '(0D4)mdlGlobalFunc
            If tempKey = txtKey.Text Then
                If createdActivationFile(txtKey.Text) = True Then '(0D2)mdlGlobalFunc
                    MsgBox("Product Name: " & systemName & " " & systemVersion & vbNewLine & _
                           "Activation Status: Activated!" & vbNewLine & vbNewLine & _
                           systemCopyright,
                           vbInformation, "Congratulations!")
                    Call mdlGlobalFunc.checkActivation() '(0F1)mdlGlobalFunc
                    Me.Close()
                End If
            Else
                MsgBox("Invalid Activation Key!" & vbNewLine & vbNewLine & _
                       systemCopyright,
                       vbExclamation, "Attention!")
                txtKey.Focus()
                txtKey.SelectAll()
            End If
        Else
            MsgBox("Please Enter an Activation Key!" & vbNewLine & vbNewLine & _
                   systemCopyright,
                   vbExclamation, "Attention!")
            txtKey.Focus()
        End If

    End Sub

    '--(04B)--PrepActivation Function
    Private Sub prepActivation()

        'disable frmLogin if visible
        If frmSysLogin.Visible = True Then
            frmSysLogin.Enabled = False
        End If

        'activation info
        If isTrial = True Then
            lblActivationStatus.Text = "TRIAL VERSION"
            lblActivationStatus.ForeColor = Color.Red
            gpActivate.Visible = True
            If bwQuery.IsBusy <> True Then
                cp2.Visible = True
                cp2.IsRunning = True
                txtCode.Text = "Generating Activation Code . . . "
                queryOption = "activation"
                bwQuery.RunWorkerAsync() '(1B)LocalFunc
            End If
        Else
            lblActivationStatus.Text = "PRODUCT ACTIVATED"
            lblActivationStatus.ForeColor = Color.Black
            gpActivate.Visible = False
            Timer1.Enabled = False
            Timer1.Stop()
        End If

    End Sub

#End Region

#Region "--(05)-- SMS CONFIGURATION"

#Region "--(05A)-- SMS CONFIGURATION USING FILE HANDLING"

    Public smsConfig As String = systemDataFolder & "\" & systemNameShort & "smsConfig.log"
    '--(05A.1)--SET SMS Settings
    Private Sub setSMSSettings(ByVal targetPort As String)

        Call getSMSLastStat() '(01)mdlIndicatorFunc

        Try
            Select Case targetPort
                Case "1"
                    cboPort1.Text = iComPort1
                    cboBaudRate1.Text = iBaudRate1
                    cboParity1.Text = iParity1
                    cboDataBits1.Text = iDataBits1
                    cboStopBits1.Text = iStopBits1
            End Select

        Catch ex As Exception
            showErrorMsg(ex.Message, "(01B)" & Me.Name) '(02A)localFunc
        End Try

    End Sub

    '--(05A.2)--GET SMS LAST STATUS
    Public Sub getSMSLastStat()

        Try

            '==============================================================================================|
            '-(05A.1)- GET USER DEFINED PORT SETTINGS
            '==============================================================================================|

            Dim strFile As String = smsConfig '<= TARGET FILE **
            Dim SeparatorChar As String = ","
            Dim FileText As String
            Dim FileLines As String()
            Dim OneLine As String()

            'Fetch Connection String Information from file
            If My.Computer.FileSystem.FileExists(strFile) Then

                FileText = My.Computer.FileSystem.ReadAllText(strFile)
                FileLines = FileText.Split(CChar(Environment.NewLine))

                If FileLines.Length > 1 Then
                    OneLine = base64Decode(FileLines(FileLines.Length - 2)).Split(CChar(SeparatorChar)) 'GET LAST LINE VALUES
                Else
                    OneLine = base64Decode(FileLines(0)).Split(CChar(SeparatorChar)) 'GET LAST LINE VALUES
                End If

                iComPort1 = OneLine(0).ToString '(4)mdlGlobalFunc
                iBaudRate1 = OneLine(1).ToString '(4)mdlGlobalFunc
                iParity1 = OneLine(2).ToString  '(4)mdlGlobalFunc
                iDataBits1 = OneLine(3).ToString  '(4)mdlGlobalFunc
                iStopBits1 = OneLine(4).ToString
            End If

        Catch ex As Exception
            errorMsg = "An Error Occured : (03A)mdlGlobalFunc" & vbNewLine & ex.Message
        End Try

    End Sub

    '--(05A.3)--INSERT SMS Status
    Public Function insertSMSStat(ByVal iComPort1 As String,
                                   ByVal iBaudRate1 As String,
                                   ByVal iParity1 As String,
                                   ByVal iDataBits1 As String,
                                   ByVal iStopBits1 As String) As Boolean

        insertSMSStat = True

        'UPDATE values on file
        Dim strFile As String = smsConfig '<= TARGET FILE **
        Dim SeparatorChar As String = ","

        Dim tempDateTime As String = ToMySqlDate(DateTime.Now)
        Dim txtContent As String =
                  base64Encode(
                      iComPort1 & SeparatorChar & _
                      iBaudRate1 & SeparatorChar & _
                      iParity1 & SeparatorChar & _
                      iDataBits1 & SeparatorChar & _
                      iStopBits1
                      )

        Try

            If System.IO.File.Exists(strFile) = False Then

                Dim sw As StreamWriter
                sw = File.CreateText(strFile)
                sw.WriteLine(txtContent)
                SetAttr(strFile, vbHidden)
                sw.Close()

            Else

                Using writer As New StreamWriter(strFile, True)
                    writer.WriteLine(txtContent)
                    SetAttr(strFile, vbHidden)
                    writer.Close()
                End Using

            End If

        Catch ex As Exception
            errorMsg = "An Error Occured : (03B)mdlGlobalFunc" & vbNewLine & ex.Message
            Return False
        End Try

    End Function

#End Region

#Region "--(05B)-- AUTO DETECT MODEM"

    '--(05B.1)-- DISPLAY MODEMS DECTECTED
    Public Function ModemsConnected() As String

        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_POTSModem")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Return ""
        End Try
        Return modems
    End Function

    '--(05B.2)--GETS MODEMS DECTECTED
    Private Sub activePort()
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            cboDongle.Items.Add(ports(i))
        Next
    End Sub

#End Region

#Region "--(05C)-- DATA RECIEVE HANDLING"

    '--(05C.1)-- SERIAL PORT DATARECIEVE
    Private Sub spDevice_datarecieved(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spDevice.DataReceived
        Try
            dataMsg1 = spDevice.ReadExisting()
        Catch ex As Exception
            Call closePort()
            'showErrorMsg(ex.Message, "-(00A) Data Recieve handling (spDevice1)")
            AppendTextBox(txtReceived1, vbNewLine & ex.Message) ' & vbNewLine)

        End Try

    End Sub

#End Region

#Region "--(05D)-- DEVICE STATUS SETTINGS"

    '--(05D.1)-- SENDING COMMANDS
    Private Sub getSignal()
        With spDevice
            If .IsOpen = False Then
                Call testPort1()
            End If
            AppendTextBox(txtReceived1, vbNewLine & "> Getting Signal . . . . . . .")
            atcommands = "AT+CSQ" ' signal
            .Write(atcommands & Chr(13))
            Threading.Thread.Sleep(1000)

            getDeviceStatus("+CSQ:", "signal")
        End With
    End Sub
    Private Sub getNumber()
        With spDevice
            If .IsOpen = False Then
                Call testPort1()
            End If
            AppendTextBox(txtReceived1, vbNewLine & "> Getting Number . . . . . . .")
            atcommands = "AT+CNUM" ' signal
            .Write(atcommands & Chr(13))
            Threading.Thread.Sleep(3000)

            getDeviceStatus("+CNUM:", "number")
        End With
    End Sub

    Private Sub getSim()
        With spDevice
            If .IsOpen = False Then
                Call testPort1()
            End If
            atcommands = "AT+CPIN" ' signal
            .Write(atcommands & Chr(13))
            Threading.Thread.Sleep(3000)

            getDeviceStatus("+CPIN:", "sim")
        End With
    End Sub

    '--(05D.2)-- GET DATA RECIEVE
    Public Function getDataRecieve(ByVal deviceId As String)
        Try
            Select Case deviceId
                Case "1"
                    deviceStatus = dataMsg1.ToString
                    AppendTextBox(txtReceived1, vbNewLine & ">  " & deviceStatus)
            End Select

        Catch ex As Exception
            Call closePort()
            AppendTextBox(txtReceived1, vbNewLine & ex.Message) ' & vbNewLine)

        End Try
        Return deviceStatus
    End Function

    '--(05D.3)-- GET DEVICE STATUS
    Public Sub getDeviceStatus(ByVal atCommands As String,
                             ByVal status As String)
        Try

            arrDeviceStat = Split(getDataRecieve("1"), atCommands, , CompareMethod.Text)
            For i = 1 To UBound(arrDeviceStat)
                Dim input As String = arrDeviceStat(i)
                Dim result() As String
                Dim pattern As String = "(:)|(,"")|("","")|("")|(,)"

                result = Regex.Split(input, pattern)
                Select Case status
                    Case "signal"
                        btnSimSignal1.Image = convertedValuesSignal(result(0).ToString.Trim, btnSimSignal1, spDevice)
                        btnSimStat1.Image = Global.Loading_Kiosk_Server_System.My.Resources.simOk
                        AppendRibbonBar(rbSim1, "SIM 1")
                    Case "number"
                        txtCpNum.Text = result(2).ToString.Trim
                    Case "sim"
                        '  txtCpNum.Text = result(4).ToString.Trim
                End Select

            Next
            '    AppendTextBox(txtReceived1, vbNewLine & deviceStatus)

            Array.Clear(arrDeviceStat, 0, arrDeviceStat.Length)
        Catch ex As Exception
            Call closePort()
            showErrorMsg(ex.Message, "-(01B) Device Status Settings (getDeviceStatus)")
        End Try
    End Sub

#End Region

    Private Sub testPort1()
        Dim readData As String = ""
        If btnConnect.Text <> "Stop" Then

            stopProcSignal = False
            '=================================================================|
            '--(02A.1A)-- SET VALUES
            '=================================================================|
            iComPort1 = cboPort1.Text ' cboPort1.Text
            iBaudRate1 = cboBaudRate1.Text
            iParity1 = cboParity1.Text
            iDataBits1 = cboDataBits1.Text
            iStopBits1 = cboStopBits1.Text

            Call insertSMSStat(iComPort1, iBaudRate1, iParity1, iDataBits1, iStopBits1)
            Call setSMSSettings("1") '(02AB)localFunc

            cboPort1.Enabled = False
            cboBaudRate1.Enabled = False
            cboParity1.Enabled = False
            cboDataBits1.Enabled = False
            cboStopBits1.Enabled = False

            btnConnect.Text = "Stop"

            txtReceived1.Text = Nothing
            AppendTextBox(txtReceived1, "> Initializing Serial Port " & iComPort1 & "...")
            '=================================================================|
            '--(02A.1B)-- OPEN SERIAL PORT
            '=================================================================|
            Try
                '-------------------------------------------------------------|
                '--(02A.1B1)-- SET Serial Port Properties
                '=============================================================|
                AppendTextBox(txtReceived1, "OK!" & vbNewLine & "> Executing read . . ." & vbNewLine)
                With spDevice
                    .PortName = iComPort1 'Set  to the selected COM port at startup
                    .BaudRate = iBaudRate1 'Set Baud rate to the selected value on
                    Select Case iParity1
                        Case "Even"
                            .Parity = IO.Ports.Parity.Even
                        Case "Odd"
                            .Parity = IO.Ports.Parity.Odd
                        Case "None"
                            .Parity = IO.Ports.Parity.None
                        Case Else
                            .Parity = IO.Ports.Parity.Mark
                    End Select
                    Select Case iStopBits1
                        Case "1"
                            .StopBits = IO.Ports.StopBits.One
                        Case Else
                            .StopBits = IO.Ports.StopBits.Two
                    End Select
                    .DataBits = CInt(iDataBits1) 'Open our serial port
                    .ReadTimeout = 100
                    .Open()

                End With
                '   Call getDeviceStatus(spDevice, getPort, "1")
                Call getSignal()
                '  Call getSim()
                Call getNumber()
                'If bwExecute.IsBusy = False Then
                '    bwExecute.RunWorkerAsync()
                'End If
            Catch ex As Exception

                Call closePort() '(02AE)localFunc
                AppendTextBox(txtReceived1, "Error!> (02AD.3)" & Me.Name & ":" & ex.Message)
                Exit Sub
            End Try

        Else
            '=================================================================|
            '--(02A.1C)-- CLOSE PORT
            '=================================================================|
            Call closePort() '(02AE)localFunc
            cboPort1.Enabled = True
            cboBaudRate1.Enabled = True
            cboParity1.Enabled = True
            cboDataBits1.Enabled = True
            cboStopBits1.Enabled = True
            btnConnect.Text = "Connect"
            stopProcSignal = True
            '     bwExecute.CancelAsync()
        End If

    End Sub

    Private Sub closePort()
        Try
            If spDevice.IsOpen = True Then
                AppendTextBox(txtReceived1, vbNewLine & "> Closing Port . . . . .")
                spDevice.Close() 'Close our Serial Port
            End If

            AppendTextBox(txtReceived1, vbNewLine & ">>>> Port Closed <<<<")

        Catch ex As IOException
            If ((Not spDevice Is Nothing) AndAlso spDevice.IsOpen) Then
                spDevice.Close()
            End If
        End Try

    End Sub
#End Region

#End Region

#Region "-=- UI Functions -=-"

    '=-CLOSE
    Private Sub MyBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Enabled = True
        isDBoveride = False
        If frmSysLogin.Visible = True Then
            frmSysLogin.Enabled = True
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '=-LOAD
    Private Sub frmSystemProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.WaitCursor
        frmMain.Enabled = False
        Me.KeyPreview = True
        cp1.Dock = DockStyle.Fill
        SuperTabControl1.SelectedTab = spSystemSettings

    End Sub

    '=-SuperTabControl1 Function
    Private Sub SuperTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged

        If spDatabase.IsSelected = True And spDatabase.Visible = True Then

            'set Database Setting Values
            txtBackupName.Text = getDBfileName() '(0D3)mdlGlobalFunc
            txtDBsource.Text = db_dataSource
            txtDBname.Text = db_dataBase
            txtDBuser.Text = db_userID
            txtDBpw.Text = db_passWord

            gp3.Enabled = True
            Call getDbBackupInfo() '(1)LocalFunc

        End If

        If lockFunction = False Then

            If spSystemSettings.IsSelected = True Then

            ElseIf spActivation.IsSelected = True Then

                Call prepActivation() '(16)LocalFunc

            ElseIf spUser.IsSelected = True Then

                cancelPw = True 'Controls device password cancel function
                Call inputDefault() '(4)LocalFUNC
                Call prepBwQuery() '(1A)localFunc

            End If

        End If

    End Sub

#Region "-- SPECIAL OBJECTS"

#End Region

#Region "-- DATABASE OBJECTS"

    '=-Override DB Restore Function
    Private Sub txtDBpw_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDBpw.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            Me.KeyPreview = True
            If txtDBpw.Focus = True Then
                If gp2.Enabled = False Then

                    Dim message, title, defaultValue As String

                    title = "Authentication Required"
                    message = "Enter password"
                    defaultValue = "*"

                    If txtDBpw.Text = systemNameShort & "admin" Then
                        gp2.Enabled = True
                        txtDBpw.Text = db_passWord
                        txtRestoreLoc.Focus()
                        isDBoveride = True
                    Else
                        MsgBox("Access Denied!", vbCritical)
                    End If

                End If
            End If
        End If

    End Sub

    '=-btnBackup Function
    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        If okDBloc(txtBackupLocation.Text) = True Then
            Call setDbBackupInfo() '(2)LocalFunc
            popSuccessBackup = True
            dbExecType = "backup"
            frmSysDBexec.Show()
        Else
            MsgBox("Database Backup Failed!" & vbNewLine & "Selected Backup Location does not Exist.", vbExclamation, "Error!")
        End If
    End Sub

    '=-btnBrowse Function
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        FolderBrowserDialog1.SelectedPath = txtBackupLocation.Text
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtBackupLocation.Text = FolderBrowserDialog1.SelectedPath
            Call setDbBackupInfo() '(2)LocalFunc
        End If
    End Sub

    '=-RESTORE
    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        If userAccessLevel <> "Administrator" And isDBoveride = False Then
            MsgBox("Your Access Level is Limited. Access Denied!", vbCritical, "Restricted Access!")
        Else
            If txtRestoreFileName.Text <> "" And txtRestoreFileName.Text.Substring(txtRestoreFileName.Text.LastIndexOf(".") + 1) = "sql" Then
                If MsgBox("Are you sure you want to Restore Database?", vbQuestion + vbYesNo, "Restore Database?") = vbYes Then
                    popSuccessBackup = True
                    dbExecType = "restore"
                    dbRestoreLoc = txtRestoreLoc.Text
                    frmSysDBexec.Show()
                End If
            Else
                MsgBox("Please Select a MySql File to Restore.", vbInformation, "Attention!")
            End If
        End If
    End Sub

    '=-btnOpen Function
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Title = "Please Select a .sql File"
        OpenFileDialog1.InitialDirectory = txtBackupLocation.Text
        OpenFileDialog1.Filter = "MySQL Database (*.sql)|*.sql"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.FileName = ".sql"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtRestoreLoc.Text = OpenFileDialog1.FileName
            txtRestoreFileName.Text = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        End If
    End Sub

    '=-btnDBtest Function
    Private Sub btnDBtest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBtest.Click
        Call prepBwQueryDb() '(04D)localFunc
    End Sub

    '=-lblPassword Function
    Private Sub lblPassword_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblPassword.MouseDoubleClick

    End Sub

    '=-cbBakupOnExit Function
    Private Sub cbBackupOnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBackupOnExit.Click
        If okDBloc(txtBackupLocation.Text) = True Then
            Call setDbBackupInfo() '(2)LocalFunc
        Else
            MsgBox("Selected Backup Location does not Exist.", vbExclamation, "Error!")
            cbBackupOnExit.Checked = False
        End If
    End Sub

#End Region

#Region "-- ACTIVATION OBJECTS"

    '=-Timer1 Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        With lblActivationStatus
            If .Visible = True Then
                If .Text = "TRIAL VERSION" Then
                    .Text = ""
                Else
                    .Text = "TRIAL VERSION"
                End If
            End If
        End With
    End Sub

    '=-txtCode Functions
    Private Sub txtCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Click
        Call txtCode_GotFocus(sender, e)
    End Sub
    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        txtCode.SelectAll()
    End Sub

    '=-btnActivate Functions
    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Call checkActivation() '(3)localFunc
    End Sub

#End Region

#Region "-- USER ACCOUNTS OBJECTS"

    '=-advTree1 Function
    Private Sub advTree1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advTree1.SelectionChanged
        If advTree1.Enabled = True Then
            Call txtDef() '(3)LocalFUNC
        End If
    End Sub
    Private Sub advTree1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles advTree1.DoubleClick
        If advTree1.Nodes.Count <> 0 Then
            btnEdit.PerformClick()
        End If
    End Sub

    '=-btnAdd Function
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call inputAdd() '(5)LocalFUNC
    End Sub

    '=-btnEdit FUnction
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If advTree1.Nodes.Count <> 0 Then
            checkName = convertUpperCase(txtLogName.Text)
            Call inputEdit() '(6)LocalFUNC
        Else
            MsgBox("No Record(s) Found!", vbExclamation, "Cannot Edit!")
        End If
    End Sub

    '=-btnDelete Function
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call delRecord() '(11)localFunc
    End Sub

    '=-btnSave Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call saveUpdateInfo("1") '(10)LocalFunc
    End Sub

    '=-btnCancel Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call inputDefault() '(4)LocalFunc
        Call txtDef() '(3)
    End Sub

    '=-btnRefresh Function
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call refreshList() '(0D)localFunc
    End Sub

    '=-btnChangePass
    Private Sub btnChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePass.Click
        If btnChangePass.Checked = False Then
            btnChangePass.Checked = True
            txtPass.Text = ""
        Else
            btnChangePass.Checked = False
            txtPass.Text = base64Decode(advTree1.SelectedNode.Cells(5).Text.ToString)
        End If
        Call btnChangePassEvent() '(7)LocalFunc
    End Sub

    '=-txtPass Change
    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If txtPass.ReadOnly = True And btnSave.Text = "&Update" Then
            errorCap = "Attention!"
            errorMsg = "Click this to Edit Password."
            Call popBaloon(btnChangePass, Me)
        End If
    End Sub

    '=-RESTRICTIONS and VALIDATIONS
    Private Sub txtLName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLname.KeyPress
        If isAlphaInput(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtFName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFname.KeyPress
        If isAlphaInput(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboTitle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTitle.KeyPress
        e.Handled = True
    End Sub
    Private Sub cboAccessLevel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboAccessLevel.KeyPress
        e.Handled = True
    End Sub

#End Region

#Region "-- SMS OBJECTS"
    Private Sub cboDongle_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDongle.SelectedValueChanged
        cboPort1.Text = Trim(Mid(cboDongle.Text, 1, 5))
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            Call testPort1()
        Catch ex As Exception
            showErrorMsg(ex.Message, "connect")

        End Try
    End Sub

    Private Sub btnCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmd.Click
        Try
            With spDevice
                .WriteLine(txtCommand.Text) '.WriteLine(txtCommand.Text)
                '' atcommands = "AT+CUSD=1,#143*"
                'TextCommand = "*143*#"
                'strCommand = "AT+CUSD=1," & TextCommand & ",15"
                Threading.Thread.Sleep(1000)
                AppendTextBox(txtReceived1, vbNewLine & txtCommand.Text)
            End With
        Catch ex As Exception
            AppendTextBox(txtReceived1, vbNewLine & ex.Message)


        End Try
    End Sub


#End Region

#End Region

End Class