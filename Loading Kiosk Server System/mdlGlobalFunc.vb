Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Environment
Imports System.Drawing.Printing

Module mdlGlobalFunc

    '--(VARIABLES: System Information)--
    Public systemVersion As String = "Version 0.0.1"
    Public systemVersionOld As String = "Version 0.0.01"

    Public systemCompName As String = "VENDO, INC."
    Public systemCompCode As String = "vi"
    Public systemCompAddress As String = "Davao City"
    Public systemName As String = "Load Kiosk Server Central"
    Public systemNameShort As String = "LKSC"
    Public systemCopyright As String = "© " & Today.ToString("yyyy") & " Parrafitt Technologies. All Rights Reserved."
    Public systemDataFolder As String = getAppFolder() '(05A)mdlGlobalFunc

    Public current_sys_ver As String
    Public current_db_ver As String

    '--(VARIABLES: Database Settings)--
    Public db_version As String = "v1.0"
    Public db_versionOld As String = "v1.01"

    Public db_conStrFile As String = systemDataFolder & "\" & systemNameShort & "cs.dat"
    Public db_dirLoc As String = My.Application.Info.DirectoryPath & "\bin\Database Backups"  'PRIMARY DIRECTORY
    Public db_dirLoc1 As String = "C:\xampp\mysql\bin\" 'SECONDARY
    Public db_backupSetFile As String = systemDataFolder & "\" & systemNameShort & "db.dat"

    Public db_dataSource As String = "..."
    Public db_dataBase As String = "..."
    Public db_userID As String = "..."
    Public db_passWord As String = "..."

    Public isDBoveride As Boolean = False
    Public db_connected As Boolean = True
    Public db_error_msg As String
    Public popSuccessBackup As Boolean = False
    Public dbExecType As String
    Public dbRestoreLoc As String

    '--(VARIABLES: Product Activation Settings)--
    Public activationFile As String = systemDataFolder & "\" & systemNameShort & "af.dat"
    Public isTrial As Boolean = True
    Public trialLimitRecord As Integer = 2 '<= LIMITATION APPLIED TO ALL MANAGERS =>
    Public trialCtr As Integer

    '--(VARIABLES: Branch Settings)--
    Public branchFile As String = systemDataFolder & "\" & systemNameShort & "bf.dat"
    Public branchNo As String = ""
    Public branchCode As String = ""
    Public branchName As String = ""

    '--(VARIABLES: Public)--
    Public attLogDir As String = My.Application.Info.DirectoryPath & "\"
    Public attLogFile As String = ""
    Public quickAddUsed As Boolean = False
    Public lockFunction As Boolean = False

#Region "--(00)-- DATABASE FUNCTIONS"

    '--(00A)--connect to mySQL database
    Public con As New MySqlConnection
    Public Sub connectDB()

        con.ConnectionString = ("Data Source=" & db_dataSource & _
                              ";Database=" & db_dataBase & _
                              ";User ID=" & db_userID & _
                              ";Password=" & db_passWord & _
                              ";Convert Zero Datetime=True;")

    End Sub

    '--(00B)--GET DB CONNECTION INFO from txt file
    Public Sub getDBconnStringInfo()

        Dim FileText As String
        Dim FileLines As String()
        Dim OneLine As String()
        Dim SeparatorChar As String = ","

        'Fetch Connection String Information from file
        If My.Computer.FileSystem.FileExists(db_conStrFile) Then
            FileText = My.Computer.FileSystem.ReadAllText(db_conStrFile)
            FileLines = FileText.Split(CChar(Environment.NewLine))

            OneLine = FileLines(0).Split(CChar(SeparatorChar))

            db_dataSource = base64Decode(OneLine(0)) '(4)mdlGlobalFunc
            db_dataBase = base64Decode(OneLine(1))
            db_userID = base64Decode(OneLine(2))
            db_passWord = base64Decode(OneLine(3))
        End If

        'Test Connection
        Call testDBconn() '(0C)mdlGlobalFunc

    End Sub

    '--(00C)--UPDATE Connection String File values
    Public Function updateDBconnStringInfo(ByVal tSource As String,
                                           ByVal tDbName As String,
                                           ByVal tDbUser As String,
                                           ByVal tDbPw As String) As Boolean

        updateDBconnStringInfo = True

        'UPDATE values on file
        Dim strFile As String = db_conStrFile
        Dim SeparatorChar As String = ","
        Dim sw As StreamWriter
        Try
            If System.IO.File.Exists(strFile) = True Then
                System.IO.File.Delete(strFile)
            End If
            sw = File.CreateText(strFile)
            sw.WriteLine(base64Encode(tSource) & SeparatorChar & _
                         base64Encode(tDbName) & SeparatorChar & _
                         base64Encode(tDbUser) & SeparatorChar & _
                         base64Encode(tDbPw)) '(3)mdlGlobalFunc
            SetAttr(strFile, vbHidden)
            sw.Close()
        Catch ex As Exception
            db_error_msg = "(00C)mdlGlobalFunc: " & ex.Message
            updateDBconnStringInfo = False
        End Try

        'Test Connections
        Call getDBconnStringInfo() '(0B1)mdlGlobalFunc

        updateDBconnStringInfo = db_connected

    End Function

    '--(00D)--TEST DB CONNECTION
    Public Sub testDBconn()

        db_connected = True
        Try
            Call connectDB() '(0A)mdlGlobalFunc
            con.Open()
        Catch ex As Exception
            db_connected = False
            db_error_msg = ex.Message
        Finally
            con.Close()
        End Try

    End Sub

    '--(00E)--EXECUTE Query to DB
    Public Function executeMySQLquery(ByRef SQLStatement As String) As Boolean

        executeMySQLquery = True
        Try
            Call connectDB()
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand
            With cmd
                .CommandText = SQLStatement
                .CommandType = CommandType.Text
                .Connection = con
                .ExecuteNonQuery()
            End With
            con.Close()
        Catch myerror As MySqlException
            db_error_msg = myerror.Number & ": " & myerror.Message
            executeMySQLquery = False
        Finally
            con.Dispose()
        End Try

    End Function

    '--(00F)--EXECUTE Query to DB with parameters
    Public Function execMySQLqueryParam(ByVal execType As String,
                                        ByVal targetTable As String,
                                        ByVal targetField As String,
                                        ByVal tValue As String,
                                        ByVal tUpdateField As String) As Boolean

        execMySQLqueryParam = True
        Try

            Dim tSplitFields() As String = Split(targetField, ",")
            Dim tSplitValues() As String = Split(tValue, "^")
            Dim queryStatement As String = ""

            If execType = "insert" Then

                queryStatement = "INSERT INTO " & targetTable & _
                    "(" & targetField.ToString.Replace("@", "") & _
                    ") VALUES(" & targetField & ")"

            ElseIf execType = "update" Then

                queryStatement = "UPDATE " & targetTable & " SET"
                For x = 0 To tSplitFields.Length - 1
                    If x = 0 Then
                        queryStatement = queryStatement & " " & tSplitFields(x).ToString.Replace("@", "") & "=" & tSplitFields(x).ToString
                    Else
                        queryStatement = queryStatement & "," & tSplitFields(x).ToString.Replace("@", "") & "=" & tSplitFields(x).ToString
                    End If
                Next
                queryStatement = queryStatement & " " & tUpdateField

            End If

            Call connectDB() '(00A)mdlGlobalFunc
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(queryStatement, con)
            With cmd
                For x = 0 To tSplitFields.Length - 1
                    .Parameters.AddWithValue(tSplitFields(x).ToString, tSplitValues(x).ToString)
                Next
                .ExecuteNonQuery()
            End With
            con.Close()

        Catch myerror As MySqlException
            db_error_msg = myerror.Number & ": " & myerror.Message
            execMySQLqueryParam = False
        Finally
            con.Dispose()
        End Try

    End Function

    '--(00G)--GET Database Backup Name
    Public Function getDBfileName() As String
        getDBfileName = systemNameShort & "_" & db_version & "_" & Now.ToString("yyMMdd_HHmmss") & ".sql"
    End Function

    '--(00H)--BACKUP Database
    Public Function backupDB(ByVal backupLoc As String) As Boolean

        backupDB = True

        ''---------------------------------------------------------------
        ''-(00H.2)- create .sql file and save to backup location
        ''===============================================================
        'Call testDBconn() '(00D)mdlGlobalFunc
        'If db_connected = True Then
        '    Try
        '        Dim myProcess As New Process()
        '        myProcess.StartInfo.FileName = "cmd.exe"
        '        myProcess.StartInfo.UseShellExecute = False
        '        myProcess.StartInfo.WorkingDirectory = mysqlFileLoc
        '        myProcess.StartInfo.RedirectStandardInput = True
        '        myProcess.StartInfo.RedirectStandardOutput = True
        '        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        '        myProcess.StartInfo.CreateNoWindow = True
        '        myProcess.Start()
        '        Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        '        Dim mystreamreader As StreamReader = myProcess.StandardOutput
        '        myStreamWriter.WriteLine("mysqldump.exe --host=" & db_dataSource & _
        '                                 " --user=" & db_userID & _
        '                                 " --password=" & db_passWord & _
        '                                 " " & db_dataBase & _
        '                                 " -r """ & bSqlFile & """")
        '        myStreamWriter.Close()
        '        myProcess.WaitForExit()
        '        myProcess.Close()
        '        AppendTextBox(frmSysDBexec.txtErrors, vbNewLine & "   -1stFile...OK!")
        '    Catch ex As Exception
        '        AppendTextBox(frmSysDBexec.txtErrors, vbNewLine & "   -1stFile...Error!> " & ex.Message)
        '        backupDB = False
        '    End Try

        '    '---------------------------------------------------------------
        '    '-(00H.3)- copy .sql file to local dir Database Backups
        '    '===============================================================
        '    If backupLoc & bFileName <> db_dirLoc & bFileName Then
        '        System.IO.File.Copy(bSqlFile, bSqlFile2)
        '        AppendTextBox(frmSysDBexec.txtErrors, vbNewLine & "   -2ndFile...OK!")
        '    Else
        '        AppendTextBox(frmSysDBexec.txtErrors, vbNewLine & "   -2ndFile...SKIPPED!")
        '    End If
        'Else
        '    AppendTextBox(frmSysDBexec.txtErrors, vbNewLine & "   !> DISCONNECTED")
        '    backupDB = False
        'End If

    End Function

    '--(00I)--RESTORE Database
    Public Function restoreDB(ByVal restoreLoc As String) As Boolean

        restoreDB = True
        Try
            Dim bLocation As String = restoreLoc
            Dim bWorkingDir As String = db_dirLoc ' check if mysql
            If File.Exists(db_dirLoc & "\mysql.exe") = True Then
                bWorkingDir = db_dirLoc
            Else
                If File.Exists(db_dirLoc1 & "\mysql.exe") = True Then
                    bWorkingDir = db_dirLoc1
                Else
                    restoreDB = False
                    db_error_msg = "Cannot find file: mysql.exe"
                    Exit Function
                End If
            End If

            'check if backup location exists
            If File.Exists(restoreLoc) = True Then

                '---------------------------------------------------------------
                '-(00I.1)- create .sql file and save to backup location
                '===============================================================
                Call testDBconn() '(00D)mdlGlobalFunc
                If db_connected = False Then 'checks if connected to database
                    restoreDB = False
                ElseIf restoreLoc.Contains(systemNameShort & "_" & db_version & "_") = False And isDBoveride = False Then 'checks database name
                    restoreDB = False
                    db_error_msg = "Invalid Database Version!"
                Else

                    Try
                        Dim myProcess As New Process()
                        myProcess.StartInfo.FileName = "cmd.exe"
                        myProcess.StartInfo.UseShellExecute = False
                        myProcess.StartInfo.WorkingDirectory = bWorkingDir
                        myProcess.StartInfo.RedirectStandardInput = True
                        myProcess.StartInfo.RedirectStandardOutput = True
                        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                        myProcess.StartInfo.CreateNoWindow = True
                        myProcess.Start()
                        Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                        Dim mystreamreader As StreamReader = myProcess.StandardOutput
                        myStreamWriter.WriteLine("mysql.exe --host=" & db_dataSource & _
                                                         " --user=" & db_userID & _
                                                         " --password=" & db_passWord & _
                                                         " " & db_dataBase & _
                                                         " < """ & restoreLoc & """")
                        myStreamWriter.Close()
                        myProcess.WaitForExit()
                        myProcess.Close()

                    Catch ex As Exception
                        db_error_msg = " > (00I.1) An Error Occured : " & ex.Message
                    End Try

                End If
            Else
                db_error_msg = "File not found!"
                restoreDB = False
            End If
        Catch ex As Exception
            restoreDB = False
        End Try

    End Function

    '--(00J)--GET dbBackupLoc Function
    Public Function getDbBackUpLoc() As String

        getDbBackUpLoc = db_dirLoc
        Dim FileText As String
        Dim FileLines As String()
        Dim OneLine As String()
        Dim SeparatorChar As String = ","
        Try
            If My.Computer.FileSystem.FileExists(db_backupSetFile) Then
                FileText = My.Computer.FileSystem.ReadAllText(db_backupSetFile)
                FileLines = FileText.Split(CChar(Environment.NewLine))
                OneLine = FileLines(0).Split(CChar(SeparatorChar))
                getDbBackUpLoc = base64Decode(OneLine(0))
            End If
        Catch ex As Exception
            showErrorMsg(ex.Message, "(00J)mdlGlobalFunc")
        End Try

    End Function

    '--(00K)--GET dbBackupOnExit Function
    Public Function backupOnExit() As Boolean

        backupOnExit = False
        Dim FileText As String
        Dim FileLines As String()
        Dim OneLine As String()
        Dim SeparatorChar As String = ","
        Try
            If My.Computer.FileSystem.FileExists(db_backupSetFile) Then
                FileText = My.Computer.FileSystem.ReadAllText(db_backupSetFile)
                FileLines = FileText.Split(CChar(Environment.NewLine))
                OneLine = FileLines(0).Split(CChar(SeparatorChar))
                Dim temp As String = base64Decode(OneLine(1))
                If temp = "Y" Then
                    backupOnExit = True
                End If
            End If
        Catch ex As Exception
            backupOnExit = False
            showErrorMsg(ex.Message, "(00K)mdlGlobalFunc")
        End Try

    End Function

    '--(00L)--clearDbTables Function
    Public Function clearDbTables() As Boolean

        clearDbTables = True
        Dim sqlQuery As String = "" & _
            "DROP DATABASE IF EXISTS `" & db_dataBase & "`; " & _
            "CREATE DATABASE `" & db_dataBase & "` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_general_ci */;"
        If executeMySQLquery(sqlQuery) = False Then
            clearDbTables = False
        End If

    End Function

    '--(00M)--GET 1 VALUE FROM DB
    Public Function getDbValue(ByVal sqlStatement As String, ByVal isAmountFormat As Boolean) As String

        getDbValue = ""

        Call connectDB()
        Dim myReader As MySqlDataReader
        Dim cmd As MySqlCommand = New MySqlCommand(sqlStatement, con)
        Try
            con.Open()
            myReader = cmd.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    getDbValue = myReader.GetValue(0).ToString
                End While
            End If
            con.Close()
        Catch ex As MySqlException
            showErrorMsg(ex.Message, "(00M)mdlPayroll")
            Return "< Error : (00M)mdlPayroll >"
        Finally
            con.Dispose()
        End Try

        If isAmountFormat = True Then
            If getDbValue <> "" Then
                Return Format(CDbl(getDbValue), amountFormat)
            Else
                Return Format(0, amountFormat)
            End If
        Else
            Return getDbValue
        End If

    End Function

#End Region

#Region "--(01)-- PRODUCT ACTIVATION FUNCTIONS"

    '--(01A)--CHECK Activation status
    Public Sub checkActivation()
        isTrial = True

        Dim FileText As String
        Dim FileLines As String()
        Dim OneLine As String()
        Dim SeparatorChar As String = "|"
        Dim tcpuID As String = scrambleSN(CpuId()) '(0D4(0D3)) mdlGlobalFunc
        Dim tempCpuID As String

        If My.Computer.FileSystem.FileExists(activationFile) Then
            FileText = My.Computer.FileSystem.ReadAllText(activationFile)
            FileLines = FileText.Split(CChar(Environment.NewLine))

            OneLine = FileLines(0).Split(CChar(SeparatorChar))

            Try
                tempCpuID = base64Decode(OneLine(0)) '(2)mdlGlobalFunc
                If tcpuID = tempCpuID Then
                    isTrial = False
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    '--(01B)--CREATE Activation File values
    Public Function createdActivationFile(ByVal newKey As String) As Boolean
        createdActivationFile = True
        Dim strFile As String = activationFile
        Dim sw As StreamWriter
        Try
            If System.IO.File.Exists(strFile) = True Then
                System.IO.File.Delete(strFile)
            End If
            sw = File.CreateText(strFile)
            sw.WriteLine(base64Encode(newKey)) '(1)mdlGlobalFunc
            SetAttr(strFile, vbHidden)
            sw.Close()
        Catch ex As Exception
            MsgBox("An Error Occured: (01B)mdlGlobalFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
            createdActivationFile = False
        End Try
    End Function

    '--(01C)--GET CPU ID
    Public Function CpuId() As String
        CpuId = ""
        Try
            Dim computer As String = "."
            Dim wmi As Object = GetObject("winmgmts:" & _
                "{impersonationLevel=impersonate}!\\" & _
                computer & "\root\cimv2")
            Dim processors As Object = wmi.ExecQuery("Select * from " & _
                "Win32_Processor")

            Dim cpu_ids As String = ""
            For Each cpu As Object In processors
                cpu_ids = cpu_ids & ", " & cpu.ProcessorId
            Next cpu
            If cpu_ids.Length > 0 Then cpu_ids = _
                cpu_ids.Substring(2)
            Return cpu_ids
        Catch ex As Exception
            MsgBox("An Error Occured: (01C)mdlGlobalFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
        End Try
    End Function

    '--(01D)--SCRAMBLE SN
    Public Function scrambleSN(ByVal tString As String) As String
        scrambleSN = ""
        Try
            Dim scrambleSN2 As String = ""
            Dim stringList As List(Of String) = New List(Of String)

            For i As Integer = 0 To tString.Length - 1 Step 2
                stringList.Add(tString.Substring(i, 2))
            Next

            Dim ctr As Integer = stringList.Count - 1
            Dim ctrSeparate As Integer = 0
            Dim ctrSeparate2 As Integer = 0
            For x = 0 To stringList.Count - 1
                If (ctr - x) <= ctr Then
                    If x = 0 Then
                        scrambleSN = stringList.Item(ctr - x).ToString
                        ctrSeparate = ctrSeparate + 1
                    ElseIf x Mod 2 Then
                        If ctrSeparate2 = 2 Then
                            scrambleSN2 = scrambleSN2 & "-" & stringList.Item(ctr - x).ToString
                            ctrSeparate2 = 0
                        Else
                            scrambleSN2 = scrambleSN2 & stringList.Item(ctr - x).ToString
                            ctrSeparate2 = ctrSeparate2 + 1
                        End If
                    Else
                        If ctrSeparate = 2 Then
                            scrambleSN = scrambleSN & "-" & stringList.Item(ctr - x).ToString
                            ctrSeparate = 0
                        Else
                            scrambleSN = scrambleSN & stringList.Item(ctr - x).ToString
                            ctrSeparate = ctrSeparate + 1
                        End If
                    End If
                End If
            Next
            scrambleSN = scrambleSN & "-" & scrambleSN2
            Return scrambleSN
        Catch ex As Exception
            MsgBox("An Error Occured: (01D)mdlGlobalFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
        End Try

    End Function

    '--(01E)--SHOW MESSAGE
    Public Sub showTrialMsg()
        MsgBox("* * PRODUCT REGISTRATION REQUIRED * * " & vbNewLine & vbNewLine & _
                  "Please register this product to enjoy its full function." & vbNewLine & vbNewLine & _
                  "Contact us via email: " & vbNewLine & _
                  "parrafitt@yahoo.com" & vbNewLine & _
                  "parrafitt@gmail.com" & vbNewLine & _
                  "parrafitt@msn.com" & vbNewLine & vbNewLine & _
                  systemCopyright, vbCritical, "Process stopped . . !")
    End Sub

#End Region

#Region "--(02)-- THEME FUNCTIONS"

    '--(02A)--GET Theme Style Function
    Public Function getThemeStyle() As String

        getThemeStyle = "Office2010Black"
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT setValue FROM set_other WHERE function='theme'", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    getThemeStyle = myReader.GetValue(0)
                End While
            Else
                MsgBox("mdlGlobalFunc(02A) - Error Retrieving ThemeStyle", vbCritical, "Error")
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(02A)mdlGlobalFunc")
        Finally
            con.Dispose()
        End Try

    End Function

    '--(02B)--SET Theme Style Function
    Public Sub setThemeStyle(ByVal tThemeStyle As String)

        Dim sqlStatement As String = "UPDATE set_other SET setValue='" & tThemeStyle & "' WHERE function='theme'"
        If executeMySQLquery(sqlStatement) = False Then
            showErrorMsg(db_error_msg, "(02B)mdlGlobalFunc")
        End If

    End Sub

#End Region

#Region "--(03)-- USER ACCOUNTS FUNCTIONS"

    '--(03A)--GET user information
    Public userTitle As String
    Public userEmpCode As String
    Public userLogName As String
    Public userFirstName As String
    Public userLastName As String
    Public userAccessLevel As String
    Public userEditBy As String
    Public Sub getUserInfo()
        userTitle = ""
        userFirstName = ""
        userLastName = ""
        userAccessLevel = ""

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                   "man_user.Title,  " & _
                                                   "man_user.FName,  " & _
                                                   "man_user.LName,  " & _
                                                   "man_user_access.accessName " & _
                                                   "FROM man_user " & _
                                                   "LEFT JOIN man_user_access ON man_user_access.accessNo = man_user.accessNo " & _
                                                   "WHERE man_user.EmpCode='" & userEmpCode & "'", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    userTitle = myReader.GetValue(0)
                    userFirstName = myReader.GetValue(1)
                    userLastName = myReader.GetValue(2)
                    userAccessLevel = myReader.GetValue(3)
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            MsgBox("An Error Occured: (03A)mdlGlobalFunc" & vbNewLine & "> " & myerror.Message, vbExclamation, "Attention!")
        Finally
            con.Dispose()
        End Try
    End Sub

    '--(03B)--GET userAccessNo
    Public Function getUserAccessNo(ByVal tAccessName As String) As String
        getUserAccessNo = ""

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                   "man_user_access.accessNo  " & _
                                                   "FROM man_user_access " & _
                                                   "WHERE man_user_access.accessName='" & tAccessName & "'", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    getUserAccessNo = myReader.GetValue(0).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            MsgBox("An Error Occured: (03B)mdlGlobalFunc" & vbNewLine & "> " & myerror.Message, vbExclamation, "Attention!")
        Finally
            con.Dispose()
        End Try
    End Function

    '--(03C)--POPULATE user information
    Public Function getEmpCode(ByVal username As String) As String
        getEmpCode = ""
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                   "man_user.empCode " & _
                                                   "FROM man_user " & _
                                                   "WHERE man_user.username='" & username & "' " & _
                                                   "AND man_user.isVisible='Y'", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    getEmpCode = myReader.GetValue(0).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            MsgBox("An Error Occured: (03C)mdlGlobalFunc" & vbNewLine & "> " & myerror.Message, vbExclamation, "Attention!")
        Finally
            con.Dispose()
        End Try
    End Function

#End Region

#Region "--(04)-- CHILD FORM FUNCTIONS"

    '--(04A)--CLOSE ChildForms
    Public Sub closeChildForms()

        '--LIST--
        If frmMain.btnManMachine.Checked = True Then
            frmManMachine.Close()
        End If
        If frmMain.btnManNetwork.Checked = True Then
            frmManNetwork.Close()
        End If
        If frmMain.btnManItem.Checked = True Then
            frmManItem.Close()
        End If
        If frmMain.btnManFranchisee.Checked = True Then
            frmManFranchisee.Close()
        End If
        If frmMain.btnManAdvertisement.Checked = True Then
            frmManAdvt.Close()
        End If

        '--LOG--
        If frmMain.btnLogMachine.Checked = True Then
            frmLogMachine.Close()
        End If
        If frmMain.btnLogTrans.Checked = True Then
            frmLogTrans.Close()
        End If

    End Sub

#End Region

#Region "--(05)-- SPECIAL FUNCTIONS"

    '--(05A)--GET APP FOLDER
    Public Function getAppFolder() As String

        getAppFolder = GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Parrafitt Technologies\" & systemCompCode & "_" & systemNameShort
        Try
            If Directory.Exists(getAppFolder) = False Then
                Directory.CreateDirectory(getAppFolder)
            End If
        Catch ex As Exception
            showErrorMsg(ex.Message, "(05A)mdlGlobalFunc")
        End Try

    End Function

    '--(05B)--base64Encode Function for Password Enryption
    Public Function base64Encode(ByVal sData As String) As String
        Try
            Dim encData_byte As Byte() = New Byte(sData.Length - 1) {}
            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData)
            Dim encodedData As String = Convert.ToBase64String(encData_byte)
            Return (encodedData)
        Catch ex As Exception
            MsgBox("An Error Occured: (05B)mdlGlobalFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
            Throw (New Exception("Error in base64Encode" & ex.Message))
        End Try
    End Function

    '--(05C)--base64Decode Function for Password Decryption
    Public Function base64Decode(ByVal sData As String) As String
        Dim encoder As New System.Text.UTF8Encoding()
        Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(sData)
        Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        Dim result As String = New [String](decoded_char)
        Return result
    End Function

    '--(05D)--Resize Image
    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image

        Try

            Dim newWidth As Integer
            Dim newHeight As Integer
            If preserveAspectRatio Then
                Dim originalWidth As Integer = image.Width
                Dim originalHeight As Integer = image.Height
                Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
                Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
                Dim percent As Single = If(percentHeight < percentWidth, percentHeight, percentWidth)
                newWidth = CInt(originalWidth * percent)
                newHeight = CInt(originalHeight * percent)
            Else
                newWidth = size.Width
                newHeight = size.Height
            End If

            Dim newImage As Image = New Bitmap(newWidth, newHeight)
            Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
            End Using

            Return newImage

        Catch ex As Exception
            showErrorMsg(ex.Message, "(05D)mdlGlobalFunc")
            Return Nothing
        End Try

    End Function

    '--(05E.1)--SelectDistinct
    Public Function SelectDistinct(ByVal TableName As String, ByVal SourceTable As DataTable, ByVal FieldName As String) As DataTable

        Try

            Dim dt As DataTable = New DataTable
            dt = SourceTable.Clone()

            SourceTable.DefaultView.Sort = "[" & FieldName & "] ASC"
            Dim LastValue As Object = Nothing

            For x = 0 To SourceTable.DefaultView.Count - 1

                If ColumnEqual(LastValue, SourceTable.DefaultView(x).Item(FieldName)) = False Then '(05E.2)mdlGlobalFunc
                    LastValue = SourceTable.DefaultView(x).Item(FieldName).ToString
                    dt.ImportRow(SourceTable.DefaultView(x).Row)
                End If

            Next

            Return dt

        Catch ex As Exception
            showErrorMsg(ex.Message, "(05E)mdlGlobalFunc")
            Return Nothing
        End Try

    End Function

    '--(05E.2)--ColumnEqual
    Private Function ColumnEqual(ByVal A As Object, ByVal B As Object) As Boolean
        ' Compares two values to see if they are equal. Also compares DBNULL.Value.
        ' Note: If your DataTable contains object fields, then you must extend this
        ' function to handle them in a meaningful way if you intend to group on them.

        If IsNothing(A) AndAlso IsNothing(B) Then
            '  both are DBNull.Value
            Return True
        End If
        If IsNothing(A) OrElse IsNothing(B) Then
            '  only one is DBNull.Value
            Return False
        End If
        Return (A.Equals(B))
        ' value type standard comparison
    End Function

#End Region

#Region "--(06)-- STRING MANIPULATION FUNCTIONS"

    '--(06A)--Make letter uppercase (String)
    Public Function convertUpperCase(ByVal tempString As String)
        Dim newWord As String
        newWord = ""
        Dim tempLength = tempString.Length
        Dim tempChar As Char
        For i = 0 To tempLength - 1
            tempChar = tempString.Chars(i)
            If Char.IsLower(tempChar) Then
                'Convert to uppercase, and put at the caret position in the TextBox.
                tempChar = Char.ToUpper(tempChar)
            End If
            newWord = newWord + tempChar
        Next
        Return newWord
    End Function

    '--(06B)--CONVERT to DATE VIEW Funtion
    Public Function convertToDateDB(ByVal tDate As String) As String
        convertToDateDB = ""
        Dim tDay As String = ""
        Dim tMonth As String = ""
        Dim tyear As String = ""

        If tDate.Contains("/") Then
            Dim tArray() As String = Split(tDate, "/")

            tDay = tArray(1).ToString
            tMonth = tArray(0).ToString
            tyear = tArray(2).ToString

            convertToDateDB = tyear & "-" & tMonth & "-" & tDay
        Else
            convertToDateDB = tDate
        End If
        Return convertToDateDB
    End Function

    '--(06C)--SplitStringByChar
    Public Function SplitStringByChar(ByVal StringToSplit As String, ByVal numberOfChar As Integer) As List(Of String)

        Try
            ' Validate the Input
            If numberOfChar > 1 AndAlso StringToSplit.Length > 0 Then
                Dim strings As New List(Of String)
                For i As Integer = 0 To StringToSplit.Length - 1 Step numberOfChar
                    strings.Add(StringToSplit.Substring(i, numberOfChar))
                Next
                Return strings
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("An Error Occured: (06C)mdlGlobalFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
            Return Nothing
        End Try

    End Function

    '--(06D)--cleanStringForDB
    Public Function cleanStringForDB(ByVal tString As String) As String
        cleanStringForDB = tString
        If cleanStringForDB.Contains("'") Then
            cleanStringForDB = cleanStringForDB.Replace("'", "''")
        End If
        Return cleanStringForDB
    End Function

    '--(06D)--STRIP a character in a string
    Function stripCharOfString(ByVal strIn As String, ByVal strRem As Char) As String

        ' Replace invalid characters with empty strings.
        Return strIn.Replace(strRem, "")

    End Function

    '--(06E)--ALPHA input only
    Public Function isAlphaInput(ByVal tChar As Char) As Boolean

        If Asc(tChar) > 32 And Asc(tChar) < 65 Then
            isAlphaInput = False
        ElseIf Asc(tChar) > 90 And Asc(tChar) < 97 Then
            isAlphaInput = False
        ElseIf Asc(tChar) > 122 And Asc(tChar) < 127 Then
            isAlphaInput = False
        Else
            isAlphaInput = True
        End If

    End Function

    '--(06F)--CONVERT to AMOUNT PESO
    Public Function convertToPesoAmount(ByVal tValue As String) As String

        convertToPesoAmount = "0.00"

        If tValue <> "" Then
            convertToPesoAmount = "₱" & tValue
        End If

    End Function

    '--(06G)--IMAGE db Format
    Public Function convertToImageDB(ByVal tValue As String) As String

        convertToImageDB = ""

        If tValue <> "" Then
            convertToImageDB = tValue.Replace("\", "\\")
        End If

    End Function

    '--(06H)--CHECK amount value
    Public amountFormat As String = "#,##0.00"
    Public Sub checkAmountValue(ByRef txtBox As DevComponents.DotNetBar.Controls.TextBoxX, ByRef tForm As Form, ByVal changeValue As Boolean)

        If txtBox.ReadOnly = True Then
            Exit Sub
        End If

        If txtBox.Text <> "" Then
            Try

                Dim temp As Double = CDbl(txtBox.Text)
                If changeValue = True Then
                    txtBox.Text = Format(temp, amountFormat)
                End If

            Catch ex As Exception
                errorCap = "An Error Occured : (06H)mdlGlobalFunc"
                errorMsg = "Please enter a valid amount!"
                popBaloon(txtBox, tForm)
                txtBox.Text = Format(CDbl(0), amountFormat)
                txtBox.SelectAll()
            End Try
        End If

    End Sub

    '--(06I)--CHECK qty value
    Public qtyFormat As String = "#,##0"
    Public Sub checkQtyValue(ByRef txtBox As DevComponents.DotNetBar.Controls.TextBoxX, ByRef tForm As Form, ByVal changeValue As Boolean)

        If txtBox.ReadOnly = True Then
            Exit Sub
        End If

        If txtBox.Text <> "" Then
            Try

                Dim temp As Double = CDbl(txtBox.Text)
                If changeValue = True Then
                    txtBox.Text = Format(temp, qtyFormat)
                End If

            Catch ex As Exception
                errorCap = "An Error Occured : (06I)mdlGlobalFunc"
                errorMsg = "Please enter a valid quantity!"
                popBaloon(txtBox, tForm)
                txtBox.Text = Format(CDbl(0), qtyFormat)
                txtBox.SelectAll()
            End Try
        End If

    End Sub

    '--(06J)--CHECK qty value
    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        val = val.ToLower
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

    '--(06K)--Get Ordinal Suffix
    Public Function GetOrdinalSuffix(ByVal num As Integer) As String

        Try
            If (num.ToString().EndsWith("11")) Then Return "th"
            If (num.ToString().EndsWith("12")) Then Return "th"
            If (num.ToString().EndsWith("13")) Then Return "th"
            If (num.ToString().EndsWith("1")) Then Return "st"
            If (num.ToString().EndsWith("2")) Then Return "nd"
            If (num.ToString().EndsWith("3")) Then Return "rd"
        Catch ex As Exception
            showErrorMsg(ex.Message, "(06K)mdlGlobalFunc")
        End Try
        Return "th"

    End Function

#End Region

#Region "--(07)-- COMBOBOX OBJECT FUNCTIONS"

    '--(07A)--VERIFY if value is in list of ComboBox
    Public Function isInCboList(ByVal cboList As ComboBox) As Boolean

        isInCboList = False
        Dim tempVal As String = convertUpperCase(cboList.Text)
        Try
            For x = 0 To cboList.Items.Count - 1
                If tempVal = convertUpperCase(cboList.Items(x).item(0).ToString) Then
                    isInCboList = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            Try
                For x = 0 To cboList.Items.Count - 1
                    If tempVal = convertUpperCase(cboList.Items(x).ToString) Then
                        isInCboList = True
                        Exit For
                    End If
                Next
            Catch ex2 As Exception
                MsgBox("An Error Occured: (07A)mdlGlobalFunc" & vbNewLine & "> " & ex2.Message, vbExclamation, "Attention!")
            End Try
        End Try

    End Function

    '--(07B)--AUTOCOMPLETE list cboBox any String
    Public Sub autoCompleteListCboBox(ByVal selectedComboBox As ComboBox, ByVal indexOfText As String)

        Try
            With selectedComboBox
                .AutoCompleteCustomSource.Clear() '// Clear AutoCompleteList.
                Try
                    For Each itm As String In selectedComboBox.Items '// loop thru all items in the ComboBox.
                        .AutoCompleteCustomSource.Add(itm) '// add original item to your AutoCompleteList.
                        '// locate the .Substring you want to add to the AutoCompleteList.
                        itm = itm.Substring(itm.IndexOf(indexOfText) + 2) '// get all text following the 'indexOfText'
                        .AutoCompleteCustomSource.Add(itm) '// add .Substring of item to your AutoCompleteList.
                    Next
                Catch ex As Exception
                    Dim itm As String
                    For x = 0 To selectedComboBox.Items.Count - 1
                        If selectedComboBox.Items(x).item(0).ToString() <> "" Then
                            itm = selectedComboBox.Items(x).item(0).ToString()
                            .AutoCompleteCustomSource.Add(itm) '// add original item to your AutoCompleteList.
                            '// locate the .Substring you want to add to the AutoCompleteList.
                            itm = itm.Substring(itm.IndexOf(indexOfText) + 2) '// get all text following the 'indexOfText'
                            .AutoCompleteCustomSource.Add(itm) '// add .Substring of item to your AutoCompleteList.
                        End If
                    Next
                End Try
            End With
        Catch ex As Exception
            MsgBox("An Error Occured: (07B)mdlGlobalFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
        End Try

    End Sub

    '--(07C)--POP cbo
    Public Sub popCbo(ByVal queryStatement As String,
                      ByVal customFirstItm As String,
                      ByVal tDispayMember As String,
                      ByRef targetCbo As ComboBox)

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand(queryStatement, con)
        Dim tDt As DataTable = New DataTable()
        Dim myReader As MySqlDataReader
        Try

            con.Open()
            myReader = sql.ExecuteReader
            tDt.Load(myReader, LoadOption.Upsert)
            con.Close()

            With targetCbo

                .DataSource = Nothing
                .Items.Clear()
                .DataSource = tDt

                If customFirstItm <> "" Then
                    Dim newRow As DataRow = tDt.NewRow
                    newRow(0) = customFirstItm ' adds a custom value at the beginning **
                    tDt.Rows.InsertAt(newRow, 0)
                End If

                .DisplayMember = tDispayMember
                .SelectedIndex = 0
                .Refresh()

            End With

        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(07C)mdlGlobalFunc")
        Finally
            con.Dispose()
        End Try

    End Sub

    '--(07D)--VALIDATE then Add cbo Value
    Public Function validateAddCbo(ByRef targetCbo As ComboBox,
                           ByVal fieldName As String,
                           ByVal targetTable As String,
                           ByVal targetColumn As String) As Boolean

        validateAddCbo = True

        With targetCbo

            If MsgBox("You have entered an unregistered " & fieldName & "." & _
                      vbNewLine & _
                      vbNewLine & _
                      "Do you want to add this record?", vbQuestion + vbYesNoCancel, "Add unregistered record?") = vbYes Then

                Dim tFields As String = "" & _
                        "@" & targetColumn & ""
                Dim tValues As String = "" & _
                    targetCbo.Text.Trim & ""
                If execMySQLqueryParam("insert", targetTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc
                    'MsgBox("Record was successfully added.", vbInformation, "Record Added!")
                Else
                    showErrorMsg(db_error_msg, "(07D)mdlGlobalFunc")
                    validateAddCbo = False
                End If

            Else
                validateAddCbo = False
                .Text = ""
                .Focus()
            End If

        End With

    End Function

#End Region

#Region "--(08)-- SPECIAL FUNCTIONS"

    '--(08A)-- showAccessDenied
    Public Sub showAccessDenied()
        MsgBox("You have a Limited Access Level!" & vbNewLine & vbNewLine & _
                  "Please contact your Supervisor or System Administrator.", vbCritical, "Access Denied!")
    End Sub

    '--(08B)-- GET values of DataGridView to Dataset
    Public Function DatagridviewToDataset(ByVal dgv As DataGridView) As System.Data.DataSet
        Dim ds As New System.Data.DataSet

        'Take the data and structure from the datagridview and return it as a dataset.  You can use 
        '"Imports System.Data" declaration at the top of your project/class and remove the system.data 
        'from the various parts of this function.

        Try
            'Add a new table to the dataset
            ds.Tables.Add("Main")

            'Add the columns
            Dim col As System.Data.DataColumn

            'For each colum in the datagridveiw add a new column to your table
            For Each dgvCol As DataGridViewColumn In dgv.Columns
                col = New System.Data.DataColumn(dgvCol.Name)
                ds.Tables("Main").Columns.Add(col)
            Next

            'Add the rows from the datagridview
            Dim row As System.Data.DataRow
            Dim colcount As Integer = dgv.Columns.Count - 1

            For i As Integer = 0 To dgv.Rows.Count - 1
                row = ds.Tables("Main").Rows.Add

                For Each column As DataGridViewColumn In dgv.Columns
                    row.Item(column.Index) = dgv.Rows.Item(i).Cells(column.Index).Value
                Next

            Next

            Return ds
        Catch ex As Exception
            MsgBox("An Error Occured: (08B)mdlGlobalFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
            'Catch any potential errors and display them to the user
            'MessageBox.Show("Error Converting from DataGridView" & ex.InnerException.ToString, _
            '"Error Converting from DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    '--(08C)-- GET Last day of the month
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function

    '--(08D1)-- DataTable_To_Txt_File
    Public Function DataTable_To_Text(ByVal table As DataTable, ByVal path As String, ByVal header As Boolean, ByVal delimiter As Char) As Boolean

        DataTable_To_Text = True
        Try
            If table.Columns.Count < 0 OrElse table.Rows.Count < 0 Then
                DataTable_To_Text = False
                Exit Function
            End If

            Using sw As IO.StreamWriter = New IO.StreamWriter(path)
                If header Then
                    For i As Integer = 0 To table.Columns.Count - 2
                        sw.Write(table.Columns(i).ColumnName & delimiter)
                    Next
                    sw.Write(table.Columns(table.Columns.Count - 1).ColumnName & Environment.NewLine)
                End If

                For row As Integer = 0 To table.Rows.Count - 2
                    For col As Integer = 0 To table.Columns.Count - 2
                        sw.Write(table.Rows(row).Item(col).ToString & delimiter)
                    Next
                    sw.Write(table.Rows(row).Item(table.Columns.Count - 1).ToString & Environment.NewLine)
                Next

                For col As Integer = 0 To table.Columns.Count - 2
                    sw.Write(table.Rows(table.Rows.Count - 1).Item(col).ToString & delimiter)
                Next
                sw.Write(table.Rows(table.Rows.Count - 1).Item(table.Columns.Count - 1).ToString)
            End Using
        Catch ex As Exception
            showErrorMsg(ex.Message, "(08D)mdlGlobalFunc")
            DataTable_To_Text = False
        End Try

    End Function

    '--(08D2)-- DataTable_To_Txt_File
    Public Function DataTable_To_Text_secure(ByVal table As DataTable, ByVal path As String, ByVal header As Boolean, ByVal delimiter As Char) As Boolean

        DataTable_To_Text_secure = True
        Try
            If table.Columns.Count < 0 OrElse table.Rows.Count < 0 Then
                DataTable_To_Text_secure = False
                Exit Function
            End If
            Using sw As IO.StreamWriter = New IO.StreamWriter(path)
                If header Then
                    For i As Integer = 0 To table.Columns.Count - 2
                        sw.Write(base64Encode(table.Columns(i).ColumnName) & delimiter)
                    Next
                    sw.Write(base64Encode(table.Columns(table.Columns.Count - 1).ColumnName) & Environment.NewLine)
                End If

                For row As Integer = 0 To table.Rows.Count - 2
                    For col As Integer = 0 To table.Columns.Count - 2
                        sw.Write(base64Encode(table.Rows(row).Item(col).ToString) & delimiter)
                    Next
                    sw.Write(base64Encode(table.Rows(row).Item(table.Columns.Count - 1).ToString) & Environment.NewLine)
                Next

                For col As Integer = 0 To table.Columns.Count - 2
                    sw.Write(base64Encode(table.Rows(table.Rows.Count - 1).Item(col).ToString) & delimiter)
                Next
                sw.Write(base64Encode(table.Rows(table.Rows.Count - 1).Item(table.Columns.Count - 1).ToString))
            End Using
        Catch ex As Exception
            showErrorMsg(ex.Message, "(08D)mdlGlobalFunc")
            DataTable_To_Text_secure = False
        End Try

    End Function

    '--(08D3)-- GET attLogFileDir
    Public Function getAttLogFileDir() As String

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                   "funcVal  " & _
                                                   "FROM set_system " & _
                                                   "WHERE set_system.function='attLogFileLoc'", con)
        Dim myReader As MySqlDataReader
        Dim temp As String = ""
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    temp = myReader.GetValue(0).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(08D3)mdlGlobalFunc")
        Finally
            con.Dispose()
        End Try

        If temp <> "" Then
            getAttLogFileDir = temp & "\"
        Else
            getAttLogFileDir = attLogDir
        End If

    End Function

    '--(08D4)-- SET attLogFile
    Public Sub getAttLogFileName()

        attLogDir = getAttLogFileDir() & systemNameShort & "_AttLog_" & Now.ToString("yyMMdd_HHmmss") & ".dat" '(08D3)mdlGlboalFunc
        attLogFile = systemNameShort & "_AttLog_" & Now.ToString("yyMMdd_HHmmss") & ".dat" '(08D3)mdlGlboalFunc

    End Sub

    '--(08D5)-- SET attLogFileDir
    Public Function setAttLogFileDir(ByVal newPath As String) As Boolean

        setAttLogFileDir = True

        Dim tTable As String = "set_system"
        Dim tFields As String = "" & _
            "@funcVal"
        Dim tValues As String = "" & _
            newPath.Trim & "^" & _
            ""
        Dim tUpdateField As String = "WHERE function='attLogFileLoc'"

        If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = True Then '(0D2)mdlGlobalFunc
            MsgBox("Location Was Successfully Updated.", vbInformation, "Location Updated!")
        Else
            showErrorMsg(db_error_msg, "(08D5)mdlGlobalFunc")
            setAttLogFileDir = False
        End If

    End Function

    '--(08E1)-- Txt_File_To_DataTable
    Private Function Text_To_DataTable(ByVal path As String, ByVal delimitter As Char, ByVal header As Boolean) As DataTable

        Try
            Dim source As String = String.Empty
            Dim dt As DataTable = New DataTable

            If IO.File.Exists(path) Then
                source = IO.File.ReadAllText(path)
            Else
                Throw New IO.FileNotFoundException("Could not find the file at " & path, path)
            End If

            Dim rows() As String = source.Split({Environment.NewLine}, StringSplitOptions.None)

            For i As Integer = 0 To rows(0).Split(delimitter).Length - 1
                Dim column As String = rows(0).Split(delimitter)(i)
                dt.Columns.Add(If(header, column, "column" & i + 1))
            Next

            For i As Integer = If(header, 1, 0) To rows.Length - 1
                Dim dr As DataRow = dt.NewRow

                For x As Integer = 0 To rows(i).Split(delimitter).Length - 1
                    If x <= dt.Columns.Count - 1 Then
                        dr(x) = rows(i).Split(delimitter)(x)
                    Else
                        Throw New Exception("The number of columns on row " & i + If(header, 0, 1) & " is greater than the amount of columns in the " & If(header, "header.", "first row."))
                    End If
                Next

                dt.Rows.Add(dr)
            Next

            Return dt
        Catch ex As Exception
            showErrorMsg(ex.Message, "(08E)mdlGlobalFunc")
            Return Nothing
        End Try

    End Function

    '--(08E2)-- Txt_File_To_DataTable
    Public Function Text_To_DataTable_secure(ByVal path As String, ByVal delimitter As Char, ByVal header As Boolean) As DataTable

        Try
            Dim source As String = String.Empty
            Dim dt As DataTable = New DataTable

            If IO.File.Exists(path) Then
                source = IO.File.ReadAllText(path)
            Else
                Throw New IO.FileNotFoundException("Could not find the file at " & path, path)
            End If

            Dim rows() As String = source.Split({Environment.NewLine}, StringSplitOptions.None)

            For i As Integer = 0 To rows(0).Split(delimitter).Length - 1
                Dim column As String = base64Decode(rows(0).Split(delimitter)(i).ToString)
                dt.Columns.Add(If(header, column, "column" & i + 1))
            Next

            For i As Integer = If(header, 1, 0) To rows.Length - 1
                Dim dr As DataRow = dt.NewRow

                For x As Integer = 0 To rows(i).Split(delimitter).Length - 1
                    If x <= dt.Columns.Count - 1 Then
                        dr(x) = rows(i).Split(delimitter)(x).ToString
                        dr(x) = base64Decode(dr(x).ToString)
                        'If x = 0 Then
                        '    dr(x) = getDeviceNoByName(dr(x).ToString)
                        'End If
                    Else
                        Throw New Exception("The number of columns on row " & i + If(header, 0, 1) & " is greater than the amount of columns in the " & If(header, "header.", "first row."))
                    End If
                Next

                dt.Rows.Add(dr)
            Next

            Return dt
        Catch ex As Exception
            showErrorMsg(ex.Message, "(08E2)mdlGlobalFunc")
            Return Nothing
        End Try

    End Function

    '--(08F1)-- GET syncSched
    Public Function getSyncSchedDB() As String

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                   "funcVal  " & _
                                                   "FROM set_system " & _
                                                   "WHERE set_system.function='syncSched'", con)
        Dim myReader As MySqlDataReader
        Dim temp As String = ""
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    temp = myReader.GetValue(0).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(08F1)mdlGlobalFunc")
        Finally
            con.Dispose()
        End Try

        If temp <> "" Then
            getSyncSchedDB = temp
        Else
            getSyncSchedDB = ""
        End If

    End Function

    '--(08F2)-- SET attLogFileDir
    Public Function setSyncSched(ByVal newTime As String) As Boolean

        setSyncSched = True

        If newTime = "12:00 AM" Then
            newTime = ""
        Else
            newTime = CDate(newTime).ToLongTimeString
        End If

        Dim tTable As String = "set_system"
        Dim tFields As String = "" & _
            "@funcVal"
        Dim tValues As String = "" & _
            newTime.Trim & "^" & _
            ""
        Dim tUpdateField As String = "WHERE function='syncSched'"

        If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = True Then '(0D2)mdlGlobalFunc
            MsgBox("Sync Schedule was Successfully Updated.", vbInformation, "Sync Schedule Updated!")
        Else
            showErrorMsg(db_error_msg, "(08F2)mdlGlobalFunc")
            setSyncSched = False
        End If

    End Function

    '--(08F3)-- GET lastSyncSched
    Public Function getLastSyncSchedDB() As String

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                   "funcVal  " & _
                                                   "FROM set_system " & _
                                                   "WHERE set_system.function='lastSync'", con)
        Dim myReader As MySqlDataReader
        Dim temp As String = ""
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    temp = myReader.GetValue(0).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(08F3)mdlGlobalFunc")
        Finally
            con.Dispose()
        End Try

        If temp <> "" Then
            getLastSyncSchedDB = temp
        Else
            getLastSyncSchedDB = ""
        End If

    End Function

    '--(08F4)-- SET LastSyncSched
    Public Function setLastSyncSched(ByVal lastDate As String) As Boolean

        setLastSyncSched = True

        If lastDate = "" Then
            lastDate = ""
        Else
            lastDate = ToMySqlDate(lastDate)
        End If

        Dim tTable As String = "set_system"
        Dim tFields As String = "" & _
            "@funcVal"
        Dim tValues As String = "" & _
            lastDate.Trim & "^" & _
            ""
        Dim tUpdateField As String = "WHERE function='lastSync'"

        If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = True Then '(0D2)mdlGlobalFunc
        Else
            showErrorMsg(db_error_msg, "(08F4)mdlGlobalFunc")
            setLastSyncSched = False
        End If

    End Function

    '--(08G)--ResponsiveSleep
    Public Sub ResponsiveSleep(ByRef iMilliSeconds As Integer)

        Dim i As Integer, iHalfSeconds As Integer = iMilliSeconds / 500
        For i = 1 To iHalfSeconds
            Threading.Thread.Sleep(500) : Application.DoEvents()
        Next i

    End Sub

#End Region

#Region "--(09)-- MULTI BRANCH FUNCTIONS"

    '--(09A)--GET BRANCH INFO
    Public Sub getBranchInfo()

        Try
            Dim strFile As String = branchFile '<= TARGET FILE **
            Dim SeparatorChar As String = ","
            Dim FileText As String
            Dim FileLines As String()
            Dim OneLine As String()

            'Fetch Connection String Information from file
            branchNo = ""
            branchCode = ""
            If My.Computer.FileSystem.FileExists(strFile) Then
                FileText = My.Computer.FileSystem.ReadAllText(strFile)
                FileLines = FileText.Split(CChar(Environment.NewLine))

                OneLine = FileLines(0).Split(CChar(SeparatorChar))

                If OneLine(0).ToString <> "" Then
                    branchNo = base64Decode(OneLine(0)) '(4)mdlGlobalFunc
                End If

                If OneLine(1).ToString <> "" Then
                    branchCode = base64Decode(OneLine(1)) '(4)mdlGlobalFunc
                End If

            End If
        Catch ex As Exception
            showErrorMsg(ex.Message, "(09A)mdlGlobalFunc")
        End Try

    End Sub

    '--(09B)--UPDATE Branch Info
    Public Function updateBranchInfo(ByVal tBranchNo As String, ByVal tBranchCode As String) As Boolean

        updateBranchInfo = True

        'UPDATE values on file
        Dim strFile As String = branchFile '<= TARGET FILE **
        Dim SeparatorChar As String = ","
        Dim sw As StreamWriter
        Try
            With frmSysSettings
                If System.IO.File.Exists(strFile) = True Then
                    System.IO.File.Delete(strFile)
                End If
                sw = File.CreateText(strFile)
                sw.WriteLine(
                    base64Encode(tBranchNo) & SeparatorChar & _
                    base64Encode(tBranchCode))
                SetAttr(strFile, vbHidden)
                sw.Close()
            End With
        Catch ex As Exception
            showErrorMsg(ex.Message, "(09B)mdlGlobalFunc")
            updateBranchInfo = False
        End Try

    End Function

    '--(09C)--GET repNo
    Public Function getBranchName() As String

        getBranchName = ""
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                   "man_branch.branchName " & _
                                                   "FROM man_branch " & _
                                                   "WHERE man_branch.branchNo='" & cleanStringForDB(branchNo) & "' " & _
                                                   "", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    getBranchName = myReader.GetValue(0).ToString
                End While
            Else
                errorMsg = "(09C)mdlGlobalFunc" & vbNewLine & "> man_branch.branchNo='" & cleanStringForDB(branchNo) & "' does not exists."
            End If
            con.Close()
        Catch myerror As MySqlException
            errorMsg = "(09C)mdlGlobalFunc - An Error Occured: " & myerror.Message
        Finally
            con.Dispose()
        End Try

    End Function

    '--(09D)--CHECK db Version
    Public Function isDbVersionOk() As Boolean

        isDbVersionOk = False
        Try

            Call connectDB()
            Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                       "set_other.setValue " & _
                                                       "FROM set_other " & _
                                                       "WHERE set_other.function='db_version' " & _
                                                       "", con)
            Dim myReader As MySqlDataReader
            Try
                con.Open()
                myReader = sql.ExecuteReader
                If myReader.HasRows Then
                    While myReader.Read
                        current_db_ver = myReader.GetValue(0).ToString
                        If db_version = myReader.GetValue(0).ToString Then
                            isDbVersionOk = True
                        End If
                    End While
                Else
                    errorMsg = "(09D)mdlGlobalFunc" & vbNewLine & "> set_other.function='db_version' does not exists."
                End If
                con.Close()
            Catch myerror As MySqlException
                errorMsg = "(09D)mdlGlobalFunc - An Error Occured: " & myerror.Message
            Finally
                con.Dispose()
            End Try

        Catch ex As Exception
            errorMsg = "(09D)mdlGlobalFunc - An Error Occured: " & ex.Message
        End Try

    End Function

    '--(09E)--CHECK System Version
    Public Function isSystemVersionOk() As Boolean

        isSystemVersionOk = False
        Try

            Call connectDB()
            Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                       "set_other.setValue " & _
                                                       "FROM set_other " & _
                                                       "WHERE set_other.function='systemVersion' " & _
                                                       "", con)
            Dim myReader As MySqlDataReader
            Try
                con.Open()
                myReader = sql.ExecuteReader
                If myReader.HasRows Then
                    While myReader.Read
                        current_sys_ver = myReader.GetValue(0).ToString
                        If systemVersion = current_sys_ver Then
                            isSystemVersionOk = True
                        End If
                    End While
                Else
                    errorMsg = "(09E)mdlGlobalFunc" & vbNewLine & "> set_other.function='systemVersion' does not exists."
                End If
                con.Close()
            Catch myerror As MySqlException
                errorMsg = "(09E)mdlGlobalFunc - An Error Occured: " & myerror.Message
            Finally
                con.Dispose()
            End Try

        Catch ex As Exception
            errorMsg = "(09E)mdlGlobalFunc - An Error Occured: " & ex.Message
        End Try

    End Function

    '--(09F)--UPDATE System Version
    Public Function updateSystemVersion() As Boolean

        updateSystemVersion = False
        Try

            If systemVersionOld = "Version 3.3.4" Then 'executes on specific versions only
                Call patchUpdates() '(09H) ** REMOVE IF NOT NEEDED
            End If

            Dim querySql As String = "UPDATE set_other SET " & _
                "set_other.setValue='" & systemVersion & "' " & _
                "WHERE set_other.function='systemVersion' "
            If executeMySQLquery(querySql) = True Then
                updateSystemVersion = True
            Else
                errorMsg = "(09F)mdlGlobalFunc - An Error Occured: " & db_error_msg
            End If

        Catch ex As Exception
            errorMsg = "(09F)mdlGlobalFunc - An Error Occured: " & ex.Message
        End Try

    End Function

    '--(09G)--UPDATE Database Version
    Public Function updateDatabaseVersion() As Boolean

        updateDatabaseVersion = False
        Try

            Dim querySql As String = "UPDATE set_other SET " & _
                "set_other.setValue='" & db_version & "' " & _
                "WHERE set_other.function='db_version' "

            If executeMySQLquery(querySql) = True Then
                updateDatabaseVersion = True
            Else
                errorMsg = "(09G)mdlGlobalFunc - An Error Occured: " & db_error_msg
            End If
        Catch ex As Exception
            errorMsg = "(09G)mdlGlobalFunc - An Error Occured: " & ex.Message
        End Try

    End Function

    '--(09H)--PATCH UPDATES
    Private Sub patchUpdates()

        Dim querySql As String = "" & _
            "UPDATE `sur_hrms`.`aref_pyrl_sss` SET `EC` = '30.00' WHERE `aref_pyrl_sss`.`salaryBracket` = 29; " & _
            "UPDATE `sur_hrms`.`aref_pyrl_sss` SET `EC` = '30.00' WHERE `aref_pyrl_sss`.`salaryBracket` = 30; " & _
            "UPDATE `sur_hrms`.`aref_pyrl_sss` SET `EC` = '30.00' WHERE `aref_pyrl_sss`.`salaryBracket` = 31; "
        If executeMySQLquery(querySql) = False Then
            errorMsg = "(09H1)mdlGlobalFunc - An Error Occured: " & db_error_msg
        End If

    End Sub

#End Region

#Region "--(10)-- PRINTER SETTINGS FUNCTIONS"

    '--(10A)--GET Installed Printers
    Public Sub getPrintersInstalled(ByVal cboList As ComboBox)

        Try

            Dim i As Integer
            Dim pkInstalledPrinters As String

            cboList.Items.Clear()
            For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
                pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
                cboList.Items.Add(pkInstalledPrinters)
            Next

        Catch ex As Exception
            showErrorMsg(ex.Message, "(10A)mdlGlobalFunc")
        End Try

    End Sub

#End Region

End Module

Public Module MyExtensions

    '--(00)--CONVERT DATETIME to mySql FORMAT Function
    <Extension()>
    Public Function ToMySqlDate(ByVal d As Date) As String
        Try
            d = d.ToString("yyyy-MM-dd HH:mm:ss")
            If d <> "1988-01-01 00:00:00" Then
                Return d.ToString("yyyy-MM-dd HH:mm:ss")
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Module

Public Module MyDelegates

    '--(TextBoxX Append)--
    Public Delegate Sub AppendTextBoxDelegate(ByVal TB As DevComponents.DotNetBar.Controls.TextBoxX, ByVal txt As String)
    Public Sub AppendTextBox(ByVal TB As DevComponents.DotNetBar.Controls.TextBoxX, ByVal txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New AppendTextBoxDelegate(AddressOf AppendTextBox), New Object() {TB, txt})
        Else
            TB.AppendText(txt)
            TB.SelectionStart = TB.TextLength
            TB.SelectionLength = 0
            TB.ScrollToCaret()
        End If
    End Sub

    '--(TextBoxX Append)--
    Public Delegate Sub SelectionStartTextBoxDelegate(ByVal TB As DevComponents.DotNetBar.Controls.TextBoxX)
    Public Sub SelectionStartTextBox(ByVal TB As DevComponents.DotNetBar.Controls.TextBoxX)
        If TB.InvokeRequired Then
            TB.Invoke(New SelectionStartTextBoxDelegate(AddressOf SelectionStartTextBox), New Object() {TB})
        Else
            TB.SelectionStart = TB.TextLength
            TB.ScrollToCaret()
        End If
    End Sub

    '--(LabelX)--
    Public Delegate Sub TxtLabelDelegate(ByVal LB As DevComponents.DotNetBar.LabelX, ByVal txt As String)
    Public Sub TxtLabel(ByVal LB As DevComponents.DotNetBar.LabelX, ByVal txt As String)
        If LB.InvokeRequired Then
            LB.Invoke(New TxtLabelDelegate(AddressOf TxtLabel), New Object() {LB, txt})
        Else
            LB.Text = txt
        End If
    End Sub

    '--(ProgressBarX Progress)--
    Public Delegate Sub ProgressBarDelegate(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX, ByVal val As Integer)
    Public Sub ProgressBar(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX, ByVal val As Integer)
        If PB.InvokeRequired Then
            PB.Invoke(New ProgressBarDelegate(AddressOf ProgressBar), New Object() {PB, val})
        Else
            PB.Value = val
        End If
    End Sub

    '--(ProgressBarX Text)--
    Public Delegate Sub ProgressBarTxtDelegate(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX, ByVal txt As String)
    Public Sub ProgressBarTxt(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX, ByVal txt As String)
        If PB.InvokeRequired Then
            PB.Invoke(New ProgressBarTxtDelegate(AddressOf ProgressBarTxt), New Object() {PB, txt})
        Else
            PB.Text = txt
        End If
    End Sub

    '--(CircularProgress Running)--
    Public Delegate Sub CircularProgressRunDelegate(ByVal CP As DevComponents.DotNetBar.Controls.CircularProgress, ByVal isRun As Boolean)
    Public Sub CircularProgressRun(ByVal CP As DevComponents.DotNetBar.Controls.CircularProgress, ByVal isRun As Boolean)
        If CP.InvokeRequired Then
            CP.Invoke(New CircularProgressRunDelegate(AddressOf CircularProgressRun), New Object() {CP, isRun})
        Else
            CP.IsRunning = isRun
        End If
    End Sub

    '--(CircularProgress Value)--
    Public Delegate Sub CircularProgressTextDelegate(ByVal CP As DevComponents.DotNetBar.Controls.CircularProgress, ByVal tValue As Integer)
    Public Sub CircularProgressText(ByVal CP As DevComponents.DotNetBar.Controls.CircularProgress, ByVal tValue As Integer)
        If CP.InvokeRequired Then
            CP.Invoke(New CircularProgressTextDelegate(AddressOf CircularProgressText), New Object() {CP, tValue})
        Else
            CP.Value = tValue
        End If
    End Sub

    '--(Ribonbar)--
    Public Delegate Sub AppendRibbonBarDelegate(ByVal TB As DevComponents.DotNetBar.RibbonBar, ByVal txt As String)
    Public Sub AppendRibbonBar(ByVal TB As DevComponents.DotNetBar.RibbonBar, ByVal txt As String)
        Try
            If TB.InvokeRequired Then
                TB.Invoke(New AppendRibbonBarDelegate(AddressOf AppendRibbonBar), New Object() {TB, txt})
            Else
                TB.Text = txt
            End If
        Catch ex As Exception
            showErrorMsg(ex.Message, "-(02B) Other Functions (AppendRibbonBar)")
        End Try
    End Sub

End Module
