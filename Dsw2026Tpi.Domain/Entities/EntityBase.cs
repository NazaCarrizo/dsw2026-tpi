namespace Dsw2026Tpi.Domain.Entities;

public abstract class EntityBase(Guid? id = null)
{
    public Guid Id { get; init; } = id ?? Guid.NewGuid();

    public bool Deleted { get; set; } = false;

    public DateTime CreatedAt { get; set; } // FRONT?
    public DateTime UpdatedAt { get; set; } // FRONT?
}
