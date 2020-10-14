using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaCore.modelo
{
    public class Profesores
    {
        public Profesores()
        {
            Cursos = new HashSet<Cursos>();
        }
        [Key]
        public int IdProfesor { get; set; } //Clave primaria
        public string Nombre { get; set; }

        //Entity Framework Core
        public ICollection<Cursos> Cursos { get; set; } //Objeto de navegación virtual EFC

    }
}
