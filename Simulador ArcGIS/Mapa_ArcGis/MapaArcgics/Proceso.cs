using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaArcgics
{
    class Proceso
    {
        private static string nombres;

        public static string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public static DataSet BaseDB { get; set; }
        public string Email { get; set; }
        public static string id_icono { get; set; }

        public static double ent_dec_capacidad_max_combustible { get; set; }
        public static double ent_dec_velocidad_med { get; set; }
        public static double ent_dec_km_l { get; set; }
        public static double escenario { get; set; }
    }
}
