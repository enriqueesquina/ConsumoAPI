namespace GencionProyecto.DTO
{
    public class InformeResponse
    {
        public int InformeId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateOnly? FechaInicio { get; set; }
        public DateOnly? FechaFin { get; set; }
        public int EstadoId { get; set; }
        public int MiembroEquipoId { get; set; }
        public int UsuarioId { get; set; }
        public int ProyectoId { get; set; }
    }
}
