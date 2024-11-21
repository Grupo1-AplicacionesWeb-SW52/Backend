using CareNestSolution.Profile.Domain.Model.Commands;
using CareNestSolution.Profile.Domain.Model.Queries;
using CareNestSolution.Profile.Domain.Model.ValueObjects;
using CareNestSolution.Profile.Domain.Services;
using CareNestSolution.Profile.Interfaces.ACL;

namespace CareNestSolution.Profile.Application.ACL;

public class ProfilesContextFacade(
    IProfileCommandService profileCommandService,
    IProfileQueryService profileQueryService) : IProfilesContextFacade
{
    public async Task<int> CreateProfile(
        string fullName,
        string email,
        string phone,
        string document,
        string password,
        string profileImg,
        string address,
        string district)
    {
        var createProfileCommand = new CreateProfileCommand(
            fullName,
            email,
            phone,
            document,
            password,
            profileImg,
            address,
            district);
        var profile = await profileCommandService.Handle(createProfileCommand);
        return profile?.Id ?? 0;
    }

    public async Task<int> FetchProfileIdByEmail(string email)
    {
        var getProfileByEmailQuery = new GetProfileByEmailQuery(new EmailAddress(email));
        var profile = await profileQueryService.Handle(getProfileByEmailQuery);
        return profile?.Id ?? 0;
    }
}

/* string FullName,
    string Email,
    string Phone,
    string Document,
    string Password,
    string ProfileImg,
    string Address,
    string District*/