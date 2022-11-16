Public Class empresa
    Property cedJur As String
    Property siglas As String
    Property nomEmpresa As String
    Property añofund As String
    Public Overrides Function ToString() As String
        Return "(Ced: " + " " + cedJur + ") " + "(Siglas: " + " " + siglas + ") " + "(Nombre: " + nomEmpresa + ") " + "(Año: " + añofund + ")"
    End Function

End Class
