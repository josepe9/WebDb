namespace WebDb.Models.DataDB
{
    using System.ComponentModel.DataAnnotations;
    public class Matricula
    {
        [Key]
        public int MatriId { get; set; }

        [Display(Name ="Alumno")]
        public int AlumnoId { get; set; }

        [Display(Name = "Curso")]
        public int CursoId { get; set; }

        [StringLength(50)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public Alumno Alumno { get; set; }
        public Curso Curso { get; set; }
    }
}
