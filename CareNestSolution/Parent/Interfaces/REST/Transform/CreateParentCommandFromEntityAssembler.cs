using CareNestSolution.Parent.Domain.Model.Commands;
using CareNestSolution.Parent.Interfaces.REST.Resources;

namespace CareNestSolution.Parent.Interfaces.REST.Transform;

public static class CreateParentCommandFromResourceAssembler
{
    public static CreateParentCommand ToCommandFromResource(CreateParentResource resource)
    {
        return new CreateParentCommand(
            resource.Id,
            resource.Name,
            resource.Surname,
            resource.Email,
            resource.Document,
            resource.PhoneNumber,
            resource.Password);
    }
}
