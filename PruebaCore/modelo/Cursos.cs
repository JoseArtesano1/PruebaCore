using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaCore.modelo
{
   public class Cursos
    {
        public Cursos()
        {
            Alumnos = new HashSet<Alumnos>();
        }

        [Key]
        public int IdCurso { get; set; } //Clave primaria
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int IdProfesor { get; set; } //Campo clave foranea

        //Entity Framework Core
        public Profesores Profesor { get; set; } //Objeto de navegación virtual EFC
        public ICollection<Alumnos> Alumnos { get; set; } //Objeto de navegación virtual EFC

    }
}
