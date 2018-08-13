Public Class Form1

    Dim value1 As Int32
    Dim value2 As Int32
    Dim Operate As String = ""


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResultBox.Text = ResultBox.Text + "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResultBox.Text = ResultBox.Text + "4"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResultBox.Text = ResultBox.Text + "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResultBox.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ResultBox.Text = ResultBox.Text + "8"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ResultBox.Text = ResultBox.Text + "5"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ResultBox.Text = ResultBox.Text + "2"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ResultBox.Text = ResultBox.Text + "0"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ResultBox.Text = ResultBox.Text + "9"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ResultBox.Text = ResultBox.Text + "6"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ResultBox.Text = ResultBox.Text + "3"

    End Sub
    ' Result
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        value2 = Convert.ToInt32(ResultBox.Text)

        If Operate = "+" Then
            ResultBox.Text = CStr(value1 + value2)
        ElseIf Operate = "-" Then
            ResultBox.Text = CStr(value1 - value2)
        ElseIf Operate = "/" Then
            ResultBox.Text = CStr(value1 / value2)
        ElseIf Operate = "*" Then
            ResultBox.Text = CStr(value1 * value2)
        End If

        Operate = ""
    End Sub
    ' Multiply
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        value1 = Convert.ToInt32(ResultBox.Text)
        Operate = "*"
        ResultBox.Clear()
    End Sub
    ' Division
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        value1 = Convert.ToInt32(ResultBox.Text)
        Operate = "/"
        ResultBox.Clear()
    End Sub
    ' Subtraction
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        value1 = Convert.ToInt32(ResultBox.Text)
        Operate = "-"
        ResultBox.Clear()
    End Sub
    ' Addition
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        value1 = Convert.ToInt32(ResultBox.Text)
        Operate = "+"
        ResultBox.Clear()
    End Sub

    Private Sub ResultBox_TextChanged(sender As Object, e As EventArgs) Handles ResultBox.TextChanged

    End Sub
End Class
