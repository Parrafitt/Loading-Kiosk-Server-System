Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class frmSysLogin

#Region "-=- Local Functions -=-"

    Public bGo As Boolean
    Dim exeType As String
    Dim user As String
    Dim pw As String
    Dim updateShown As Boolean = False
    Public dontCheck As Boolean = True

    '--(00)--prepBwLoad Function
    Public Sub New()
        InitializeComponent()
        bwLoad.WorkerReportsProgress = True
        bwLoad.WorkerSupportsCancellation = True
    End Sub

    '--(01)--prepBwLoad Function
    Private Sub prepBwLoad()

        If bwLoad.IsBusy <> True Then

            imgError.Visible = False
            imgCritical.Visible = False
            imgOk.Visible = False
            If exeType = "connDb" Then
                '------------------------------------------------------------------------------
                '-(1A.1)- Check DB Connection
                '==============================================================================
                lblCp1.Text = "Connecting to Database, please wait . . ."
                lblCp1.Visible = True
                cp1.Visible = True
                cp1.IsRunning = True
                lblCp1.Visible = True
                btnLogin.Enabled = False
                txtUser.Enabled = False
                txtPass.Enabled = False
                user = txtUser.Text
                pw = txtPass.Text
                bwLoad.RunWorkerAsync() '(1B)LocalFunc

            Else
                '------------------------------------------------------------------------------
                '-(1A.2)- Check Credentials
                '==============================================================================
                lblCp1.Text = "Authenticating Credentials, Please Wait . . ."
                lblCp1.Visible = True
                cp1.Visible = True
                cp1.IsRunning = True
                lblCp1.Visible = True
                btnLogin.Enabled = False
                txtUser.Enabled = False
                txtPass.Enabled = False
                user = txtUser.Text
                pw = txtPass.Text
                exeType = "authenticate"
                bwLoad.RunWorkerAsync() '(1B)LocalFunc
            End If
        End If

    End Sub

    '--(02)--bwLoad Functions
    Private Sub bwLoad_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwLoad.DoWork
        If (bwLoad.CancellationPending = True) Then
            e.Cancel = True
        Else

            '* check activation status
            Call checkActivation() '(0D1)mdlGlobalFunc

            If exeType = "authenticate" Then

                ' authenticate user *  * 
                Call checkUserPass() '(03)LocalFunc

            Else

                ' get database connection settings *  * 
                Call getDBconnStringInfo() '(0)mdlGlobalFunc

            End If
        End If
    End Sub
    Private Sub bwLoad_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoad.RunWorkerCompleted

        imgError.Visible = False
        imgOk.Visible = False
        imgCritical.Visible = False

        If exeType = "authenticate" Then
            
            '===================================================================|
            '-(02.A)- AUTHENTICATE
            '===================================================================|
            If bGo = True Then
                userLogName = txtUser.Text 'save userName
                Call getUserInfo() '(03A)mdlGlobalFunc
                If frmMain.Visible = False Then
                    frmMain.Show()
                End If
                frmMain.Enabled = True
                Me.Close()
            Else
                cp1.Visible = False
                lblCp1.Visible = False
                txtPass.Text = ""
                txtUser.Text = ""
                txtUser.Focus()
                MsgBox("Invalid Username and Password!", vbCritical, "Access Denied!")
            End If

        Else

            '===================================================================|
            '-(02.B)- CHECK DATABASE CONNECTION
            '===================================================================|
            If db_connected = False Then

                cp1.Visible = False
                cp1.IsRunning = False
                lblCp1.Visible = True
                imgCritical.Visible = True
                If db_dataSource = "..." Then
                    lblCp1.Text = "< Setup Database Connection >"
                Else
                    lblCp1.Text = "Database Connection Error!"
                End If

            Else

                cp1.Visible = False
                cp1.IsRunning = False
                lblCp1.Visible = False
                lblCp1.Text = "Connected to Database"

                '---------------------------------------------------------------|
                '-(02.C)- get version information
                '===============================================================|
                If isTrial = True Then
                    imgError.Visible = True
                    lblCp1.Visible = True
                    lblCp1.Text = "TRIAL VERSION * * *"
                    If lblVersion.Text.Contains("Trial") = False Then
                        lblVersion.Text = lblVersion.Text & " ( Trial Version ) "
                    End If
                Else
                    If lblVersion.Text.Contains("Trial") = True Then
                        lblVersion.Text = lblVersion.Text.Replace(" ( Trial Version ) ", "")
                    End If
                End If

                '* set values
                btnLogin.Enabled = True
                txtPass.Enabled = True
                txtUser.Enabled = True
                txtPass.Text = ""
                txtUser.Text = ""
                txtUser.Focus()
                Call buttonEvents() '(04)LocalFUNC

                '---------------------------------------------------------------|
                '-(02.D)- check db_version
                '===============================================================|
                If isDbVersionOk() = False Then '(09D)mdlGlobalFunc
                    If current_db_ver <> db_versionOld Then
                        txtPass.Enabled = False
                        txtUser.Enabled = False
                        imgOk.Visible = False
                        imgError.Visible = False
                        imgCritical.Visible = True
                        lblCp1.Visible = True
                        lblCp1.Text = "Invalid database version! Please target database version " & current_db_ver & ""
                        Exit Sub
                    Else

                        If updateShown = False Then
                            updateShown = True
                            dontCheck = True
                            If MsgBox("Current database version : " & current_db_ver & " " & vbNewLine & _
                                      "Database version after update : " & db_version & " " & vbNewLine & vbNewLine & _
                                      "* This Program is about to update its database structure and modify specific data." & vbNewLine & vbNewLine & _
                                 "* Please ensure that you have backed-up your database before continuing." & vbNewLine & vbNewLine & _
                                 "Do you wish to continue?", vbQuestion + vbYesNoCancel, "Update Database?") = vbYes Then
                                With frmSysPatcher
                                    If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                                        .Close()
                                    Else
                                        .Close()
                                    End If
                                End With
                            Else
                                updateShown = True
                                dontCheck = False
                            End If
                        Else
                            txtPass.Enabled = False
                            txtUser.Enabled = False
                            imgOk.Visible = False
                            imgError.Visible = False
                            imgCritical.Visible = True
                            lblCp1.Visible = True
                            lblCp1.Text = "Invalid database version! Please update database version to " & current_db_ver & ""
                            Exit Sub
                        End If

                    End If
                End If

                '---------------------------------------------------------------|
                '-(02.E)- check systemVersion
                '===============================================================|
                If isSystemVersionOk() = False Then
                    If current_sys_ver <> systemVersionOld Then
                        txtPass.Enabled = False
                        txtUser.Enabled = False
                        imgOk.Visible = False
                        imgError.Visible = False
                        imgCritical.Visible = True
                        lblCp1.Visible = True
                        If current_sys_ver <> "" Then
                            lblCp1.Text = "Invalid program version! Please install " & systemNameShort & " - " & current_sys_ver & ""
                        Else
                            lblCp1.Text = "< INVALID PROGRAM VERSION ! >"
                        End If
                    Else
                        '------------------------------------------------------|
                        '-(02.E1)- Update systemVersion
                        '------------------------------------------------------|
                        If updateSystemVersion() = False Then '(09H)mdlGlboalFunc - updates system version if meets previous version
                            txtPass.Enabled = False
                            txtUser.Enabled = False
                            imgOk.Visible = False
                            imgError.Visible = False
                            imgCritical.Visible = True
                            lblCp1.Visible = True
                            lblCp1.Text = "A database error occured!"
                            Exit Sub
                        Else
                            lblVersion.Text = systemNameShort & " - " & systemVersion & ""
                        End If
                    End If
                End If

            End If

        End If

    End Sub

    '--(03)--VALIDATE userName and passWord
    Private Sub checkUserPass()

        bGo = False

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT EmpCode FROM man_user " & _
                                                  "WHERE Username=@0 " & _
                                                  "AND Password=@1 " & _
                                                  "AND isVisible='Y'", con)

        Dim myReader As MySqlDataReader
        Try
            con.Open()
            sql.Parameters.AddWithValue("@0", user)
            sql.Parameters.AddWithValue("@1", base64Encode(pw))
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    userEmpCode = myReader.GetValue(0).ToString
                End While
                bGo = True
            End If
            con.Close()
        Catch myerror As MySqlException
            bGo = False
            showErrorMsg(myerror.Message, "(03)" & Me.Name)
        Finally
            con.Dispose()
        End Try

    End Sub

    '--(04)--BOTTONS Function
    Private Sub buttonEvents()
        If txtPass.Text = "" Or txtUser.Text = "" Then
            btnLogin.Visible = False
        Else
            btnLogin.Visible = True
        End If
    End Sub

    '--(05)--SETUP Database
    Private Sub setupDB()

        lockFunction = True
        With frmSysSettings

            If db_connected = True Then
                lockFunction = False
            End If

            .SuperTabControl1.SelectedTab = .spDatabase
            .spSystemSettings.Visible = False
            .spUser.Visible = False
            .spActivation.Visible = False
            .gp1.Enabled = False
            .gp2.Enabled = False
            .gp3.Enabled = True
            .Show()
            .txtDBsource.Focus()
            .txtDBsource.SelectAll()

        End With

    End Sub

    '--(06)--PREP FOR ACTIVATIVATION
    Private Sub prepActivation()

        '* activate product
        lockFunction = True
        With frmSysSettings
            .spSystemSettings.Visible = False
            .spUser.Visible = False
            .spActivation.Visible = True
            .SuperTabControl1.SelectedTab = .spDatabase
            lockFunction = False
            .spDatabase.Visible = False
            .SuperTabControl1.SelectedTab = .spActivation
            .Show()
        End With

    End Sub

#End Region

#Region "-=- UI Functions -=-"

    '=-CLOSE
    Private Sub MyBase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ResponsiveSleep(500)
        If frmMain.Enabled = False Then
            frmMain.Close()
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '=-LOAD
    Private Sub frmSysLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'prep form
        Cursor.Current = Cursors.WaitCursor
        ResponsiveSleep(1000)

        imgError.Location = cp1.Location
        imgCritical.Location = cp1.Location
        imgOk.Location = cp1.Location
        If frmMain.Visible = True Then
            frmMain.Enabled = False
        End If

        lblVersion.Text = systemNameShort & " - " & systemVersion & ""

        dontCheck = False
        errorMsg = ""
        exeType = "connDb"
        Call prepBwLoad() '(1A)localFunc

    End Sub

    '=-ACTIVATED
    Private Sub MyBase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        '* check database connection
        If dontCheck = False Then
            errorMsg = ""
            exeType = "connDb"
            Call prepBwLoad() '(1A)localFunc
        End If

    End Sub

    '=-USERNAME keypress
    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPass.Focus()
        Else
            Call buttonEvents() '(2)LocalFUNC
        End If
    End Sub

    '=-PASSWORD keypress Function
    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then 'on enter key goto textbox
            Call btnLogin_Click(sender, e)
        Else
            Call buttonEvents() '(2)LocalFUNC
        End If
    End Sub

    '=-LOGIN Function
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If db_connected = True Then
            exeType = "authenticate"
            Call prepBwLoad() '(01)localFunc
        Else
            showErrorMsg(db_error_msg, "(btnLogin_Click)" & Me.Name)
            txtUser.Focus()
        End If

    End Sub

    '=-lblVersion Function
    Private Sub lblVersion_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblVersion.DoubleClick

        Call setupDB() '(05)localFunc

    End Sub

    '=-lblCp1 Function
    Private Sub lblCp1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCp1.DoubleClick

        Call setupDB() '(05)localFunc

    End Sub
    Private Sub lblCp1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCp1.MouseHover
        If errorMsg <> "" Then
            errorCap = "Attention!"
            popBaloon(lblCp1, Me)
        End If
    End Sub

    '=-imgError Function
    Private Sub imgError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgError.Click

        If lblCp1.Text.Contains("TRIAL") = True Then

            Call prepActivation() '(06)localFunc

        Else

            '* check database connection
            imgError.Visible = False
            exeType = "connDb"
            Call prepBwLoad() '(01)localFunc

        End If

    End Sub

    '=-imgCritical Function
    Private Sub imgCritical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgCritical.Click

        '* check database connection
        exeType = "connDb"
        Call prepBwLoad()

    End Sub

#End Region

End Class