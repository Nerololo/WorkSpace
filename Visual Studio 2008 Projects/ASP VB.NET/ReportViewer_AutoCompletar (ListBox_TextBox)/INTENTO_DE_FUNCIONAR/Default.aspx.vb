Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Populate1()
    End Sub

    Public Sub Populate1()
        Dim cmd As New SqlCommand("SELECT * FROM entidad", New SqlConnection(ConfigurationManager.AppSettings("ConnString")))
        cmd.Connection.Open()

        Dim oItem As ListItem = New ListItem("...", "1")


        Dim ddlValues As SqlDataReader
        ddlValues = cmd.ExecuteReader()

        combobox.DataSource = ddlValues
        combobox.DataValueField = "ent_str_tipo_entidad"
        combobox.DataTextField = "ent_str_tipo_entidad"
        combobox.DataBind()

        cmd.Connection.Close()
        cmd.Connection.Dispose()
        combobox.Items.Insert(0, oItem)
    End Sub
End Class
