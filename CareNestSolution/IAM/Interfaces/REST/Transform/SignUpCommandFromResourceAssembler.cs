using CareNestSolution.IAM.Domain.Model.Commands;
using CareNestSolution.IAM.Interfaces.REST.Resources;

namespace CareNestSolution.IAM.Interfaces.REST.Transform;

public class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(resource.Username, resource.Password);
    }
}