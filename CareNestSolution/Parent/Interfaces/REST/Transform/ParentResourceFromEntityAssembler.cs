using CareNestSolution.Parent.Domain.Model.Aggregate;
using CareNestSolution.Parent.Interfaces.REST.Resources;

namespace CareNestSolution.Parent.Interfaces.REST.Transform;

public static class ParentResourceFromEntityAssembler
{
    public static ParentResource ToResourceFromEntity(ParentAggregate entity)
    {
        return new ParentResource(
            entity.Id, 
            entity. Name, 
            entity. Surname, 
            entity. Email, 
            entity. Document, 
            entity. PhoneNumber, 
            entity. Password);

    } 
}
