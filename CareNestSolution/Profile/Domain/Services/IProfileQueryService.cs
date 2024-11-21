using CareNestSolution.Profile.Domain.Model.Queries;

namespace CareNestSolution.Profile.Domain.Services;

public interface IProfileQueryService
{
    Task<IEnumerable<Model.Aggregates.Profile>> Handle(GetAllProfilesQuery query);
    
    Task<Model.Aggregates.Profile?> Handle(GetProfileByEmailQuery query);
    
    Task<Model.Aggregates.Profile> Handle(GetProfileByIdQuery query);
}