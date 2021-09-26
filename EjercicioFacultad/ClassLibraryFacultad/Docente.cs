namespace ClassLibraryFacultad
{
    public class Docente : Empleado
    {
        public override string GetNombreCompleto() {
            return $"Docente {Nombre}";
        }
    }
}
