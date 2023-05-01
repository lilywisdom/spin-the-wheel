' Name: Spin the Wheel
' Purpose: Spins wheel
' Programmer: Lily Woodworth Wisdom on 4/30/23

Option Strict On
Option Infer Off
Option Explicit On


Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = My.Resources.spin_0
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Dim MyValue As Integer
        MyValue = CInt(Int((26 * Rnd()) + 1))


        If MyValue = 1 Then
            picWheel.Image = My.Resources.spin_0
        ElseIf MyValue = 2 Then
            picWheel.Image = My.Resources.spin_1
        ElseIf MyValue = 3 Then
            picWheel.Image = My.Resources.spin_2
        ElseIf MyValue = 4 Then
            picWheel.Image = My.Resources.spin_3
        ElseIf MyValue = 5 Then
            picWheel.Image = My.Resources.spin_4
        ElseIf MyValue = 6 Then
            picWheel.Image = My.Resources.spin_5
        ElseIf MyValue = 7 Then
            picWheel.Image = My.Resources.spin_6
        ElseIf MyValue = 8 Then
            picWheel.Image = My.Resources.spin_7
        ElseIf MyValue = 9 Then
            picWheel.Image = My.Resources.spin_8
        ElseIf MyValue = 10 Then
            picWheel.Image = My.Resources.spin_9
        ElseIf MyValue = 11 Then
            picWheel.Image = My.Resources.spin_10
        ElseIf MyValue = 12 Then
            picWheel.Image = My.Resources.spin_11
        ElseIf MyValue = 13 Then
            picWheel.Image = My.Resources.spin_12
        ElseIf MyValue = 14 Then
            picWheel.Image = My.Resources.spin_13
        ElseIf MyValue = 15 Then
            picWheel.Image = My.Resources.spin_14
        ElseIf MyValue = 16 Then
            picWheel.Image = My.Resources.spin_15
        ElseIf MyValue = 17 Then
            picWheel.Image = My.Resources.spin_16
        ElseIf MyValue = 18 Then
            picWheel.Image = My.Resources.spin_17
        ElseIf MyValue = 19 Then
            picWheel.Image = My.Resources.spin_18
        ElseIf MyValue = 20 Then
            picWheel.Image = My.Resources.spin_19
        ElseIf MyValue = 21 Then
            picWheel.Image = My.Resources.spin_20
        ElseIf MyValue = 22 Then
            picWheel.Image = My.Resources.spin_21
        ElseIf MyValue = 23 Then
            picWheel.Image = My.Resources.spin_22
        ElseIf MyValue = 24 Then
            picWheel.Image = My.Resources.spin_23
        ElseIf MyValue = 25 Then
            picWheel.Image = My.Resources.spin_24
        ElseIf MyValue = 26 Then
            picWheel.Image = My.Resources.spin_25
        End If
    End Sub
    Private Async Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        For intTimer As Integer = 1 To 10
            picWheel.Image = My.Resources.spin_1
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_2
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_3
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_4
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_5
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_6
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_7
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_8
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_9
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_10
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_11
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_12
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_13
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_14
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_15
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_16
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_17
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_18
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_19
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_20
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_21
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_22
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_23
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_24
            Await Task.Delay(20)
            picWheel.Image = My.Resources.spin_25
            Await Task.Delay(20)
        Next
    End Sub



End Class


