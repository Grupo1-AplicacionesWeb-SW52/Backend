namespace CareNestSolution.CareNest.Domain.Model.Commands;

public record CreateCaregiverCommand(
    string Name,
    string Email,
    string Password,
    string ProfilePicture,
    string Role,
    double Rating,
    string Phone,
    string Location,
    string Address,
    DateTime DateOfBirth,
    string Gender,
    string Experience,
    string Bio,
    Dictionary<string, string> Availability
    )
{

}

