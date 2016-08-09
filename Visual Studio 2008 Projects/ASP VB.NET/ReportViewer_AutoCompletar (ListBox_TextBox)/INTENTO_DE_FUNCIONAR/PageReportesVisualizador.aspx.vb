Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WebForms
Imports System.IO
Imports System.Drawing


    Partial Class PageReportesVisualizador
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Dim Valor As String = Request.QueryString("Valor")

                Dim dataSetEntidad As New DataSetTableAdapters.entidadTableAdapter()
                Dim dataSetArma As New DataSetTableAdapters.armaTableAdapter()
                Dim dataSourceVisualizador As ReportDataSource
                Dim DATATABLE As DataTable

                ReportViewer1.ProcessingMode = ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = Valor

                If Valor = "Report1.rdlc" Then
                    DATATABLE = dataSetArma.GetData()

                    dataSourceVisualizador = New ReportDataSource("DataSet_arma", DATATABLE)
                Else
                    DATATABLE = dataSetEntidad.GetData()

                    dataSourceVisualizador = New ReportDataSource("DataSet_entidad", DATATABLE)
                End If

                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(dataSourceVisualizador)
                ReportViewer1.LocalReport.Refresh()
            End If
        End Sub

    Protected Sub imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim rp As New PrintReportSample.ReportPrintDocument(ReportViewer1.LocalReport)
        rp.Print()
    End Sub
    End Class
