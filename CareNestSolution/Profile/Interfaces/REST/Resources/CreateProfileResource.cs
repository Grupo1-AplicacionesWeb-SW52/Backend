namespace CareNestSolution.Profile.Interfaces.REST.Resources;

public record CreateProfileResource(
    string FullName,
    string Email,
    string Phone,
    string Document,
    string Password,
    string ProfileImg,
    string Address,
    string District );