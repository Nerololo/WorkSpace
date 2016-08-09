Imports System.Web
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web.Services
Imports System.IO
Imports System.Net

Public Class MostrarImagen
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            context.Response.ContentType = "image/gif"
            context.Response.Clear()
            context.Response.BufferOutput = True

            Dim fileName As String = context.Request.QueryString("ImageFileName")
            Dim Item As Integer = context.Request.QueryString("Item")

            Dim wc As New WebClient()
            Dim bytes As Byte() = wc.DownloadData(fileName)
            Dim ms As New MemoryStream(bytes)
            ' Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

            'Dim imagen As New Bitmap(New Bitmap(fileName), CInt(800), CInt(1329))
            Dim imagen As New Bitmap(ms)
            Dim myEncoder As Encoder
            Dim myEncoderParameter As EncoderParameter
            Dim myEncoderParameters As EncoderParameters

            'selecciona la pagina del tiff
            imagen.SelectActiveFrame(FrameDimension.Page, Item)
            myEncoderParameters = New EncoderParameters(2)

            myEncoder = Encoder.Quality
            myEncoderParameter = New EncoderParameter(myEncoder, CType(100L, Int32))
            myEncoderParameters.Param(0) = myEncoderParameter

            myEncoder = Encoder.ColorDepth
            myEncoderParameter = New EncoderParameter(myEncoder, CType(32L, Int32))
            myEncoderParameters.Param(1) = myEncoderParameter

            ''parte que busca png
            'Dim dimension As FrameDimension
            'dimension = New FrameDimension(imagen.FrameDimensionsList(0))
            'imagen.SelectActiveFrame(dimension, Item)
            ''hasjdhjsahd

            Dim tempStream As New MemoryStream

            imagen.Save(tempStream, GetEncoder(ImageFormat.Gif), myEncoderParameters)
            context.Response.OutputStream.Write(tempStream.ToArray(), 0, tempStream.Length)
            context.Response.Output.Write(imagen)

            imagen.Dispose()
            imagen = Nothing
        Catch ex As Exception
            context.Response.Write(ex.Message)
        End Try
    End Sub
    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()
        Dim codec As ImageCodecInfo

        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next codec
        Return Nothing
    End Function
    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
End Class