Option Explicit On
Imports System.IO.Ports
Public Class frmMain
    Dim dbCon As New ADODB.Connection
    Dim dbRS As New ADODB.Recordset
    'Declaration for serial communication protocol/////////////////////////////////
    Dim RByte As Byte
    Dim RStart As Boolean
    Dim RTotalBytes As Integer
    Dim RCount As Integer

    '//////////////////////////////////////////
    Dim Live(8) As Integer
    Dim Ref(8) As Integer
    Dim Latched(8) As Integer

    Dim pCMD As String
    Dim tCount As Integer
    Dim fTrigger As Boolean
    Dim Score(100) As Integer
    Dim CMD(100) As String

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetComList()
        Dim R As Integer

        Chart.Column = 1
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R
        Chart.Column = 2
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R
        Chart.Column = 3
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R
        Chart.Column = 4
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R
        Chart.Column = 5
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R
        Chart.Column = 6
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R
        Chart.Column = 7
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R
        Chart.Column = 8
        For R = 1 To Chart.RowCount
            Chart.Row = R
            Chart.Data = 0
        Next R

        Chart.Row = 1

        dbCon.Open("Driver={SQL Server}; Server=.\SQLEXPRESS; Database=Skinput", )
        

    End Sub
    Private Sub GetComList()
        ' Get a list of serial port names.
        Dim ports As String() = SerialPort.GetPortNames()
        ' Display each port name to the console.
        Dim port As String
        For Each port In ports
            cmbCOM.Items.Add(port)
        Next port

    End Sub
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        On Error GoTo X
        If Port.PortOpen = True Then Port.PortOpen = False
        'set selected port
        Port.CommPort = Mid(cmbCOM.Text, 4)
        'baud rate setting
        Port.Settings = "9600,N,8,1"
        'some other settings
        Port.InputLen = 1
        Port.RThreshold = 1
        'open the port
        Port.PortOpen = True

        MsgBox("Port is Re-configured.", MsgBoxStyle.Information) 'display message
        Exit Sub
X:
        MsgBox(Err.Description)
    End Sub
    Private Sub Port_OnComm(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Port.OnComm
        'On Error GoTo X
        Dim Value As Single

        If Not Port.CommEvent = 2 Then Exit Sub
        RByte = Asc(Port.Input)
        'txtSerial = txtSerial & Chr(RByte)
        'Serial Communication Protocol/////////////////////////////////////////////
        If RStart = False Then
            Select Case RCount
                Case 0
                    If RByte = Asc("L") Then RCount = 1 Else RCount = 0
                Case 1
                    If RByte = Asc("I") Then RCount = 2 Else RCount = 0
                Case 2
                    RTotalBytes = RByte
                    RCount = 0
                    RStart = True
            End Select
            Exit Sub
        End If
        RCount = RCount + 1
        '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        If RCount = 1 Then

            'Temperature//////////////////////////////////////////////////////////////

            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV1.Text = Value
            Live(0) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 1
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        If RCount = 2 Then
            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV2.Text = Value
            Live(1) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 2
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        If RCount = 3 Then
            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV3.Text = Value
            Live(2) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 3
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        If RCount = 4 Then
            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV4.Text = Value
            Live(3) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 4
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        If RCount = 5 Then
            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV5.Text = Value
            Live(4) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 5
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        If RCount = 6 Then
            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV6.Text = Value
            Live(5) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 6
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        If RCount = 7 Then
            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV7.Text = Value
            Live(6) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 7
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        If RCount = 8 Then
            'display value-----------------------------------------------------------
            Value = Format(RByte, "00.0")
            lblV8.Text = Value
            Live(7) = Value
            'graph plotting----------------------------------------------------------
            Chart.Column = 8
            'shift all data
            Dim temp As Integer
            Dim R As Integer
            For R = 1 To Chart.RowCount - 1
                Chart.Row = R + 1
                temp = Chart.Data
                Chart.Row = R
                Chart.Data = temp
            Next R
            'insert data in last row
            Chart.Row = Chart.RowCount
            Chart.Data = Value

        End If

        'Re-Syncronize
        If RCount = RTotalBytes Then
            RStart = False
            RCount = 0

            Process()
        End If

        Exit Sub
X:
        MsgBox(Err.Description)
    End Sub
    Sub Process()
        Dim i As Integer


        For i = 0 To 7
            If Math.Abs(Live(i) - Ref(i)) >= Val(txtDelta.Text) Then
                fTrigger = True
                tCount = 0

                If Not chkLearn.Checked Then Timer1.Enabled = True

                If Math.Abs(Live(i) - Ref(i)) > Math.Abs(Latched(i) - Ref(i)) Then
                    Latched(i) = Live(i)
                End If
            End If
        Next i

        'display on screen
        lblL1.Text = Latched(0)
        lblL2.Text = Latched(1)
        lblL3.Text = Latched(2)
        lblL4.Text = Latched(3)
        lblL5.Text = Latched(4)
        lblL6.Text = Latched(5)
        lblL7.Text = Latched(6)
        lblL8.Text = Latched(7)


    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i, j, SrNo As Integer

        tCount = tCount + 1

        If tCount < 5 Then Return


        If fTrigger = True Then
            'search the current pattern in database
            dbRS.Open("SELECT * FROM Pattern", dbCon, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            'clear the score array
            For i = 0 To 99
                Score(i) = 99999
            Next

            While Not dbRS.EOF
                Dim dbV(8) As Integer
                dbV(0) = dbRS.Fields("V1").Value
                dbV(1) = dbRS.Fields("V2").Value
                dbV(2) = dbRS.Fields("V3").Value
                dbV(3) = dbRS.Fields("V4").Value
                dbV(4) = dbRS.Fields("V5").Value
                dbV(5) = dbRS.Fields("V6").Value
                dbV(6) = dbRS.Fields("V7").Value
                dbV(7) = dbRS.Fields("V8").Value

                SrNo = dbRS.Fields("SrNo").Value
                CMD(SrNo) = dbRS.Fields("CMD").Value

                'compare the values for the score
                Score(SrNo) = 0
                Dim x As Integer
                For x = 0 To 7
                    Score(SrNo) = Score(SrNo) + (Math.Abs(dbV(x) - Latched(x)) * (x + 1))
                Next x

                dbRS.MoveNext()
            End While
            dbRS.Close()
            fTrigger = False

            'sort the score array in acending order
            Dim tno As Integer
            Dim temp As String
            For i = 0 To 99
                For j = i + 1 To 99
                    If Score(i) > Score(j) Then
                        'swap them
                        tno = Score(i)
                        Score(i) = Score(j)
                        Score(j) = tno

                        temp = CMD(i)
                        CMD(i) = CMD(j)
                        CMD(j) = temp
                    End If
                Next j
            Next i

            txtSysMsg.Text = ""
            For i = 0 To 99
                If Score(i) <> 99999 Then
                    txtSysMsg.Text = txtSysMsg.Text & vbNewLine & CMD(i) & "-" & Score(i)
                End If
            Next


            'If pCMD <> CMD(0) Then
            Select Case CMD(0)
                Case "Left"
                    If chkEnable.Checked Then System.Windows.Forms.SendKeys.Send("{LEFT}")
                Case "Right"
                    If chkEnable.Checked Then System.Windows.Forms.SendKeys.Send("{RIGHT}")
                Case "Change"
                    If chkEnable.Checked Then System.Windows.Forms.SendKeys.Send("{UP}")
                Case "Down"
                    If chkEnable.Checked Then System.Windows.Forms.SendKeys.Send("{DOWN}")
                Case "Next"
                    If chkEnable.Checked Then System.Windows.Forms.SendKeys.Send("N")
                Case "Prev"
                    If chkEnable.Checked Then System.Windows.Forms.SendKeys.Send("P")
                Case Else
                    pCMD = ""
            End Select

            txtCMDs.Text = CMD(0) & vbNewLine & txtCMDs.Text
            pCMD = CMD(0)

            'End If
        End If



        'refresh latched values

        Latched(0) = Ref(0)
        Latched(1) = Ref(1)
        Latched(2) = Ref(2)
        Latched(3) = Ref(3)
        Latched(4) = Ref(4)
        Latched(5) = Ref(5)
        Latched(6) = Ref(6)
        Latched(7) = Ref(7)

        Timer1.Enabled = False
        fTrigger = False

    End Sub

    Private Sub btnRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRef.Click
        lblR1.Text = lblV1.Text
        lblR2.Text = lblV2.Text
        lblR3.Text = lblV3.Text
        lblR4.Text = lblV4.Text
        lblR5.Text = lblV5.Text
        lblR6.Text = lblV6.Text
        lblR7.Text = lblV7.Text
        lblR8.Text = lblV8.Text

        Ref(0) = lblR1.Text
        Ref(1) = lblR2.Text
        Ref(2) = lblR3.Text
        Ref(3) = lblR4.Text
        Ref(4) = lblR5.Text
        Ref(5) = lblR6.Text
        Ref(6) = lblR7.Text
        Ref(7) = lblR8.Text

        Latched(0) = Ref(0)
        Latched(1) = Ref(1)
        Latched(2) = Ref(2)
        Latched(3) = Ref(3)
        Latched(4) = Ref(4)
        Latched(5) = Ref(5)
        Latched(6) = Ref(6)
        Latched(7) = Ref(7)

        Timer1.Enabled = False
        fTrigger = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim SrNo As Integer
        dbRS.Open("SELECT * FROM Pattern", dbCon, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If dbRS.BOF Then
            SrNo = 1
        Else
            dbRS.MoveLast()
            SrNo = dbRS.Fields("SrNo").Value + 1
        End If
        dbRS.AddNew()
        dbRS.Fields("SrNo").Value = SrNo
        dbRS.Fields("CMD").Value = txtCMD.Text
        dbRS.Fields("V1").Value = Latched(0)
        dbRS.Fields("V2").Value = Latched(1)
        dbRS.Fields("V3").Value = Latched(2)
        dbRS.Fields("V4").Value = Latched(3)
        dbRS.Fields("V5").Value = Latched(4)
        dbRS.Fields("V6").Value = Latched(5)
        dbRS.Fields("V7").Value = Latched(6)
        dbRS.Fields("V8").Value = Latched(7)
        dbRS.Update()
        dbRS.Close()

        txtSysMsg.Text = "Command-Pattern Saved." & vbNewLine & txtSysMsg.Text

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        frmPat.Show()
    End Sub
End Class
