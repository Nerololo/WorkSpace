<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TiffViewer.aspx.vb" Inherits="TIFFMultipagina.TiffViewer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head runat="server">
    <title>Visualizador de imágenes</title>
    <script src="jquery-1.12.0.min.js" type="text/javascript"></script>
    <style type="text/css">
         div#container
        {           
        	height: 100%;
            width: 100%;        
            text-align:left; 
            background-color:#7f7f7f;           
            padding: 0px;
         }
         
        body 
        {
            text-align:center;
            margin: 0px auto;
            padding: 0px;
            background-color:#7f7f7f;
            font-family:Verdana, Geneva, sans-serif;
            font-weight: normal;
        }
        
        img 
        {
            border: none;
        }
        
        .Boton 
        {
            float:left;
            font-size: 100%;
            height: 100%;
            margin: 4px 0px;                   
        }
        
        .disenno
        {
            text-decoration: none;
            width: 100%;
            height: 100%;
            margin: 0px;
            padding: 0px;
        }
        
        .ImagenesManagerClass
        {
            text-align: center;
            background-color: #E6E6E6;
            padding: 0px;
            overflow:hidden;
            margin-left: 0;
            margin-right: 0;
            margin-top: 0;
        }
        
        .Barra
        {
            background-color:#e3e2e2;
            height:4%;
            width:100%;
            min-height: 30px;
            border-left: 2px solid #6E6E6E; 
            border-right: 2px solid #6E6E6E;
            border-top: 2px solid #6E6E6E;
            font: 10px normal Verdana, Arial, Helvetica, sans-serif;
            position:fixed;
            left:0;
            top:0;
            z-index: 999;
        }

        /* Estilo de la lista */
        .Barra ul {
            padding: 0px; 
            margin: 0px;
            min-width: 500px; 
            float: left;
            list-style: none;
            border-top: 1px solid #fff; /*--Da la sensación de bisel en el panel--*/
            font-size: 1.1em;
            height:100%;
            width:40%;         
        }

        /* alineacion de la lista (izquierda) */
        .Barra ul li{
            padding: 0px; 
            margin: 4px 5px;
            float: left;
            position: relative;
            width: 7%;
            text-align:center;
        }

        .Barra ul li a{
            padding: 5px;
            float: left;
            text-indent: -9999px; /*--Para el reemplazo del texto - Empujar el texto fuera de la página --*/
            width: 100%;
            text-decoration: none;
            color: #333;
            position: relative;
            cursor:pointer;
        }

        .Barra ul li select
        {
            float: left;
            position: relative;
            font-size:10px;
            width:100%;
            margin: 5px 5px;
            height:100%;
        }

        html .Barra ul li a:hover
        {
        	background-color: #fff; 
        }

        html .Barra ul li a.active { /*--estado activo cuando sub-panel está abierto--*/
            background-color: #fff;
            margin-top: -2px; /*--Empuje hacia arriba 2px para fijar el botón activo sub-panel--*/
            border: 1px solid #555;
            border-top: none;
            z-index: 200; /*--Mantiene el vínculo activo en la parte superior de la sub-panel--*/
            position: relative;
            width:100%;
        }
        
        a.Antes 
        {
        	background: url(images/icons/2.png) no-repeat center center;
            border-left: 1px solid #bbb;
            width:100%;
        }
        
        a.Siguiente 
        {
        	background: url(images/icons/1.png) no-repeat center center;                    
            border-right: 1px solid #bbb;
            width:100%;
        }
        
        a.lupaMenos
        {
        	background: url(images/icons/magnifier--minus.png) no-repeat center center; 
        	width:100%;
        }
        
        a.lupaMas
        {
        	background: url(images/icons/magnifier--plus.png) no-repeat center center; 
        	width:100%;
        }
        
        .Impresora
        {
            background: url(images/icons/01.png) no-repeat center center;     
            height:16px;       	
        }
        
        .Guardar
        {
        	background: url(images/icons/02.png) no-repeat center center;
        	height:16px;
        }
        
        .Barra a.Normal
        {
            text-indent: 0px;
            width: 100%;
            text-align:center;
            float:left;
        }
        
        .Select
        {
            width:100%;
            float:left;
            text-align:center;                   
        }      
    </style>
    <script type="text/javascript" src="jquery-1.12.0.min.js"></script>
    <script type="text/javascript">
        function PrintPanel() {
            var contents = document.getElementById("ImagenesManager").innerHTML;
            var frame1 = document.createElement('iframe');
            
            frame1.name = "frame1";
            frame1.style.position = "absolute";
            frame1.style.top = "-1000000px";
            document.body.appendChild(frame1);
            
            var frameDoc = frame1.contentWindow ? frame1.contentWindow : frame1.contentDocument.document ? frame1.contentDocument.document : frame1.contentDocument;
            frameDoc.document.open();
            frameDoc.document.write('<html>');
            frameDoc.document.write('<body>');
            frameDoc.document.write(contents);
            frameDoc.document.write('</body></html>');
            frameDoc.document.close();
            setTimeout(function () {
                window.frames["frame1"].focus();
                window.frames["frame1"].print();
                document.body.removeChild(frame1);
            }, 500);
            return false;
        }
    </script>   
    <script language="javascript" type="text/javascript">

        function rotatecntrl(sel) {
            var rotate = "rotate(" + sel.value + "deg)";
            var trans = "all 0.3s ease-out";

            $(".ImagenesManagerClass").css({
                "-webkit-transform": rotate,
                "-moz-transform": rotate,
                "-o-transform": rotate,
                "msTransform": rotate,
                "transform": rotate,
                "-webkit-transition": trans,
                "-moz-transition": trans,
                "-o-transition": trans,
                "transition": trans
            });

        }
    </script>    
     <script language="JavaScript" type="text/javascript">
     $(document).ready(function(){
        setDiv();
        $(window).resize(function(){ 
            setDiv();
        });
    });
    
        function setDiv(){
            var widthBrowser = $(window).height();
            var heightBrowser = $(window).width();        
            $(window).width(widthBrowser);
            $(window).height(heightBrowser);    
        }
        
     
		function findDOM(objectId) {
			if (document.getElementById) {
				return (document.getElementById(objectId));}
			if (document.all) {
				return (document.all[objectId]);}
			}
			
			function zoom(type,imgx,sz) {
				imgd = findDOM(imgx);
				var width = imgd.style.width
			    var res = width.replace("%", ""); 
			    
			    res = parseInt(res);
			    
			    if (type=="+"  && res < 200) {
			        res += 10;
			        
			        imgd.style.width = res.toString() + "%";
                    imgd.style.height = res.toString() + "%";   
                } 				
				
			    if (type=="-" && res > 50) {
				    res -= 10;
			        
			        imgd.style.width = res.toString() + "%";
                    imgd.style.height = res.toString() + "%";  			
			    }
    			
			    if (type=="++") {
			        imgd.style.width = "100%";
			        imgd.style.height = "100%"; 							
			    }
		    } 
     </script>
</head>
    <body>
        <div id="container">
            <form id="form1" runat="server">
                <div id="Viewer">
                    <div id="Barra" class="Barra">
                        <ul id="mainpanel">
                            <li><a href="#" class="lupaMenos" onclick="zoom('-','ImagenesManager',92/66)">items2</a></li>
                            <li><a href="#" class="Normal" onclick="zoom('++','ImagenesManager',92/66)">100%</a></li>
                            <li><a href="#" class="lupaMas" onclick="zoom('+','ImagenesManager',92/66)">items3</a></li>
                            <li><asp:LinkButton ID="LinkAntes" runat="server" CssClass="Antes">items4</asp:LinkButton></li>
                            <li>
                                <asp:DropDownList ID="paginas" CssClass="Select" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                            </li>
                            <li><asp:LinkButton ID="LinkSiguiente" runat="server" CssClass="Siguiente">items5</asp:LinkButton></li>
                            <li><select id="selectrotate"  class="Select" onchange="rotatecntrl(this);">
                                    <option value="0">0</option>

                                    <option value="90">90</option>

                                    <option value="180">180</option>

                                    <option value="270">270</option>
                                </select>
                            </li>
                            <li><a href="#" class="Impresora" onclick="return PrintPanel();"></a></li>
                            <li><asp:LinkButton id="Button2"  CssClass="Guardar" runat="server" OnClick="Button2_Click" /></li>
                        </ul>
                    </div>
                    
                    <asp:Panel ID ="pnlContents" runat="server" >
                        <div style="background-color:White;">
                            <div id ="ImagenesManager" runat="server" style="width:100%; height:100%;"
                                class="ImagenesManagerClass">
                            </div>
                        </div>
                    </asp:Panel>
                </div>       
            </form>  
        </div>  
    </body>
</html>

