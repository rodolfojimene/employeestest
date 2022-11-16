Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formulario2 = New Form2()

        If TextBox1.Text = "R" And TextBox2.Text = "1" Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("usuario y contraseña incorrecta")
        End If
    End Sub
End Class
