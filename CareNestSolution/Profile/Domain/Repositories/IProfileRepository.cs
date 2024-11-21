using CareNestSolution.Profile.Domain.Model.ValueObjects;
using CareNestSolution.Shared.Domain.Repositories;

namespace CareNestSolution.Profile.Domain.Repositories;

public interface IProfileRepository : IBaseRepository<Model.Aggregates.Profile>
{
    Task<Model.Aggregates.Profile?> FindProfileByEmailAsync(EmailAddress email);
}