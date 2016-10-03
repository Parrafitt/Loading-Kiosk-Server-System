Public Class frmSysAbout

    Private Sub frmAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Enabled = True
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.Enabled = False
        lblCopyright.Text = systemCopyright
        lblVersion.Text = systemNameShort & " - " & systemVersion
        If isTrial = True Then
            lblVersion.Text = lblVersion.Text & " ***UNREGISTERED"
        End If
    End Sub

End Class