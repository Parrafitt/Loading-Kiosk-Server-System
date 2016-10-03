Imports MySql.Data.MySqlClient

Public Class frmSysAccessConfirm

#Region "-=- Local Function -=-"

    'local variables
    Dim tUsername As String
    Dim bGo As Boolean
    Dim user As String
    Dim pw As String
    Dim ctrRefresh As Integer = 0

#Region "--(00)-- UI Layout and Other Functions --"

    '--(00A)-- Initialize 
    Public Sub New()
        InitializeComponent()
        bwLoad.WorkerReportsProgress = True
        bwLoad.WorkerSupportsCancellation = True
    End Sub

#End Region

#Region "--(01)-- SPECIAL Functions --"

    '--(01A)--prepBwLoad Function
    Private Sub prepBwLoad()

        If bwLoad.IsBusy <> True Then
            imgDenied.Visible = False
            imgLock.Visible = False
            lblStatus.Text = "Authenticating . . ."
            lblStatus.Visible = True
            cp1.Visible = True
            cp1.IsRunning = True
            txtUser.Enabled = False
            txtPass.Enabled = False
            user = txtUser.Text
            pw = txtPass.Text
            bwLoad.RunWorkerAsync() '(1B)LocalFunc
        End If

    End Sub

    '--(01B)--bwLoad Functions
    Private Sub bwLoad_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwLoad.DoWork
        If (bwLoad.CancellationPending = True) Then
            e.Cancel = True
        Else
            Call checkUserPass() '(02)LocalFunc
        End If
    End Sub
    Private Sub bwLoad_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoad.RunWorkerCompleted

        cp1.Visible = False
        cp1.IsRunning = False
        txtUser.Enabled = True
        txtPass.Enabled = True
        lblStatus.BackColor = Color.Transparent

        If bGo = True Then

            userEditBy = tUsername
            DialogResult = Windows.Forms.DialogResult.OK

        Else

            imgDenied.Visible = True
            lblStatus.Visible = True
            lblStatus.Text = "Access Denied !"
            lblStatus.BackColor = Color.Brown
            txtPass.Text = ""
            txtUser.Text = ""
            txtUser.Focus()

        End If

    End Sub

    '--(01C)--VALIDATE userName and passWord
    Private Sub checkUserPass()

        bGo = False

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT Username FROM man_user " & _
                                                   "WHERE Username='" & user & _
                                                   "' AND Password='" & base64Encode(pw) & "' AND isVisible='Y'", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    tUsername = myReader.Item(0).ToString
                End While
                bGo = True
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(01C)" & Me.Name)
        Finally
            con.Dispose()
        End Try

    End Sub

#End Region

#End Region

#Region "-=- UI Function -=-"

    '=-CLOSE
    Private Sub MyBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Enabled = True
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '=-LOAD
    Private Sub MyBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Prep Form
        Cursor.Current = Cursors.WaitCursor
        frmMain.Enabled = False
        Me.KeyPreview = True
        lblStatus.Visible = False
        imgDenied.Visible = False
        imgDenied.Size = cp1.Size
        imgDenied.Location = cp1.Location
        cp1.Visible = False

        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    '=-SHORTCUT Key Functions
    Private Sub MyBase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F3) Then
            Me.KeyPreview = True
            btnDone.PerformClick()
        ElseIf (e.KeyCode = Keys.Escape) Then
            Me.KeyPreview = True
            btnClose.PerformClick()
        End If
    End Sub

    '=-Title
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'set date and time
        If txtTitle.Text = "* * AUTHENTICATION REQUIRED * *" Then
            txtTitle.Text = "AUTHENTICATION REQUIRED"
        Else
            txtTitle.Text = "* * AUTHENTICATION REQUIRED * *"
        End If

        If imgDenied.Visible = True Then
            If ctrRefresh = 3 Then
                lblStatus.Visible = False
                imgDenied.Visible = False
                imgDenied.Size = cp1.Size
                imgDenied.Location = cp1.Location
                cp1.Visible = False
                imgLock.Visible = True
                ctrRefresh = 0
            End If
            ctrRefresh = ctrRefresh + 1
        End If

    End Sub

    '=-btnDone Function
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Call prepBwLoad() '(01)localFunc
    End Sub

    '=-USERNAME keypress
    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPass.Focus()
        End If
    End Sub

    '=-PASSWORD keypress Function
    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then 'on enter key goto textbox
            Call btnDone_Click(sender, e)
        End If
    End Sub

#End Region

End Class