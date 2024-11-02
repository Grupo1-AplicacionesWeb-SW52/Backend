using CareNestSolution.Users.Domain.Model.Entities;

namespace CareNestSolution.Users.Domain.Repositories;

public interface IParentRepository
{
    Task<ParentEntity?> GetByIdAsync(int id);
    Task<IEnumerable<ParentEntity>> GetAllAsync();
    Task AddAsync(ParentEntity parent);
    Task UpdateAsync(ParentEntity parent);
}