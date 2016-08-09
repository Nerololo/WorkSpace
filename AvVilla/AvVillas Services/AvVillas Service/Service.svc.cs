using System.Collections.Generic;
using System.Linq;

namespace AvVillas_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service : IService
    {
        public List<PeticionUsuario> ConsultarPeticion(int usuario_ID)
        {
            using (AvVillasEntities context = new AvVillasEntities())
            {
                List<PeticionUsuario> peticion = new List<PeticionUsuario>();

                var usuarioExiste = (from busquedaUsuario in context.tbl_login
                                     join busquedaPeticion in context.tbl_peticion
                                     on busquedaUsuario.ID_Login equals busquedaPeticion.usr_ID
                                     where busquedaPeticion.usr_ID == usuario_ID
                                     select busquedaPeticion).ToList();

                if (usuarioExiste.Count > 0)
                {
                    foreach (var item in usuarioExiste)
                    {
                        peticion.Add(new PeticionUsuario(item));
                    }
                    return peticion;
                }
                else
                {
                    return null;
                }
            }
        }

        public void GuardarPeticion(string nombres, string apellidos, long fechaNacimiento, string sexo, string tipoCedula, int cedula, string Observaciones, byte[] imagenCara, byte[] imagenAtras, int usuario_ID)
        {
            using (AvVillasEntities context = new AvVillasEntities())
            {
                tbl_peticion peticion = new tbl_peticion();

                peticion.usr_nombres = nombres;
                peticion.usr_apellidos = apellidos;
                peticion.usr_fechaNacimiento = fechaNacimiento;
                peticion.usr_sexo = sexo;
                peticion.usr_tipoCedula = tipoCedula;
                peticion.usr_cedula = cedula;
                peticion.usr_imagenCara = imagenCara;
                peticion.usr_imagenAtras = imagenAtras;
                peticion.usr_ID = usuario_ID;
                peticion.usr_Observaciones = Observaciones;

                context.tbl_peticion.Add(peticion);
                context.SaveChanges();
            }
        }

        public int VerificarUsuario(string tipoCC, string usuario, string password)
        {
            using (AvVillasEntities context = new AvVillasEntities())
            {
                var usuarioExiste = (from busquedaUsuario in context.tbl_login
                                     where busquedaUsuario.usr_login == usuario && busquedaUsuario.usr_password == password && busquedaUsuario.usr_tipoCedula == tipoCC
                                     select busquedaUsuario).FirstOrDefault();

                if (usuarioExiste != null)
                {
                    return usuarioExiste.ID_Login;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void BorrarPeticion(int peticion_ID)
        {
            using (AvVillasEntities context = new AvVillasEntities())
            {
                var peticion = context.tbl_peticion.Single(c => c.ID_Peticion == peticion_ID);
                context.tbl_peticion.Remove(peticion);
                context.SaveChanges();
            }
        }

        public void EditarPeticion(int peticion_ID, string nombres, string apellidos, long fechaNacimiento, string sexo, string tipoCedula, int cedula, string Observaciones, byte[] imagenCara, byte[] imagenAtras)
        {
            using (AvVillasEntities context = new AvVillasEntities())
            {
                var peticion = context.tbl_peticion.Single(c => c.ID_Peticion == peticion_ID);

                peticion.usr_nombres = nombres;
                peticion.usr_apellidos = apellidos;
                peticion.usr_fechaNacimiento = fechaNacimiento;
                peticion.usr_sexo = sexo;
                peticion.usr_tipoCedula = tipoCedula;
                peticion.usr_cedula = cedula;
                peticion.usr_imagenCara = imagenCara;
                peticion.usr_imagenAtras = imagenAtras;
                peticion.usr_Observaciones = Observaciones;

                context.SaveChanges();
            }
        }
    }
}
