Public Class empleados
    Property numEmpleado As String
    Property cedula As String
    Property nombre As String
    Property apellidos As String
    Property sexo As String
    Property edad As String
    Property empresalab As String
    Property fechaIngreso As String
    Property puesto As String
    Property horaslab As String
    Public Overrides Function ToString() As String
        Return "(Numero Empl: " + " " + numEmpleado + ") " + "(Cedula: " + " " + cedula + ") " + "(Nombre: " + nombre + ") " + "(Apellisdos: " + apellidos + ")" + "(Sexo: " + sexo + ") " + "(Edad: " + edad + ")" + "(Horas Laboradas: " + horaslab + ") " + "(Fecha Ing: " + fechaIngreso + ") " + "(Puesto: " + puesto + ")"
    End Function
End Class
