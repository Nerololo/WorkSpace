using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace Project
{
    public static class HelperMethods
    {
        public static readonly string problemaConexion = "Problemas de Conexion, revisa si tienes conexion";
        public static readonly string canceledRequest = "Request was cancelled.";
        public static bool logeado;
		public static int usuario_ID;

        public static long ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            try
            {
                TimeSpan diff = date - origin;
                return (long)Math.Floor(diff.TotalSeconds);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static string ConvertFromUnixTimestamp(long timestamp, bool horas)
        {
            try
            {
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                var timeSpan = TimeSpan.FromSeconds(timestamp);
                var localDateTime = origin.Add(timeSpan);

                if (horas)
                {
                    return string.Format("{0:d/M/yyyy h:mm tt}", localDateTime);
                }
                else
                {
                    return string.Format("{0:d/M/yyyy}", localDateTime);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static AlertDialog.Builder setAlert(string mensaje, Context contexto)
        {
            AlertDialog.Builder alerta = new AlertDialog.Builder(contexto);
            alerta.SetTitle("Notificacion");
            alerta.SetMessage(mensaje);
            alerta.SetPositiveButton("OK", (enviador, evento) => { });

            return alerta;
        }

        public static ProgressDialog setSpinnerDialog(string mensaje, Context contexto)
        {
            ProgressDialog progress = new ProgressDialog(contexto);
            progress.Indeterminate = true;
            progress.SetProgressStyle(ProgressDialogStyle.Spinner);
            progress.SetMessage(mensaje);
            progress.SetCancelable(false);

            return progress;
        }
    }
}