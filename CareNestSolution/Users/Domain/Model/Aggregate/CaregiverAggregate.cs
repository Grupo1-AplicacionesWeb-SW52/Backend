
using CareNestSolution.CareNest.Domain.Model.Commands;

namespace CareNestSolution.CareNest.Domain.Model.Aggregate;

public class CaregiverAggregate
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string ProfilePicture { get; private set; }
    public string Role { get; private set; }
    public double Rating { get; private set; }
    public string Phone { get; private set; }
    public string Location { get; private set; }
    public string Address { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string Gender { get; private set; }
    public string Experience { get; private set; }
    public string Bio { get; private set; }
    public Dictionary<string, string> Availability { get; private set; }

    public CaregiverAggregate(CreateCaregiverCommand command)
    {
        Name = command.Name;
        Email = command.Email;
        Password = command.Password;
        ProfilePicture = command.ProfilePicture;
        Role = command.Role;
        Rating = command.Rating;
        Phone = command.Phone;
        Location = command.Location;
        Address = command.Address;
        DateOfBirth = command.DateOfBirth;
        Gender = command.Gender;
        Experience = command.Experience;
        Bio = command.Bio;
        Availability = new Dictionary<string, string>(command.Availability);
    }

    public void Update(UpdateCaregiverCommand command)
    {
        Name = command.Name;
        Email = command.Email;
        Password = command.Password;
        ProfilePicture = command.ProfilePicture;
        Role = command.Role;
        Rating = command.Rating;
        Phone = command.Phone;
        Location = command.Location;
        Address = command.Address;
        DateOfBirth = command.DateOfBirth;
        Gender = command.Gender;
        Experience = command.Experience;
        Bio = command.Bio;
        Availability = new Dictionary<string, string>(command.Availability);
    }

}