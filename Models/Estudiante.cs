using System.Globalization;

namespace AcademiaApp.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Direccion Direccion { get; set; }

    }
}
