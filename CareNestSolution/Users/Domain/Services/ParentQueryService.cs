using CareNestSolution.CareNest.Domain.Model.Aggregate;
using CareNestSolution.CareNest.Domain.Model.Commands;
using CareNestSolution.CareNest.Domain.Model.Queries;
using CareNestSolution.Users.Domain.Repositories;

namespace CareNestSolution.Users.Domain.Services;

public class ParentQueryService
{
    private readonly IParentRepository _parentRepository;

    public ParentQueryService(IParentRepository parentRepository)
    {
        _parentRepository = parentRepository;
    }

    public async Task<ParentAggregate?> GetParentByIdAsync(GetParentByIdQuery query)
    {
        var parentEntity = await _parentRepository.GetByIdAsync(query.Id);
        if (parentEntity == null) return null;

        // Convertir la entidad a un aggregate
        return new ParentAggregate(new CreateParentCommand(
            parentEntity.Name,
            parentEntity.Surname,
            parentEntity.Email,
            parentEntity.Document,
            parentEntity.PhoneNumber,
            parentEntity.Password
        ));
    }

    public async Task<IEnumerable<ParentAggregate>> GetAllParentsAsync(GetAllParentsQuery query)
    {
        var parentEntities = await _parentRepository.GetAllAsync();
        return parentEntities.Select(entity => new ParentAggregate(new CreateParentCommand(
            entity.Name,
            entity.Surname,
            entity.Email,
            entity.Document,
            entity.PhoneNumber,
            entity.Password
        )));
    }
}