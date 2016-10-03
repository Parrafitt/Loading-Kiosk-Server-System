Module mdlSysFunc

    '--VARIABLES--

#Region "--(01)--PRIMARY KEY GENERATION "

    '--(01A)-- MACH NO
    Public Function getMachNo() As String

        Dim tTable As String = "man_machine"
        Dim tColumn As String = "machNo"
        Dim tLength As Integer = 4
        Dim tLeadChr As String = "M"

        Return getNextPrimaryNo(tColumn, tTable, tLength, True, tLeadChr)

    End Function

    '--(01B)-- FRANCHISEE NO
    Public Function getFranchiseeNo() As String

        Dim tTable As String = "man_franchisee"
        Dim tColumn As String = "franchiseeNo"
        Dim tLength As Integer = 4
        Dim tLeadChr As String = "C"

        Return getNextPrimaryNo(tColumn, tTable, tLength, True, tLeadChr)

    End Function

    '--(01C)-- ADVERTISEMENT NO
    Public Function getAdvertisementNo() As String

        Dim tTable As String = "man_advertisement"
        Dim tColumn As String = "advertisementNo"
        Dim tLength As Integer = 6
        Dim tLeadChr As String = "A"

        Return getNextPrimaryNo(tColumn, tTable, tLength, True, tLeadChr)

    End Function

#End Region

#Region "--(02)--ERROR CODE CONVERTION "

    '--VARIABLES--
    Public inp_temp As String
    Public inp_keylock As String
    Public inp_power As String
    Public inp_akd As String
    Public inp_cashlock As String
    Public inp_doorlock As String
    Public inp_coin As String
    Public inp_bill As String

    '--(02A)-- convertMachStatus
    Public Sub convertMachStatus(ByVal statusCode As Integer)

        '==========================================================================|
        '--(02A.1)-- PREP VALUES
        '==========================================================================|
        Dim strArr(8) As String
        Dim ctr As Integer = 0
        Dim ErrString As String = ""
        Dim revBinary As String = ""

        inp_temp = Nothing
        inp_keylock = Nothing
        inp_power = Nothing
        inp_akd = Nothing
        inp_cashlock = Nothing
        inp_doorlock = Nothing
        inp_coin = Nothing
        inp_bill = Nothing

        statusCode = Convert.ToString(CInt(statusCode), 2).PadLeft(8, "0")
        revBinary = StrReverse(statusCode)

        '==========================================================================|
        '--(02A.1)-- SET VALUES
        '==========================================================================|
        For ctr = 0 To revBinary.Length - 1
            strArr(ctr) = revBinary(ctr)
        Next
        If statusCode = 0 Then
            Exit Sub
        Else
            For ctr = 0 To strArr.Length - 1
                Select Case ctr

                    Case 0 '=> BILL ACCEPTOR
                        inp_bill = strArr(ctr)

                    Case 1 '=> COIN ACCEPTOR
                        inp_coin = strArr(ctr)

                    Case 2 '=> DOOR LOCK
                        inp_doorlock = strArr(ctr)

                    Case 3 '=> CASH LOCK
                        inp_cashlock = strArr(ctr)

                    Case 4 '=> ANTI-KAWAT DEVICE
                        inp_akd = strArr(ctr)

                    Case 5 '=> POWER
                        inp_power = strArr(ctr)

                    Case 6 '=> KEY LOCK
                        inp_keylock = strArr(ctr)

                    Case 7 '=> TEMPERATURE
                        inp_temp = strArr(ctr)

                End Select
            Next
        End If

    End Sub


#End Region

End Module
