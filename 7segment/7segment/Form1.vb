Public Class Form1
    Dim Second As Int32 = -1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_BackColorChanged(sender As Object, e As EventArgs) Handles Button1.BackColorChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second += 1

        If (Second = 1) Then
            Button1.BackColor = Color.White
            Button2.BackColor = Color.White
            Button3.BackColor = Color.White
            Button4.BackColor = Color.White
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White
        ElseIf (Second = 2) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.White
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.White
            Button7.BackColor = Color.Red

        ElseIf (Second = 3) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.White
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White

        ElseIf (Second = 4) Then
            Button1.BackColor = Color.White
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.White
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White

        ElseIf (Second = 5) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White

        ElseIf (Second = 6) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 7) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.White
            Button3.BackColor = Color.White
            Button4.BackColor = Color.White
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White

        ElseIf (Second = 8) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 9) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White

        Else
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Second = 0
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class
