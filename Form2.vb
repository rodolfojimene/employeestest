Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private datosEmpresa As empresa
    Private Sub editar()
        TextBox1.Text = datosEmpresa.cedJur
        TextBox2.Text = datosEmpresa.siglas
        TextBox3.Text = datosEmpresa.nomEmpresa
        TextBox4.Text = datosEmpresa.añofund
    End Sub
    Private Sub limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datosEmpresa = New empresa()
        datosEmpresa.cedJur = TextBox1.Text
        datosEmpresa.siglas = TextBox2.Text
        datosEmpresa.nomEmpresa = CStr(TextBox3.Text)
        datosEmpresa.añofund = TextBox4.Text
        datosEmpresa.ToString()
        Dim indiceEmpresa = -1
        For Each emp As empresa In ListBox1.Items
            If emp.cedJur.Equals(datosEmpresa.cedJur) Then
                indiceEmpresa = ListBox1.Items.IndexOf(emp)
            End If
        Next

        If indiceEmpresa >= 0 Then
            ListBox1.Items.RemoveAt(indiceEmpresa)
        End If
        ListBox1.Items.Add(datosEmpresa)
        limpiar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex >= 0 Then
            datosEmpresa = ListBox1.SelectedItem()
            editar()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim formulario3 = New Form3()
        If ListBox1.SelectedIndex >= 0 Then
            formulario3.labelnombre.Text = datosEmpresa.nomEmpresa

        End If

        formulario3.ShowDialog()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class