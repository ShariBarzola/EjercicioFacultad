namespace ClassLibraryFacultad
{
    public class Directivo : Empleado
    {
        public override string GetNombreCompleto()
        {
            return $"Sr. Director {Apellido}";
        }
    }
}
