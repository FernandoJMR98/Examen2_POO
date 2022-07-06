using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class Asignatura
    {
        public int Clave { get; }
        public string Nombre { get; }
        public int Creditos { get; }

        public Asignatura(int id, string name, int creditos) { 
        
            Clave = id;

            Nombre = name;

            Creditos = creditos;
        
        }
    }
}
