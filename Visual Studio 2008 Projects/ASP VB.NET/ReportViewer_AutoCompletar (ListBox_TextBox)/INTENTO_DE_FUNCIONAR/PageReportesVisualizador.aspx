<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PageReportesVisualizador.aspx.vb" Inherits="PageReportesVisualizador" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="450" Height = "250">
        </rsweb:ReportViewer>
        
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Imprimir" OnClick="imprimir" />

    </form>
    </body>
</html>