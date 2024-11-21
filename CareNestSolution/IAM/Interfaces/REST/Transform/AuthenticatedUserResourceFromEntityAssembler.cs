using CareNestSolution.IAM.Domain.Model.Aggregates;
using CareNestSolution.IAM.Interfaces.REST.Resources;

namespace CareNestSolution.IAM.Interfaces.REST.Transform;

public class AuthenticatedUserResourceFromEntityAssembler
{
    public static AuthenticatedUserResource ToResourceFromEntity(
        User user, string token)
    {
        return new AuthenticatedUserResource(user.Id, user.Username, token);
    }
}