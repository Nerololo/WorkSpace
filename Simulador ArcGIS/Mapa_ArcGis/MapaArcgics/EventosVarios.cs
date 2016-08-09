using Esri.ArcGISRuntime.Controls;
using System.Windows.Controls;
using Esri.ArcGISRuntime.Geometry;
using System;
using System.Windows.Input;
using Esri.ArcGISRuntime.Location;
using System.Threading.Tasks;
using System.Windows;
using Esri.ArcGISRuntime.Layers;
using nameSpaceRandomProvider;
using System.Linq;
using MapaArcgics;
using System.Data;

namespace ArcGISRuntime.Samples.Desktop
{
    public partial class SimuladorMain : Window
    {

        //==================================================================================================================================
        //                                                      Eventos
        //==================================================================================================================================

        //=========================================
        //           Lista de Grillas
        //========================================

        private void gridTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (gridTypeCombo.SelectedIndex)
            {
                case 0:
                    LatLonMapGrid latLongMapGrid = new LatLonMapGrid();
                    // Use Geographic positioning for LatLong MapGrid.
                    latLongMapGrid.LabelPosition = MapGridLabelPosition.Geographic;
                    MyMapView.MapGrid = latLongMapGrid;
                    break;
                case 1:
                    UsngMapGrid usngMapGrid = new UsngMapGrid();
                    // Use Screen-aligned AllSides option for USNG MapGrid.
                    usngMapGrid.LabelPosition = MapGridLabelPosition.AllSides;
                    MyMapView.MapGrid = usngMapGrid;
                    break;
                case 2:
                    MgrsMapGrid mgrsGrid = new MgrsMapGrid();
                    // Use Screen-aligned TopLeft position for MGRS MapGrid.
                    mgrsGrid.LabelPosition = MapGridLabelPosition.TopLeft;
                    MyMapView.MapGrid = mgrsGrid;
                    break;
                case 3:
                    UtmMapGrid utmGrid = new UtmMapGrid();
                    MyMapView.MapGrid = utmGrid;
                    break;
                case 4:
                    MyMapView.MapGrid = null;
                    break;
            }
        }

        private void MyMapView_NavigationCompleted(object sender, EventArgs e)
        {
            MyMapView.NavigationCompleted -= MyMapView_NavigationCompleted;
        }

        //========================================
        //          Cambiar Layer del mapa
        //========================================

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            MyMapView.Map.Layers.RemoveAt(0);

            MyMapView.Map.Layers.Add(new ArcGISTiledMapServiceLayer()
            {
                ServiceUri = ((RadioButton)sender).Tag as string
            });
        }

        //==============================================
        //           Coordenadas del mouse
        //==============================================

        private void MyMapView_MouseMove(object sender, MouseEventArgs e)
        {
            if (MyMapView.GetCurrentViewpoint(ViewpointType.BoundingGeometry) == null)
                return;

            screenPoint = e.GetPosition(MyMapView);

            MapPoint mapPoint = MyMapView.ScreenToLocation(screenPoint);

            if (MyMapView.WrapAround)
            {
                mapPoint = GeometryEngine.NormalizeCentralMeridian(mapPoint) as MapPoint;
            }

            MapCoordsTextBlock.Text = string.Format("Latitud = {0},\nLongitud = {1}",
                                                     Math.Round(((mapPoint.X / 100000) + 9.0556), 5), Math.Round(((mapPoint.Y / 100000) + 0.1133), 5));
        }

        //==============================================
        //     Evento cuando se hace zoom o deszoom
        //==============================================

        //  Start map interaction
        private async void MyMapView_ExtentChanged(object sender, EventArgs e)
        {
            var graphicsOverlay = overviewMap.GraphicsOverlays["overviewOverlay"];

            // Update overview map graphic
            Graphic g = graphicsOverlay.Graphics.FirstOrDefault();
            if (g == null) //first time
            {
                g = new Graphic();
                graphicsOverlay.Graphics.Add(g);
            }
            // Get current viewpoints extent from the MapView
            var currentViewpoint = MyMapView.GetCurrentViewpoint(ViewpointType.BoundingGeometry);
            var viewpointExtent = currentViewpoint.TargetGeometry.Extent;
            g.Geometry = viewpointExtent;

            // Adjust overview map scale
            await overviewMap.SetViewAsync(viewpointExtent.GetCenter(), MyMapView.Scale * 15);

            await Task.WhenAny(AcceptPointsAsync());
        }

        //==================================================
        //       Proovedor de Seguimiento Random/GPS
        //==================================================

        private void providerSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (providerSelector.SelectedIndex == 0)
                MyMapView.LocationDisplay.LocationProvider = new SystemLocationProvider();
            else
                MyMapView.LocationDisplay.LocationProvider = new RandomProvider();
        }

        //========================================================
        //            Evento cuando se Clickea el mapa
        //========================================================

        private async void MyMapView_MapViewTapped(object sender, MapViewInputEventArgs e)
        {
            var entidad = await _EntidadesEnElMapa.HitTestAsync(sender as Esri.ArcGISRuntime.Controls.ViewBase, e.Position);
            var puntoDeMovimiento = await _PuntosDeMovimientoEnElMapa.HitTestAsync(sender as Esri.ArcGISRuntime.Controls.ViewBase, e.Position);
            var Lineas1 = await _LineasEnElMapaRuta.HitTestAsync(sender as Esri.ArcGISRuntime.Controls.ViewBase, e.Position);
            var Lineas2 = await _LineasEnElMapaRutaMover.HitTestAsync(sender as Esri.ArcGISRuntime.Controls.ViewBase, e.Position);
            var Lineas3 = await _LineasEnElMapaSimpleMover.HitTestAsync(sender as Esri.ArcGISRuntime.Controls.ViewBase, e.Position);
            var Lineas4 = await _LineasInicialesEntidadesRutas.HitTestAsync(sender as Esri.ArcGISRuntime.Controls.ViewBase, e.Position);
            var hit4 = new Graphic();


            if (entidad != null)
            {
                ToogleSeleccion(entidad, 0);
                hit4 = entidad;                
            }
            else if (puntoDeMovimiento != null)
            {
                ToogleSeleccion(puntoDeMovimiento, 1);
                hit4 = puntoDeMovimiento;
            }
            else if (Lineas1 != null)
            {
                ToogleSeleccion(Lineas1, 2);
            }
            else if (Lineas2 != null)
            {
                ToogleSeleccion(Lineas2, 2);
            }
            else if (Lineas3 != null)
            {
                ToogleSeleccion(Lineas3, 2);
            }
            else if (Lineas4 != null)
            {
                ToogleSeleccion(Lineas4, 2);
            }

            
        }
    }
}