Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports System.IO

Public Class frmSysPatcher

#Region "-- Local Functions --"

    '--VARIABLES--
    Dim progressPercent As Integer
    Dim progressCtr As Integer = 10 'Total number of function calls in bwQuery
    Dim hasError As Boolean
    Dim errorCtr As Integer

    '--(00)--prepBwLoad Function
    Public Sub New()
        InitializeComponent()
        bwLoad.WorkerReportsProgress = True
        bwLoad.WorkerSupportsCancellation = True
    End Sub

    '--(01)--prepBwLoad Function
    Private Sub prepBwLoad()

        If bwLoad.IsBusy <> True Then

            With cp1
                .ProgressColor = Color.SpringGreen
                .IsRunning = True
                .Visible = True
            End With
            txtProcess.Text = ">Preparing program for database structure update . . ."
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Executing database backup procedures . . . ")

            With frmSysDBexec
                popSuccessBackup = True
                dbExecType = "backup"
                If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    .Close()
                    AppendTextBox(txtProcess, "Success!")
                Else
                    .Close()
                    If MsgBox("Database backup procedures was unsuccessful! " & vbNewLine & _
                              "** NOTE: DATA DAMAGE MAY OCCUR DURING PROGRAM PATCH, BACKUP YOUR DATABASE BEFORE CONTINUING ** " & vbNewLine & vbNewLine & _
                              "Do you still want to continue program patch?", vbCritical + vbYesNoCancel, "Attention!") <> vbYes Then
                        Me.Close()
                    End If
                End If
            End With

            hasError = False
            errorMsg = Nothing
            progressPercent = 0
            errorCtr = 0 'counts total errors occured
            bwLoad.RunWorkerAsync() '(02)LocalFunc

        End If

    End Sub

    '--(02)--bwLoad Functions
    Private Sub bwLoad_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwLoad.DoWork
        If (bwLoad.CancellationPending = True) Then
            e.Cancel = True
        Else

            Dim sqlQuery As String

            '===============================================================================|
            '-(02.A1)- ADD 'pyrl_qb_settings' table
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Updating 'pyrl_qb_settings' table . . . ")
            sqlQuery = "" & _
                "CREATE TABLE `pyrl_qb_settings` (" & _
                "`mainIndex` int(1) NOT NULL AUTO_INCREMENT," & _
               "`bankAcct` varchar(150) COLLATE latin1_general_ci NOT NULL," & _
               "`payeeAcct` varchar(150) COLLATE latin1_general_ci NOT NULL," & _
               "`expenseAcct` varchar(150) COLLATE latin1_general_ci NOT NULL," & _
               "PRIMARY KEY (`mainIndex`)" & _
               ") ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci"
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A1) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A2)- ADD 'pyrl_qb_settings' row
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Adding 'pyrl_qb_settings' row . . . ")
            sqlQuery = "" & _
                "INSERT INTO `sur_hrms`.`pyrl_qb_settings` (`mainIndex`, `bankAcct`, `payeeAcct`, `expenseAcct`) VALUES ('1', '', '', '');"
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A2) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A3)- ADD 'aref_employee_type' Table
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Adding 'aref_employee_type' table . . . ")
            sqlQuery = "" & _
                "CREATE TABLE `aref_employee_type` (" & _
                "`empType` int(2) NOT NULL AUTO_INCREMENT," & _
                "`empTypeName` varchar(25) COLLATE latin1_general_ci NOT NULL," & _
                "`isVisible` char(1) COLLATE latin1_general_ci NOT NULL DEFAULT 'Y'," & _
                "PRIMARY KEY (`empType`)" & _
                ") ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci"
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A3) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A4)- ADD 'aref_employee_type' row
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Adding 'aref_employee_type' row . . . ")
            sqlQuery = "" & _
                "INSERT INTO `sur_hrms`.`aref_employee_type` (`empType`, `empTypeName`, " & _
                "`isVisible`) VALUES " & _
                "(NULL, 'Regular', 'Y'), " & _
                "(NULL, 'Casual', 'Y')," & _
                "(NULL, 'Probationary', 'Y')," & _
                "(NULL, 'Board Member', 'Y');"
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A4) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A5)- UPDATE 'man_employee' Table
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Updating 'man_employee' table structure . . . ")
            sqlQuery = "" & _
                "ALTER TABLE `man_employee` ADD `empType` INT(2) NOT NULL AFTER `terminationDate`; " & _
                ""
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A5) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A6)- UPDATE 'man_employee.empType' Table
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Updating 'man_employee.empType' values . . . ")
            sqlQuery = "" & _
                "UPDATE `man_employee` SET empType=IF(isBoardMember='Y','4','1')"
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A6) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A7)- Truncate tables
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Truncate target tables . . . ")
            sqlQuery = "" & _
                "TRUNCATE `pyrl_list_cola`; " & _
                "TRUNCATE `pyrl_list_hdmf`; " & _
                "TRUNCATE `pyrl_list_philhealth`; " & _
                "TRUNCATE `pyrl_list_sss`; " & _
                "TRUNCATE `pyrl_list_tax`; "
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A7) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A8)- DELETE table RECORDS
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ DELETE 'Salary Deduction' Records of 'pyrl_list_ar' table. . . ")
            sqlQuery = "" & _
                "DELETE FROM `pyrl_list_ar` WHERE transTypeNo='4'; "
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A8) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.A9)- DELETE table RECORDS
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ DELETE 'Salary Deduction' Records of 'pyrl_list_loan' table. . . ")
            sqlQuery = "" & _
                "DELETE FROM `pyrl_list_loan` WHERE transTypeNo='4'; "
            If executeMySQLquery(sqlQuery) = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " !> (02.A9) An Error Occured : " & db_error_msg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

            '===============================================================================|
            '-(02.B)- Updated set_other.db_version
            '===============================================================================|
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "+ Updating database version . . . ")
            If updateDatabaseVersion() = True Then
                AppendTextBox(txtProcess, " Success!")
            Else
                AppendTextBox(txtProcess, vbNewLine & " >  (02.B) An Error Occured : " & errorMsg)
                hasError = True
                errorCtr = errorCtr + 1
            End If
            bwLoad.ReportProgress(0)

        End If

    End Sub
    Private Sub bwLoad_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoad.ProgressChanged
        progressPercent += 1
        CircularProgressText(cp1, (progressPercent / progressCtr) * 100)
    End Sub
    Private Sub bwLoad_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoad.RunWorkerCompleted
        frmSysLogin.dontCheck = False
        If hasError = True Then

            With cp1
                .ProgressColor = Color.LightCoral
                .IsRunning = False
                .Value = 100
                .Visible = True
            End With

            txtProcess.Text = txtProcess.Text & vbNewLine & vbNewLine & _
                "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" & vbNewLine & vbNewLine & _
                "> " & CStr(errorCtr) & " error(s) occured . . ."

        Else

            With cp1
                .ProgressColor = Color.LightGreen
                .IsRunning = False
                .Value = 100
                .Visible = True
            End With

            txtProcess.Text = txtProcess.Text & vbNewLine & vbNewLine & _
                "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" & vbNewLine & vbNewLine & _
                "> Update of Database Structure Successfull . . ." & vbNewLine & vbNewLine & _
                "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"

        End If

        txtProcess.SelectionStart = txtProcess.TextLength
        txtProcess.SelectionLength = 0
        txtProcess.ScrollToCaret()

        If hasError = False Then

            txtProcess.Text = txtProcess.Text & vbNewLine & "THIS WINDOW WILL CLOSE IN : 3"
            txtProcess.SelectionStart = txtProcess.TextLength
            txtProcess.ScrollToCaret()
            ResponsiveSleep(1000)

            txtProcess.Text = txtProcess.Text & " - 2"
            txtProcess.SelectionStart = txtProcess.TextLength
            txtProcess.ScrollToCaret()
            ResponsiveSleep(1000)

            txtProcess.Text = txtProcess.Text & " - 1"
            txtProcess.SelectionStart = txtProcess.TextLength
            txtProcess.ScrollToCaret()
            ResponsiveSleep(1000)

            Me.Close()

        End If

    End Sub

    '--(03)--copyDbTable Functions
    Private Function copyDbTableByFile() As Boolean

        copyDbTableByFile = True

        'Dim db_dirLoc As String = My.Application.Info.DirectoryPath & "\bin\Database Backups\"  'PRIMARY DIRECTORY
        Dim restoreFile As String = db_dirLoc & "\man_fingerprint.sql"
        If File.Exists(restoreFile) = False Then
            restoreFile = My.Application.Info.DirectoryPath & "\bin\Database Backups\man_fingerprint.sql"
            If File.Exists(restoreFile) = False Then
                restoreFile = My.Application.Info.DirectoryPath & "\Database Backups\man_fingerprint.sql"
            End If
        End If
        Try

            Dim bWorkingDir As String = db_dirLoc ' check if mysql
            If File.Exists(db_dirLoc & "\mysql.exe") = True Then
                bWorkingDir = db_dirLoc
                If File.Exists(db_dirLoc1 & "\mysql.exe") = True Then
                    bWorkingDir = db_dirLoc1
                Else
                    copyDbTableByFile = False
                    db_error_msg = "Cannot find file: mysql.exe"
                    Exit Function
                End If
            End If

            'check if backup location exists
            AppendTextBox(txtProcess, vbNewLine & vbNewLine & "  - loading file from " & restoreFile & " . . . ")
            If File.Exists(restoreFile) = True Then

                '---------------------------------------------------------------
                '-(03.A)- create .sql file and save to backup location
                '===============================================================
                Call testDBconn() '(00D)mdlGlobalFunc
                If db_connected = False Then 'checks if connected to database
                    copyDbTableByFile = False
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
                                                         " -D " & db_dataBase & _
                                                         " < """ & restoreFile & """")
                        myStreamWriter.Close()
                        myProcess.WaitForExit()
                        myProcess.Close()
                    Catch ex As Exception
                        db_error_msg = " > (03.A) An Error Occured : " & ex.Message
                        copyDbTableByFile = False
                    End Try

                End If
            Else
                db_error_msg = "File not found!"
                copyDbTableByFile = False
            End If
        Catch ex As Exception
            db_error_msg = " > (03.A) An Error Occured : " & ex.Message
            copyDbTableByFile = False
        End Try

    End Function

    'data fetching variables
    Dim ds As DataTable = New DataTable()
    Dim myReader As MySqlDataReader
    Dim sql As MySqlCommand

    '--(04)--copyDbTable Functions
    Private Function updatePayRates() As Boolean

        updatePayRates = True

        Call connectDB()
        sql = New MySqlCommand("SELECT " & _
                               "pyrl_emp_info.empNo, " & _
                               "aref_pyrl_paytype.payTypeName, " & _
                               "pyrl_emp_info.basicRate " & _
                               "FROM pyrl_emp_info " & _
                               "LEFT JOIN aref_pyrl_paytype ON aref_pyrl_paytype.payType=pyrl_emp_info.paytype ", con)
        ds = New DataTable()
        Try
            con.Open()
            myReader = Sql.ExecuteReader
            ds.Load(myReader, LoadOption.Upsert)
            con.Close()
        Catch myerror As MySqlException
            If myerror.Number.ToString <> "1317" Then
                showErrorMsg(myerror.Message, "(04)" & Me.Name)
            End If
            Return False
        Finally
            con.Dispose()
        End Try

        Dim empNo As String
        Dim basicRate As String
        Dim payType As String
        Dim dailyRate As String
        Dim hourlyRate As String
        Dim minuteRate As String

        Dim tTable As String = "pyrl_emp_info"
        Dim tFields As String = "" & _
                        "@dailyRate," & _
                        "@hourlyRate," & _
                        "@minuteRate"
        Dim tValues As String
        Dim tUpdateField As String

        If ds.Rows.Count <> 0 Then
            With ds
                For x = 0 To .Rows.Count - 1

                    empNo = .Rows(x).Item(0).ToString
                    AppendTextBox(txtProcess, vbNewLine & "  -Updating " & empNo & "...")
                    payType = .Rows(x).Item(1).ToString
                    basicRate = .Rows(x).Item(2).ToString
                    dailyRate = calPayRates(basicRate, payType, "Daily").ToString.Replace(",", "")
                    hourlyRate = calPayRates(basicRate, payType, "Hourly").ToString.Replace(",", "")
                    minuteRate = calPayRates(basicRate, payType, "Minute").ToString.Replace(",", "")

                    tValues = "" & _
                        dailyRate & "^" & _
                        hourlyRate & "^" & _
                        minuteRate & ""
                    tUpdateField = "WHERE empNo='" & empNo & "'"
                    If execMySQLqueryParam("update", tTable, tFields, tValues, tUpdateField) = False Then '(0D2)mdlGlobalFunc
                        showErrorMsg(db_error_msg, "(04)" & Me.Name)
                        AppendTextBox(txtProcess, "ERROR!")
                    End If
                    AppendTextBox(txtProcess, "OK!")

                Next
            End With
        End If
       
    End Function

    '--(04D8)--CALCULATE PAY RATES
    Private Function calPayRates(ByVal basicRate As String, ByVal payType As String, ByVal returnValue As String) As String

        '=====================================================================|
        '--(04D8.A)-- PREP VARIABLES
        '=====================================================================|
        calPayRates = ""
        Dim tBasicRate As Double = 0
        Try
            tBasicRate = CDbl(basicRate)
        Catch ex As Exception
            tBasicRate = 0
        End Try
        Dim dailyRate As Double = 0
        Dim hourlyRate As Double = 0
        Dim minuteRate As Double = 0

        '=====================================================================|
        '--(04D8.B)-- CALCULATE
        '=====================================================================|
        If payType = "Daily" Then

            'for daily
            If basicRate <> "" Then
                dailyRate = basicRate
                hourlyRate = dailyRate / 8
                minuteRate = hourlyRate / 60
            End If

        ElseIf payType = "Monthly" Then

            'for monthly
            If basicRate <> "" Then
                dailyRate = (basicRate * 12) / 365
                hourlyRate = dailyRate / 8
                minuteRate = hourlyRate / 60
            End If

        End If

        '=====================================================================|
        '--(04D8.C)-- SET RETURN VALUES
        '=====================================================================|
        Select Case returnValue
            Case "Daily"
                Return Format(dailyRate, "#,##0.0000")
            Case "Hourly"
                Return Format(hourlyRate, "#,##0.0000")
            Case "Minute"
                Return Format(minuteRate, "#,##0.0000")
        End Select
       
    End Function

#End Region

#Region "-- Main Functions --"

    '=-Close
    Private Sub MyBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If bwLoad.IsBusy = False Then
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    '=-Load
    Private Sub MyBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TitleText = "<h5>" & systemName & " - UPDATING DATABASE STRUCTURE</h5>"
        Call prepBwLoad()

    End Sub

#End Region

End Class