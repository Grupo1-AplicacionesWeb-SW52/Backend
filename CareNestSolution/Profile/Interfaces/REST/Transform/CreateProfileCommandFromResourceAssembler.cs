using CareNestSolution.Profile.Domain.Model.Commands;
using CareNestSolution.Profile.Interfaces.REST.Resources;

namespace CareNestSolution.Profile.Interfaces.REST.Transform;

public static class CreateProfileCommandFromResourceAssembler
{
    public static CreateProfileCommand ToCommandFromResource(CreateProfileResource resource)
    {
        return new CreateProfileCommand(
            resource.FullName,
            resource.Email,
            resource.Phone,
            resource.Document,
            resource.ProfileImg,
            resource.Address,
            resource.District);
    }
}

