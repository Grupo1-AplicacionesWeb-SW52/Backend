namespace CareNestSolution.Parent.Interfaces.REST.Resources;

    public record CreateParentResource(
        int Id, 
        string Name, 
        string Surname, 
        string Email, 
        string Document, 
        string PhoneNumber, 
        string Password);