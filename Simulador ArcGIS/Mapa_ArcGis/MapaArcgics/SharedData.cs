using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaArcgics
{
    public class SharedData
    {

        private static SharedData oInstance;
        private string clientes;

        public SharedData()
        {
        }

        public static SharedData Instance()
        {

            if (oInstance == null)
                oInstance = new SharedData();

            return oInstance;

        }

       // public string Nombre { get; set; }

        //public Cliente Clientes
        //{
        //    get
        //    {
        //        if (cliente = null)
        //            cliente = new Clientes();
        //        return clientes;
        //    }
        //}

        public string Nombres
        {
            get { return clientes; }
            set { clientes = value; }
        }



    }
}
