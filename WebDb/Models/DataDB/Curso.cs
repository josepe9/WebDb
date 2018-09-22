namespace WebDb.Models.DataDB
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Curso
    {
        public int CursoId { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }
        [StringLength(30)]
        public string  Descripcion { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
