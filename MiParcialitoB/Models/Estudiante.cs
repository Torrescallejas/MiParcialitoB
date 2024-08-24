namespace MiParcialitoB.Models
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }  // Llave primaria
        public string Nombre { get; set; }

        // Relaciones
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
