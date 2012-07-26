Imports System.Math
Imports System.IO.Ports
Public Class Form1
    Private Sub ShutterSpeedProfile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutterSpeedProfile.SelectedIndexChanged
        If ShutterSpeedProfile.Text = "Constant" Then
            ShutterSpeedMin.Enabled = False
            ShutterSpeedPeriod.Enabled = False
        Else
            ShutterSpeedMin.Enabled = True
            ShutterSpeedPeriod.Enabled = True
        End If
    End Sub

    Private Sub WaitTimeProfile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitTimeProfile.SelectedIndexChanged
        If WaitTimeProfile.Text = "Constant" Then
            WaitMin.Enabled = False
            WaitPeriod.Enabled = False
        Else
            WaitMin.Enabled = True
            WaitPeriod.Enabled = True
        End If
    End Sub

    Private Sub ShutterSpeedProfile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ShutterSpeedProfile.KeyPress
        e.KeyChar = ChrW(0)
    End Sub

    Private Sub WaitTimeProfile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WaitTimeProfile.KeyPress
        e.KeyChar = ChrW(0)
    End Sub

    Private Sub NumericOnly_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ShutterSpeedMax.KeyPress, WaitTimePt.KeyPress, WaitPeriod.KeyPress, WaitMin.KeyPress, WaitMax.KeyPress, TimesPt.KeyPress, ShutterTimePt.KeyPress, ShutterSpeedPeriod.KeyPress, ShutterSpeedMin.KeyPress, NumShotsProfile.KeyPress, RepeatSequencePt.KeyPress, RepeatSequenceProfile.KeyPress
        Select Case AscW(e.KeyChar)
            Case Asc("0") To Asc("9")
            Case 8
            Case Else
                e.KeyChar = ChrW(0)
        End Select
    End Sub

    Private Sub GenerateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateBtn.Click
        Dim numShots As UInteger
        Dim ShutterMin As UInteger
        Dim ShutterMax As UInteger
        Dim ShutterPeriod As UInteger
        Dim WaitTimeMin As UInteger
        Dim WaitTimeMax As UInteger
        Dim WaitTimePeriod As UInteger
        Try
            numShots = CUInt(NumShotsProfile.Text)
            If numShots > 16000 Then
                MsgBox("Number of Shots is limited to 16000!", vbOKOnly, "Shots")
                Return
            End If


            ShutterMax = CUInt(ShutterSpeedMax.Text)
            If Not ShutterSpeedProfile.Text = "Constant" Then
                ShutterPeriod = CUInt(ShutterSpeedPeriod.Text)
                ShutterMin = CUInt(ShutterSpeedMin.Text)
            End If

            WaitTimeMax = CUInt(WaitMax.Text)
            If Not WaitTimeProfile.Text = "Constant" Then
                WaitTimePeriod = CUInt(WaitPeriod.Text)
                WaitTimeMin = CUInt(WaitMin.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        Dim shutterVector(numShots) As UInt16
        Dim waitVector(numShots) As UInt16

        Select Case ShutterSpeedProfile.Text
            Case "Sine"
                SineGen(ShutterMin, ShutterMax, ShutterPeriod, numShots, shutterVector)
            Case "Square"
                SquareGen(ShutterMin, ShutterMax, ShutterPeriod, numShots, shutterVector)
            Case "Sawtooth"
                SawtoothGen(ShutterMin, ShutterMax, ShutterPeriod, numShots, shutterVector)
            Case "Constant"
                For i As Integer = 0 To numShots - 1
                    shutterVector(i) = ShutterMax
                Next
            Case Else
                MsgBox("Incorrect input in profile type box: " & ShutterSpeedProfile.Text)
        End Select

        Select Case WaitTimeProfile.Text
            Case "Sine"
                SineGen(WaitTimeMin, WaitTimeMax, WaitTimePeriod, numShots, waitVector)
            Case "Square"
                SquareGen(WaitTimeMin, WaitTimeMax, WaitTimePeriod, numShots, waitVector)
            Case "Sawtooth"
                SawtoothGen(WaitTimeMin, WaitTimeMax, WaitTimePeriod, numShots, waitVector)
            Case "Constant"
                For i As Integer = 0 To numShots - 1
                    waitVector(i) = WaitTimeMax
                Next
            Case Else
                MsgBox("Incorrect input in profile type box: " & WaitTimeProfile.Text)
        End Select

        ShutterChart.Series(0).Points.Clear()
        WaitTimeChart.Series(0).Points.Clear()
        For i As Integer = 0 To numShots - 1
            ShutterChart.Series(0).Points.AddY(CDbl(shutterVector(i)))
            WaitTimeChart.Series(0).Points.AddY(CDbl(waitVector(i)))
        Next

        UploadBtnProfile.Enabled = True

    End Sub

    Private Sub SineGen(ByVal Min As UInteger, ByVal Max As UInteger, ByVal Period As UInteger, ByVal Points As UInteger, ByRef Output As UInt16())
        For i As Integer = 0 To Points - 1
            Dim A As Double = (Max - Min) / 2
            Dim omega As Double = (2 * PI) / Period
            Output(i) = A * Sin(omega * i) + A + Min
        Next
    End Sub

    Private Sub SquareGen(ByVal Min As UInteger, ByVal Max As UInteger, ByVal Period As UInteger, ByVal Points As UInteger, ByRef Output As UInt16())
        For i As Integer = 0 To Points - 1
            Dim omega As Double = (2 * PI) / Period
            Dim sineFunc As Double = Sin(omega * i)
            If sineFunc > 0 Then
                Output(i) = Max
            Else
                Output(i) = Min
            End If
        Next
    End Sub

    Private Sub SawtoothGen(ByVal Min As UInteger, ByVal Max As UInteger, ByVal Period As UInteger, ByVal Points As UInteger, ByRef Output As UInt16())
        For i As Integer = 0 To Points - 1
            Dim omega As Double = (2 * PI) / Period
            'use 3rd order Taylor approx
            Dim sawtooth As Double = (8 / (PI * PI)) * (Sin(omega * i) - (1 / 9) * Sin(3 * omega * i) + (1 / 25) * Sin(5 * omega * i))
            Dim A As Double = (Max - Min) / 2
            Output(i) = A * sawtooth + A + Min
        Next
    End Sub

    Private Sub PtAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PtAddBtn.Click
        Dim n As Integer = PtGrid.Rows.Add()
        PtGrid.Rows.Item(n).Cells(0).Value = n
        PtGrid.Rows.Item(n).Cells(1).Value = ShutterTimePt.Text
        PtGrid.Rows.Item(n).Cells(2).Value = WaitTimePt.Text
        PtGrid.Rows.Item(n).Cells(3).Value = TimesPt.Text
    End Sub

    Private Sub PtUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PtUpload.Click
        Dim WaitTimes(0) As UInt16
        Dim ShutterTimes(0) As UInt16
        Dim NumRepeats As UInt16
        Try
            NumRepeats = CUInt(RepeatSequencePt.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        Dim NumPoints As UInt16 = 0
        Dim n As Integer = PtGrid.Rows.Count
        For i As Integer = 0 To n - 1
            Dim shutterTimeInt As UInteger
            Dim waitTimeInt As UInteger
            Dim timesInt As Integer
            Try
                shutterTimeInt = CUInt(PtGrid.Rows.Item(i).Cells(1).Value)
                waitTimeInt = CUInt(PtGrid.Rows.Item(i).Cells(2).Value)
                timesInt = CInt(PtGrid.Rows.Item(i).Cells(3).Value)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try
            For j As Integer = 0 To timesInt - 1
                WaitTimes(UBound(WaitTimes)) = waitTimeInt
                ReDim Preserve WaitTimes(UBound(WaitTimes) + 1)
                ShutterTimes(UBound(ShutterTimes)) = shutterTimeInt
                ReDim Preserve ShutterTimes(UBound(ShutterTimes) + 1)
                NumPoints += 1
            Next
        Next
        Dim args = New UploadArgs
        args.ShutterTimes = ShutterTimes
        args.WaitTimes = WaitTimes
        args.numPoints = NumPoints
        args.numRepeats = NumRepeats
        DeviceUploadBackgroundWorker.RunWorkerAsync(args)
        PtLoadingLabel.Visible = True
        PtUpload.Enabled = False
        'UploadPoints(ShutterTimes, WaitTimes, NumPoints, NumRepeats)
    End Sub

    Private Sub UploadBtnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadBtnProfile.Click
        Dim numShots As UInt16
        Dim numRepeats As UInt16
        Try
            numShots = CUInt(NumShotsProfile.Text)
            numRepeats = CUInt(RepeatSequenceProfile.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        Dim ShutterTimeProfileValues(numShots) As UInt16
        Dim WaitTimeProfileValues(numShots) As UInt16
        For i As Integer = 0 To numShots - 1
            ShutterTimeProfileValues(i) = ShutterChart.Series(0).Points.Item(i).YValues(0)
            WaitTimeProfileValues(i) = WaitTimeChart.Series(0).Points.Item(i).YValues(0)
        Next
        Dim args = New UploadArgs
        args.ShutterTimes = ShutterTimeProfileValues
        args.WaitTimes = WaitTimeProfileValues
        args.numPoints = numShots
        args.numRepeats = numRepeats
        DeviceUploadBackgroundWorker.RunWorkerAsync(args)
        ProfileLoadingLbl.Visible = True
        UploadBtnProfile.Enabled = False
        GenerateBtn.Enabled = False
        'UploadPoints(ShutterTimeProfileValues, WaitTimeProfileValues, numShots, numRepeats)
    End Sub

    'Save point by point table to a CSV text file
    Private Sub PatternSaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatternSaveBtn.Click
        Dim file As System.IO.StreamWriter
        If SavePatternDialog.ShowDialog() = DialogResult.OK Then
            Try
                file = My.Computer.FileSystem.OpenTextFileWriter(SavePatternDialog.FileName, False)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try
            For i As Integer = 0 To PtGrid.Rows.Count - 1
                file.WriteLine(PtGrid.Rows.Item(i).Cells(1).Value & "," _
                               & PtGrid.Rows.Item(i).Cells(2).Value & "," _
                               & PtGrid.Rows.Item(i).Cells(3).Value)
            Next
            file.Close()
        End If
    End Sub

    'user can open a previously saved pattern or one generated from another tool
    Private Sub PatternOpenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatternOpenBtn.Click
        Dim fileReader As System.IO.StreamReader
        If OpenPatternDialog.ShowDialog() = DialogResult.OK Then
            Try
                fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenPatternDialog.FileName)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try
            PtGrid.Rows.Clear()
            While Not fileReader.EndOfStream
                Dim stringReader As String
                Dim fields() As String
                stringReader = fileReader.ReadLine()
                fields = Split(stringReader, ",")
                If fields.Count <> 3 Then
                    MsgBox("File format incorrect!")
                    PtGrid.Rows.Clear()
                    fileReader.Close()
                    Return
                End If

                Dim n As Integer = PtGrid.Rows.Add()
                PtGrid.Rows.Item(n).Cells(0).Value = n
                PtGrid.Rows.Item(n).Cells(1).Value = fields(0)
                PtGrid.Rows.Item(n).Cells(2).Value = fields(1)
                PtGrid.Rows.Item(n).Cells(3).Value = fields(2)
            End While
            fileReader.Close()
        End If
    End Sub

    'storage class for sending arguments to background worker
    Private Class UploadArgs
        Property ShutterTimes As UInt16()
        Property WaitTimes As UInt16()
        Property numPoints As UInt16
        Property numRepeats As UInt16
    End Class

    'data is uploaded to device using a background worker (separate thread) so GUI doesn't appear to hang
    Private Sub DeviceUploadBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles DeviceUploadBackgroundWorker.DoWork
        UploadPoints(e.Argument.ShutterTimes, e.Argument.WaitTimes, e.Argument.numPoints, e.Argument.numRepeats)
    End Sub

    'when upload thread finishes, buttons are restored and loading labels go away
    Private Sub DeviceUploadBackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DeviceUploadBackgroundWorker.RunWorkerCompleted
        'restore button states and labels
        ProfileLoadingLbl.Visible = False
        UploadBtnProfile.Enabled = True
        GenerateBtn.Enabled = True
        PtLoadingLabel.Visible = False
        PtUpload.Enabled = True
    End Sub

    'routine that communicates with device to load data points
    Private Sub UploadPoints(ByRef ShutterTimes As UInt16(), ByRef WaitTimes As UInt16(), ByVal numPoints As UInt16, ByVal numRepeats As UInt16)
        Dim mySerial As New SerialPort(ComPortPt.Text, 9600)
        mySerial.ReadTimeout = 1000 'set timeout to one second
        mySerial.NewLine = vbCrLf 'all serial com is terminated with crlf
        Try
            mySerial.Open()
            'send gui control string
            mySerial.WriteLine("gui_control")
            If mySerial.ReadLine() = "gui_control_ack" Then

                'device acknowledged control
                mySerial.WriteLine("gui_set_repeats") 'set repeats
                Dim numRepeatsBytes() As Byte = BitConverter.GetBytes(numRepeats)
                mySerial.Write(numRepeatsBytes, 0, 2)
                mySerial.Write(vbCrLf)
                If mySerial.ReadLine() = "gui_stored_ack" Then
                    'stored successfully
                Else
                    'no ack, error
                    'Return
                End If

                Dim numShotsBytes() As Byte = BitConverter.GetBytes(numPoints)
                mySerial.WriteLine("gui_num_shots") 'set total number of shots
                mySerial.Write(numShotsBytes, 0, 2)
                mySerial.Write(vbCrLf)
                If mySerial.ReadLine() = "gui_stored_ack" Then
                    'stored successfully
                Else
                    'no ack, error
                    'Return
                End If

                'send points followed by crlf
                For i As Integer = 0 To numPoints - 1
                    Dim ShutterTimeBytes() As Byte = BitConverter.GetBytes(ShutterTimes(i))
                    Dim WaitTimeBytes() As Byte = BitConverter.GetBytes(WaitTimes(i))
                    mySerial.Write(ShutterTimeBytes, 0, 2)
                    mySerial.Write(WaitTimeBytes, 0, 2)
                    mySerial.Write(vbCrLf)

                    If mySerial.ReadLine() = "gui_stored_ack" Then
                        'device acknowledged write
                    Else
                        'no ack, error
                        'Return
                    End If
                Next

                'all points written, send done
                mySerial.WriteLine("gui_done")

            End If
            mySerial.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            mySerial.Close()
            Return
        End Try
    End Sub

End Class
