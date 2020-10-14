using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaCore.modelo
{
   public class Alumnos
    {
        [Key]
        public int IdAlumno { get; set; } //Clave primaria
        public string Nombre { get; set; }
        public DateTime Nacimiento { get; set; }
        public int IdCurso { get; set; } //Campo clave foranea

        //Entity Framework Core
        public Cursos Curso { get; set; } //Objeto de navegación virtual EFC


    }
}
