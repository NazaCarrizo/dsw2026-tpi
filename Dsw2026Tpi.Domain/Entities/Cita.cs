using Dsw2026Tpi.Domain.Enums;

namespace Dsw2026Tpi.Domain.Entities;

public class Cita : EntityBase
{
    public Guid TurnoId { get; set; }
    public Guid PatientId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public EstadoCita Status { get; set; } = EstadoCita.BOOKED;
    public DateTime? CancelledAt { get; set; }
    public DateTime? AttendedAt { get; set; }

    public Cita() { }

    public Cita(Guid turnoId, Guid patientId, string reason)
    {
        if (reason.Length < 5)
            throw new ArgumentException("La razón de la cita debe tener al menos 5 caracteres.");
            
        TurnoId = turnoId;
        PatientId = patientId;
        Reason = reason;
        Status = EstadoCita.BOOKED;
    }

    public void Cancel()
    {
        if (Status != EstadoCita.BOOKED)
            throw new InvalidOperationException("Solo se puede cancelar una cita en estado reservado.");

        Status = EstadoCita.CANCELLED;
        CancelledAt = DateTime.UtcNow;
    }
}