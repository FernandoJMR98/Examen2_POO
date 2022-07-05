﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class Alumno
    {
        public int Id { get; }
        public string Name { get; }
        public string LastName { get; }
        public string FullName => $"{Name} {LastName}"; //Verificar si es necesario

        public Alumno(int id, string name, string lastName) {
            
            Id = id;
            Name = name;
            LastName = lastName;

        }
    }
}