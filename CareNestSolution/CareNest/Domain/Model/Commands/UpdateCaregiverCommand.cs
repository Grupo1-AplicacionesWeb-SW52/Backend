namespace CareNestSolution.CareNest.Domain.Model.Commands;

public class UpdateCaregiverCommand
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Role { get; set; }
    public double? Rating { get; set; }
    public string? Phone { get; set; }
    public string? Location { get; set; }
    public string? Address { get; set; }
    public AdditionalInfo? AdditionalInfo { get; set; }
    public Dictionary<string, string>? Availability { get; set; }

    public UpdateCaregiverCommand(int id, string? name = null, string? email = null, string? password = null, string? profilePicture = null, string? role = null, double? rating = null, string? phone = null, string? location = null, string? address = null, AdditionalInfo? additionalInfo = null, Dictionary<string, string>? availability = null)
    {
        Id = id;
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