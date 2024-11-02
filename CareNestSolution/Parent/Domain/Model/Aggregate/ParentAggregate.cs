using CareNestSolution.Parent.Domain.Model.Commands;

namespace CareNestSolution.Parent.Domain.Model.Aggregate;

public class ParentAggregate
{
    public int Id { get; private set; }
    
    //========================== Parent Information ==========================
    
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string Document { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Password { get; private set; }
    
    //======================== end Parent Information ========================

    public ParentAggregate()
    {
        this.Name = string.Empty;
        this.Surname = string.Empty;
        this.Email = string.Empty;
        this.Document = string.Empty;
        this.PhoneNumber = string.Empty;
        this.Password = string.Empty;
    }
    
    public ParentAggregate(int id, string name, string surname, 
        string email, string document, string phoneNumber, string password) : this()
    {
        Id = id;
        Name = name;
        Surname = surname;
        Email = email;
        Document = document;
        PhoneNumber = phoneNumber;
        Password = password;
    }
    
    public ParentAggregate(CreateParentCommand command) : this()
    {
        Id = command.Id; 
        Name = command.Name;
        Surname = command.Surname;
        Email = command.Email;
        Document = command.Document;
        PhoneNumber = command.PhoneNumber;
        Password = command.Password;
    }
    
}
























