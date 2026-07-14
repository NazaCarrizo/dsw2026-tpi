namespace Dsw2026Tpi.Domain.Entities;

public class Speciality: EntityBase
{
    public string Name { get; init; }
    public string Description { get; init; }

    #region Constructor for EF
#pragma warning disable CS8618
    private Speciality() { }
#pragma warning restore CS8618
    #endregion

    public Speciality(string name, string description, Guid? id = null) : base(id)
{
    if (string.IsNullOrWhiteSpace(name) || name.Length < 3 || name.Length > 100)
        throw new ArgumentException("El nombre debe tener entre 3 y 100 caracteres.");

    if (string.IsNullOrWhiteSpace(description) || description.Length < 10 || description.Length > 100)
        throw new ArgumentException("La descripción debe tener entre 10 y 100 caracteres.");

    Name = name;
    Description = description;
}
}
