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
        Id = 0; 
        Name = command.Name;
        Surname = command.Surname;
        Email = command.Email;
        Document = command.Document;
        PhoneNumber = command.PhoneNumber;
        Password = command.Password;
    }
    
    public void UpdateParent(UpdateParentCommand command)
    {
        if (!string.IsNullOrEmpty(command.Name)) Name = command.Name;
        if (!string.IsNullOrEmpty(command.Surname)) Surname = command.Surname;
        if (!string.IsNullOrEmpty(command.Email)) Email = command.Email;
        if (!string.IsNullOrEmpty(command.Document)) Document = command.Document;
        if (!string.IsNullOrEmpty(command.PhoneNumber)) PhoneNumber = command.PhoneNumber;
        if (!string.IsNullOrEmpty(command.Password)) Password = command.Password;
    }
}