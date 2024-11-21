using CareNestSolution.IAM.Domain.Model.Commands;
using CareNestSolution.IAM.Interfaces.REST.Resources;

namespace CareNestSolution.IAM.Interfaces.REST.Transform;

public class SignInCommandFromResourceAssembler
{
    public static SignInCommand ToCommandFromResource(SignInResource resource)
    {
        return new SignInCommand(resource.Username, resource.Password);
    }
}