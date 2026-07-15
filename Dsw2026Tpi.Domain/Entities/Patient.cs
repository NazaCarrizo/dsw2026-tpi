namespace Dsw2026Tpi.Domain.Entities;

public class Patient: EntityBase 
{
    public string FullName { get; init; } 
    public string Email { get; init; }
    public string Dni { get; init; }

    public Patient() { }

    public Patient(string fullName, string email, string dni, Guid? id = null) : base(id)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("El nombre es obligatorio.");

        if (dni.Length < 7 || dni.Length > 8)
            throw new ArgumentException("El DNI debe tener entre 7 y 8 dígitos.");

        if (!ValidatEmail(email))
            throw new ArgumentException("El email no es válido.");

        FullName = fullName;
        Email = email;
        Dni = dni;
    }
        


    public bool ValidatEmail(string email)
    {
        string[] mails = ["gmail.com", "outlook.com", "yahoo.com", "alu.frt.utn.edu.ar"];
        if (email.Contains("@"))
        {
            string[] emailParts = email.Split("@");
            if (emailParts.Length == 2 && mails.Contains(emailParts[1]))
            {
                return true;
            }
        }
        return false;
    }
}
