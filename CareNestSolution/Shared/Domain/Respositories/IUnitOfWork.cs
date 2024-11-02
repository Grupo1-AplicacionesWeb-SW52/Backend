namespace CareNestSolution.Shared.Domain.Respositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}