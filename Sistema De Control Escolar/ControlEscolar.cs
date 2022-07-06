using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Faculty
{
    public class ControlEscolar
    {
        private List<Alumno> alumnos;
        private List<Asignatura> asignaturas;
        private List<Calificacion> calificaciones;

        //Path máquina 1
        //private string txt_alumnos = @"C:\Users\ferna\Source\Repos\Examen2_POO\Sistema De Control Escolar\alumnos.txt";
        //private string txt_asignaturas = @"C:\Users\ferna\Source\Repos\Examen2_POO\Sistema De Control Escolar\asignaturas.txt";
        //private string txt_calificaciones = @"C:\Users\ferna\Source\Repos\Examen2_POO\Sistema De Control Escolar\calificaciones.txt";

        //Path máquina 2
        private string txt_alumnos = @"D:\Lenguajes de programacion\C_sharp\Examen2_POO\alumnos.txt";
        private string txt_asignaturas = @"D:\Lenguajes de programacion\C_sharp\Examen2_POO\asignaturas.txt";
        private string txt_calificaciones = @"D:\Lenguajes de programacion\C_sharp\Examen2_POO\calificaciones.txt";


        public ControlEscolar() { 
        
            alumnos = EasyFile<Alumno>.LoadDataFromFile(txt_alumnos,
                      tokens => new Alumno(Convert.ToInt32(tokens[0]), 
                      tokens[1], tokens[2]));
            
            asignaturas = EasyFile<Asignatura>.LoadDataFromFile(txt_asignaturas,
                          tokens => new Asignatura(Convert.ToInt32(tokens[0]),
                          tokens[1], Convert.ToInt32(tokens[2])));

            calificaciones = EasyFile<Calificacion>.LoadDataFromFile(txt_calificaciones,
                             tokens => new Calificacion(Convert.ToInt32(tokens[0]),
                             Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[2])));


        }

        public List<Alumno> GetAlumnos() {
            alumnos.Sort((a, b) => a.Apellido.CompareTo(b.Apellido));
            return alumnos;
        }

        public void NewAlumno(int AlumnoID, string AlumnoName, string AlumnoLastName) {
            alumnos.Add(new Alumno(AlumnoID, AlumnoName, AlumnoLastName));
            EasyFile<Alumno>.SaveDataToFile(txt_alumnos, new[] { "Matricula",
                "Nombre", "Apellido" }, alumnos);
        }

        public void NewCalificacion(int matricula, int clave, int cal)
        {
            List<Calificacion> list_cal = new List<Calificacion>();
            list_cal = GetCalificaciones();

            list_cal.RemoveAll(a => a.Matricula == matricula && a.Clave == clave);
            list_cal.Add(new Calificacion(matricula, clave, cal));
            list_cal.Sort((a, b) => a.Matricula.CompareTo(b.Matricula));

            EasyFile<Calificacion>.SaveDataToFile(txt_calificaciones, new[] { "Matricula",
                "Clave", "CalifacionObtenida" }, list_cal);
        }

        public List<Asignatura> GetAsignaturas()
        {
            asignaturas.Sort((a, b) => a.Clave.CompareTo(b.Clave));
            return asignaturas;
        }

        public List<Calificacion> GetCalificaciones()
        {
            calificaciones.Sort((a, b) => a.Matricula.CompareTo(b.Matricula));
            return calificaciones;
        }

        public int GetNewMatricula()
        {
            alumnos.Sort((a, b) => a.Matricula.CompareTo(b.Matricula));
            int idx = alumnos.Count()-1;
            return alumnos.ElementAt(idx).Matricula + 1;
        }

        public void NewKardex(int matricula) {
            List<Calificacion> cal = new List<Calificacion>();
            calificaciones.ForEach(a => cal.Add(new Calificacion(a.Matricula, a.Clave, a.CalifacionObtenida)));
            asignaturas.ForEach(a => cal.Add(new Calificacion(matricula, a.Clave, -1)));
            cal.ForEach(a => NewCalificacion(a.Matricula, a.Clave, a.CalifacionObtenida));
            EasyFile<Calificacion>.SaveDataToFile(txt_calificaciones, new[] { "Matricula",
                "Clave", "CalifacionObtenida" }, cal);
        }

        public decimal GetCalificacionFinal(int matricula) 
        {
            List<Calificacion> cal = new List<Calificacion>();
            decimal promedio = 0;

            calificaciones.FindAll(a => a.Matricula == matricula).ForEach(a =>
                cal.Add(new Calificacion(
                           a.Matricula, a.Clave, a.CalifacionObtenida)));

            cal.RemoveAll(a => a.CalifacionObtenida == -1);
            cal.ForEach(a => promedio += a.CalifacionObtenida);
            if (cal.Count > 0)
            {
                promedio /= cal.Count();
            }
            else
            {
                promedio = 0;
            }

            return Decimal.Round(promedio, 2);

        }

        public decimal GetCalificacionParcial(int matricula)
        {
            List<Calificacion> cal = new List<Calificacion>();
            decimal promedio = 0;

            calificaciones.FindAll(a => a.Matricula == matricula)
                .FindAll(a => a.CalifacionObtenida >= 70 ).ForEach(a => {
                    cal.Add(new Calificacion(
                               a.Matricula, a.Clave, a.CalifacionObtenida));});

            cal.RemoveAll(a => a.CalifacionObtenida == -1);
            cal.ForEach(a => promedio += a.CalifacionObtenida);
            if (cal.Count > 0)
            {
                promedio /= cal.Count();
            }
            else
            {
                promedio = 0;
            }

            return Decimal.Round(promedio, 2);

        }

        public List<CalificaionPromedio> GetCalificacionesFinales()
        {
            List<CalificaionPromedio> cal = new List<CalificaionPromedio>();

            alumnos.ForEach(a =>
                cal.Add(new CalificaionPromedio(a.Matricula, 0000, GetCalificacionFinal(a.Matricula))));

            cal = cal.OrderByDescending(a => a.CalifacionObtenida).ToList();

            return cal;
        }

        public List<CalificacionConCreditos> GetCalificacionesParciales()
        {
            List<CalificacionConCreditos> cal = new List<CalificacionConCreditos>();
            int creditosTotales = 0;
            int creditos = 0;
            decimal porcentaje = 0;

            alumnos.ForEach(a => {
                calificaciones.FindAll(d => d.Matricula == a.Matricula && d.CalifacionObtenida >= 0 && d.CalifacionObtenida >= 70)
                .ForEach(b =>
                {
                    creditos += asignaturas.Find(c => c.Clave == b.Clave).Creditos;
                });
                calificaciones.FindAll(e => e.Matricula == a.Matricula)
                .ForEach(f => creditosTotales += asignaturas.Find(c => c.Clave == f.Clave).Creditos);

                if (creditosTotales > 0)
                {
                    porcentaje = (decimal)creditos / creditosTotales * 100;
                }
                else { porcentaje = 0; }

                cal.Add(new CalificacionConCreditos(a.Matricula, creditos, GetCalificacionParcial(a.Matricula), Decimal.Round(porcentaje, 2)));
                creditos = 0;
                creditosTotales= 0;
            });

            cal = cal.OrderByDescending(a=>a.Promedio).ToList();

            return cal;
        }

        public List<Asignatura> GetAsignaturasPorAlumnos()
        {
            List<Asignatura> cal = new List<Asignatura>();
            int contador = 0;
            asignaturas.ForEach(b => {
                calificaciones.FindAll(a => a.CalifacionObtenida < 70 && a.CalifacionObtenida >= 0 && a.Clave == b.Clave).
                ForEach(c => { contador++; });
                cal.Add(new Asignatura(b.Clave, b.Nombre, contador));
                contador = 0;
                }
            );

            cal = cal.OrderByDescending(a => a.Creditos).ToList();

            return cal;  
        }

        public List<Alumno> GetAlumnosReprobados()
        {
            List<Alumno> al = new List<Alumno>();

            alumnos.ForEach(b =>
            {
                if(calificaciones.Any(a => a.CalifacionObtenida < 70 && a.CalifacionObtenida >= 0 && a.Matricula == b.Matricula))
                {
                    al.Add(new Alumno(b.Matricula, b.Nombre, b.Apellido));
                }
            });
            return al;
        } 


        public List<Asignatura> GetAsignaturasReprobadas(int matricula)
        {
            List<Asignatura> al = new List<Asignatura>();

            calificaciones.FindAll(a => a.Matricula == matricula && a.CalifacionObtenida < 70 && a.CalifacionObtenida >= 0).ForEach(b => {
                al.Add(new Asignatura(b.Clave,
                    asignaturas.Find(c => c.Clave == b.Clave).Nombre,
                    asignaturas.Find(c => c.Clave == b.Clave).Creditos
                ));
            });
            al.Sort((a,b) => a.Clave.CompareTo(b.Clave));
            return al;
        }

    }
}
