using Microsoft.VisualBasic;

namespace Dsw2026Tpi.Domain.Entities;

public class Disponibilidad : EntityBase
{
    public Guid DoctorId { get; private set; }
    public int Month { get; init; }
    public int Year { get; init; }
    public DayOfWeek DayOfWeek { get; init; }
    public TimeSpan StartTime { get; init; } 
    public TimeSpan EndTime { get; init; }

    public Disponibilidad() { } 

    public Disponibilidad(Guid doctorId, int month, int year, DayOfWeek dayOfWeek, TimeSpan startTime, TimeSpan endTime)
    {
        DoctorId = doctorId;
        Month = month;
        Year = year;
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
    }
}