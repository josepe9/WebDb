using System.ComponentModel.DataAnnotations;

namespace WebDb.Models.DataDB
{
    public class Alumno
    {
        public int AlumnoId { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(60)]
        public string Direccion { get; set; }

        [StringLength(25)]
        public string Telefono { get; set; }
    }
}
