using CareNestSolution.IAM.Domain.Model.Aggregates;
using CareNestSolution.IAM.Interfaces.REST.Resources;

namespace CareNestSolution.IAM.Interfaces.REST.Transform;

public class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(user.Id, user.Username);
    }
}