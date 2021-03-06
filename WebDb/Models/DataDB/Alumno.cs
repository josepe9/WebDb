﻿namespace WebDb.Models.DataDB
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Alumno
    {
        public int AlumnoId { get; set; }

        [StringLength(40)]
        [Required]
        public string Nombre { get; set; }
        
        [StringLength(60)]
        public string Direccion { get; set; }

        [StringLength(25)]
        public string Telefono { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
