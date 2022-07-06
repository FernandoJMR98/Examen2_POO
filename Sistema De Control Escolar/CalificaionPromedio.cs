using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class CalificaionPromedio
    {
        public int Matricula { get; }
        public int Clave { get; }
        public decimal CalifacionObtenida { get; }


        public CalificaionPromedio(int matricula, int clave, decimal calificacionObtenida)
        {

            Matricula = matricula;
            Clave = clave;
            CalifacionObtenida = calificacionObtenida;

        }
    }
}
