namespace CareNestSolution.Users.Domain.Model.Entities;

public class ParentEntity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string Document { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Password { get; private set; }

    public ParentEntity(int id, string name, string surname, string email, string document, string phoneNumber, string password)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Email = email;
        Document = document;
        PhoneNumber = phoneNumber;
        Password = password;
    }

    public void Update(string name, string surname, string email, string document, string phoneNumber, string password)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Document = document;
        PhoneNumber = phoneNumber;
        Password = password;
    }
}