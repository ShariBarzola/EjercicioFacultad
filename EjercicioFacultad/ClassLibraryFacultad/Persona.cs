using System;

namespace ClassLibraryFacultad
{
    public class Persona
    {
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public virtual string GetCredencial() 
        {
            return "getcredencial";
        }
        public virtual string GetNombreCompleto()
        {
            return "getnombrecompleto";
        }
    }
}
