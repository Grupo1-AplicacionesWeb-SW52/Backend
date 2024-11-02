namespace CareNestSolution.CareNest.Domain.Model.Commands;

public class CreateCaregiverCommand
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfilePicture { get; set; }
    public string Role { get; set; }
    public double Rating { get; set; }
    public string Phone { get; set; }
    public string Location { get; set; }
    public string Address { get; set; }
        
    // Información adicional
    public AdditionalInfo AdditionalInfo { get; set; }
    public Dictionary<string, string> Availability { get; set; }

    public CreateCaregiverCommand(string name, string email, string password, string profilePicture, string role, double rating, string phone, string location, string address, AdditionalInfo additionalInfo, Dictionary<string, string> availability)
    {
        Name = name;
        Email = email;
        Password = password;
        ProfilePicture = profilePicture;
        Role = role;
        Rating = rating;
        Phone = phone;
        Location = location;
        Address = address;
        AdditionalInfo = additionalInfo;
        Availability = availability;
    }
}

public class AdditionalInfo
{
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Experience { get; set; }
    public string Bio { get; set; }
}