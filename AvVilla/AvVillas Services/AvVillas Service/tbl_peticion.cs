//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvVillas_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_peticion
    {
        public int ID_Peticion { get; set; }
        public string usr_nombres { get; set; }
        public string usr_apellidos { get; set; }
        public long usr_fechaNacimiento { get; set; }
        public string usr_sexo { get; set; }
        public int usr_cedula { get; set; }
        public string usr_tipoCedula { get; set; }
        public byte[] usr_imagenCara { get; set; }
        public byte[] usr_imagenAtras { get; set; }
        public int usr_ID { get; set; }
        public string usr_Observaciones { get; set; }
    
        public virtual tbl_login tbl_login { get; set; }
    }
}
