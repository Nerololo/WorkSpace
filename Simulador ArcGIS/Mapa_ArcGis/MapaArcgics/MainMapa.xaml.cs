using Esri.ArcGISRuntime.Controls;
using System.Collections.Generic;
using System;
using System.Windows;
using Esri.ArcGISRuntime.Layers;
using Esri.ArcGISRuntime.Symbology;
using System.Windows.Media;
using System.Data;
using Esri.ArcGISRuntime.Geometry;
using MapaArcgics;
using System.Linq;

namespace ArcGISRuntime.Samples.Desktop
{
    public partial class SimuladorMain : Window
    {
        private int AnimationDuration = 10000;           // Velocidad Animacion
        private const int MAX_GRAPHICS = 20;            //   Maximo de Graficos a Seleccionar

        public List<string> GridTypes { get; set; }     // ListBox con Tipo de Grillas

        //=======================================================
        //             Definicion Overlays
        //=======================================================

        //              Overlay Entidades
        private static GraphicsOverlay _EntidadesEnElMapa;

        //              Overlay Puntos de Movimiento
        private static GraphicsOverlay _PuntosDeMovimientoEnElMapa;

        //              Overlay Lineas SIMPLES/RUTAS
        private static GraphicsOverlay _LineasEnElMapaSimpleMover;
        private static GraphicsOverlay _LineasEnElMapaRuta;
        private static GraphicsOverlay _LineasEnElMapaRutaMover;
        private static GraphicsOverlay _LineasInicialesEntidadesRutas;
        private static GraphicsOverlay overview;

        //=======================================================
        //             Definicion Colecciones
        //=======================================================

        //          COLECCIONES ENTIDADES SIMPLE/RUTAS
        private static GraphicCollection coleccionEntidadesSeleccionadas = new GraphicCollection();
        private static GraphicCollection coleccionEntidadesAsignadasRutas;

        //          COLECCIONES PUNTO DE MOVIMIENTOS SIMPLE/RUTAS
        private static GraphicCollection coleccionPuntoDeMovimientosSeleccionado = new GraphicCollection();
        private static GraphicCollection coleccionRutaDePuntoDeMovimientos = new GraphicCollection();

        //          COLECCIONES LINEAS RUTA/INICIAL           
        private static GraphicCollection coleccionLineasEnElMapaRuta = new GraphicCollection();
        private static GraphicCollection coleccionLineasEntidadAPuntosDeMovimientoInicial = new GraphicCollection();
        private static GraphicCollection coleccionOverViewEntidades = new GraphicCollection();
        private static GraphicCollection coleccionOverViewEntidadesBorrar = new GraphicCollection();

        //=======================================================
        //          Definicion Lineas/Iconos/Coordenadas
        //=======================================================

        //          LINEAS 
        SimpleLineSymbol blueLine;
        SimpleLineSymbol overviewBlueLine;
        SimpleLineSymbol blackOutlineSymbol;

        //          ICONOS
        SimpleMarkerSymbol redIcon;
        SimpleMarkerSymbol overviewRedIcon;
        SimpleMarkerSymbol blueIcon;
        SimpleMarkerSymbol overviewBlueIcon;

        //          COORDENADAS SCREEN/MAPA
        Point screenPoint;
        MapPoint Punto1;
        MapPoint Punto2;
        Graphic iconoConMapTip = new Graphic();

        int intentosCargarLayer;
        int colocarEntidad;
        private int swrafa = 1;
        public bool creandoRuta = false;
        bool lineaInicialBorrada = false;
        int paresRutasSeleccionados;

        public SimuladorMain()
        {
            try
            {
                Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ClientId = "G6C72pyuz8qXugPp";
                Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.Initialize();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to initialize the ArcGIS Runtime with the client ID provided: " + ex.Message);
            }

            InitializeComponent();
            CreateGraphics();
            var _x = AreAllLayersLoaded();

            //=======================================================
            //             Inicializacion de Iconos/Lineas
            //=======================================================

            //          Borde rodeando los iconos
            blackOutlineSymbol = new SimpleLineSymbol()
            {
                Color = Colors.Black,
                Style = SimpleLineStyle.Solid,
                Width = 1
            };

            //          Iconos    
            blueIcon = new SimpleMarkerSymbol()
            {
                Color = Colors.Blue,
                Size = 15,
                Style = SimpleMarkerStyle.Square,
                Outline = blackOutlineSymbol
            };

            overviewBlueIcon = new SimpleMarkerSymbol()
            {
                Color = Colors.Blue,
                Size = 5,
                Style = SimpleMarkerStyle.Square,
                Outline = blackOutlineSymbol
            };

            redIcon = new SimpleMarkerSymbol()
            {
                Color = Colors.Red,
                Size = 15,
                Style = SimpleMarkerStyle.Circle,
                Outline = blackOutlineSymbol
            };

            overviewRedIcon = new SimpleMarkerSymbol()
            {
                Color = Colors.Red,
                Size = 5,
                Style = SimpleMarkerStyle.Circle,
                Outline = blackOutlineSymbol
            };

            //      Linea azul que une los puntos
            blueLine = new SimpleLineSymbol()
            {
                Color = Colors.Blue,
                Width = 4,
                Style = SimpleLineStyle.Dash
            };

            overviewBlueLine = new SimpleLineSymbol()
            {
                Color = Colors.Blue,
                Width = 2,
                Style = SimpleLineStyle.Dash
            };

            //=================================================
            //           Inicializacion Overlays
            //=================================================

            GridTypes = new List<string>() { "Lat/Lon", "USNG", "MGRS", "UTM", "None" };
            DataContext = this;
            _EntidadesEnElMapa = MyMapView.GraphicsOverlays["graphicsOverlay"];
            _PuntosDeMovimientoEnElMapa = MyMapView.GraphicsOverlays["PuntosDeMovimiento"];
            _LineasEnElMapaSimpleMover = MyMapView.GraphicsOverlays["polylineOverlay"];
            _LineasEnElMapaRuta = MyMapView.GraphicsOverlays["rutaOverlay"];
            _LineasInicialesEntidadesRutas = MyMapView.GraphicsOverlays["inicialesEntidadesRutas"];
            _LineasEnElMapaRutaMover = MyMapView.GraphicsOverlays["rutasLinasAMover"];
            overview = overviewMap.GraphicsOverlays["overviewOverlay"];
            MyMapView.ExtentChanged += MyMapView_ExtentChanged;
        }

        private void Ivan_Click(object sender, RoutedEventArgs e)
        {
            ConexionDB Conexion = new ConexionDB();

            Proceso.BaseDB = Conexion.Conectar_BD()  ;
              
                //string r = (string)ds.Tables["entidad"].Rows[0]["ent_str_tipo_entidad"];

            foreach (DataRow item in Proceso.BaseDB.Tables["entidad"].Rows)
            {
                //Proceso.ent_dec_capacidad_max_combustible  = Convert.ToDouble(item["ent_dec_capacidad_max_combustible"].ToString());

                //string nombre = item["ent_str_tipo_entidad"].ToString();
                //gg = gg + nombre;.
            }    
                //d.Nombres = gg

            MapaArcgics.Form1 frm = new MapaArcgics.Form1();
            frm.Show();
        }

        private void CreateGraphics()
        {





        }

    }
 }