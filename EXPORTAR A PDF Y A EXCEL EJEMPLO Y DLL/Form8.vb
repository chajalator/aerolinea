Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form8
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objConexion As MySqlConnection
        objConexion = New MySqlConnection
        objConexion.ConnectionString = "server=localhost;userid=hospitalss;password=hospitalss;database=hssg;"

        Dim mes_date As String = DateTime.Now.ToString("MM")
        Dim date2 As String = DateTime.Now.ToString("yy")
        Dim Da As New MySqlDataAdapter("select distinct anio from hssg.REGISTRO;", objConexion)

        Dim ds As New DataSet
        objConexion.Open()
        ' 
        ' utilizar el adaptador para llenar el dataset con una tabla
        Da.Fill(ds, "anio")
        objConexion.Close()
        '
        ' una vez desconectado, recorrer la tabla del dataset
        Dim objTabla As DataTable
        objTabla = ds.Tables("anio")
        '
        '
        Dim objFila As DataRow
        For Each objFila In objTabla.Rows
            '
            ' mostrar los datos mediante un objeto de fila
            ComboBox2.Items.Add(objFila.Item("anio"))
        Next
    End Sub

    Private Sub MENUToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MENUToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=hospitalss;password=hospitalss;database=hssg"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query_relleno As String
            query_relleno = "select * from paciente  where paciente.cod_paciente IN(select cod_paciente from registro where anio = '" & ComboBox2.Text & "');"
            COMMAND = New MySqlCommand(query_relleno, MysqlConn)
            sda.SelectCommand = COMMAND
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim archivoguardar As String
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\ListadoPacientesAño" + ComboBox2.Text + ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DataGridView1.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DataGridView1)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph("Reporte de Pacientes", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte de Pacientes Del Año :" + ComboBox2.Text, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            datatable.AddCell(DataGridView1.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                datatable.AddCell(DataGridView1(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Dim worksheet As Excel.Worksheet
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        GridAExcel(DataGridView1)
       
    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True

    End Function

    Private Sub AyudaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Try
            Process.Start("C:/recepcion.pdf")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class