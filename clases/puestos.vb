Public Class puestos
    Property indPuesto As String
    Property nombPuesto As String
    Property salHora As String
    Public Overrides Function ToString() As String
        Return "(Indicador puesto: " + "" + indPuesto + ") " + "(Nombre Puesto: " + " " + nombPuesto + ") " + "(Salario por hora: " + salHora + ")"
    End Function
End Class
