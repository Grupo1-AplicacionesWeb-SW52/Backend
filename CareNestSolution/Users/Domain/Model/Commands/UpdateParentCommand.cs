namespace CareNestSolution.CareNest.Domain.Model.Commands;

public record UpdateParentCommand(
    int Id,
    string Name, 
    string Surname,
    string Email,
    string Document,
    string PhoneNumber,
    string Password)
{

}