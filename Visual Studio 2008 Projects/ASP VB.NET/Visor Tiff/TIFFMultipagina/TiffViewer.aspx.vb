Public Partial Class TiffViewer
    Inherits System.Web.UI.Page

    Private Sub ObjetoImg(ByVal fileName As String, ByVal pagina As Integer)
        Try
            Dim imagen As System.Web.UI.HtmlControls.HtmlImage
            imagen = New System.Web.UI.HtmlControls.HtmlImage
            imagen.Src = "MostrarImagen.ashx?ImageFileName=" & fileName & "&Item=" & pagina
            imagen.Attributes.Add("class", "disenno")
            imagen.Width = 800
            imagen.Height = 1000
            imagen.Alt = ""
            imagen.ID = "myimg" '& CType(pagina, String)
            ImagenesManager.Controls.Add(imagen)

            'Dim br As New System.Web.UI.HtmlControls.HtmlGenericControl("br")
            'ImagenesManager.Controls.Add(br)
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim fileName As String = Request.QueryString("ImageFileName")
            Dim NroPaginas As Integer = CType(Val(Request.QueryString("NroPaginas")), Integer)

            Dim xxt As Integer = 1
            For xxt = 1 To NroPaginas
                paginas.Items.Add(xxt)
            Next

            ObjetoImg(fileName, 0)
        End If
    End Sub
    Protected Sub paginas_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles paginas.SelectedIndexChanged
        Dim page As Integer = CType(paginas.SelectedValue, Integer) - 1
        Dim fileName As String = Request.QueryString("ImageFileName")

        Try
            ObjetoImg(fileName, page)
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub

    Protected Sub LinkAntes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkAntes.Click
        If paginas.SelectedIndex > 0 Then
            paginas.SelectedIndex = paginas.SelectedIndex - 1
        End If

        paginas_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Protected Sub LinkSiguiente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkSiguiente.Click
        Dim NroPaginas As Integer = CType(Val(Request.QueryString("NroPaginas")), Integer) - 1
        If paginas.SelectedIndex < NroPaginas Then
            paginas.SelectedIndex = paginas.SelectedIndex + 1
        End If

        paginas_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
    '    Dim fileName As String = Request.QueryString("ImageFileName")
    '    Response.Redirect(fileName)
    '    'Response.ContentType = "application/octet-stream"
    '    'Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName)
    '    'Response.TransmitFile(fileName)
    '    'Response.End()
    'End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
         Dim fileName As String = Request.QueryString("ImageFileName")
        Response.Redirect(fileName)
    End Sub
End Class