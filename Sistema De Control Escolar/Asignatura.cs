using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class Asignatura
    {
        public int Id { get; }
        public string Name { get; }
        public int Creditos { get; }

        public Asignatura(int id, string name, int creditos) { 
        
            Id = id;

            Name = name;

            Creditos = creditos;
        
        }
    }
}
