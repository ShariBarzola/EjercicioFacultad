using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryFacultad
{
    public class Facultad
    {
        public List<Alumno> Alumnos { get; set; }
        public List<Empleado> Empleados { get; set; }
        public int CantidadSedes { get; set; }
        public string Nombre { get; set; }
        public Facultad()
        {
            Alumnos = new List<Alumno>();
            Empleados = new List<Empleado>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void EliminarAlumno(int codigoAlumno)
        {
            Alumno alumno = Alumnos.FirstOrDefault(x => x.Codigo == codigoAlumno);
            Alumnos.Remove(alumno);
        }
        public void EliminarEmpleado(int legajoEmpleado)
        {
            Empleado empleado = Empleados.FirstOrDefault(x => x.Legajo == legajoEmpleado);
            Empleados.Remove(empleado);
        }
        public void ModificarAlumno(Alumno alumno)
        {
            foreach (Alumno a in Alumnos)
            {
                if (a.Codigo == alumno.Codigo)
                {
                    a.Nombre = alumno.Nombre;
                    a.Apellido = alumno.Apellido;
                    a.Edad = alumno.Edad;
                    break;
                }
            }
        }

        public void ModificarEmpleado(Empleado empleado)
        {
            foreach (Empleado e in Empleados)
            {
                if (e.Legajo == empleado.Legajo)
                {
                    e.Nombre = empleado.Nombre;
                    e.Apellido = empleado.Apellido;
                    e.Edad = empleado.Edad;
                    break;
                }
            }
        }
        public Alumno GetAlumno(int codigoAlumno)
        {
            Alumno alumno = Alumnos.FirstOrDefault(x => x.Codigo == codigoAlumno);
            return alumno;
        }
        public Empleado GetEmpleado(int legajoEmpleado)
        {
            Empleado empleado = Empleados.FirstOrDefault(x => x.Legajo == legajoEmpleado);
            return empleado;
        }
        public bool existeAlumno(int codigoAlumno)
        {
            bool existeAlumno = Alumnos.Any(x => x.Codigo == codigoAlumno);
            return existeAlumno;
        }
        public bool existeEmpleado(int legajoEmpleado)
        {
            bool existeEmpleado = Empleados.Any(x => x.Legajo == legajoEmpleado);
            return existeEmpleado;
        }
    }
}
