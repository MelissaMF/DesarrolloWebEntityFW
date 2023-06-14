using System.ComponentModel.DataAnnotations;
namespace AcademiaApp.Models
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Ciudad { get; set; }
        [MaxLength(4)]
        [MinLength(1)]
        public string NumeroCasa { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante? Estudiante { get; set; }
    }
}
