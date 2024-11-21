using CareNestSolution.Profile.Domain.Model.Commands;

namespace CareNestSolution.Profile.Domain.Services;

public interface IProfileCommandService
{
    Task<Model.Aggregates.Profile?> Handle(CreateProfileCommand command);
}