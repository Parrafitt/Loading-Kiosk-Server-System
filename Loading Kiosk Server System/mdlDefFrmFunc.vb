Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient

Module mdlDefFrmFunc

    '--(01)--btnRefresh Events
    Public Sub btnRefreshIco(ByVal btnRefresh As DevComponents.DotNetBar.ButtonX)
        If btnRefresh.Tooltip.ToString.Contains("Cancel") = True Then
            btnRefresh.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.cancel
        Else
            btnRefresh.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.refresh
        End If
    End Sub

    '--(02)--View Date Range Function
    Public globalDtFrom As String
    Public globalDtTo As String
    Public Sub viewDateRange(ByVal txtSearch As Object,
                             ByVal cboViewCat As DevComponents.DotNetBar.Controls.ComboBoxEx,
                             ByVal dtFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput,
                             ByVal dtTo As DevComponents.Editors.DateTimeAdv.DateTimeInput)

        Try
            Dim tDay As String = Today.ToString("MM/dd/yyyy")

            If cboViewCat.Text <> "Custom..." Then
                dtFrom.Enabled = False
                dtTo.Enabled = False
            Else
                dtFrom.Enabled = True
                dtTo.Enabled = True
            End If

            Select Case cboViewCat.Text
                Case "All"
                    dtFrom.Text = "01/01/2014"
                    dtTo.Text = tDay
                    txtSearch.Focus()
                Case "Today"
                    dtFrom.Text = tDay
                    dtTo.Text = tDay
                    txtSearch.Focus()
                Case "Yesterday"
                    dtFrom.Text = Now.AddDays(-CInt("1")).ToString("MM/dd/yyyy")
                    dtTo.Text = Now.AddDays(-CInt("1")).ToString("MM/dd/yyyy")
                    txtSearch.Focus()
                Case "This Week"
                    dtFrom.Text = Now.AddDays(-CInt(Today.DayOfWeek - DayOfWeek.Sunday)).ToString("MM/dd/yyyy") 'gets DATE of Sunday This Week
                    dtTo.Text = tDay
                    txtSearch.Focus()
                Case "Last Week"
                    dtFrom.Text = Now.AddDays(-7 + (-CInt(Today.DayOfWeek - DayOfWeek.Sunday))).ToString("MM/dd/yyyy") 'gets DATE of Sunday Last Week
                    dtTo.Text = Now.AddDays(-7 + (-CInt(Today.DayOfWeek - DayOfWeek.Saturday))).ToString("MM/dd/yyyy") 'gets DATE of Saturday Last Week
                    txtSearch.Focus()
                Case "This Month"
                    dtFrom.Text = Today.AddDays(-Today.Day + 1).ToString("MM/dd/yyyy") 'gets FIRST Day of the aMonth
                    dtTo.Text = tDay
                    txtSearch.Focus()
                Case "Last Month"
                    Dim thisMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
                    dtFrom.Value = thisMonth.AddMonths(-1).ToString("MM/dd/yyyy") 'gets FIRST day of previous Month
                    dtTo.Value = thisMonth.AddDays(-1).ToString("MM/dd/yyyy") 'gets LAST day of previous Month
                    txtSearch.Focus()
                Case "Last 30 Days"
                    dtFrom.Text = Now.AddDays(-CInt("30")).ToString("MM/dd/yyyy")
                    dtTo.Text = tDay
                    txtSearch.Focus()
                Case "Last 90 Days"
                    dtFrom.Text = Now.AddDays(-CInt("90")).ToString("MM/dd/yyyy")
                    dtTo.Text = tDay
                    txtSearch.Focus()
                Case "Year to Date"
                    dtFrom.Text = "01/01/" & Now.Year.ToString
                    dtTo.Text = tDay
                    txtSearch.Focus()
                Case Else
                    dtFrom.Focus()
                    Exit Select
            End Select
            globalDtFrom = dtFrom.Text
            globalDtTo = dtTo.Text
        Catch ex As Exception
            MsgBox("An Error Occured: (02)mdlDefFrmFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
        End Try
        
    End Sub

    '--(03)--expandCollapseView Function
    Public Sub collapseView(ByVal collapse As Boolean,
                                  ByVal gpList As DevComponents.DotNetBar.Controls.GroupPanel,
                                  ByVal gpInfo As DevComponents.DotNetBar.Controls.GroupPanel,
                                  ByVal btnExpand As DevComponents.DotNetBar.ButtonX,
                                  ByVal txtSearch As DevComponents.DotNetBar.Controls.TextBoxX,
                                  ByVal formWidth As Integer)
        If collapse = False Then
            gpList.Width = (gpInfo.Left + gpInfo.Width) - gpList.Left
            gpInfo.Visible = False
            btnExpand.Text = "|< Collapse"
            txtSearch.Focus()
        Else
            Dim temp As Integer = formWidth - ((70 / 100) * formWidth)
            If temp < 400 Then
                gpList.Width = formWidth - ((70 / 100) * formWidth)
            Else
                gpList.Width = 400
            End If
            gpInfo.Left = (gpList.Left * 1.5) + gpList.Width
            gpInfo.Width = formWidth - (gpList.Width + (gpList.Left * 3.3))
            gpInfo.Visible = True
            btnExpand.Text = "Expand >|"
            txtSearch.Focus()
        End If

    End Sub

    '--(04)--POP Baloon
    Public b As DevComponents.DotNetBar.Balloon = New DevComponents.DotNetBar.Balloon()
    Public errorCap As String
    Public errorMsg As String
    Public errorLeft As Integer
    Public errorTop As Integer
    Public Sub popBaloon(ByRef tObject As Object, ByRef tForm As Form)
        Dim isTopmost As Boolean
        If tForm.TopMost = True Then
            isTopmost = True
        End If
        b = New DevComponents.DotNetBar.Balloon()
        b.Style = eBallonStyle.Balloon
        b.CaptionText = errorCap
        b.Text = errorMsg
        b.AlertAnimation = eAlertAnimation.TopToBottom
        b.AutoResize()
        b.AutoClose = True
        b.AutoCloseTimeOut = 3
        b.Owner = tForm
        If isTopmost = True Then
            tForm.TopMost = False
        End If
        Try
            b.Show(tObject, False)
        Catch ex As Exception
            Dim r As Rectangle = Screen.GetWorkingArea(tForm)
            Dim BorderWidth As Integer = (tForm.Width - tForm.ClientSize.Width) / 2
            Dim TitlebarHeight As Integer = tForm.Height - tForm.ClientSize.Height - (2 * BorderWidth)
            b.Location = New Point(errorLeft + ((frmMain.Width - tForm.Width) / 2),
                                   (frmMain.MainRibbon.Height + tForm.Top + TitlebarHeight + errorTop))
            b.Show(False)
        End Try
        If isTopmost = True Then
            tForm.TopMost = True
        End If
    End Sub

    '--(05)--GET NEXT Primary Key
    Public Function getNextPrimaryNo(ByVal targetCol As String,
                                     ByVal targetTbl As String,
                                     ByVal ctrLength As Integer,
                                     ByVal isAlphaNum As Boolean,
                                     ByVal leadChr As String) As String

        Dim tLastCtr As Integer
        Dim tLastChr As Char = "A"
        Dim tMaxCtr As Integer
        If isAlphaNum = False Then
            getNextPrimaryNo = leadChr & ("1").ToString.PadLeft(ctrLength, "0"c)
        Else
            getNextPrimaryNo = leadChr & tLastChr & CStr("1").ToString.PadLeft(ctrLength - 1, "0"c)
            tMaxCtr = CInt(CStr("9").ToString.PadLeft(ctrLength - 1, "9"c))
        End If

        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & targetCol & " FROM " & targetTbl & " ORDER BY " & targetCol & " DESC LIMIT 0,1", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read

                    If isAlphaNum = False Then

                        tLastCtr = CInt(myReader.GetValue(0).ToString)
                        tLastCtr = tLastCtr + 1
                        getNextPrimaryNo = leadChr & tLastCtr.ToString.PadLeft(ctrLength, "0"c)

                    Else

                        Dim ignoreChr As Integer = leadChr.Length + CStr(tLastChr).Length
                        tLastChr = myReader.GetValue(0).ToString.Substring(leadChr.Length, CStr(tLastChr).Length)
                        tLastCtr = CInt(myReader.GetValue(0).ToString.Substring(ignoreChr, myReader.GetValue(0).ToString.Length - ignoreChr))
                        tLastCtr = tLastCtr + 1
                        If tLastCtr <= tMaxCtr Then
                            getNextPrimaryNo = leadChr & tLastChr & tLastCtr.ToString.PadLeft(ctrLength - 1, "0"c)
                        Else
                            tLastChr = Chr(Asc(tLastChr) + 1)
                            getNextPrimaryNo = leadChr & tLastChr & CStr("1").ToString.PadLeft(ctrLength - 1, "0"c)
                        End If

                    End If

                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            MsgBox("An Error Occured: (05)mdlDefFrmFunc" & vbNewLine & "> " & myerror.Message, vbExclamation, "Attention!")
        Finally
            con.Dispose()
        End Try

    End Function

    '--(06)--CHECK if Value exist in database
    Public Function hasDbDuplicate(ByVal targetCol As String, ByVal targetTbl As String, ByVal tValue As String) As Boolean
        hasDbDuplicate = False
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & targetCol & " FROM " & targetTbl & " " & _
                                                   "WHERE " & targetCol & "='" & cleanStringForDB(tValue) & "' AND isVisible='Y'", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                hasDbDuplicate = True
            End If
            con.Close()
        Catch myerror As MySqlException
            MsgBox("An Error Occured: (06)mdlDefFrmFunc" & vbNewLine & "> " & myerror.Message, vbExclamation, "Attention!")
        Finally
            con.Dispose()
        End Try
    End Function

    '--(07)--CHECK if Value exist in database
    Public Sub checkMaxInput(ByVal tObject As Object, ByVal tForm As Form)

        Try
            If tObject.Text.Length = tObject.MaxLength Then
                errorMsg = "Only " & CStr(tObject.MaxLength) & " character(s) is allowed..."
                popBaloon(tObject, tForm)
            End If
        Catch ex As Exception
            MsgBox("An Error Occured: (07)mdlDefFrmFunc" & vbNewLine & "> " & ex.Message, vbExclamation, "Attention!")
        End Try

    End Sub

    '--(08)--ERROR MSGBOX
    Public Sub showErrorMsg(ByVal errorMsg As String, ByVal errorTag As String)

        MsgBox("An Error Occured: " & errorTag & vbNewLine & "> " & errorMsg, vbExclamation, "Attention!")

    End Sub

    '--(09)--BUSY MSGBOX
    Public Sub showBusyMsg()

        MsgBox("System is currently processing a request, please cancel active process to continue.", vbExclamation, "Attention!")

    End Sub

    '--(10)--GET Primary Key
    Public Function getPrimaryNo(ByVal targetTbl As String, ByVal primaryKeyCol As String, ByVal refCol As String, ByVal refColValue As String) As String

        getPrimaryNo = ""
        Call connectDB()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT " & targetTbl & "." & primaryKeyCol & " " & _
                                                   "FROM " & targetTbl & " " & _
                                                   "WHERE " & targetTbl & "." & refCol & "='" & refColValue & "'", con)
        Dim myReader As MySqlDataReader
        Try
            con.Open()
            myReader = sql.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read
                    getPrimaryNo = myReader.GetValue(0).ToString
                End While
            End If
            con.Close()
        Catch myerror As MySqlException
            showErrorMsg(myerror.Message, "(10)mdlDefFrmFunc") '(08)mdlDefFrmFunc
        Finally
            con.Dispose()
        End Try

    End Function

End Module
