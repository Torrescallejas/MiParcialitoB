namespace MiParcialitoB.Models
{
    public class Curso
    {
        public int CursoID { get; set; }  // Llave primaria
        public string NombreCurso { get; set; }

        // Relaciones
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
