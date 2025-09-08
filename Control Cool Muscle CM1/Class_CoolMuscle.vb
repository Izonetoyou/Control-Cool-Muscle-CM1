Imports System.IO.Ports

Public Class Class_CoolMuscle
    Private WithEvents SerialPort As New SerialPort
    Public Event DataReceivedEvent(ByVal data As String)

    Public Function OpenPort(portName As String, baudRate As Integer) As Boolean
        Try
            If SerialPort.IsOpen Then Return True

            With SerialPort
                .PortName = portName
                .BaudRate = baudRate
                .DataBits = 8
                .Parity = Parity.None
                .StopBits = StopBits.One
                .Handshake = Handshake.None
                .Encoding = System.Text.Encoding.ASCII
                .Open()
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show("Error opening serial port: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub ClosePort()
        If SerialPort.IsOpen Then SerialPort.Close()
    End Sub

    Public Sub SendCommand(command As String)
        If SerialPort.IsOpen Then
            SerialPort.WriteLine(command)
        Else
            MessageBox.Show("Serial port not open")
        End If
    End Sub


    Public Sub Enable()
        SendCommand("(.1" & vbCrLf)
    End Sub


    Public Sub Disable()
        SendCommand(").1" & vbCrLf)
    End Sub


    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Try
            Dim receivedData As String = SerialPort.ReadExisting()
            RaiseEvent DataReceivedEvent(receivedData)
        Catch ex As Exception
            MessageBox.Show("Error receiving data: " & ex.Message)
        End Try
    End Sub

    Public Sub readPosition()
        SendCommand("?96.1" & vbCrLf)
    End Sub
    Public Sub Home()
        SendCommand("|1.1" & vbCrLf)
    End Sub
    Public Sub PTP(position As String, speed As String, acc As String)
        SendCommand("P1.1=" & position & ",S1.1=" & speed & "A1.1=" & acc & vbCrLf)
        SendCommand("B1.1" & vbCrLf)
        SendCommand("S1.1, A1.1, P1.1" & vbCrLf)
        SendCommand("[.1" & vbCrLf)
    End Sub
    Public Sub StopMotion()
        SendCommand("].1" & vbCrLf)
    End Sub

    Public Sub OrgSearch()
        SendCommand("I.1" & vbCrLf)
    End Sub
End Class
