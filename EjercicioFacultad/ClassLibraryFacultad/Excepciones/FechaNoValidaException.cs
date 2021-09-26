using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacultad.Excepciones
{
    public class FechaNoValidaException : Exception
    {
        public FechaNoValidaException(string value)
            : base(string.Format("Ingresó una fecha con formato distinto al solicitado(dd/mm/aaaa): {0}", value))
        {

        }
    }
}
