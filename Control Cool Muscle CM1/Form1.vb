Imports System.IO
Imports System.IO.Ports

Public Class Form1
    Private Cls_CoolMuscle As New Class_CoolMuscle()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Cls_CoolMuscle.DataReceivedEvent, AddressOf SerialDataReceived
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            If Cls_CoolMuscle.OpenPort("COM5", 38400) Then
                Timer_CM.Enabled = True
                btnConnect.Text = "Disconnect"
            End If
        Else
            Timer_CM.Enabled = False
            Cls_CoolMuscle.ClosePort()
            btnConnect.Text = "Connect"
        End If
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Cls_CoolMuscle.PTP(txt_position.Text, txt_speed.Text, txt_acc.Text)

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Cls_CoolMuscle.StopMotion()
    End Sub

    Private Sub SerialDataReceived(ByVal data As String)
        Try
            Dim startIndex As Integer = data.IndexOf("Px.1=")

            If startIndex <> -1 Then
                Dim extractedText As String = data.Substring(startIndex)

                Invoke(New MethodInvoker(Sub() lbPosition.Text = extractedText.Replace("Px.1=", "")))
            End If
        Catch ex As Exception
            MessageBox.Show("Error processing data: " & ex.Message)
        End Try


    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnenable.Click
        Cls_CoolMuscle.Enable()

    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        Cls_CoolMuscle.Disable()

    End Sub

    Private Sub Timer_CM_Tick(sender As Object, e As EventArgs) Handles Timer_CM.Tick
        Timer_CM.Enabled = False

        If cbshowposition.Checked Then
            Cls_CoolMuscle.readPosition()


        End If

        Timer_CM.Enabled = True
    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Cls_CoolMuscle.Home()
    End Sub

    Private Sub PositionBar_ValueChanged(sender As Object, e As EventArgs) Handles PositionBar.ValueChanged
        Cls_CoolMuscle.PTP(PositionBar.Value, txt_speed.Text, txt_acc.Text)
    End Sub
End Class
