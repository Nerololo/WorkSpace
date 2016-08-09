Imports Microsoft.VisualBasic
Imports System.Web.UI.WebControls
Imports Microsoft.Reporting.WebForms
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Partial Class PageReporteBotones
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        ExportarReporteExcel("TestFileReporte1", "Report.rdlc", Me)
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click

        ExportarReporteExcel("TestFileReporte2", "Report1.rdlc", Me)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        Response.Redirect("PageReportesVisualizador.aspx?Valor=Report.rdlc")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click

        Response.Redirect("PageReportesVisualizador.aspx?Valor=Report1.rdlc")
    End Sub

    Public Function ExportarReporteExcel(ByVal FileName As String, ByVal ReportPath As String, ByVal Page As System.Web.UI.Page) As String
        ' Setup DataSet
        Dim ds As New DataSetTableAdapters.entidadTableAdapter()
        Dim ds1 As New DataSetTableAdapters.armaTableAdapter()
        Dim rds As ReportDataSource

        If (ReportPath = "Report1.rdlc") Then
            Dim DATATABLE1 As DataTable = ds1.GetData()

            ' Create Report DataSource
            rds = New ReportDataSource("DataSet_arma", DATATABLE1)
        Else
            'Exportar Todo el Reporte
            Dim DATATABLE3 As DataTable = ds.GetData()
            'Filtrar Datos a Exportar (Usando Consultas Creadas en el DataSet)
            Dim DATATABLE4 As DataTable = ds.GetDataBy("Bryan")

            ' Create Report DataSource
            rds = New ReportDataSource("DataSet_entidad", DATATABLE3)
        End If

        ' Variables
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing

        ' Setup the report viewer object and get the array of bytes
        Dim viewer As New ReportViewer()
        viewer.ProcessingMode = ProcessingMode.Local
        viewer.LocalReport.ReportPath = ReportPath
        viewer.LocalReport.DataSources.Add(rds)

        Dim bytes As Byte() = viewer.LocalReport.Render("Excel", Nothing, mimeType, encoding, extension, streamids, warnings)

        ' Now that you have all the bytes representing the PDF report, buffer it and send it to the client.
        Page.Response.Buffer = True
        Page.Response.Clear()
        Page.Response.ContentType = mimeType
        Page.Response.AddHeader("content-disposition", ("attachment; filename=" & FileName & ".") + extension)
        Page.Response.BinaryWrite(bytes)
        ' create the file
        ' send it to the client to download
        Page.Response.Flush()
        Return FileName
    End Function
End Class
