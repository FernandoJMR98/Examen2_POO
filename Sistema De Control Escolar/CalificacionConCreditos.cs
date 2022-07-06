using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class CalificacionConCreditos
    {
        public int Matricula { get; }
        public int Creditos { get; }
        public decimal Promedio { get; }
        public decimal Porcentaje { get; }
        public CalificacionConCreditos(int matricula, int creditos, decimal promedio, decimal porcentaje)
        {
            Matricula = matricula;
            Creditos = creditos;
            Promedio = promedio;
            Porcentaje = porcentaje;
        }
        
    }
}
