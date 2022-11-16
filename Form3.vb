Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private datosEmpresa As empresa
    Private datosPuestos As puestos
    Private formul2 As Form2
    Private formul3 As Form3
    Private Sub editar()
        TextBox1.Text = datosPuestos.indPuesto
        TextBox2.Text = datosPuestos.nombPuesto
        TextBox3.Text = datosPuestos.salHora

    End Sub
    Private Sub limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formulario4 = New Form4()
        formulario4.Label11.Text = labelnombre.Text
        If ListBox1.Items.Count > 0 Then
            For Each listaOcupaciones As puestos In ListBox1.Items
                formulario4.ComboBox2.Items.Add(listaOcupaciones.nombPuesto)
            Next
        End If

        formulario4.ShowDialog()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub labelnombre_Click(sender As Object, e As EventArgs) Handles labelnombre.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datosPuestos = New puestos()
        datosPuestos.indPuesto = TextBox1.Text
        datosPuestos.nombPuesto = CStr(TextBox2.Text)
        datosPuestos.salHora = TextBox3.Text

        datosPuestos.ToString()
        Dim indicepuesto = -1
        For Each pues As puestos In ListBox1.Items
            If pues.indPuesto.Equals(datosPuestos.indPuesto) Then
                indicepuesto = ListBox1.Items.IndexOf(pues)
            End If
        Next

        If indicepuesto >= 0 Then
            ListBox1.Items.RemoveAt(indicepuesto)
        End If
        ListBox1.Items.Add(datosPuestos)
        limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.SelectedIndex >= 0 Then
            datosPuestos = ListBox1.SelectedItem()
            editar()
        End If
    End Sub
End Class