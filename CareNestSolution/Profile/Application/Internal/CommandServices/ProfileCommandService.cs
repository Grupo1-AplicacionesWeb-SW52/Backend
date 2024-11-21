using CareNestSolution.Profile.Domain.Model.Commands;
using CareNestSolution.Profile.Domain.Repositories;
using CareNestSolution.Profile.Domain.Services;
using CareNestSolution.Shared.Domain.Repositories;

namespace CareNestSolution.Profile.Application.Internal.CommandServices;

public class ProfileCommandService(
    IProfileRepository profileRepository, 
    IUnitOfWork unitOfWork) 
    : IProfileCommandService
{
    /// <inheritdoc />
    public async Task<Domain.Model.Aggregates.Profile?> Handle(CreateProfileCommand command)
    {
        var profile = new Domain.Model.Aggregates.Profile(command);
        try
        {
            await profileRepository.AddAsync(profile);
            await unitOfWork.CompleteAsync();
            return profile;
        } catch (Exception e)
        {
            // Log error
            return null;
        }
    }
}