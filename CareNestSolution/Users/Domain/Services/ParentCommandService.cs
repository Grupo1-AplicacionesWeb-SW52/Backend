using CareNestSolution.CareNest.Domain.Model.Commands;
using CareNestSolution.Users.Domain.Model.Entities;
using CareNestSolution.Users.Domain.Repositories;

namespace CareNestSolution.Users.Domain.Services;

public class ParentCommandService
{
    private readonly IParentRepository _parentRepository;
    public ParentCommandService(IParentRepository parentRepository)
    {
        _parentRepository = parentRepository;
    }
    public async Task AddParentAsync(CreateParentCommand command)
    {
        var parent = new ParentEntity(
            id: 0, // Asumiendo que el id será generado en la base de datos
            name: command.Name,
            surname: command.Surname,
            email: command.Email,
            document: command.Document,
            phoneNumber: command.PhoneNumber,
            password: command.Password
        );

        await _parentRepository.AddAsync(parent);
    }
    public async Task UpdateParentAsync(UpdateParentCommand command)
    {
        var existingParent = await _parentRepository.GetByIdAsync(command.Id);

        if (existingParent == null)
        {
            throw new Exception($"Parent with ID {command.Id} not found.");
        }
        existingParent.Update(
            command.Name,
            command.Surname,
            command.Email,
            command.Document,
            command.PhoneNumber,
            command.Password
        );
        await _parentRepository.UpdateAsync(existingParent);
    }
}