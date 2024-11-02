using CareNestSolution.Parent.Domain.Model.Aggregate;
using CareNestSolution.Parent.Domain.Model.Queries;
using CareNestSolution.Parent.Domain.Repositories;
using CareNestSolution.Parent.Domain.Services;

namespace CareNestSolution.Parent.Application.Internal.QueryServices;

public class ParentQueryService : IParentQueryService
{
    private readonly IParentRepository parentRepository;
    
    public ParentQueryService(IParentRepository parentRepository)
    {
        this.parentRepository = parentRepository;
    }

    public async Task<IEnumerable<ParentAggregate>> Handle(GetAllParentsQuery query)
    {
        return await Task.FromResult<IEnumerable<ParentAggregate>>(new List<ParentAggregate>());
    }

    public async Task<ParentAggregate?> Handle(GetParentByIdQuery query)
    {
        return await Task.FromResult<ParentAggregate?>(null);
    }
}