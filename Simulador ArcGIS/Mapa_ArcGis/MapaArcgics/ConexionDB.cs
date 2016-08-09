using System.Data;
using System.Data.SqlClient;
using MapaArcgics;

namespace ArcGISRuntime.Samples.Desktop
{
    class ConexionDB
    {
        public DataSet Conectar_BD()
        {
            string _connString = @"Data Source=BRYAN\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(_connString))
            {

                //Abrimos la conexión

                connection.Open();

                //Creamos un comando para lanzar la query (consulta)

                SqlCommand command = connection.CreateCommand();

                command.CommandType = System.Data.

                CommandType.Text;
                //command.CommandText = string.Format("SELECT  * from entidad Where Nombre ID = @Nombre");
                //string b = "";
                //command.Parameters.AddWithValue("@Nombre", Convert.ToString(b));

                //Proceso.id_icono = "1";

                command.CommandText = string.Format("SELECT * from entidad Where id_entidad ='" + Proceso.id_icono + "'");

                SqlDataReader reader = command.ExecuteReader();

                connection.Close();

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataSet ds = new DataSet(); adapter.SelectCommand = command;
                adapter.Fill(ds, "entidad");

                return ds;
            }
        }
    }
}
