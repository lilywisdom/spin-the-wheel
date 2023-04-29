Public Class frmMain
    Dim Number As Integer
    Dim Random As Decimal
    Dim Number2 As Integer
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        TimerSpin.Enabled = True

    End Sub

    Private Sub TimerSpin_Tick(sender As Object, e As EventArgs) Handles TimerSpin.Tick
        Number += 1
        Number2 += 1

        If Number = 1 Then
            picWheel.Image = My.Resources.spin_0
        ElseIf Number = 2 Then
            picWheel.Image = My.Resources.spin_1
        ElseIf Number = 3 Then
            picWheel.Image = My.Resources.spin_2
        ElseIf Number = 4 Then
            picWheel.Image = My.Resources.spin_3
        ElseIf Number = 5 Then
            picWheel.Image = My.Resources.spin_4
        ElseIf Number = 6 Then
            picWheel.Image = My.Resources.spin_5
        ElseIf Number = 7 Then
            picWheel.Image = My.Resources.spin_6
        ElseIf Number = 8 Then
            picWheel.Image = My.Resources.spin_7
        ElseIf Number = 9 Then
            picWheel.Image = My.Resources.spin_8
        ElseIf Number = 10 Then
            picWheel.Image = My.Resources.spin_9
        ElseIf Number = 11 Then
            picWheel.Image = My.Resources.spin_10
        ElseIf Number = 12 Then
            picWheel.Image = My.Resources.spin_11
        ElseIf Number = 13 Then
            picWheel.Image = My.Resources.spin_12
        ElseIf Number = 14 Then
            picWheel.Image = My.Resources.spin_13
        ElseIf Number = 15 Then
            picWheel.Image = My.Resources.spin_14
        ElseIf Number = 16 Then
            picWheel.Image = My.Resources.spin_15
        ElseIf Number = 17 Then
            picWheel.Image = My.Resources.spin_16
        ElseIf Number = 18 Then
            picWheel.Image = My.Resources.spin_17
        ElseIf Number = 19 Then
            picWheel.Image = My.Resources.spin_18
        ElseIf Number = 20 Then
            picWheel.Image = My.Resources.spin_19
        ElseIf Number = 21 Then
            picWheel.Image = My.Resources.spin_20
        ElseIf Number = 22 Then
            picWheel.Image = My.Resources.spin_21
        ElseIf Number = 23 Then
            picWheel.Image = My.Resources.spin_22
        ElseIf Number = 24 Then
            picWheel.Image = My.Resources.spin_23
        ElseIf Number = 25 Then
            picWheel.Image = My.Resources.spin_24
        ElseIf Number = 26 Then
            picWheel.Image = My.Resources.spin_25

        End If
    End Sub
End Class
