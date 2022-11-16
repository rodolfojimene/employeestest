Imports Microsoft.Office.Interop
Public Class Gestor
    Property AplicacionExcel As Excel.Application

    Public Sub New()
    End Sub

    ' Crea y se retorna un Nuevo Archivo de Excel a partir de la Aplicación de Excel
    Public Function Obtener_Nuevo_Archivo_Excel() As Excel.Workbook
        Return AplicacionExcel.Workbooks.Add()
    End Function

    ' Guarda una Hoja de Excel en la Ubicación especificada
    Public Sub Guardar_Excel(Ubicacion As String, Hoja_Excel As Excel.Worksheet)
        Hoja_Excel.SaveAs(Ubicacion)
    End Sub
    Public Sub Abrir_Applicacion_Excel()
        AplicacionExcel = CreateObject("Excel.Application")
    End Sub

    Public Sub Cerrar_Aplicacion_Excel()
        If AplicacionExcel IsNot Nothing Then
            AplicacionExcel.Quit()
        End If
    End Sub

End Class
