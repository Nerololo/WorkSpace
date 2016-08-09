using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace AvVillas_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<PeticionUsuario> ConsultarPeticion(int usuario_ID);

        [OperationContract]
        int VerificarUsuario(string tipoCC, string usuario, string password);

        [OperationContract]
        void GuardarPeticion(string nombres, string apellidos, long fechaNacimiento, string sexo, string tipoCedula, int cedula, string Observaciones, byte[] imagenCara, byte[] imagenAtras, int usuario_ID);

        [OperationContract]
        void BorrarPeticion(int ID);

        [OperationContract]
        void EditarPeticion(int ID, string nombres, string apellidos, long fechaNacimiento, string sexo, string tipoCedula, int cedula, string Observaciones, byte[] imagenCara, byte[] imagenAtras);

    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class PeticionUsuario
    {
        public PeticionUsuario() { }
        public PeticionUsuario(tbl_peticion peticion)
        {
            peticion_ID = peticion.ID_Peticion;
            usr_nombres = peticion.usr_nombres;
            usr_apellidos = peticion.usr_apellidos;
            usr_fechaNacimiento = peticion.usr_fechaNacimiento;
            usr_sexo = peticion.usr_sexo;
            usr_tipoCedula = peticion.usr_tipoCedula;
            usr_cedula = peticion.usr_cedula;
            usr_imagenCara = peticion.usr_imagenCara;
            usr_imagenAtras = peticion.usr_imagenAtras;
            usr_ID = peticion.usr_ID;
            usr_Observaciones = peticion.usr_Observaciones;
        }
        [DataMember]
        public int usr_ID { get; set; }
        [DataMember]
        public int peticion_ID { get; set; }
        [DataMember]
        public string usr_nombres { get; set; }
        [DataMember]
        public string usr_apellidos { get; set; }
        [DataMember]
        public long usr_fechaNacimiento { get; set; }
        [DataMember]
        public string usr_sexo { get; set; }
        [DataMember]
        public string usr_tipoCedula { get; set; }
        [DataMember]
        public int usr_cedula { get; set; }
        [DataMember]
        public string usr_Observaciones { get; set; }
        [DataMember]
        public byte[] usr_imagenCara { get; set; }
        [DataMember]
        public byte[] usr_imagenAtras { get; set; }
    }
}
