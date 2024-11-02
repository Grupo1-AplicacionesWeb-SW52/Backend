namespace CareNestSolution.CareNest.Domain.Model.Commands;

public class UpdateParentCommand
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? Document { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Password { get; set; }
    
    public UpdateParentCommand(int id, string? name = null, string? surname = null, string? email = null, string? document = null, string? phoneNumber = null, string? password = null)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Email = email;
        Document = document;
        PhoneNumber = phoneNumber;
        Password = password;
    }
}