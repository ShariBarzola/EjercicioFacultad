using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacultad.Excepciones
{
    public class EdadNumeroNegativoException : Exception
    {
        public EdadNumeroNegativoException(int value) 
            : base(string.Format("Ingresó una edad de número negativo o igual a 0: {0}", value))
        {
            
        }
    }
}
