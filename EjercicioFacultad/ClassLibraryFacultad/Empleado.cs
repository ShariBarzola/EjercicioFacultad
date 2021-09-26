using System;
using System.Collections.Generic;

namespace ClassLibraryFacultad
{
    public abstract class Empleado : Persona
    {
        public int Antiguedad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Legajo { get; set; }
        public List<Salario> Salarios { get; set; }
        public Salario UltimoSalario { get; set; }
        public override string GetCredencial()
        {
            return $"{Legajo} - {GetNombreCompleto()} salario ${UltimoSalario.GetSalarioNeto()}";
        }
        public override string GetNombreCompleto()
        {
            return base.GetNombreCompleto();
        }
    }
}
