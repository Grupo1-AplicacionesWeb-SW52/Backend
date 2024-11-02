using CareNestSolution.Parent.Domain.Model.Aggregate;
using CareNestSolution.Parent.Domain.Model.Commands;
using CareNestSolution.Parent.Domain.Services;
using CareNestSolution.Shared.Domain.Respositories;

namespace CareNestSolution.Parent.Application.Internal.CommandServices;

public class ParentCommandService : IParentCommandService
{
    private readonly IUnitOfWork _unitOfWork;
    
    public ParentCommandService(IUnitOfWork unitOfWork)
    {
        this._unitOfWork = unitOfWork;
    }

    public async Task<ParentAggregate?> Handle(CreateParentCommand command)
    {
        var parent = new ParentAggregate(command);
        await _unitOfWork.CompleteAsync();
        return parent;
    }
}