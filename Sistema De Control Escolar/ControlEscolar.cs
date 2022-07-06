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

        private string txt_alumnos = @"C:\Users\ferna\Source\Repos\Examen2_POO\Sistema De Control Escolar\alumnos.txt";
        private string txt_asignaturas = @"C:\Users\ferna\Source\Repos\Examen2_POO\Sistema De Control Escolar\asignaturas.txt";
        private string txt_calificaciones = @"C:\Users\ferna\Source\Repos\Examen2_POO\Sistema De Control Escolar\calificaciones.txt";


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
            alumnos.Sort((a, b) => a.LastName.CompareTo(b.LastName));
            return alumnos;
        }

        public void NewAlumno(int AlumnoID, string AlumnoName, string AlumnoLastName) {
            alumnos.Add(new Alumno(AlumnoID, AlumnoName, AlumnoLastName));
            EasyFile<Alumno>.SaveDataToFile(txt_alumnos, new[] { "Id",
                "Name", "LastName" }, alumnos);
        }

        public void NewCalificacion(int matricula, int clave, int cal)
        {
            calificaciones.Add(new Calificacion(matricula, clave, cal));
            EasyFile<Calificacion>.SaveDataToFile(txt_calificaciones, new[] { "Matricula",
                "Clave", "CalifacionObtenida" }, calificaciones);
        }

        public List<Asignatura> GetAsignaturas()
        {
            asignaturas.Sort((a, b) => a.Id.CompareTo(b.Id));
            return asignaturas;
        }

        public int GetNewMatricula()
        {
            alumnos.Sort((a, b) => a.Id.CompareTo(b.Id));
            int idx = alumnos.Count()-1;
            return alumnos.ElementAt(idx).Id + 1;
        }

        public int GetCalificacionFinal(int matricula) 
        {
            List<Calificacion> cal = new List<Calificacion>();
            int promedio = 0;

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

            return promedio;

        }

        public int GetCalificacionParcial(int matricula)
        {
            List<Calificacion> cal = new List<Calificacion>();
            int promedio = 0;

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

            return promedio;

        }

        public List<Calificacion> GetCalificacionesFinales()
        {
            List<Calificacion> cal = new List<Calificacion>();

            alumnos.ForEach(a =>
                cal.Add(new Calificacion(a.Id, 0000, GetCalificacionFinal(a.Id))));

            cal = cal.OrderByDescending(a => a.CalifacionObtenida).ToList();

            return cal;
        }

        public List<CalificacionConCreditos> GetCalificacionesParciales()
        {
            List<CalificacionConCreditos> cal = new List<CalificacionConCreditos>();
            int creditosTotales = 0;
            int creditos = 0;
            float porcentaje = 0;

            alumnos.ForEach(a => {
                calificaciones.FindAll(d => d.Matricula == a.Id && d.CalifacionObtenida >= 70)
                .ForEach(b =>
                {
                    creditos += asignaturas.Find(c => c.Id == b.Clave).Creditos;
                });
                calificaciones.FindAll(e => e.Matricula == a.Id)
                .ForEach(f => creditosTotales += asignaturas.Find(c => c.Id == f.Clave).Creditos);

                if (creditosTotales > 0)
                {
                    porcentaje = (float)creditos / creditosTotales * 100;
                }
                else { porcentaje = 0; }

                cal.Add(new CalificacionConCreditos(a.Id, creditos, GetCalificacionParcial(a.Id), porcentaje));
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
                calificaciones.FindAll(a => a.CalifacionObtenida < 70 && a.Clave == b.Id).
                ForEach(c => { contador++; });
                cal.Add(new Asignatura(b.Id, b.Name, contador));
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
                if(calificaciones.Any(a => a.CalifacionObtenida < 70 && a.Matricula == b.Id))
                {
                    al.Add(new Alumno(b.Id, b.Name, b.LastName));
                }
            });
            return al;
        } 


        public List<Asignatura> GetAsignaturasReprobadas(int matricula)
        {
            List<Asignatura> al = new List<Asignatura>();

            calificaciones.FindAll(a => a.Matricula == matricula).ForEach(b => {
                al.Add(new Asignatura(b.Clave,
                    asignaturas.Find(c => c.Id == b.Clave).Name,
                    asignaturas.Find(c => c.Id == b.Clave).Creditos
                ));
            });

            return al;
        }

    }
}
