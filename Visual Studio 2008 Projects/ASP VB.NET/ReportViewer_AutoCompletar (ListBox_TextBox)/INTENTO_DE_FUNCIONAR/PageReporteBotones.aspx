<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PageReporteBotones.aspx.vb" Inherits="PageReporteBotones" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods = "true"> </asp:ScriptManager>

            <asp:Button ID="Button1" runat="server" Text="Exportar" />
            <asp:Button ID="Button4" runat="server" Text="Exportar 2" />
            <asp:Button ID="Button2" runat="server" Text="Reporte 1" />
            <asp:Button ID="Button3" runat="server" Text="Reporte 2" />
        </form>
    </body>
</html>
