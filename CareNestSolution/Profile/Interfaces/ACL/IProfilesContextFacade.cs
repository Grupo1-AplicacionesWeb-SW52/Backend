namespace CareNestSolution.Profile.Interfaces.ACL;

public interface IProfilesContextFacade
{
    Task<int> CreateProfile(
        string fullName,
        string email,
        string phone,
        string document,
        string profileImg,
        string address,
        string district);
    


    Task<int> FetchProfileIdByEmail(string email);
}