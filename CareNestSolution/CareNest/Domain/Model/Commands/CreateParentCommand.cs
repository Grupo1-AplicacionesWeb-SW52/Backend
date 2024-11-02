namespace CareNestSolution.CareNest.Domain.Model.Commands;

public class CreateParentCommand
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Document { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    
    public CreateParentCommand(string name, string surname, string email, string document, string phoneNumber, string password)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Document = document;
        PhoneNumber = phoneNumber;
        Password = password;
    }
}