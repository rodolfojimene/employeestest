
Public Class ReporteEmpleados

    Public Sub New()
    End Sub

    Public Sub Generar_Reporte_Empleados(Empleados As List(Of empleados), UbicacionGuardarArchivo As String)
        Dim GestorExcel = New Gestor()
        Dim formulario4 = New Form4()


        Try
            GestorExcel.Abrir_Applicacion_Excel()

            Dim ArchivoExcel = GestorExcel.Obtener_Nuevo_Archivo_Excel()
            Dim HojaExcel = ArchivoExcel.Worksheets(1)
            HojaExcel.Name = "REPORTE EMPLEADOS"

            Dim Fila = 2

            HojaExcel.Cells(Fila, 2).Font.Bold = True
            HojaExcel.Cells(Fila, 2).Font.Size = 16
            HojaExcel.Cells(Fila, 2) = "Reporte de por horas laboradas"

            Fila += 2
            HojaExcel.Cells(Fila, 2).Font.Bold = True
            HojaExcel.Cells(Fila, 2) = "Empresa"
            HojaExcel.Cells(Fila, 3).Font.Bold = True
            HojaExcel.Cells(Fila, 3) = formulario4.Label11.Text.ToString


            Dim SalarioEmpleado = 0
            Fila += 1
            For Each empleado In Empleados
                HojaExcel.Cells(Fila, 3) = empleado.numEmpleado
                HojaExcel.Cells(Fila, 4) = empleado.cedula
                SalarioEmpleado += empleado.horaslab
                Fila += 1
            Next


            Fila += 2
            HojaExcel.Cells(Fila, 3).Font.Bold = True
            HojaExcel.Cells(Fila, 3) = "Totales"
            Fila += 1
            HojaExcel.Cells(Fila, 3) = "Suma de pesos promedio"
            HojaExcel.Cells(Fila, 4) = CStr(SalarioEmpleado)
            Fila += 1
            HojaExcel.Cells(Fila, 3) = "Promedio general de pesos"


            HojaExcel.Columns(3).AutoFit()
            HojaExcel.Columns(4).AutoFit()

            GestorExcel.Guardar_Excel(UbicacionGuardarArchivo, HojaExcel)

            MessageBox.Show("Reporte generado correctamente", "Información")
        Catch Ex As Exception
            Console.WriteLine("Error generando el reporte de pesos de animales: " + Ex.ToString())
        Finally
            GestorExcel.Cerrar_Aplicacion_Excel()
        End Try
    End Sub

End Class
