using CareNestSolution.CareNest.Domain.Model.Commands;
using CareNestSolution.Users.Domain.Model.Entities;
using CareNestSolution.Users.Domain.Model.ValueObjects;
using CareNestSolution.Users.Domain.Repositories;

namespace CareNestSolution.Users.Domain.Services;

public class CaregiverCommandService
{
    private readonly ICaregiverRepository _caregiverRepository;

    public CaregiverCommandService(ICaregiverRepository caregiverRepository)
    {
        _caregiverRepository = caregiverRepository;
    }

    public async Task CreateCaregiverAsync(CreateCaregiverCommand command)
    {
        var caregiverEntity = new CaregiverEntity(
            0, // El ID será manejado por la base de datos
            command.Name,
            command.Email,
            command.Password,
            command.ProfilePicture,
            command.Role,
            command.Rating,
            command.Phone,
            command.Location,
            command.Address,
            new AdditionalInfo(
                command.DateOfBirth,
                command.Gender,
                command.Experience,
                command.Bio
            ),
            new Availability(command.Availability)
        );

        await _caregiverRepository.AddAsync(caregiverEntity);
    }

    public async Task UpdateCaregiverAsync(UpdateCaregiverCommand command)
    {
        var existingCaregiver = await _caregiverRepository.GetByIdAsync(command.Id);

        if (existingCaregiver == null)
        {
            throw new Exception($"Caregiver with ID {command.Id} not found.");
        }
        existingCaregiver.Update(
            command.Name,
            command.Email,
            command.Password,
            command.ProfilePicture,
            command.Role,
            command.Rating,
            command.Phone,
            command.Location,
            command.Address,
            new AdditionalInfo(
                command.DateOfBirth,
                command.Gender,
                command.Experience,
                command.Bio
            ),
            new Availability(command.Availability)
        );

        await _caregiverRepository.UpdateAsync(existingCaregiver);
    }
}