using System;

namespace ClassLibraryFacultad
{
    public sealed class Salario
    {
        public double Bruto { get; set; }
        public string CodigoTransferencia { get; set; }
        public double Descuentos { get; set; }
        public DateTime Fecha { get; set; }
        public double GetSalarioNeto()
        {
            return Bruto - 10000;
        }
    }
}
