Imports System.Windows.Forms.VisualStyles
Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Interop

Public Class Form4
    Private datosEmpleado As empleados
    Private datosPuestos As puestos
    Private datosEmpresa As empresa
    Property ReporteEmpleados As ReporteEmpleados
    Private Sub editar()
        TextBox1.Text = datosEmpleado.numEmpleado
        TextBox2.Text = datosEmpleado.cedula
        TextBox3.Text = datosEmpleado.nombre
        TextBox4.Text = datosEmpleado.apellidos
        ComboBox1.Text = datosEmpleado.sexo
        TextBox5.Text = datosEmpleado.edad
        TextBox7.Text = datosEmpleado.horaslab
        TextBox6.Text = datosEmpleado.fechaIngreso
        ComboBox2.Text = datosEmpleado.puesto



    End Sub
    Private Sub limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datosEmpleado = New empleados()
        datosEmpleado.numEmpleado = TextBox1.Text
        datosEmpleado.cedula = TextBox2.Text
        datosEmpleado.nombre = TextBox3.Text
        datosEmpleado.apellidos = TextBox4.Text
        datosEmpleado.edad = TextBox5.Text
        datosEmpleado.fechaIngreso = TextBox6.Text
        datosEmpleado.horaslab = TextBox7.Text
        datosEmpleado.sexo = ComboBox1.Text
        datosEmpleado.puesto = ComboBox2.Text
        datosEmpleado.horaslab = TextBox7.Text

        datosEmpleado.ToString()
        Dim indiceEmpleado = -1
        For Each emp As empleados In ListBox1.Items
            If emp.cedula.Equals(datosEmpleado.cedula) Then
                indiceEmpleado = ListBox1.Items.IndexOf(emp)
            End If
        Next

        If indiceEmpleado >= 0 Then
            ListBox1.Items.RemoveAt(indiceEmpleado)
        End If
        ListBox1.Items.Add(datosEmpleado)
        limpiar()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex >= 0 Then
            datosEmpleado = ListBox1.SelectedItem()
            editar()

        End If
    End Sub
    Private Function ObtenerDatosEmpleados() As List(Of empleados)
        Dim emplea = New List(Of empleados)
        For Each empleados As empleados In ListBox1.Items
            emplea.Add(empleados)
        Next
        Return emplea
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveFileDialog1.Filter = "XLSX Files|*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ruta = SaveFileDialog1.FileName
            Dim emplea = ObtenerDatosEmpleados()
            Dim nombre = Form3.labelnombre.Text
            ReporteEmpleados.Generar_Reporte_Empleados(emplea, ruta, nombre)
        End If


    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReporteEmpleados = New ReporteEmpleados()
    End Sub
End Class