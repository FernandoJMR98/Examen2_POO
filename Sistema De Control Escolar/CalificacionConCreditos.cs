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
        public int Promedio { get; }
        public float Porcentaje { get; }
        public CalificacionConCreditos(int matricula, int creditos, int promedio, float porcentaje)
        {
            Matricula = matricula;
            Creditos = creditos;
            Promedio = promedio;
            Porcentaje = porcentaje;
        }
        
    }
}
