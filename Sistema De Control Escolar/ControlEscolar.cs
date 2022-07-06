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

        private string txt_alumnos = @"D:\Lenguajes de programacion\C_sharp\Examen2_POO\Sistema De Control Escolar\alumnos.txt";
        private string txt_asignaturas = @"D:\Lenguajes de programacion\C_sharp\Examen2_POO\Sistema De Control Escolar\asignaturas.txt";
        private string txt_calificaciones = @"D:\Lenguajes de programacion\C_sharp\Examen2_POO\Sistema De Control Escolar\calificaciones.txt";


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

    }
}
