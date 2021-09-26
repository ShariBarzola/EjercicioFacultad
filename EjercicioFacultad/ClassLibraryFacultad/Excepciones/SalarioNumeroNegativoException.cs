using System;

namespace ClassLibraryFacultad.Excepciones
{
    public class SalarioNumeroNegativoException : Exception
    {
        public SalarioNumeroNegativoException(int value)
            : base(string.Format("Ingresó un salario bruto de monto negativo o igual a 0: {0}", value))
        {

        }

    }
}
