Imports System.IO
Module mdlComHardware
    Public iComPort1 As String
    Public iBaudRate1 As String
    Public iParity1 As String
    Public iDataBits1 As String
    Public iStopBits1 As String

    Public dataMsg1 As String = ""
    Public deviceStatus As String = ""
    Public stopProcSignal As Boolean
    Public signalDisp As Boolean
    Public atcommands As String = ""
    Public arrDeviceStat() As String
    Public cpNum As String = ""
#Region "--(01)-- SMS CONFIGURATION USING FILE HANDLING"

    Public smsConfig As String = systemDataFolder & "\" & systemNameShort & "smsConfig.log"
    '--(01A)--SET SMS Settings
    Public Sub setSMSSettings(ByVal targetPort As String)

        Call getSMSLastStat() '(01)mdlIndicatorFunc

        Try
            Select Case targetPort
                Case "1"
                    frmSysSettings.cboPort1.Text = iComPort1
                    frmSysSettings.cboBaudRate1.Text = iBaudRate1
                    frmSysSettings.cboParity1.Text = iParity1
                    frmSysSettings.cboDataBits1.Text = iDataBits1
                    frmSysSettings.cboStopBits1.Text = iStopBits1
            End Select

        Catch ex As Exception
            showErrorMsg(ex.Message, "(01B)") '(02A)localFunc
        End Try

    End Sub

    '--(01B)--GET SMS LAST STATUS
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

    '--(01C)--INSERT SMS Status
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


    Public Function convertedValuesSignal(ByVal values As String, ByVal rbnSignal As DevComponents.DotNetBar.ButtonItem, ByVal spDevice As System.IO.Ports.SerialPort)
        Try
            Select Case CInt(values)
                Case 2 To 6
                    rbnSignal.Image = Global.Loading_Kiosk_Server_System.My.Resources._1x25
                Case 7 To 10
                    rbnSignal.Image = Global.Loading_Kiosk_Server_System.My.Resources._2x25
                Case 11 To 15
                    rbnSignal.Image = Global.Loading_Kiosk_Server_System.My.Resources._3x25
                Case 16 To 20
                    rbnSignal.Image = Global.Loading_Kiosk_Server_System.My.Resources._4x25
                Case 21 To 98
                    rbnSignal.Image = Global.Loading_Kiosk_Server_System.My.Resources._5x25
                Case Else
                    rbnSignal.Image = Global.Loading_Kiosk_Server_System.My.Resources._0x25
            End Select
        Catch ex As Exception
            showErrorMsg(ex.Message, "-(01C) Device Status Settings (convertedValuesSignal)")
        End Try
        Return rbnSignal.Image
    End Function



End Module
