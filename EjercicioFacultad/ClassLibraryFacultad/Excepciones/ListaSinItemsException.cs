using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacultad.Excepciones
{
    public class ListaSinItemsException : Exception
    {
        public ListaSinItemsException()
             : base(string.Format("El listado solicitado está vacío. Sin registros de Alumnos o Empleados"))
        {

        }
    }
}
