
using CareNestSolution.CareNest.Domain.Model.Commands;

namespace CareNestSolution.CareNest.Domain.Model.Aggregate;

public class ParentAggregate
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string Document { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Password { get; private set; }

    public ParentAggregate(CreateParentCommand command)
    {
        Name = command.Name;
        Surname = command.Surname;
        Email = command.Email;
        Document = command.Document;
        PhoneNumber = command.PhoneNumber;
        Password = command.Password;
    }

    public void Update(UpdateParentCommand command)
    {
        Name = command.Name;
        Surname = command.Surname;
        Email = command.Email;
        Document = command.Document;
        PhoneNumber = command.PhoneNumber;
        Password = command.Password;
    }
    
}
























