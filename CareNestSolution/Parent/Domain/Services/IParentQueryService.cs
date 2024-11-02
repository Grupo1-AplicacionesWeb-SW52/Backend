using CareNestSolution.Parent.Domain.Model.Aggregate;
using CareNestSolution.Parent.Domain.Model.Queries;

namespace CareNestSolution.Parent.Domain.Services;

public interface IParentQueryService
{
    Task<IEnumerable<ParentAggregate>> Handle(GetAllParentsQuery query);
        
    Task<ParentAggregate?> Handle(GetParentByIdQuery query);
}