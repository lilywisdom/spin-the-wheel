' Name: Spin the Wheel
' Purpose: Spins wheel
' Programmer: Lily Woodworth Wisdom & Jelani Penny - Johnson on 4/30/23


Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain
        Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            picWheel.Image = My.Resources.spin_0
        End Sub

    Private Async Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Dim MyValue As Integer

        MyValue = CInt(Int((25 * Rnd()) + 1))
        For intTimer As Integer = 1 To 2
            If MyValue = 25 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 24 Then
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
                Label1.Text = "2000"
            ElseIf MyValue = 23 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 22 Then
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
                Label1.Text = "2000"
            ElseIf MyValue = 21 Then
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
                Label1.Text = "SKIP"
            ElseIf MyValue = 20 Then
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
                Label1.Text = "2000"
            ElseIf MyValue = 19 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 18 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 17 Then
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
                Label1.Text = "5000"
            ElseIf MyValue = 16 Then
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
                Label1.Text = "SKIP"
            ElseIf MyValue = 15 Then
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
                Label1.Text = "BROKE"
            ElseIf MyValue = 14 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 13 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 12 Then
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
                Label1.Text = "2000"
            ElseIf MyValue = 11 Then
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
                Label1.Text = "5000"
            ElseIf MyValue = 10 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 9 Then
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
                Label1.Text = "BROKE"
            ElseIf MyValue = 8 Then
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
                Label1.Text = "2000"
            ElseIf MyValue = 7 Then
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
                Label1.Text = "1000"
            ElseIf MyValue = 6 Then
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
                Label1.Text = "10000"
            ElseIf MyValue = 5 Then
                picWheel.Image = My.Resources.spin_1
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_2
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_3
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_4
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_5
                Label1.Text = "SKIP"
            ElseIf MyValue = 4 Then
                picWheel.Image = My.Resources.spin_1
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_2
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_3
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_4
                Label1.Text = "5000"
            ElseIf MyValue = 3 Then
                picWheel.Image = My.Resources.spin_1
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_2
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_3
                Label1.Text = "1000"
            ElseIf MyValue = 2 Then
                picWheel.Image = My.Resources.spin_1
                Await Task.Delay(20)
                picWheel.Image = My.Resources.spin_2
                Label1.Text = "1000"
            ElseIf MyValue = 1 Then
                picWheel.Image = My.Resources.spin_1
                Label1.Text = "2000"

            End If
        Next

    End Sub
End Class


