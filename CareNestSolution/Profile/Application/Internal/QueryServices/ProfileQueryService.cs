using CareNestSolution.Profile.Domain.Model.Queries;
using CareNestSolution.Profile.Domain.Repositories;
using CareNestSolution.Profile.Domain.Services;
namespace CareNestSolution.Profile.Application.Internal.QueryServices;

public class ProfileQueryService(IProfileRepository profileRepository) : IProfileQueryService
{
    /// <inheritdoc />
    public async Task<IEnumerable<Domain.Model.Aggregates.Profile>> Handle(GetAllProfilesQuery query)
    {
        return await profileRepository.ListAsync();
    }

    /// <inheritdoc />
    public async Task<Domain.Model.Aggregates.Profile?> Handle(GetProfileByEmailQuery query)
    {
        return await profileRepository.FindProfileByEmailAsync(query.Email);
    }

    /// <inheritdoc />
    public async Task<Domain.Model.Aggregates.Profile?> Handle(GetProfileByIdQuery query)
    {
        return await profileRepository.FindByIdAsync(query.ProfileId);
    }
}