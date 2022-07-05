using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class Calificacion
    {
        public int Matricula { get; }
        public int Clave { get; }
        public int CalifacionObtenida { get; }


        public Calificacion(int matricula, int clave, int calificacionObtenida) { 

            Matricula = matricula;
            Clave = clave;
            CalifacionObtenida = calificacionObtenida;

        }

    }
}
