using CareNestSolution.Profile.Interfaces.REST.Resources;

namespace CareNestSolution.Profile.Interfaces.REST.Transform;

public static class ProfileResourceFromEntityAssembler
{
    public static ProfileResource ToResourceFromEntity(Domain.Model.Aggregates.Profile entity)
    {
        return new ProfileResource(entity.Id, entity.FullName, entity.EmailAddress, entity.StreetAddress);
    }
}