Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar.Metro.ColorTables

Public Class frmMain

#Region "-=- Local Functions -=-"

    Private buttonFile As DevComponents.DotNetBar.Office2007StartButton

    '--(1)--POPULATE user information
    Public Sub popUserInfo()

        lblUserQfirst.Text = userFirstName
        lblUserQlast.Text = convertUpperCase(userLastName)
        lblUserQpos.Text = convertUpperCase(userAccessLevel)
        lblUserQtitle.Text = userTitle

        'set icon of users
        If lblUserQtitle.Text = "Ms" Or lblUserQtitle.Text = "Mrs" Then
            btnUserQiconM.Visible = False
            btnUserQiconF.Visible = True
        Else
            btnUserQiconM.Visible = True
            btnUserQiconF.Visible = False
        End If

    End Sub

    '--(2)--UPDATE themeStyle buttons
    Private Sub updateBtnThemeStyle(ByVal tThemeStyle As String)
        If tThemeStyle = "Office2010Blue" Then
            themeStyle1.Checked = True
        ElseIf tThemeStyle = "Office2010Silver" Then
            themeStyle2.Checked = True
        ElseIf tThemeStyle = "Office2010Black" Then
            themeStyle3.Checked = True
        ElseIf tThemeStyle = "VisualStudio2010Blue" Then
            themeStyle4.Checked = True
        End If
    End Sub

    '--(3)--UPDATE rpList ToolTips
    Private Sub updateRpListTooltips()

        If btnManAdvertisement.Tooltip = "" Then

            btnManAdvertisement.Tooltip = "View " & rbAdvertisement.Text & " Manager..."
            btnAddAdvertisement.Tooltip = "Add new " & rbAdvertisement.Text & "..."
            btnSearchAdvertisement.Tooltip = "Search for " & rbAdvertisement.Text & "..."

            btnManFranchisee.Tooltip = "View " & rbFranchisee.Text & " Manager..."
            btnAddFranchisee.Tooltip = "Add new " & rbFranchisee.Text & "..."
            btnSearchFranchisee.Tooltip = "Search for " & rbFranchisee.Text & "..."

            btnManItem.Tooltip = "View " & rbItem.Text & " Manager..."
            btnAddItem.Tooltip = "Add new " & rbItem.Text & "..."
            btnSearchItem.Tooltip = "Search for " & rbItem.Text & "..."

            btnManMachine.Tooltip = "View " & rbMachine.Text & " Manager..."
            btnAddMachine.Tooltip = "Add new " & rbMachine.Text & "..."
            btnSearchMachine.Tooltip = "Search for " & rbMachine.Text & "..."

            btnManNetwork.Tooltip = "View " & rbNetwork.Text & " Manager..."
            btnAddNetwork.Tooltip = "Add new " & rbNetwork.Text & "..."
            btnSearchNetwork.Tooltip = "Search for " & rbNetwork.Text & "..."

        End If

    End Sub

#End Region

#Region "-=- UI Functions -=-"

#Region "-- DEFAULT FORM FUNCTIONS"

    '=-CLOSE
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmSysLogin.Visible = False Then
            If MsgBox("Unsaved Changes will be Discarded. Are you sure you want to exit?", vbExclamation + vbYesNo + vbDefaultButton2, "Exit Application?") = vbYes Then
                If backupOnExit() = True Then '(0E5)mdlGlobalFunc
                    dbExecType = "backup"
                    frmSysDBexec.Show()
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btnStartExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartExit.Click
        Me.Close()
    End Sub

    '=-LOAD
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'select home rb by default
        rbiHome.Select()

        'lock ribboncontrol
        MainRibbon.AutoExpand = True

        'get theme settings
        Dim tempStyle As String = getThemeStyle() '(0H)mdlGlobalFunc
        Dim style As eStyle = CType(System.Enum.Parse(GetType(eStyle), tempStyle), eStyle)
        StyleManager.ChangeStyle(style, Color.Empty)
        Call updateBtnThemeStyle(tempStyle) '(2)LocalFunc
        Call updateRpListTooltips() '(3)LocalFunc

        Me.KeyPreview = True
        Timer1.Enabled = True
        Timer1.Start()

        With frmServer
            .Width = Me.Width - 30
            .Height = Me.Height - (MainRibbon.Height + 30)
            .MdiParent = Me
            .Show()
        End With

    End Sub

    '=-ACTIVATED
    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'change mouse cursor
        Cursor.Current = Cursors.WaitCursor

        'populate user information
        Call popUserInfo() '(5a)mdlGlobalFunc

        'check activation
        MainRibbon.TitleText = "<h5>" & systemCompName & " ( " & systemNameShort & " - " & systemVersion & " )" & "</h5> "
        If isTrial = True Then
            MainRibbon.TitleText = MainRibbon.TitleText & "TRIAL VERSION * * *"
        End If
    End Sub

    '=-THEME Changer
    Private Sub AppCommandTheme_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles AppCommandTheme.Executed
        Dim source As ICommandSource = TryCast(sender, ICommandSource)
        If TypeOf source.CommandParameter Is String Then
            Dim style As eStyle = CType(System.Enum.Parse(GetType(eStyle), source.CommandParameter.ToString()), eStyle)
            StyleManager.ChangeStyle(style, Color.Empty)
            Call setThemeStyle(source.CommandParameter.ToString()) '(0G2)mdlGLobalFunc
            Call updateBtnThemeStyle(source.CommandParameter.ToString()) '(2)LocalFunc
        ElseIf TypeOf source.CommandParameter Is Color Then
            StyleManager.ColorTint = CType(source.CommandParameter, Color)
        End If
    End Sub

    '=-LOGOUT
    Private Sub btnUserQlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserQlogout.Click
        If MsgBox("Unsaved Changes will be Discarded. Are you sure you want to logout?", vbExclamation + vbYesNoCancel + vbDefaultButton2, "Logout?") = vbYes Then
            Me.Enabled = False

            lblUserQfirst.Text = ""
            lblUserQlast.Text = ""
            lblUserQpos.Text = ""
            lblUserQtitle.Text = ""
            btnUserQiconM.Visible = False
            btnUserQiconF.Visible = False

            'close active forms
            Call closeChildForms() '(9)mdlGlobalFunc

            'select home rb by default
            'If userAccessLevel = "Viewer" Then
            '    rbiHR201.Select()
            'Else
            '    rbiTimeKeep.Select()
            'End If

            frmSysLogin.Show()
        End If
    End Sub

    '=-TIME and DATE
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'set date and time
        lblDisplayDate.Text = Now.ToLongTimeString & " - " & Now.ToLongDateString

    End Sub

    '=-MOUSE HOVER Functions
    Private Sub rbiHR201_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbiHome.MouseHover
        rbiHome.RaiseClick()
    End Sub
    Private Sub rbiLibrary_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbiList.MouseHover
        rbiList.RaiseClick()
    End Sub
    Private Sub rbiLog_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbiLog.MouseHover
        rbiLog.RaiseClick()
    End Sub

    '=-START System Properties
    Private Sub btnStartProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartSettings.Click
         frmSysSettings.Show()
    End Sub

    '=-START ABOUT
    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmSysAbout.Show()
    End Sub

#End Region

#Region "-- SHORTCUT KEYS"

    '=-SHORTCUT Key Functions
    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F10) Then
            Me.KeyPreview = True
            btnUserQlogout.RaiseClick()
            'ElseIf (e.KeyCode = Keys.D2 AndAlso e.Modifiers = Keys.Control) Then
            '    Me.KeyPreview = True
            '    btnInvoiceRecords.RaiseClick()
        End If
    End Sub

#End Region

#Region "-- LIST PANEL --"

    '=-MACHINE
    Private Sub btnManMachine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManMachine.Click
        If Me.btnManMachine.Checked = False Then
            With frmManMachine
                Call closeChildForms() '(2)mdlGlobalFunc
                .Width = Me.Width - 100
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub
    Private Sub btnAddMachine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMachine.Click
        If Me.btnManMachine.Checked = True Then
            frmManMachine.btnAdd.PerformClick()
        Else
            quickAddUsed = True
            btnManMachine.RaiseClick()
        End If
    End Sub
    Private Sub btnSearchMachine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchMachine.Click
        If Me.btnManMachine.Checked = True Then
            If frmManMachine.btnExpand.Visible = True Then
                frmManMachine.btnExpand.PerformClick()
            End If
        Else
            Me.btnManMachine.RaiseClick()
            frmManMachine.btnExpand.PerformClick()
        End If
    End Sub

    '=-NETWORK
    Private Sub btnManNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManNetwork.Click
        If Me.btnManNetwork.Checked = False Then
            With frmManNetwork
                Call closeChildForms() '(2)mdlGlobalFunc
                .Width = Me.Width - 100
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub
    Private Sub btnAddNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNetwork.Click
        If Me.btnManNetwork.Checked = True Then
            frmManNetwork.btnAdd.PerformClick()
        Else
            quickAddUsed = True
            btnManNetwork.RaiseClick()
        End If
    End Sub
    Private Sub btnSearchNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchNetwork.Click
        If Me.btnManNetwork.Checked = True Then
            If frmManNetwork.btnExpand.Visible = True Then
                frmManNetwork.btnExpand.PerformClick()
            End If
        Else
            Me.btnManNetwork.RaiseClick()
            frmManNetwork.btnExpand.PerformClick()
        End If
    End Sub

    '=-ITEM
    Private Sub btnManItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManItem.Click
        If Me.btnManItem.Checked = False Then
            With frmManItem
                Call closeChildForms() '(2)mdlGlobalFunc
                .Width = Me.Width - 100
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub
    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        If Me.btnManItem.Checked = True Then
            frmManItem.btnAdd.PerformClick()
        Else
            quickAddUsed = True
            btnManItem.RaiseClick()
        End If
    End Sub
    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        If Me.btnManItem.Checked = True Then
            If frmManItem.btnExpand.Visible = True Then
                frmManItem.btnExpand.PerformClick()
            End If
        Else
            Me.btnManItem.RaiseClick()
            frmManItem.btnExpand.PerformClick()
        End If
    End Sub

    '=-FRANCHISEE
    Private Sub btnManfranchisee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManFranchisee.Click
        If Me.btnManfranchisee.Checked = False Then
            With frmManFranchisee
                Call closeChildForms() '(2)mdlGlobalFunc
                .Width = Me.Width - 100
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub
    Private Sub btnAddfranchisee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFranchisee.Click
        If Me.btnManfranchisee.Checked = True Then
            frmManFranchisee.btnAdd.PerformClick()
        Else
            quickAddUsed = True
            btnManfranchisee.RaiseClick()
        End If
    End Sub
    Private Sub btnSearchfranchisee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFranchisee.Click
        If Me.btnManfranchisee.Checked = True Then
            If frmManFranchisee.btnExpand.Visible = True Then
                frmManFranchisee.btnExpand.PerformClick()
            End If
        Else
            Me.btnManfranchisee.RaiseClick()
            frmManFranchisee.btnExpand.PerformClick()
        End If
    End Sub

    '=-Advertisement
    Private Sub btnManAdvertisement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManAdvertisement.Click
        If Me.btnManAdvertisement.Checked = False Then
            With frmManAdvt
                Call closeChildForms() '(2)mdlGlobalFunc
                .Width = Me.Width - 100
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub
    Private Sub btnAddAdvertisement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAdvertisement.Click
        If Me.btnManAdvertisement.Checked = True Then
            frmManAdvt.btnAdd.PerformClick()
        Else
            quickAddUsed = True
            btnManAdvertisement.RaiseClick()
        End If
    End Sub
    Private Sub btnSearchAdvertisement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAdvertisement.Click
        If Me.btnManAdvertisement.Checked = True Then
            If frmManAdvt.btnExpand.Visible = True Then
                frmManAdvt.btnExpand.PerformClick()
            End If
        Else
            Me.btnManAdvertisement.RaiseClick()
            frmManAdvt.btnExpand.PerformClick()
        End If
    End Sub

#End Region

#Region "-- LOGS PANEL --"

    '=-MACHINE STATUS
    Private Sub btnLogMachine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogMachine.Click
        If Me.btnLogMachine.Checked = False Then
            With frmLogMachine
                Call closeChildForms() '(2)mdlGlobalFunc
                .Width = Me.Width - 100
                .Height = Me.Height - 100
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub

    '=-TRANSACTION LOG
    Private Sub btnLogTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogTrans.Click
        If Me.btnLogTrans.Checked = False Then
            With frmLogTrans
                Call closeChildForms() '(2)mdlGlobalFunc
                .Width = Me.Width - 100
                .Height = Me.Height - 100
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub

#End Region

#End Region

End Class