using CareNestSolution.Profile.Domain.Model.ValueObjects;
using CareNestSolution.Profile.Domain.Repositories;
using CareNestSolution.Shared.Infrastructure.Persistence.EFC.Configuration;
using CareNestSolution.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace CareNestSolution.Profile.Infrastructure.Persistence.EFC.Repositories;

public class ProfileRepository(AppDbContext context)
    : BaseRepository<Domain.Model.Aggregates.Profile>(context), IProfileRepository
{
    public async Task<Domain.Model.Aggregates.Profile?> FindProfileByEmailAsync(EmailAddress email)
    {
        return Context.Set<Domain.Model.Aggregates.Profile>().FirstOrDefault(p => p.Email == email);
    }
}