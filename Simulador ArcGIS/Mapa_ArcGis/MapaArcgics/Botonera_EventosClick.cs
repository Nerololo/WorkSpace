using Esri.ArcGISRuntime.Controls;
using System.Windows.Controls;
using System;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows;
using Esri.ArcGISRuntime.Layers;

namespace ArcGISRuntime.Samples.Desktop
{
    public partial class SimuladorMain : Window
    {
        //==========================================
        //          Menu Click Derecho
        //==========================================

        private void MyMapView_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ContextMenu cm = FindResource("cmButton") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        //==============================================
        //        Define que Iconos va a crear
        //==============================================

        private void Entidad_Click(object sender, RoutedEventArgs e)
        {
            colocarEntidad = 1;
            
        }

        private void Movimiento_Click(object sender, RoutedEventArgs e)
        {
            colocarEntidad = 2;
        }

        //=================================================================================
        //       Crear Ruta (Deseleccionar Puntos de Movimiento y Agregar a la coleccion)
        //=================================================================================

        private void Crear_Ruta_Click(object sender, RoutedEventArgs e)
        {
            if (coleccionEntidadesSeleccionadas.Count > 0)
            {
                foreach (var punto in coleccionPuntoDeMovimientosSeleccionado)
                {
                    if (punto.IsSelected == true)
                    {
                        punto.IsSelected = false;
                    }
                }

                coleccionEntidadesAsignadasRutas = new GraphicCollection(coleccionEntidadesSeleccionadas);
                creandoRuta = true;
            }
        }

        //===================================================================
        //      Recorrer Ruta (Animar Entidades seleccionadas a su ruta)
        //===================================================================

        private async void Recorrer_Ruta_Click(object sender, RoutedEventArgs e)
        {
            var contadorLineas = 0;
            coleccionPuntoDeMovimientosSeleccionado.Clear();
            foreach (var graphic in coleccionEntidadesAsignadasRutas)
            {
                await AnimateGraphicRuta(graphic, coleccionRutaDePuntoDeMovimientos[0], coleccionRutaDePuntoDeMovimientos, coleccionLineasEntidadAPuntosDeMovimientoInicial[contadorLineas], coleccionLineasEnElMapaRuta, Convert.ToDouble(graphic.Attributes["Velocidad_Media"].ToString()), Convert.ToDouble(graphic.Attributes["Consumo_Combustible"].ToString()));
                contadorLineas += 1;
                lineaInicialBorrada = false;              
            }

        }

        //========================================================================
        //          Finalizar Ruta (Deseleccionar Iconos, Borrar Colecciones)
        //========================================================================

        private void Finalizar_Ruta_Click(object sender, RoutedEventArgs e)
        {
            foreach (var punto in coleccionRutaDePuntoDeMovimientos)
            {
                if (punto.IsSelected == true)
                {
                    punto.IsSelected = false;
                }
            }

            coleccionRutaDePuntoDeMovimientos.Clear();
            coleccionLineasEnElMapaRuta.Clear();
            coleccionEntidadesAsignadasRutas.Clear();
            ClearSelectButton_Click(null, null);
            paresRutasSeleccionados = 0;
            creandoRuta = false;
        }

        //======================================================
        //              Boton Mov. Simple
        //======================================================

        private async void Animar_Click(object sender, RoutedEventArgs e)
        {
            if (coleccionEntidadesSeleccionadas.Count == 1)
            { 
                Graphic graphic = coleccionEntidadesSeleccionadas[0];
                Graphic puntoDeMovimientoSeleccionado = coleccionPuntoDeMovimientosSeleccionado[0];

                if (coleccionPuntoDeMovimientosSeleccionado.Count == 1)
                {
                    graphic.IsSelected = false;
                    puntoDeMovimientoSeleccionado.IsSelected = false;
                    coleccionEntidadesSeleccionadas.Remove(graphic);
                    coleccionPuntoDeMovimientosSeleccionado.Remove(puntoDeMovimientoSeleccionado);

                    await AnimateGraphicSimple(graphic, puntoDeMovimientoSeleccionado, Convert.ToDouble(graphic.Attributes["Velocidad_Media"].ToString()), Convert.ToDouble(graphic.Attributes["Consumo_Combustible"].ToString()));                    
                }
            }
        }

        //========================================================
        //              Boton Seleccionar
        //========================================================

        private async void AddSelectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var graphicsEntidad = await FindIntersectingGraphicsAsync();
                foreach (var graphic in graphicsEntidad)
                {
                    graphic.IsSelected = true;
                    coleccionEntidadesSeleccionadas.Add(graphic);
                }
                await Task.WhenAny(AcceptPointsAsync());
            }
            catch (TaskCanceledException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Selection Error: " + ex.Message, "Graphics Layer Selection Sample");
            }
        }

        //========================================================
        //               Boton Deseleccionar
        //========================================================

        private async void RemoveSelectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var graphics = await FindIntersectingGraphicsAsync();

                foreach (var graphic in graphics)
                {
                    graphic.IsSelected = false;
                    coleccionEntidadesSeleccionadas.Remove(graphic);
                }

                await Task.WhenAny(AcceptPointsAsync());
            }
            catch (TaskCanceledException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Selection Error: " + ex.Message, "Graphics Layer Selection Sample");
            }
        }

        //========================================================
        //               Boton Limpiar Seleccion
        //========================================================

        private void ClearSelectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _EntidadesEnElMapa.ClearSelection();
                _PuntosDeMovimientoEnElMapa.ClearSelection();
                _LineasEnElMapaSimpleMover.ClearSelection();
                coleccionEntidadesSeleccionadas.Clear();
                coleccionPuntoDeMovimientosSeleccionado.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selection Error: " + ex.Message, "Graphics Layer Selection Sample");
            }
        }

        //===========================================================
        //                 Boton De Reset Mapa
        //===========================================================

        private async void resetDisplay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // If the LocationDisplay is enabled and a Location currently exists, reset the map
                // to zero rotation and center on the Location. Otherwise, set the MapView to center on 0,0.
                if (MyMapView.LocationDisplay != null &&
                    MyMapView.LocationDisplay.IsEnabled &&
                    MyMapView.LocationDisplay.CurrentLocation != null &&
                    MyMapView.LocationDisplay.CurrentLocation.Location.Extent != null)
                {
                    // Get the current AutoPanMode setting as it is automatically disabled when calling MyMapView.SetView().
                    var PanMode = MyMapView.LocationDisplay.AutoPanMode;

                    MyMapView.SetRotation(0);
                    await MyMapView.SetViewAsync(MyMapView.LocationDisplay.CurrentLocation.Location);

                    // Reset the AutoPanMode 
                    MyMapView.LocationDisplay.AutoPanMode = PanMode;
                }
                else
                {
                    var viewpoint = new Viewpoint(MyMapView.Map.Layers[0].FullExtent) { Rotation = 0.0 };
                    await MyMapView.SetViewAsync(viewpoint);
                }
                _EntidadesEnElMapa.Graphics.Clear();
                _LineasEnElMapaSimpleMover.Graphics.Clear();
                _PuntosDeMovimientoEnElMapa.Graphics.Clear();
                coleccionEntidadesSeleccionadas.Clear();
                coleccionPuntoDeMovimientosSeleccionado.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sample Error");
            }
        }

        //===========================================================
        //                 Boton Cerrar Todo
        //===========================================================

        private void CerrarTodo_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
