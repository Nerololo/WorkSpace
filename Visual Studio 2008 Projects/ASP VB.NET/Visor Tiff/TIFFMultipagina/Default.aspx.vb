Imports System.Drawing.Imaging
Imports System.Net
Imports System.IO

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton1.Click
        'Dim appPath As String = HttpContext.Current.Request.ApplicationPath + "00000001.tif"

        Dim filename As String = "https://www.digicom.com.co/Banco_32_2016_Convenios/20160223/12345.tif"
        Dim wc As New WebClient()
        Dim bytes As Byte() = wc.DownloadData(filename)
        Dim ms As New MemoryStream(bytes)
        Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

        'Dim tiffImage As String = Context.Server.MapPath(filename)
        'Dim img As System.Drawing.Image = _
        '    CType(System.Drawing.Image.FromFile(tiffImage, True), System.Drawing.Image)

        Dim ID As Guid
        ID = img.FrameDimensionsList(0)

        Dim fd As FrameDimension = New FrameDimension(ID)
        Dim alto As Integer = img.Height
        Dim ancho As Integer = img.Width
        Dim paginas As String = img.GetFrameCount(fd)

        wc.Dispose()

        Response.Redirect("TiffViewer.aspx?ImageFileName=" + filename + "&NroPaginas=" + paginas)

    End Sub
End Class