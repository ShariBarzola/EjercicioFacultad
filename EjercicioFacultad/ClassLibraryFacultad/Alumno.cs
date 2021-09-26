namespace ClassLibraryFacultad
{
    public class Alumno : Persona
    {
        public int Codigo { get; set; }
        public string Credencial { get; set; }

        public override string GetCredencial()
        {
            return $"Código {Codigo} {Apellido}, {Nombre}";
        }
    }
}
