using CareNestSolution.Shared.Infrastructure.Persistence.EFC.Configuration;
using CareNestSolution.Shared.Domain.Respositories;

namespace CareNestSolution.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}