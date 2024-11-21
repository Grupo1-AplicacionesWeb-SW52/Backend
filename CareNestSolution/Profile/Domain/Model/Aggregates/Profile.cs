
using CareNestSolution.Profile.Domain.Model.Commands;
using CareNestSolution.Profile.Domain.Model.ValueObjects;

namespace CareNestSolution.Profile.Domain.Model.Aggregates;

public partial class Profile
{
    public int Id { get; }
    public PersonName Name { get; private set; }
    public EmailAddress Email { get; private set; }
    public StreetAddress Address { get; private set; }

    public string FullName => Name.FullName;
    public string EmailAddress => Email.Address;
    public string StreetAddress => Address.FullAddress;

    public Profile()
    {
        Name = new PersonName();
        Email = new EmailAddress();
        Address = new StreetAddress();
    }

    public Profile(string fullName, string email, string address, string district)
    {
        Name = new PersonName(fullName);
        Email = new EmailAddress(email);
        Address = new StreetAddress(address, district);
    }

    public Profile(CreateProfileCommand command)
    {
        Name = new PersonName(command.FullName);
        Email = new EmailAddress(command.Email);
        Address = new StreetAddress(command.Address, command.District);
    }
    
}

































