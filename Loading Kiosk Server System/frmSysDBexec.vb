Imports System.IO

Public Class frmSysDBexec

#Region "-=- LOCAL FUNCTIONS -=-"

    '--(00)--INITIALIZE
    Public Sub New()
        InitializeComponent()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub

    '--(01)--DATABASE FUNCTIONS
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        popSuccessBackup = True

        '===========================================================|
        '-(01.A)- BACKUP DATABASE
        '===========================================================|
        If dbExecType = "backup" Then

            '-------------------------------------------------------|
            '-(01.A1)- SET VARIABLE
            '=======================================================|
            AppendTextBox(txtErrors, vbNewLine & vbNewLine & "  -Loading file locations...")
            Dim bLocation As String = getDbBackUpLoc() & "\" '(0E4)mdlGlobalFunc
            Dim bFileName As String = getDBfileName() '(00G)mdlGlobalFunc
            Dim bSqlFile As String = bLocation & bFileName
            Dim bSqlFile2 As String
            AppendTextBox(txtErrors, "OK!")

            '-------------------------------------------------------|
            '-(01.A2)- VERIFY MYSQL FILE
            '=======================================================|
            AppendTextBox(txtErrors, vbNewLine & vbNewLine & "  -Verifying MySqlFile...")
            Dim mysqlFileLoc As String ' check if mysql
            If File.Exists(db_dirLoc & "\mysqldump.exe") = True Then
                mysqlFileLoc = db_dirLoc
            Else
                If File.Exists(db_dirLoc1 & "\mysqldump.exe") = True Then
                    mysqlFileLoc = db_dirLoc1
                Else
                    popSuccessBackup = False
                    AppendTextBox(txtErrors, "Error!" & vbNewLine & "    !> (01.A2) Cannot find mysqldump...")
                    Exit Sub
                End If
            End If
            AppendTextBox(txtErrors, vbNewLine & "    * " & mysqlFileLoc)

            '-------------------------------------------------------|
            '-(01.A3)- VERIFY BACKUP LOCATIONS
            '=======================================================|
            AppendTextBox(txtErrors, vbNewLine & vbNewLine & "  -Verifying directory...")
            If Directory.Exists(bLocation) = True Then
                bSqlFile2 = mysqlFileLoc & "\" & bFileName
                AppendTextBox(txtErrors, vbNewLine & "    * " & bSqlFile)
                AppendTextBox(txtErrors, vbNewLine & "    ** " & bSqlFile2)
            Else
                popSuccessBackup = False
                AppendTextBox(txtErrors, "Error!" & vbNewLine & "    !> (01.A3) Invalid directory...")
                Exit Sub
            End If

            '-------------------------------------------------------|
            '-(01.A4)- EXECUTE BACKUP
            '=======================================================|
            AppendTextBox(txtErrors, vbNewLine & vbNewLine & "  -Checking connection...")
            Call testDBconn() '(00D)mdlGlobalFunc
            If db_connected = True Then
                AppendTextBox(txtErrors, "OK!")
                AppendTextBox(txtErrors, vbNewLine & "  -Executing backup...")
                Try
                    Dim myProcess As New Process()
                    myProcess.StartInfo.FileName = "cmd.exe"
                    myProcess.StartInfo.UseShellExecute = False
                    myProcess.StartInfo.WorkingDirectory = mysqlFileLoc
                    myProcess.StartInfo.RedirectStandardInput = True
                    myProcess.StartInfo.RedirectStandardOutput = True
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    myProcess.StartInfo.CreateNoWindow = True
                    myProcess.Start()
                    Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                    Dim mystreamreader As StreamReader = myProcess.StandardOutput
                    myStreamWriter.WriteLine("mysqldump.exe --host=" & db_dataSource & _
                                             " --user=" & db_userID & _
                                             " --password=" & db_passWord & _
                                             " " & db_dataBase & _
                                             " -r """ & bSqlFile & """")
                    myStreamWriter.Close()
                    myProcess.WaitForExit()
                    myProcess.Close()
                Catch ex As Exception
                    popSuccessBackup = False
                    AppendTextBox(txtErrors, "Error!" & vbNewLine & "    !> (01.A4) " & ex.Message & "")
                    Exit Sub
                End Try

            Else
                popSuccessBackup = False
                AppendTextBox(txtErrors, "Error!" & vbNewLine & "    !> UNABLE TO CONNECT TO SERVER!")
                Exit Sub
            End If
            AppendTextBox(txtErrors, "OK!")

            '-------------------------------------------------------|
            '-(01.A5)- EXECUTE COPYING OF BACKUP
            '=======================================================|
            'AppendTextBox(txtErrors, vbNewLine & "  -Copying backup file...")
            'Try
            '    If bLocation & bFileName <> db_dirLoc & bFileName Then
            '        System.IO.File.Copy(bSqlFile, bSqlFile2)
            '    End If
            'Catch ex As Exception
            '    AppendTextBox(txtErrors, "Error!" & vbNewLine & "    !> (01.A5) " & ex.Message & "")
            'End Try
            'AppendTextBox(txtErrors, "OK!")

            Exit Sub
        End If

        '===========================================================|
        '-(01.B)- RESTORE DATABASE
        '===========================================================|
        AppendTextBox(txtErrors, vbNewLine & "> Dropping exisiting tables . . . ")
        If clearDbTables() = True Then
            AppendTextBox(txtErrors, " Success!")
            AppendTextBox(txtErrors, vbNewLine & "> Importing new data . . . ")
            If restoreDB(dbRestoreLoc) = True Then '(0D2)mdlGlobalFunc
                AppendTextBox(txtErrors, " Success!")
            Else
                popSuccessBackup = False
            End If
        Else
            AppendTextBox(txtErrors, vbNewLine & " !> (00L)mdlGlobalFunc : An Error Occured - " & db_error_msg)
            popSuccessBackup = False
            Exit Sub
        End If

    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        CircularProgress1.Visible = False
        btnCancel.Text = "Close"
        If frmMain.Visible = True Or frmSysSettings.Visible = True Then
            If dbExecType = "backup" Then
                If popSuccessBackup = True Then
                    imgOk.Visible = True
                    lblStatus.Text = "Database Backup SUCCESSFUL!"
                    lblStatus.BackColor = Color.LightGreen
                    AppendTextBox(txtErrors, vbNewLine & vbNewLine & "> Database Backup Successful!")
                Else
                    imgError.Visible = True
                    lblStatus.Text = "ATTENTION: Database Backup FAILED . . . "
                    lblStatus.BackColor = Color.LightCoral
                    AppendTextBox(txtErrors, vbNewLine & vbNewLine & "> Database Backup Failed!")
                End If
            Else
                If popSuccessBackup = True Then
                    imgOk.Visible = True
                    lblStatus.Text = "Database Restoration SUCCESSFUL!"
                    lblStatus.BackColor = Color.LightGreen
                    txtErrors.Text = txtErrors.Text & vbNewLine & "> Database Restoration Successful!"
                Else
                    imgError.Visible = True
                    lblStatus.Text = "ATTENTION: Database Restoration FAILED . . . "
                    lblStatus.BackColor = Color.LightCoral
                    txtErrors.Text = txtErrors.Text & vbNewLine & "> " & db_error_msg & vbNewLine & "> Database Restoration Failed!"
                End If
            End If
        Else
            If popSuccessBackup = False Then
                If dbExecType = "backup" Then
                    imgError.Visible = True
                    lblStatus.Text = "ATTENTION: Database Backup FAILED . . . "
                    lblStatus.BackColor = Color.LightCoral
                    txtErrors.Text = txtErrors.Text & vbNewLine & "> " & db_error_msg & vbNewLine & "> Database Backup Failed!"
                Else
                    imgError.Visible = True
                    lblStatus.Text = "ATTENTION: Database Restoration FAILED . . . "
                    lblStatus.BackColor = Color.LightCoral
                    txtErrors.Text = txtErrors.Text & vbNewLine & "> " & db_error_msg & vbNewLine & "> Database Restoration Failed!"
                End If
            Else
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

#End Region

#Region "-=- UI FUNCTIONS -=-"

    '=-LOAD
    Private Sub frmAutoDBbackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        imgOk.Location = CircularProgress1.Location
        imgError.Location = CircularProgress1.Location
        txtErrors.Select()
        If dbExecType = "backup" Then
            Me.TitleText = "<h5>DATABASE BACKUP</h5>"
            lblStatus.Text = "Please wait while we backup your Database . . . "
            txtErrors.Text = "> Executing database backup procedures . . . "
        Else
            Me.TitleText = "<h5>RESTORE DATABASE</h5>"
            lblStatus.Text = "Please wait while we restore your Database . . . "
            txtErrors.Text = "> Executing database restoration procedures . . . "
        End If

        btnCancel.Text = "Cancel"
        If BackgroundWorker1.IsBusy <> True Then
            CircularProgress1.IsRunning = True
            BackgroundWorker1.RunWorkerAsync() '(01)localFunc
        End If
    End Sub

    '=-btnCancel Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        BackgroundWorker1.CancelAsync()
        Me.Close()
    End Sub

#End Region

End Class