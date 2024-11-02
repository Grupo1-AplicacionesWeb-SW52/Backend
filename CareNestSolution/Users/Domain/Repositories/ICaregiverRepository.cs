using CareNestSolution.Users.Domain.Model.Entities;

namespace CareNestSolution.Users.Domain.Repositories;

public interface ICaregiverRepository
{
    Task<CaregiverEntity?> GetByIdAsync(int id);
    Task<IEnumerable<CaregiverEntity>> GetAllAsync();
    Task AddAsync(CaregiverEntity caregiver);
    Task UpdateAsync(CaregiverEntity caregiver);
    Task DeleteAsync(int id);
}