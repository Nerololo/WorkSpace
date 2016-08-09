using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Controls;
using Esri.ArcGISRuntime.Geometry;
using System.Windows;
using System.Windows.Threading;
using Esri.ArcGISRuntime.Layers;
using System.Data;
using System.Windows.Media.Animation;
using MapaArcgics;

namespace ArcGISRuntime.Samples.Desktop
{
    public partial class SimuladorMain : Window
    {
        //==================================================================================================================================
        //                                                      Funciones
        //==================================================================================================================================

        //===================================
        //          Movimiento Simple
        //===================================

        private async Task AnimateGraphicSimple(Graphic entidad, Graphic puntoDeMovimiento , double VelocidadMedia = 100, double ConsumoCombustible = 22)
        {
            //AnimationDuration = ; 
            MapPoint userStartPoint = entidad.Geometry as MapPoint;
            MapPoint userFinishPoint = puntoDeMovimiento.Geometry as MapPoint;

            double distance = GeometryEngine.Distance(userStartPoint, userFinishPoint);
            double tiempo = distance / VelocidadMedia; 

            Graphic lineaCreada = GraficarLineasSimple(userFinishPoint, userFinishPoint);

            QuinticEase easing = new QuinticEase() { EasingMode = EasingMode.EaseInOut };
            DateTime animateStartTime = DateTime.Now;
            DispatcherTimer animationTimer = new DispatcherTimer();
            MapPoint animatingPoint = new MapPoint(userStartPoint.X, userStartPoint.Y);
            int contador = 0;

            _LineasEnElMapaSimpleMover.Graphics.Add(lineaCreada);

            animationTimer.Interval = TimeSpan.FromMilliseconds(33);
            animationTimer.Tick += (s, ex) =>
            {
                double fraction = (DateTime.Now.Subtract(animateStartTime)).TotalMilliseconds / tiempo;
                fraction = QuinticEasingInOut(fraction, 0, 1, 1);
                double x = (userFinishPoint.X - userStartPoint.X) * fraction + userStartPoint.X;
                double y = (userFinishPoint.Y - userStartPoint.Y) * fraction + userStartPoint.Y;
                

                if (contador == 0)
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate { _LineasEnElMapaSimpleMover.Graphics.Remove(lineaCreada); }));
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate 
                    {
                        _LineasEnElMapaSimpleMover.Graphics.Remove(lineaCreada);                    
                    }));
                }

                Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                {
                    lineaCreada = new Graphic() { Geometry = CreatePolylineXY(x, y, userFinishPoint.X, userFinishPoint.Y), Symbol = blueLine };
                    _LineasEnElMapaSimpleMover.Graphics.Add(lineaCreada);
                }));

                double Latitud = Math.Round(((x / 100000) + 9.0556), 5);
                double Longitud = Math.Round(((y / 100000) + 0.1133), 5);
                string combustible = entidad.Attributes["Combustible"].ToString();
                double combustibleNuevo = double.Parse(combustible);
                contador = 1;

                mapTipEntidad.DataContext = null;
                mapTipEntidad.DataContext = entidad;

                entidad.Attributes["Latitud"] = Latitud.ToString();
                entidad.Attributes["Longitud"] = Longitud.ToString();


                combustibleNuevo -= ConsumoCombustible;
                entidad.Attributes["Combustible"] = combustibleNuevo.ToString();

                if (combustibleNuevo < 0)
                {
                    CombustibleText.Text = "Sin Combustible";
                    animationTimer.Stop();
                    if (_LineasEnElMapaSimpleMover.Graphics.Count != 0)
                    {
                        Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                        {
                            _LineasEnElMapaSimpleMover.Graphics.Remove(lineaCreada);
                        }));
                    }

                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                    {
                        _PuntosDeMovimientoEnElMapa.Graphics.Remove(puntoDeMovimiento);
                        mapTipPuntoDeMovimiento.Visibility = Visibility.Collapsed;
                    }));

                }
                entidad.Geometry = animatingPoint.MoveTo(x, y);

                ViewBase.SetViewOverlayAnchor(mapTipEntidad, new MapPoint(x, y));
            };

            animationTimer.Start();

            await Task.Delay((int)Math.Floor(tiempo));
            {
               animationTimer.Stop();

                if (_LineasEnElMapaSimpleMover.Graphics.Count != 0)
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                    {
                        _LineasEnElMapaSimpleMover.Graphics.Remove(lineaCreada);
                    }));
                }

                Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                {
                    _PuntosDeMovimientoEnElMapa.Graphics.Remove(puntoDeMovimiento);
                    mapTipPuntoDeMovimiento.Visibility = Visibility.Collapsed;
                }));
            };
        }

        //===================================
        //          Movimiento Ruta
        //===================================

        private async Task AnimateGraphicRuta(Graphic entidadRuta, Graphic puntoDeMovimiento , GraphicCollection coleccionRutaMoviendose , Graphic lineaEntidadInicial , GraphicCollection coleccionLineasRutas, double VelocidadMedia = 100, double ConsumoCombustible = 22)
        {
            MapPoint userStartPoint = entidadRuta.Geometry as MapPoint;
            MapPoint userFinishPoint = puntoDeMovimiento.Geometry as MapPoint;
            var lineaAnimandose = new Graphic();

            double distance = GeometryEngine.Distance(userStartPoint, userFinishPoint);
            double tiempo = distance / VelocidadMedia;

            var contador = 0;
            var easing = new QuinticEase() { EasingMode = EasingMode.EaseInOut };
            var animateStartTime = DateTime.Now;
            var animationTimer = new DispatcherTimer();
            MapPoint animatingPoint = new MapPoint(userStartPoint.X, userStartPoint.Y);
            var primeraVez = false;
            var lineaInicialEntidadGuardado = new Graphic();
            if (primeraVez != true)
            {
               lineaInicialEntidadGuardado  = lineaEntidadInicial;
                primeraVez = true;
            }

            animationTimer.Interval = TimeSpan.FromMilliseconds(33);
            animationTimer.Tick += (s, ex) =>
            {
                
                double fraction = (DateTime.Now.Subtract(animateStartTime)).TotalMilliseconds / tiempo;
                fraction = QuinticEasingInOut(fraction, 0, 1, 1);
                var x = (userFinishPoint.X - userStartPoint.X) * fraction + userStartPoint.X;
                var y = (userFinishPoint.Y - userStartPoint.Y) * fraction + userStartPoint.Y;

                if (contador == 0 && lineaInicialBorrada == true)
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate { _LineasEnElMapaRuta.Graphics.Remove(lineaEntidadInicial); }));
                }
                else if (lineaInicialBorrada != true)
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate { _LineasEnElMapaRuta.Graphics.Remove(lineaInicialEntidadGuardado); }));
                    lineaInicialBorrada = true;
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate { _LineasEnElMapaRutaMover.Graphics.Remove(lineaAnimandose); }));
                }

                Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                {
                    lineaAnimandose = new Graphic() { Geometry = CreatePolylineXY(x, y, userFinishPoint.X, userFinishPoint.Y), Symbol = blueLine };
                    _LineasEnElMapaRutaMover.Graphics.Add(lineaAnimandose);
                }));

                double Latitud = Math.Round(((x / 100000) + 9.0556), 5);
                double Longitud = Math.Round(((y / 100000) + 0.1133), 5);
                string combustible = entidadRuta.Attributes["Combustible"].ToString();
                double combustibleNuevo = double.Parse(combustible);
                contador = 1;

                mapTipEntidad.DataContext = null;
                mapTipEntidad.DataContext = entidadRuta;

                entidadRuta.Attributes["Latitud"] = Latitud.ToString();
                entidadRuta.Attributes["Longitud"] = Longitud.ToString();


                combustibleNuevo -= ConsumoCombustible;
                entidadRuta.Attributes["Combustible"] = combustibleNuevo.ToString();

                if (combustibleNuevo < 0)
                {
                    CombustibleText.Text = "Sin Combustible";
                    animationTimer.Stop();
                    if (_LineasEnElMapaRutaMover.Graphics.Count != 0)
                    {
                        Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                        {
                            _LineasEnElMapaRutaMover.Graphics.Clear();
                        }));
                    }

                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                    {
                        _PuntosDeMovimientoEnElMapa.Graphics.Remove(puntoDeMovimiento);
                        mapTipPuntoDeMovimiento.Visibility = Visibility.Collapsed;
                    }));
                }
                entidadRuta.Geometry = animatingPoint.MoveTo(x, y);

                ViewBase.SetViewOverlayAnchor(mapTipEntidad, new MapPoint(x, y));
            };

            animationTimer.Start();

            await Task.Delay((int)Math.Floor(tiempo));
            
                animationTimer.Stop();

                if (_LineasEnElMapaRutaMover.Graphics.Count != 0)
                {
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                    {
                        _LineasEnElMapaRutaMover.Graphics.Remove(lineaAnimandose);

                    }));
                }

                Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                {
                    coleccionRutaMoviendose.Remove(puntoDeMovimiento);
                    _PuntosDeMovimientoEnElMapa.Graphics.Remove(puntoDeMovimiento);
                    mapTipPuntoDeMovimiento.Visibility = Visibility.Collapsed;
                }));

                Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(async delegate
                {
                    if (coleccionRutaMoviendose.Count > 0)
                    {
                        coleccionLineasRutas.Remove(lineaEntidadInicial);
                        await AnimateGraphicRuta(entidadRuta, coleccionRutaMoviendose[0], coleccionRutaMoviendose, coleccionLineasRutas[0], coleccionLineasRutas);
                    }
                }));

        }

        //===========================================================
        //          Graficar Lineas Movimiento Simple
        //===========================================================

        private Graphic GraficarLineasSimple(MapPoint coordenadaEntidad, MapPoint coordenadaPuntoDeMovimiento)
        {
            var crearLinea = CreatePolylineXY(coordenadaEntidad.X, coordenadaEntidad.Y, coordenadaPuntoDeMovimiento.X, coordenadaPuntoDeMovimiento.Y);
            var middleLinea = crearLinea.Extent.GetCenter();
            var middleLineaX = middleLinea.X;
            var middleLineaY = middleLinea.Y;

            var lineaCreada = new Graphic() { Geometry = crearLinea, Symbol = blueLine };
            lineaCreada.Attributes["XCenter"] = middleLineaX;
            lineaCreada.Attributes["YCenter"] = middleLineaY;
            return lineaCreada;
        }

        //========================================
        //             Crear Linea
        //========================================

        private Polyline CreatePolylineXY(double X1, double Y1, double X2, double Y2)
        {
            Esri.ArcGISRuntime.Geometry.LineSegment segment = new Esri.ArcGISRuntime.Geometry.LineSegment(
            new MapPoint(X1, Y1, MyMapView.SpatialReference),
            new MapPoint(X2, Y2, MyMapView.SpatialReference));

            var segmentCollection = new SegmentCollection(MyMapView.SpatialReference)
            {
                segment
            };

            return new Polyline(new[] { segmentCollection }, MyMapView.SpatialReference);
        }

        //====================================================
        //          Crear Entidades/Pto. de Movimiento
        //====================================================

        private async Task AcceptPointsAsync()
        {
            while (MyMapView.GetCurrentViewpoint(ViewpointType.BoundingGeometry).TargetGeometry.Extent != null)
            {
                var point = await MyMapView.Editor.RequestPointAsync();
                Graphic icono;
                Graphic overviewIcon;

                if (colocarEntidad == 1 && creandoRuta == false)
                {
                    Proceso.id_icono = swrafa.ToString();
                    ConexionDB Conexion = new ConexionDB();
                    Proceso.BaseDB = Conexion.Conectar_BD();

                    foreach (DataRow item in Proceso.BaseDB.Tables["entidad"].Rows)
                    {
                        Proceso.ent_dec_capacidad_max_combustible = Convert.ToDouble(item["ent_dec_capacidad_max_combustible"].ToString());
                        Proceso.ent_dec_velocidad_med = Convert.ToDouble(item["ent_dec_velocidad_med"].ToString());
                        Proceso.ent_dec_km_l = Convert.ToDouble(item["ent_dec_km_l"].ToString());
                    }

                    icono = new Graphic(point, redIcon);
                    overviewIcon = new Graphic(point, overviewRedIcon);

                    icono.Attributes["ID"] = swrafa;                   
                    icono.Attributes["Latitud"] = Math.Round(((point.X / 100000) + 9.0556), 5);
                    icono.Attributes["Longitud"] = Math.Round(((point.Y / 100000) + 0.1133), 5);
                    icono.Attributes["Max_Combustible"] = Proceso.ent_dec_capacidad_max_combustible;
                    icono.Attributes["Combustible"] = Proceso.ent_dec_capacidad_max_combustible;
                    icono.Attributes["Velocidad_Media"] = Proceso.ent_dec_velocidad_med;
                    icono.Attributes["Consumo_Combustible"] = Proceso.ent_dec_km_l;

                    _EntidadesEnElMapa.Graphics.Add(icono);
                    overview.Graphics.Add(overviewIcon);
                    swrafa += 1;
                }
                else if (colocarEntidad == 2)
                {
                    icono = new Graphic(point, blueIcon);
                    overviewIcon = new Graphic(point, overviewBlueIcon);

                    icono.Attributes["Latitud"] = Math.Round(((point.X / 100000) + 9.0556), 5);
                    icono.Attributes["Longitud"] = Math.Round(((point.Y / 100000) + 0.1133), 5);

                    _PuntosDeMovimientoEnElMapa.Graphics.Add(icono);
                    overview.Graphics.Add(overviewIcon);
                    coleccionOverViewEntidades.Add(overviewIcon);
                }
                    colocarEntidad = 0;
            }
        }

        //==============================================================
        //            Seleccionar Iconos en el area del rectangulo
        //==============================================================

        private async Task<IEnumerable<Graphic>> FindIntersectingGraphicsAsync()
        {
            var mapRect = await MyMapView.Editor.RequestShapeAsync(DrawShape.Envelope) as Envelope;

            Rect winRect = new Rect(
                MyMapView.LocationToScreen(new MapPoint(mapRect.XMin, mapRect.YMax, MyMapView.SpatialReference)),
                MyMapView.LocationToScreen(new MapPoint(mapRect.XMax, mapRect.YMin, MyMapView.SpatialReference)));

            return await _EntidadesEnElMapa.HitTestAsync(MyMapView, winRect, MAX_GRAPHICS);
        }

        //=====================================================================
        //            Ecuacion para definir velocidad de la animacion
        //=====================================================================

        private double QuinticEasingInOut(double t, double b, double c, double d)
        {
            // Sub-routine function to determine the fraction of time in the quintic easing algorithm lasts before the graphic
            // point is moved. The quintic easing in/out function has the property of the animation being slower in the beginning 
            // and end of the time interval and faster in the middle.

            t /= d / 2;
            if (t < 1)
            {
                return c / 2 * t * t * t * t * t + b;
            }
            t -= 2;
            return c / 2 * (t * t * t * t * t + 2) + b;
        }

        //=========================================================================================================================
        //     Toogle Seleccion (Mostrar Highlight, guardar seleccion en la respectiva coleccion, graficar lineas y mostrar widget)
        //=========================================================================================================================

        //tipoEntidad = 0 (Entidad) tipoEntidad = 1 (Punto De Movimiento) tipoEntidad = 2 (Linea)
        private void ToogleSeleccion(Graphic ToogleIcono, int tipoEntidad)
        {
            var seOculto = false;
            if (ToogleIcono.IsSelected == true)
            {
                if (creandoRuta == false)
                {
                    ToogleIcono.IsSelected = false;

                    if (tipoEntidad == 0)
                    {
                        coleccionEntidadesSeleccionadas.Remove(ToogleIcono);
                    }
                    else
                    {
                        coleccionPuntoDeMovimientosSeleccionado.Remove(ToogleIcono);
                    }
                }
                else if (tipoEntidad == 2 && creandoRuta == true)
                {
                    ToogleIcono.IsSelected = false;
                }

                //      Pase lo que pase si clickeas un icono con el maptip ya Visible se Oculta
                if (ToogleIcono == iconoConMapTip)
                {
                    if (tipoEntidad == 2)
                    {
                        mapTipDistanciaLineas.Visibility = Visibility.Collapsed;
                    }
                    else if (tipoEntidad == 0)
                    { 
                        mapTipEntidad.Visibility = Visibility.Collapsed;
                        iconoConMapTip = null;
                        seOculto = true;
                    }
                    else
                    {
                        mapTipPuntoDeMovimiento.Visibility = Visibility.Collapsed;
                        iconoConMapTip = null;
                        seOculto = true;
                    }
                }

                if (creandoRuta == true && seOculto == false)
                {
                    var coordenadaMapTip = ToogleIcono.Geometry as MapPoint;

                    Esri.ArcGISRuntime.Controls.MapView.SetViewOverlayAnchor(mapTipEntidad, coordenadaMapTip);
                    mapTipEntidad.DataContext = ToogleIcono;
                    mapTipEntidad.Visibility = Visibility.Visible;
                    iconoConMapTip = ToogleIcono;
                }
               
            }
            else
            {
                ToogleIcono.IsSelected = true;
                if (tipoEntidad == 0 && creandoRuta == false)
                {
                    coleccionEntidadesSeleccionadas.Add(ToogleIcono);
                }
                else if (tipoEntidad == 1 && creandoRuta == false)
                {
                    coleccionPuntoDeMovimientosSeleccionado.Add(ToogleIcono);
                }

                if (creandoRuta == true && coleccionEntidadesAsignadasRutas.Count > 0)
                {
                    //          Grafica las lineas iniciales de todas las entidades al primer Punto de Movimiento seleccionado
                    if (paresRutasSeleccionados == 0)
                    {
                        coleccionRutaDePuntoDeMovimientos.Add(ToogleIcono);
                        Punto1 = ToogleIcono.Geometry as MapPoint;

                        foreach (var entidad in coleccionEntidadesAsignadasRutas)
                        {
                            Graphic lineaCreadaRuta = GraficarLineasSimple(entidad.Geometry as MapPoint, Punto1);
                            _LineasEnElMapaRuta.Graphics.Add(lineaCreadaRuta);
                            coleccionLineasEntidadAPuntosDeMovimientoInicial.Add(lineaCreadaRuta);
                        }

                        paresRutasSeleccionados += 1;
                    }
                    //          Grafica las lineas al proximo punto               
                    else
                    {
                        Punto2 = ToogleIcono.Geometry as MapPoint;
                        if (Punto2 != null)
                        {
                            Graphic lineaCreadaRuta = GraficarLineasSimple(Punto1, Punto2);

                            coleccionLineasEnElMapaRuta.Add(lineaCreadaRuta);
                            _LineasEnElMapaRuta.Graphics.Add(lineaCreadaRuta);
                            coleccionRutaDePuntoDeMovimientos.Add(ToogleIcono);
                            Punto1 = Punto2;
                        }
                    }
                }

                if (tipoEntidad == 2)
                {
                    MapPoint CoordenadasLineas1 = new MapPoint(ToogleIcono.Geometry.Extent.XMin, ToogleIcono.Geometry.Extent.YMin);
                    MapPoint CoordenadasLineas2 = new MapPoint(ToogleIcono.Geometry.Extent.XMax, ToogleIcono.Geometry.Extent.YMax);
                    MapPoint CoordenadasMiddleLinea;
                    double LineaCenterX = 0;
                    double LineaCenterY = 0;

                    System.Collections.Generic.IDictionary<string, object> myAttributes = ToogleIcono.Attributes;
                    foreach (var oneAttribute in myAttributes)
                    {
                        if (oneAttribute.Key == "XCenter")
                        {
                            LineaCenterX = Convert.ToDouble(oneAttribute.Value.ToString());
                        }
                        else if (oneAttribute.Key == "YCenter")
                        {
                            LineaCenterY = Convert.ToDouble(oneAttribute.Value.ToString());
                        }
                    }

                    CoordenadasMiddleLinea = new MapPoint(LineaCenterX, LineaCenterY);
                    double distance = GeometryEngine.Distance(CoordenadasLineas1, CoordenadasLineas2);
                    txtResults.Text = string.Format("Distancia = {0:0.000}KM", distance);

                    //if the overlay element is found, set its position and make it visible
                    if (mapTipDistanciaLineas != null)
                    {
                        Esri.ArcGISRuntime.Controls.MapView.SetViewOverlayAnchor(mapTipDistanciaLineas, CoordenadasMiddleLinea);
                        mapTipDistanciaLineas.DataContext = ToogleIcono;
                        mapTipDistanciaLineas.Visibility = Visibility.Visible;
                        iconoConMapTip = ToogleIcono;
                    }
                }
                else if (tipoEntidad == 0)
                {
                    var coordenadaMapTip = ToogleIcono.Geometry as MapPoint;

                    Esri.ArcGISRuntime.Controls.MapView.SetViewOverlayAnchor(mapTipEntidad, coordenadaMapTip);
                    mapTipEntidad.DataContext = ToogleIcono;
                    mapTipEntidad.Visibility = Visibility.Visible;
                    iconoConMapTip = ToogleIcono;   
                }
                else
                {
                    var coordenadaMapTip = ToogleIcono.Geometry as MapPoint;

                    Esri.ArcGISRuntime.Controls.MapView.SetViewOverlayAnchor(mapTipPuntoDeMovimiento, coordenadaMapTip);
                    mapTipPuntoDeMovimiento.DataContext = ToogleIcono;
                    mapTipPuntoDeMovimiento.Visibility = Visibility.Visible;
                    iconoConMapTip = ToogleIcono;
                }
            }
        }

        //===========================================================================================================
        //          Comprueba que todos los Layers han sido cargados, si no, intenta cargalos nuevamente (2 maximo)
        //===========================================================================================================

        public async Task AreAllLayersLoaded()
        {
            // This custom function is asynchronous and attempts to load all of the layers in the Map.
            try
            {
                // Awaitable function that tries to load all of the layers in the Map. All program execution on this
                // thread stops until all the layers load or error out.
                await MyMapView.LayersLoadedAsync();
            }
            catch (Exception ex)
            {
                // There was an error with one or more of the layers loading. Display that message to the user.
                var layerUri = new Uri("http://services.arcgisonline.com/ArcGIS/rest/services/World_Topo_Map/MapServer");
                var recargarLayer = new ArcGISTiledMapServiceLayer(layerUri);

                MyMapView.Map.Layers.Clear();
                intentosCargarLayer += 1;
                MyMapView.Map.Layers.Add(recargarLayer);

                var x = AreAllLayersLoaded();

                if (intentosCargarLayer == 2)
                {
                    MessageBox.Show(ex.ToString() + "\n" + "Problemas cargando el layer, el servidor puede no estar disponible, intente reiniciar la aplicación");
                }
            }
        }
    }
}
