namespace ClassLibraryFacultad
{
    public class Bedel : Empleado
    {
        public string Apodo { get; set; }
        public override string GetNombreCompleto()
        {
            return $"Bedel {Apodo}";
        }
    }
}
