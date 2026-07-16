using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Dsw2026Tpi.Domain.Entities;

namespace Dsw2026Tpi.Data;

public class Dsw2026TpiDbContext: DbContext
{
    public Dsw2026TpiDbContext(DbContextOptions<Dsw2026TpiDbContext> options):
        base(options)
    {
    }

    public DbSet<Doctor> Doctors { get; set;} = null!;
    public DbSet<Speciality> Specialities { get; set;} = null!;
    public DbSet<Patient> Patients { get; set;} = null!;
    public DbSet<Disponibilidad> Availabilities { get; set;} = null!;
    public DbSet<Turno> Turnos { get; set;} = null!;
    public DbSet<Cita> Citas { get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    
        modelBuilder.Entity<Doctor>().HasQueryFilter(d => !d.Deleted);
        modelBuilder.Entity<Speciality>().HasQueryFilter(s => !s.Deleted);
        modelBuilder.Entity<Patient>().HasQueryFilter(p => !p.Deleted);
        modelBuilder.Entity<Disponibilidad>().HasQueryFilter(a => !a.Deleted);
        modelBuilder.Entity<Turno>().HasQueryFilter(t => !t.Deleted);
        modelBuilder.Entity<Cita>().HasQueryFilter(c => !c.Deleted);

    }
}
