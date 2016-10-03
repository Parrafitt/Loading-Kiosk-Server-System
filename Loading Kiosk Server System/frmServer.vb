Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports Loading_Kiosk_Server_System.SMS.Decoder

Public Class frmServer

    Private server As TcpComm.Server
    Private lat As TcpComm.Utilities.LargeArrayTransferHelper

#Region "-=- LOCAL FUNCTIONS -=-"

#Region "--(00)-- UI Layout and Other Functions --"

#End Region

#Region "--(01)-- Data Fetching and Display Functions --"

#End Region

#Region "--(02)-- TcpComm Functions --"

    '--VARIABLES
    Dim serverPortNo As Integer = 22490
    Dim queueCtr As Integer = 0

    '--(02A)-- START / STOP SERVER
    Private Sub startStopServer()

        If btnStartServer.Text = "START SERVER" Then

            '======================================================================|
            '-(02A.1)- START SERVER
            '======================================================================|
            Try

                AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Starting server with port " & CStr(serverPortNo) & "...")

                server = New TcpComm.Server(AddressOf UpdateUI, , True)
                lat = New TcpComm.Utilities.LargeArrayTransferHelper(server)
                server.Start(serverPortNo)

                AppendTextBox(txtEventLog, "OK!")

            Catch ex As Exception
                AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!>" & Me.Name & "(02A.1)" & ": " & ex.Message)
                lblServerStatus.Text = "STATUS: OFFLINE"
                Exit Sub
            End Try

            btnStartServer.Text = "STOP SERVER"
            lblServerStatus.Text = "STATUS: ONLINE"
            AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Server is now online...")

        Else

            '======================================================================|
            '-(02A.2)- STOP SERVER
            '======================================================================|
            Try

                AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Stopping server...")

                If server IsNot Nothing Then server.Close()
                lat = Nothing
                Me.lvTcpClient.Items.Clear()

                AppendTextBox(txtEventLog, "OK!")

            Catch ex As Exception
                AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!>" & Me.Name & "(02A.2)" & ": " & ex.Message)
                lblServerStatus.Text = "STATUS: OFFLINE"
                Exit Sub
            End Try

            btnStartServer.Text = "START SERVER"
            lblServerStatus.Text = "STATUS: OFFLINE"
            AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Server is now offline...")

        End If

    End Sub

    '--(02B)-- UpdateUI
    Public Sub UpdateUI(ByVal bytes() As Byte, ByVal sessionID As Int32, ByVal dataChannel As Byte)

        If lat.HandleIncomingBytes(bytes, dataChannel, sessionID) Then Return
        If Me.InvokeRequired() Then
            Me.Invoke(server.ServerCallbackObject, bytes, sessionID, dataChannel)
        Else
            If dataChannel < 251 Then
                Dim tempMsg As String = TcpComm.Utilities.BytesToString(bytes)
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > " & "Session " & sessionID.ToString & ": " & tempMsg)
            ElseIf dataChannel = 255 Then
                Dim tmp = ""
                Dim msg As String = TcpComm.Utilities.BytesToString(bytes)
                Dim dontReport As Boolean = False

                ' server has finished sending the bytes you put into sendBytes()
                If msg.Length > 3 Then tmp = msg.Substring(0, 3)
                If tmp = "UBS" Then ' User Bytes Sent.
                    Exit Sub
                    'Dim parts() As String = Split(msg, "UBS:")
                    'msg = "Data sent to session: " & parts(1)
                End If

                If msg = "Listening..." Or msg.Contains(" MachineID:") = False Then
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > " & msg & "")
                    Exit Sub
                End If

                Dim machName As String = ""
                updateTcpClientList(msg, "Connecting")
                If msg.Contains("R0_") Then '* Execute Machine Registration
                    If msg.Contains(":") Then
                        updateTcpClientList(machName, "Registering")
                        Dim temp() As String = Split(msg, ":")
                        machName = temp(1).ToString
                        Dim temp1() As String = Split(temp(0).ToString, " ")
                        Try
                            activeSessionID = CInt(temp1(0).ToString.Substring(temp1(0).IndexOf("#") + 1))
                        Catch ex As Exception
                            activeSessionID = -1
                        End Try
                        regMachine(temp(1).ToString, "Register") '(03F)localFunc
                    End If

                ElseIf msg.Contains("R1_") Then '* Request connection
                    If msg.Contains(":") Then
                        updateTcpClientList(machName, "Verifying")
                        Dim temp() As String = Split(msg, ":")
                        machName = temp(1).ToString
                        Dim temp1() As String = Split(temp(0).ToString, " ")
                        Try
                            activeSessionID = CInt(temp1(0).ToString.Substring(temp1(0).IndexOf("#") + 1))
                        Catch ex As Exception
                            activeSessionID = -1
                        End Try
                        regMachine(temp(1).ToString, "Verify") '(03F)localFunc
                    End If

                ElseIf msg.Contains("R2_") Then '* Request Transaction
                    If msg.Contains(":") Then
                        Dim temp() As String = Split(msg, ":")
                        Dim temp1() As String = Split(temp(0).ToString, " ") 'Separate product code and amount
                        Try
                            activeSessionID = CInt(temp1(0).ToString.Substring(temp1(0).IndexOf("#") + 1))
                        Catch ex As Exception
                            activeSessionID = -1
                        End Try

                        Dim msgS As String = temp(1).ToString
                        If msgS.Contains("_") Then
                            Dim temp2() As String = Split(msgS.ToString, "_")
                            Dim transDetails As String = base64Decode(temp2(1).ToString)
                            Dim transDet2() As String = Split(transDetails, ",")
                            machName = getDbValue("SELECT machName FROM man_machine WHERE serialNo='" & transDet2(0).ToString & "'", False)
                            If machName <> "" Then
                                updateTcpClientList(machName, "Connected")
                                updateTransQueue(transDetails)
                                updateTcpClientList(machName, "Disconnected")
                            Else
                                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Unsecured SessionId-" & sessionID.ToString & " message has been rejected.")
                                updateTcpClientList(msg, "Dropped")
                            End If
                        End If
                    End If

                ElseIf msg.Contains("R3_") Then '* Machine Status
                    If msg.Contains(":") Then
                        Dim temp() As String = Split(msg, ":")
                        Dim temp1() As String = Split(temp(0).ToString, " ") 'Separate product code and amount
                        Try
                            activeSessionID = CInt(temp1(0).ToString.Substring(temp1(0).IndexOf("#") + 1))
                        Catch ex As Exception
                            activeSessionID = -1
                        End Try

                        Dim msgS As String = temp(1).ToString
                        If msgS.Contains("_") Then
                            Dim temp2() As String = Split(msgS.ToString, "_")
                            Dim transDetails As String = base64Decode(temp2(1).ToString) '** FORMAT: encryptedCode,dateTime,stat,Ctrl,util
                            Dim transDet2() As String = Split(transDetails, ",")
                            machName = getDbValue("SELECT machName FROM man_machine WHERE serialNo='" & transDet2(0).ToString & "'", False)
                            If machName <> "" Then
                                updateTcpClientList(machName, "Receiving")
                                receiveMachStat(temp2(1).ToString, machName) '(06A)localFunc
                                updateTcpClientList(machName, "Disconnected")
                            Else
                                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Unsecured SessionId-" & sessionID.ToString & " message has been rejected.")
                                updateTcpClientList(msg, "Dropped")
                            End If
                        End If
                    End If
                Else
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Unsecured Session-" & sessionID.ToString & " has been rejected!")
                    updateTcpClientList(msg, "Dropped")
                End If

                'If msg = "Connected." Then updateTcpClientList(machName, "Connected")
                'If msg.Contains(" MachineID:") And msg.Contains("R0_") Then updateTcpClientList(machName, "Registering")
                'If msg.Contains("Session Stopped. (") Then updateTcpClientList(machName, "Disconnected")

                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > " & msg & "...")

                'If Not dontReport Then Me.ToolStripStatusLabel1.Text = msg
            End If
        End If

    End Sub

    '--(02C)-- updateTcpClientList
    Private Sub updateTcpClientList(ByVal machName As String, ByVal status As String)

        Dim lvi As ListViewItem

        lvi = New ListViewItem(DateTime.Now)
        lvi.SubItems.Add(machName)
        lvi.SubItems.Add(status)
        Me.lvTcpClient.Items.Add(lvi)

        'Dim sessionList As List(Of TcpComm.Server.SessionCommunications) = server.GetSessionCollection()
        'Dim lvi As ListViewItem

        'Me.lvTcpClient.Items.Clear()

        'For Each session As TcpComm.Server.SessionCommunications In sessionList

        '    If session.IsRunning Then
        '        If isMachineVerified(session.machineId, session.sessionID.ToString()) = True Then
        '            lvi = New ListViewItem(" Connected", 0, lvTcpClient.Groups.Item(0))
        '            addSecuredSessionID(session.sessionID.ToString())
        '        Else
        '            lvi = New ListViewItem(" Unregistered", 1, lvTcpClient.Groups.Item(2))
        '        End If
        '    Else
        '        lvi = New ListViewItem(" Disconnected", 1, lvTcpClient.Groups.Item(1))
        '        delSecuredSessionID(session.sessionID.ToString())
        '    End If

        '    lvi.SubItems.Add(session.sessionID.ToString())
        '    lvi.SubItems.Add(session.machineId)
        '    Me.lvTcpClient.Items.Add(lvi)

        'Next

    End Sub

    '--(02D)-- updateTransQueue
    Private Sub updateTransQueue(ByVal decryptCode As String)

        AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Receiving status from session " & activeSessionID.ToString & "...")
        If decryptCode.Contains(",") Then

            '=====================================================================|
            '--(02D.1)-- SET VALUES
            '=====================================================================|
            Dim decyptedMsg() As String = Split(decryptCode, ",") '**FORMAT: machSerial,refNo,prodNo,mobileNo,amtDue,amtInserted
            Dim machSerial As String = decyptedMsg(0).ToString
            Dim gRefNo As String = decyptedMsg(1).ToString
            Dim gProdNo As String = decyptedMsg(2).ToString.Trim
            Dim gMobileNo As String = decyptedMsg(3).ToString.Trim
            Dim gAmtDue As String = decyptedMsg(4).ToString.Trim
            Dim gAmtInserted As String = decyptedMsg(5).ToString.Trim
            Dim tempDateTime As String = ToMySqlDate(DateTime.Now)

            If machSerial <> "" Then
                machSerial = getDbValue("SELECT machNo FROM man_machine WHERE serialNo='" & machSerial & "'", False)
            End If

            '=====================================================================|
            '--(02D.2)-- INSERT VALUES TO LOG
            '=====================================================================|
            Dim tTable As String = "log_trans"
            Dim tFields As String = "" & _
                "@logDateTime,@refNo,@machNo,@prodNo,@mobileNo,@totalDue,@totalInsert"
            Dim tValues As String = "" & _
                tempDateTime & "^" & _
                gRefNo & "^" & _
                machSerial & "^" & _
                gProdNo & "^" & _
                gMobileNo & "^" & _
                gAmtDue & "^" & _
                gAmtInserted & ""
            AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Saving status from session " & activeSessionID.ToString & "...")
            If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc
                updateTcpClientList(machSerial, "Log of " & machSerial & " Saved!")
            Else
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & CStr(activeSessionID) & " >" & db_error_msg & "")
            End If
            
            '===================================================================|
            '--(03F.3)-- CHECK CONNECTION
            '===================================================================|
            Dim session As TcpComm.Server.SessionCommunications = server.GetSession(activeSessionID)
            If session Is Nothing Then
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & CStr(activeSessionID) & " is disconnected..!")
                updateTcpClientList(machSerial, "Disconnected")
                Exit Sub
            End If

            '===================================================================|
            '--(03F.4)-- SEND REPLY TO CLIENT
            '===================================================================|
            ResponsiveSleep(1000)
            If session IsNot Nothing Then
                server.SendText("OK", 1, session.sessionID)
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " Sending reply to Session " & CStr(activeSessionID) & "...")
            Else
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & CStr(activeSessionID) & " is disconnected..!")
            End If

            '===================================================================|
            '--(03F.5)-- DISCONNECT CLIENT
            '===================================================================|
            ResponsiveSleep(1000)
            If session IsNot Nothing Then session.Close()
            updateTcpClientList(machSerial, " Disconnected Session " & CStr(activeSessionID) & "...")

            '=====================================================================|
            '--(02D.2)-- INSERT VALUES TO QUEUE
            '=====================================================================|
            queueCtr += 1
            Dim queueNo As String = CStr(queueCtr).PadLeft(5, "0"c)
            Dim lvi As ListViewItem

            lvi = New ListViewItem(queueNo)
            lvi.SubItems.Add(machSerial)
            lvi.SubItems.Add(gProdNo)
            lvi.SubItems.Add("TCP")
            Me.lvTransQueue.Items.Add(lvi)

            If startTransTasks = False Then
                startTransTasks = True
                tmrTrans.Start()
            End If

        End If

    End Sub

#End Region

#Region "--(03)-- Security Protocols --"

    '--VARIABLES--
    Dim securedSessionID As String = Nothing
    Dim activeSessionID As Integer = -1

    '--(03A)-- Verify Machine
    Private Function isMachineVerified(ByVal securityCode As String, ByVal sessionID As String) As Boolean

        Try
            isMachineVerified = False
            AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Verifying Session " & activeSessionID.ToString & "...")
            If securityCode.Contains("_") Then

                Dim temp() As String = Split(securityCode, "_")
                Dim newCode As String = base64Decode(temp(1).ToString)

                Dim machName As String = Nothing

                Call connectDB()
                Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                           "man_machine.machName " & _
                                                           "FROM man_machine " & _
                                                           "WHERE man_machine.serialNo='" & cleanStringForDB(newCode) & "' " & _
                                                           "", con)
                Dim myReader As MySqlDataReader
                Try
                    con.Open()
                    myReader = sql.ExecuteReader
                    If myReader.HasRows Then

                        While myReader.Read
                            machName = myReader.GetValue(0).ToString
                        End While

                    Else
                        AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Invalid Activation Code Session " & CStr(activeSessionID) & "..!")
                        con.Close()
                        Return False
                    End If
                    con.Close()
                Catch myerror As MySqlException
                    errorMsg = "(03F.1)mdlGlobalFunc - An Error Occured: " & myerror.Message
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : " & errorMsg)
                Finally
                    con.Dispose()
                End Try

                Dim session As TcpComm.Server.SessionCommunications = server.GetSession(CInt(sessionID))
                If session Is Nothing Then
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & sessionID & " is disconnected..!")
                    Return False
                End If

                Dim msgToClient As String = "ACCESS DENIED!"
                If machName <> "" Then
                    msgToClient = "HELLO"
                End If

                If session IsNot Nothing Then server.SendText(msgToClient, 1, session.sessionID)

                Return True

            End If

        Catch ex As Exception
            errorMsg = "(03F)mdlGlobalFunc - An Error Occured: " & ex.Message
            AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : " & errorMsg)
            Return False
        End Try

    End Function

    '--(03B)-- addSecuredSessionID
    Private Sub addSecuredSessionID(ByVal sessionID As String)

        If securedSessionID <> Nothing Then
            securedSessionID += "," & sessionID & ","
        Else
            securedSessionID = "," & sessionID & ","
        End If

    End Sub

    '--(03C)-- delSecuredSessionID
    Private Sub delSecuredSessionID(ByVal sessionID As String)

        If securedSessionID <> Nothing Then
            securedSessionID.Replace("," & sessionID & ",", "")
        Else
            securedSessionID = Nothing
        End If

    End Sub

    '--(03D)-- verifySessionID
    Private Function isSecuredSessionID(ByVal sessionID As String) As Boolean

        If securedSessionID = Nothing Then
            Return False
        End If

        If securedSessionID.Contains("," & sessionID & ",") Then
            Return True
        Else : Return False
        End If

    End Function

    '--(03E)-- verifyMessage
    Private Function isSecuredMessage(ByVal message As String) As Boolean

        If message.Contains("!@#") Then
            Return True
        Else : Return False
        End If

    End Function

    '--(03F)-- regMachine
    Private Sub regMachine(ByVal activationCode As String, ByVal requestType As String)

        Try

            AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Verifying Session " & activeSessionID.ToString & "...")
            If activationCode.Contains("_") Then

                '===================================================================|
                '--(03F.1)-- SET VALUES
                '===================================================================|
                Dim machNo As String = Nothing
                Dim machCode As String = Nothing
                Dim machName As String = Nothing

                Dim snNo As String = Nothing
                Dim fName As String = Nothing
                Dim mName As String = Nothing
                Dim lName As String = Nothing
                Dim email As String = Nothing
                Dim machUserName As String = Nothing
                Dim machPassword As String = Nothing

                Dim temp() As String = Split(activationCode, "_")
                Dim decryptedCode As String = base64Decode(temp(1).ToString)
                If decryptedCode.Contains(",") Then

                    Dim splitDetails() As String = Split(decryptedCode, ",")
                    snNo = splitDetails(0).ToString
                    fName = splitDetails(1).ToString
                    mName = splitDetails(2).ToString
                    lName = splitDetails(3).ToString
                    email = splitDetails(4).ToString
                    machUserName = splitDetails(5).ToString
                    machPassword = splitDetails(6).ToString

                Else

                    snNo = decryptedCode

                End If

                '===================================================================|
                '--(03F.2)-- GET MACHINE INFO
                '===================================================================|
                Call connectDB()
                Dim sql As MySqlCommand = New MySqlCommand("SELECT " & _
                                                           "man_machine.machNo, " & _
                                                           "man_machine.machCode, " & _
                                                           "man_machine.machName " & _
                                                           "FROM man_machine " & _
                                                           "WHERE man_machine.serialNo='" & cleanStringForDB(snNo) & "' " & _
                                                           "AND man_machine.isVisible='Y' " & _
                                                           "AND man_machine.machStat!='2' " & _
                                                           "", con)
                Dim myReader As MySqlDataReader
                Try
                    con.Open()
                    myReader = sql.ExecuteReader
                    If myReader.HasRows Then

                        While myReader.Read
                            machNo = myReader.GetValue(0).ToString
                            machCode = myReader.GetValue(1).ToString
                            machName = myReader.GetValue(2).ToString
                        End While

                    Else
                        AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Invalid Activation Code " & temp(1).ToString & " !")
                    End If
                    con.Close()
                Catch myerror As MySqlException
                    errorMsg = "(03F.1)mdlGlobalFunc - An Error Occured: " & myerror.Message
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : " & errorMsg)
                Finally
                    con.Dispose()
                End Try

                '===================================================================|
                '--(03F.3)-- CHECK CONNECTION
                '===================================================================|
                Dim session As TcpComm.Server.SessionCommunications = server.GetSession(activeSessionID)
                If session Is Nothing Then
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & CStr(activeSessionID) & " is disconnected..!")
                    updateTcpClientList(machName, "Disconnected")
                    Exit Sub
                End If

                '===================================================================|
                '--(03F.4)-- SEND REPLY TO CLIENT
                '===================================================================|
                Dim msgToClient As String = machNo & "," & machCode & "," & machName
                If machNo = "" Then
                    msgToClient = "ACCESS DENIED!"
                    updateTcpClientList(machName, "Dropped")
                Else
                    If requestType = "Register" Then
                        updateTcpClientList(machName, "Connected")
                    Else
                        updateTcpClientList(machName, "Verified")
                    End If
                End If
                ResponsiveSleep(1000)
                If session IsNot Nothing Then
                    server.SendText(msgToClient, 1, session.sessionID)
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " Sending reply to Session " & CStr(activeSessionID) & "...")
                Else
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & CStr(activeSessionID) & " is disconnected..!")
                End If

                '===================================================================|
                '--(03F.5)-- DISCONNECT CLIENT
                '===================================================================|
                ResponsiveSleep(1000)
                If session IsNot Nothing Then session.Close()
                updateTcpClientList(machName, " Disconnected Session " & CStr(activeSessionID) & "...")

                '===================================================================|
                '--(03F.6)-- UPDATE MACHINE STATUS
                '===================================================================|
                If requestType <> "Register" Then
                    Exit Sub
                End If
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " Updating status of " & machName & "...")
                Dim queryStatement As String = "UPDATE man_machine SET man_machine.machStat='1' WHERE machNo='" & machNo & "'"
                If executeMySQLquery(queryStatement) = True Then '(0D2)mdlGlobalFunc
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " Updated status of " & machName & "...")
                Else
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Unable to update " & machName & "'s status...")
                    Exit Sub
                End If

                '===================================================================|
                '--(03F.7)-- REGISTER FRANCHISEE
                '===================================================================|
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " Registering franchisee info of " & machName & "...")

                Dim franchiseeNo As String = getFranchiseeNo()
                Dim franchiseeName As String = lName & ", " & fName & " " & mName
                Dim franchiseeType As String = "1" '** DEFAULT FRANCHISEE TYPE = 'INDIVIDUAL'

                Dim tTable As String = "man_franchisee"
                Dim tFields As String = "" & _
                    "@franchiseeNo,@franchiseeCode,@franchiseeName,@franchiseeTypeNo,@first,@middle,@last,@email,@username,@password,@machNo"
                Dim tValues As String = "" & _
                    franchiseeNo & "^" & _
                    franchiseeNo & "^" & _
                    franchiseeName & "^" & _
                    franchiseeType & "^" & _
                    fName & "^" & _
                    mName & "^" & _
                    lName & "^" & _
                    email & "^" & _
                    machUserName & "^" & _
                    machPassword & "^" & _
                    machNo & ""
                If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " Registered franchisee info of " & machName & "...")
                Else
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Unable to register franchisee info of " & machName & "...")
                End If

            End If

        Catch ex As Exception
            errorMsg = "(03F)mdlGlobalFunc - An Error Occured: " & ex.Message
            AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : " & errorMsg)
        End Try

    End Sub

#End Region

#Region "--(04)-- Transaction Functions --"

    '--VARIABLES--
    Dim startTransTasks As Boolean = False

    '--(04A)-- performTrans
    Private Sub performTrans()

        tmrTrans.Stop()
        startTransTasks = False

        Dim queueNo As String
        Dim connType As String
        Dim product As String
        Dim machineNo As String

        If lvTransQueue.Items.Count = 0 Then
            startTransTasks = False
            tmrTrans.Stop()
            Exit Sub
        End If

        queueNo = lvTransQueue.Items(0).SubItems(0).Text
        machineNo = lvTransQueue.Items(0).SubItems(1).Text
        product = lvTransQueue.Items(0).SubItems(2).Text
        connType = lvTransQueue.Items(0).SubItems(3).Text

        lblQueueNo.Text = queueNo
        lblMachine.Text = machineNo
        lblServerStat.Text = "Performing tasks for queueNo:" & CStr(queueNo) & " ..."

        AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Performing tasks for queueNo:" & CStr(queueNo) & " ...")

        Dim transNo As String = CStr(Me.lvTransComplete.Items.Count + 1).PadLeft(5, "0"c)
        With lvTransComplete.Items.Insert(0, transNo, 0)
            .SubItems.Add(machineNo)
            .SubItems.Add(product)
            .SubItems.Add(connType)
        End With

        For Each tItem As ListViewItem In lvTransQueue.Items
            If tItem.SubItems(0).Text = queueNo And tItem.SubItems(1).Text = machineNo Then
                tItem.Remove()
            End If
        Next

        'ResponsiveSleep(3000)
        AppendTextBox(txtEventLog, "OK!")

        lblQueueNo.Text = "-"
        lblMachine.Text = "-"
        lblServerStat.Text = "Ready..."

        If lvTransQueue.Items.Count <> 0 Then
            startTransTasks = True
            tmrTrans.Start()
        End If

    End Sub

#End Region

#Region "--(05)-- SMS Functions --"
    'variables

    '--(05A)-- DATA RECEIVED--
    Private Sub spDevice_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spDevice.DataReceived
        Try
            dataMsg1 = spDevice.ReadExisting()
        Catch ex As Exception
            Call closePort()
            'showErrorMsg(ex.Message, "-(00A) Data Recieve handling (spDevice1)")
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> " & ex.Message) ' & vbNewLine)
        End Try
    End Sub

    Public Function getDataRecieve(ByVal deviceId As String)
        Try
            Select Case deviceId
                Case "1"
                    deviceStatus = dataMsg1.ToString
                    AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & ">  " & deviceStatus.Replace(vbNewLine, ""))
            End Select

        Catch ex As Exception
            Call closePort()
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> " & ex.Message) ' & vbNewLine)
        End Try

        Return deviceStatus
    End Function

    '--(05B)-- CLOSE PORT--
    Private Sub closePort()
        Try
            If spDevice.IsOpen = True Then
                AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Closing Port . . . . .")
                spDevice.Close() 'Close our Serial Port
            End If

            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & ">>>> Port Closed <<<<")

        Catch ex As Exception
            If ((Not spDevice Is Nothing) AndAlso spDevice.IsOpen) Then
                spDevice.Close()
            End If
        End Try

    End Sub

    '--(05C)- -GET DEVICE STATUS--
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
                        imgSignal.Images.Add(convertedValuesSignal(result(0).ToString.Trim, btnSimSignal1, spDevice))
                    Case "number"
                        cpNum = result(2).ToString.Trim
                End Select

            Next
            '    AppendTextBox(txtReceived1, vbNewLine & deviceStatus)



            Array.Clear(arrDeviceStat, 0, arrDeviceStat.Length)
        Catch ex As Exception
            Call closePort()
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> " & ex.Message) ' & vbNewLine)

        End Try
    End Sub

    '--(05D)-- INIT SMS MODE--
    Private Sub initSMS()
        With spDevice
            If .IsOpen = False Then
                Call startSMS()
            End If
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Initializing SMS to Read . . .")
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Set to PDU Format . . .")
            atcommands = "AT+CMGF=0" 'set pdu format
            .Write(atcommands & Chr(13))
            Threading.Thread.Sleep(1000)
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Preparing the Device to Read  . . .")
            atcommands = "AT+CPMS=""SM""" ' ME read msg on dongle ' SM on sim
            .Write(atcommands & Chr(13))
            Threading.Thread.Sleep(1000)
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Device Ready . . .")

        End With
    End Sub

    Private Sub getSignal()
        signalDisp = True
        With spDevice
            If .IsOpen = False Then
                Call startSMS()
            End If
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Getting Signal . . .")
            atcommands = "AT+CSQ" ' signal
            .Write(atcommands & Chr(13))
            Threading.Thread.Sleep(2000)
            getDeviceStatus("+CSQ:", "signal")
        End With
    End Sub

    Private Sub getNumber()
        With spDevice
            If .IsOpen = False Then
                Call startSMS()
            End If
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Getting Number . . .")
            atcommands = "AT+CNUM" ' signal
            .Write(atcommands & Chr(13))
            Threading.Thread.Sleep(3000)
            getDeviceStatus("+CNUM:", "number")
        End With
    End Sub

    Private Sub updateSMSList()

        Dim lvi As ListViewItem
        lvi = New ListViewItem("SIM 1", 0)

        lvi.SubItems.Add(cpNum)
        Me.lvSmsDevice.Items.Add(lvi)

    End Sub

    Private Sub startSMS()
        Dim readData As String = ""

        stopProcSignal = False
        Call setSMSSettings("1") '(02AB)localFunc
        AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Initializing Serial Port " & iComPort1 & "...")
        '=================================================================|
        '--(02A.1B)-- OPEN SERIAL PORT
        '=================================================================|
        Try
            '-------------------------------------------------------------|
            '--(02A.1B1)-- SET Serial Port Properties
            '=============================================================|
            AppendTextBox(txtSmsLog, "OK!" & vbNewLine & ToMySqlDate(DateTime.Now) & "> Executing read . . ." & vbNewLine)
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
            Call initSMS()
            Call getSignal()
            Call getNumber()
            Call updateSMSList()
            AppendTextBox(txtEventLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Starting Server on SIM 1 ...READY!")

            'If bwExecute.IsBusy = False Then
            '    bwExecute.RunWorkerAsync()
            'End If
        Catch ex As Exception

            Call closePort() '(02AE)localFunc
            Exit Sub
        End Try

    End Sub

    Private Sub readSMS()
        Try
            Dim smsPDU As String = ""
            Dim smsContent() As String = {}


            With spDevice
                AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Device  message . . .")
                'atcommands = "AT"
                '.Write(atcommands & Chr(13))
                'Threading.Thread.Sleep(1000)

                atcommands = "AT+CMGR=0" ' read all messages read/unread
                .Write(atcommands & Chr(13))
                Threading.Thread.Sleep(1500) '5


                smsContent = Split(getDataRecieve("1"), "+CMGR:", , CompareMethod.Text)
                For i = 1 To UBound(smsContent)
                    Dim input As String = smsContent(i)
                    Dim result() As String
                    Dim pattern As String = vbCrLf '"(:)|(,"")|("","")|("")"
                    result = Regex.Split(input, pattern)
                    Dim rec As String = result(1)


                    Dim s As Object
                    Dim PDUCode As String = rec.Replace(vbCrLf, "")
                    Dim T As SMSBase.SMSType = SMSBase.GetSMSType(PDUCode)
                    '   txtResult.Text = txtResult.Text + T.ToString + vbCrLf
                    Select Case T
                        Case SMSBase.SMSType.EMS_RECEIVED
                            s = New EMS_RECEIVED(PDUCode)
                            '   smsPDU += "From:" + s.SrcAddressValue + "-Time:" + s.TP_SCTS + vbCrLf + vbCrLf
                            smsPDU += s.SrcAddressValue + "-" + s.TP_SCTS + vbCrLf + vbCrLf
                        Case SMSBase.SMSType.SMS_RECEIVED
                            s = New SMS_RECEIVED(PDUCode)
                            smsPDU += s.SrcAddressValue + "-" + s.TP_SCTS + vbCrLf + vbCrLf
                        Case SMSBase.SMSType.EMS_SUBMIT
                            s = New EMS_SUBMIT(PDUCode)
                            smsPDU += "Send to:" + s.DesAddressValue + vbCrLf + vbCrLf
                        Case SMSBase.SMSType.SMS_SUBMIT
                            s = New SMS_SUBMIT(PDUCode)
                            smsPDU += "Send to:" + s.DesAddressValue + vbCrLf + vbCrLf
                        Case SMSBase.SMSType.SMS_STATUS_REPORT
                            s = New SMS_STATUS_REPORT(PDUCode)
                            smsPDU += "Send time:" + s.TP_SCTS + "  Receive time:" + s.TP_DP + "   ״̬:" + (s.status).ToString + vbCrLf + vbCrLf
                        Case Else
                            smsPDU = "Sorry, maybe it is a wrong PDU Code"
                    End Select
                    '###########################
                    'Correct when s is SMS type, no TP_UDL is found.
                    'Note:Only EMS has the TP_UDHL and TP_UDH see 3GPP TS 23.040 V6.5.0 (2004-09)
                    '###########################

                    AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> Message in PDU Mode . . .")

                    If s.tp_DCS = 0 Then
                        If T = SMSBase.SMSType.SMS_RECEIVED Or T = SMSBase.SMSType.SMS_STATUS_REPORT Or T = SMSBase.SMSType.SMS_SUBMIT Then
                            '#############################
                            'add a parameter
                            '############################
                            smsPDU += s.decode7bit(s.tp_UD, s.TP_UDL) + vbCrLf
                        End If
                        If T = SMSBase.SMSType.EMS_RECEIVED Or T = SMSBase.SMSType.EMS_SUBMIT Then
                            smsPDU += s.decode7bit(s.tp_ud, s.tp_udl - 8 * (1 + s.tp_udhl) / 7) + vbCrLf
                        End If
                    Else
                        smsPDU = smsPDU + s.DecodeUnicode(s.TP_UD) + vbCrLf
                    End If

                Next i

                AppendTextBox(txtSmsLog, smsPDU)
                Dim result1() As String
                result1 = Regex.Split(smsPDU, vbCrLf)

                Dim rec1 As String = result1(0).ToString

                Dim TestArray() As String = Split(rec1, "-")


                'TestArray(0).ToString() ' number
                'TestArray(1).ToString() ' date time

                Dim walkingarea As String = "R2_QkZFQkZCRkYwMDAyMDZBNywwMDIxNjA5MTNBMDIsYnRuUHJvZDYsNzc3Nyw0MCw="
                AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> " & walkingarea)

                If walkingarea.Contains("R2_") Then '* Request Transaction

                    Dim msgS As String = walkingarea.ToString
                    If msgS.Contains("_") Then
                        Dim temp2() As String = Split(msgS.ToString, "_")
                        Dim transDetails As String = base64Decode(temp2(1).ToString)
                        Dim transDet2() As String = Split(transDetails, ",")
                        Dim machName = getDbValue("SELECT machName FROM man_machine WHERE serialNo='" & transDet2(0).ToString & "'", False)
                        If machName <> "" Then
                            updateTransQueue(transDetails)
                        Else
                            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Unsecured SessionId-" & machName.ToString & " message has been rejected.")
                        End If
                    End If
                End If

            End With
        Catch ex As Exception
            AppendTextBox(txtSmsLog, vbNewLine & ToMySqlDate(DateTime.Now) & "> " & ex.Message.Trim) ' & vbNewLine)

        End Try
    End Sub

#End Region

#Region "--(06)-- CLIENT Functions --"

    '--(06A)-- receiveMachStat
    Private Sub receiveMachStat(ByVal encryptedCode As String, ByVal machName As String)

        Try

            AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Receiving status from session " & activeSessionID.ToString & "...")

            Dim decryptCode As String = base64Decode(encryptedCode)
            If decryptCode.Contains(",") Then

                Dim decyptedMsg() As String = Split(decryptCode, ",") '**FORMAT: encryptedSn,dateTime,Stat,Ctrl,Util
                Dim machNo As String = decyptedMsg(0).ToString '** MACH SERIAL NO
                If machNo <> "" Then
                    machNo = getDbValue("SELECT machNo FROM man_machine WHERE serialNo='" & machNo & "'", False)
                End If
                Dim machDateTime As String = ToMySqlDate(decyptedMsg(1).ToString.Trim)
                Dim machStatusStat As String = decyptedMsg(2).ToString.Trim
                Dim machStatusCtrl As String = decyptedMsg(3).ToString.Trim
                Dim machStatusUtil As String = decyptedMsg(4).ToString.Trim

                Dim tTable As String = "log_mach_status"
                Dim tFields As String = "" & _
                    "@logDateTime,@machNo,@machStat,@machCtrl,@machUtil"
                Dim tValues As String = "" & _
                    machDateTime & "^" & _
                    machNo & "^" & _
                    machStatusStat & "^" & _
                    machStatusCtrl & "^" & _
                    machStatusUtil & ""
                AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " > Saving status from session " & activeSessionID.ToString & "...")
                If execMySQLqueryParam("insert", tTable, tFields, tValues, "") = True Then '(0D2)mdlGlobalFunc
                    updateTcpClientList(machName, "Status of " & machName & " Saved!")
                Else
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & CStr(activeSessionID) & " >" & db_error_msg & "")
                End If

                Dim session As TcpComm.Server.SessionCommunications = server.GetSession(activeSessionID)
                If session Is Nothing Then
                    AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : Session " & CStr(activeSessionID) & " is disconnected..!")
                    updateTcpClientList(machName, "Disconnected")
                    Exit Sub
                End If

                ResponsiveSleep(500)
                If session IsNot Nothing Then session.Close()
                updateTcpClientList(machName, " Disconnected Session " & CStr(activeSessionID) & "...")

            End If

        Catch ex As Exception
            errorMsg = "(06A)mdlGlobalFunc - An Error Occured: " & ex.Message
            AppendTextBox(txtTcpLog, vbNewLine & ToMySqlDate(DateTime.Now) & " <!> ATTENTION! : " & errorMsg)
        End Try

    End Sub

#End Region

#End Region


#Region "-=- UI FUNCTIONS -=-"

    '=-CLOSE
    Private Sub frmServer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'e.Cancel = True
        'MsgBox("Cannot close form!", vbInformation, "Attention!")
    End Sub

    '=-LOAD
    Private Sub MyBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtEventLog.Text = Nothing
        txtTcpLog.Text = Nothing
        txtSmsLog.Text = Nothing

    End Sub

    '=-lblServerStatus
    Private Sub lblServerStatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblServerStatus.TextChanged
        With lblServerStatus
            If .Text.Contains("OFFLINE") Then

                .BackColor = Color.IndianRed
                .ForeColor = Color.FloralWhite
                btnStartServer.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources.play

                cpServer.IsRunning = False
                cpServer.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
                cpServer.ProgressColor = Color.IndianRed

                lblServerStat.Text = "Stopped!"

            Else

                .BackColor = Color.ForestGreen
                .ForeColor = Color.FloralWhite
                btnStartServer.Image = Global.Loading_Kiosk_Server_System.My.Resources.Resources._stop

                cpServer.IsRunning = True
                cpServer.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Line
                cpServer.ProgressColor = Color.YellowGreen

                lblServerStat.Text = "Listening..."

            End If
        End With
    End Sub

    '=-tmrTrans
    Private Sub tmrTrans_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTrans.Tick
        If startTransTasks = True Then
            performTrans() '(04A)localFunc
        End If
    End Sub

#Region "-- TcpComm OBJECTS "

    '=-btnStartServer Function
    Private Sub btnStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartServer.Click
        startSMS()
        startStopServer() '(02A)localFunc
    End Sub

#End Region

#End Region

End Class