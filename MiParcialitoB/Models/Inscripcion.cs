namespace MiParcialitoB.Models
{
    public class Inscripcion
    {
        public int EstudianteID { get; set; }  // Llave primaria compuesta
        public int CursoID { get; set; }       // Llave primaria compuesta

        // Relaciones
        public Estudiante Estudiante { get; set; }
        public Curso Curso { get; set; }
    }
}
