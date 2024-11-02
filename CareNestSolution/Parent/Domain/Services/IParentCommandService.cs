using CareNestSolution.Parent.Domain.Model.Commands;
using CareNestSolution.Parent.Domain.Model.Aggregate;

namespace CareNestSolution.Parent.Domain.Services;

public interface IParentCommandService
{
    Task<ParentAggregate?> Handle(CreateParentCommand command);
}