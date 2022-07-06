using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class CalificacionConInfo
    {
        public Alumno Matricula { get; }
        public Asignatura Clave { get; }
        public int CalifacionObtenida { get; }


        public CalificacionConInfo(Alumno matricula, Asignatura clave, int calificacionObtenida)
        {

            Matricula = matricula;
            Clave = clave;
            CalifacionObtenida = calificacionObtenida;

        }
    }
}
