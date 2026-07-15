using Dsw2026Tpi.Domain.Enums;

namespace Dsw2026Tpi.Domain.Entities;

// TURNO = HUECO HORARIO
public class Turno : EntityBase
{
    public Guid DisponibilidadId { get; private set; }
    public DateTime Fecha { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public EstadoTurno Status { get; set; } = EstadoTurno.AVAILABLE;

    public Turno() { }

    public Turno(Guid disponibilidadId, DateTime date, TimeSpan start, TimeSpan end)
    {
        DisponibilidadId = disponibilidadId;
        Fecha = date;
        StartTime = start;
        EndTime = end;
    }
    

    public void MarkAsBooked()
    {
        if (Status != EstadoTurno.AVAILABLE)
            throw new Exception("El turno no está disponible para ser reservado.");
            
        Status = EstadoTurno.BOOKED;
    }
}