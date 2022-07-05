﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class ControlEscolar
    {
        private List<Alumno> alumnos;
        private List<Asignatura> asignaturas;
        private List<Calificacion> calificaciones;

        public ControlEscolar() { 
        
            alumnos = EasyFile<Alumno>.LoadDataFromFile("alumnos.txt",
                      tokens => new Alumno(Convert.ToInt32(tokens[0]), 
                      tokens[1], tokens[2]));
            
            asignaturas = EasyFile<Asignatura>.LoadDataFromFile("asignaturas.txt",
                          tokens => new Asignatura(Convert.ToInt32(tokens[0]),
                          tokens[1], Convert.ToInt32(tokens[2])));

            calificaciones = EasyFile<Calificacion>.LoadDataFromFile("calificaciones.txt",
                             tokens => new Calificacion(Convert.ToInt32(tokens[0]),
                             Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[2])));


        }

    }
}