using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class Alumno
    {
        public int Matricula { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public string FullName => $"{Apellido}, {Nombre}";


        public Alumno(int id, string name, string lastName) {
            
            Matricula = id;
            Nombre = name;
            Apellido = lastName;

        }
    }
}
