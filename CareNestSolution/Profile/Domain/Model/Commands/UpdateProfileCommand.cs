namespace CareNestSolution.Profile.Domain.Model.Commands;

public record UpdateProfileCommand(
    long Id,
    string FullName,
    string Email,
    string Phone,
    string Document,
    string Password,
    string ProfileImg,
    string Address,
    string District
    );