namespace CareNestSolution.CareNest.Domain.Model.Commands;

public record CreateParentCommand(
    string Name,
    string Surname,
    string Email,
    string Document,
    string PhoneNumber,
    string Password)
{
}