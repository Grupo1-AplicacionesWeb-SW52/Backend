using CareNestSolution.CareNest.Domain.Model.Aggregate;
using CareNestSolution.CareNest.Domain.Model.Commands;
using CareNestSolution.CareNest.Domain.Model.Queries;
using CareNestSolution.Users.Domain.Repositories;

namespace CareNestSolution.Users.Domain.Services;

public class CaregiverQueryService
{
    private readonly ICaregiverRepository _caregiverRepository;

    public CaregiverQueryService(ICaregiverRepository caregiverRepository)
    {
        _caregiverRepository = caregiverRepository;
    }

    public async Task<CaregiverAggregate?> GetCaregiverByIdAsync(GetCaregiverByIdQuery query)
    {
        var caregiverEntity = await _caregiverRepository.GetByIdAsync(query.Id);
        if (caregiverEntity == null) return null;

        // Convertir la entidad a un aggregate
        return new CaregiverAggregate(new CreateCaregiverCommand(
            caregiverEntity.Name,
            caregiverEntity.Email,
            caregiverEntity.Password,
            caregiverEntity.ProfilePicture,
            caregiverEntity.Role,
            caregiverEntity.Rating,
            caregiverEntity.Phone,  
            caregiverEntity.Location,
            caregiverEntity.Address,
            caregiverEntity.AdditionalInfo.DateOfBirth,
            caregiverEntity.AdditionalInfo.Gender,
            caregiverEntity.AdditionalInfo.Experience,
            caregiverEntity.AdditionalInfo.Bio,
            caregiverEntity.Availability.Schedule
        ));
    }

    public async Task<IEnumerable<CaregiverAggregate>> GetAllCaregiversAsync(GetAllCaregiversQuery query)
    {
        var caregiverEntities = await _caregiverRepository.GetAllAsync();
        return caregiverEntities.Select(entity => new CaregiverAggregate(new CreateCaregiverCommand(
            entity.Name,
            entity.Email,
            entity.Password,
            entity.ProfilePicture,
            entity.Role,
            entity.Rating,
            entity.Phone,
            entity.Location,
            entity.Address,
            entity.AdditionalInfo.DateOfBirth,
            entity.AdditionalInfo.Gender,
            entity.AdditionalInfo.Experience,
            entity.AdditionalInfo.Bio,
            entity.Availability.Schedule
        )));
    }

    public async Task<IEnumerable<CaregiverAggregate>> GetCaregiversByLocationAsync(GetCaregiversByLocationQuery query)
    {
        var caregiverEntities = await _caregiverRepository.GetAllAsync();
        var filteredEntities = caregiverEntities.Where(entity => entity.Location.Equals(query.Location, StringComparison.OrdinalIgnoreCase));

        return filteredEntities.Select(entity => new CaregiverAggregate(new CreateCaregiverCommand(
            entity.Name,
            entity.Email,
            entity.Password,
            entity.ProfilePicture,
            entity.Role,
            entity.Rating,
            entity.Phone,
            entity.Location,
            entity.Address,
            entity.AdditionalInfo.DateOfBirth,
            entity.AdditionalInfo.Gender,
            entity.AdditionalInfo.Experience,
            entity.AdditionalInfo.Bio,
            entity.Availability.Schedule
        )));
    }
}