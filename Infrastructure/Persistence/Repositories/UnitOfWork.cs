using Domain.Repositories;

namespace Infrastructure.Persistence.UnitOfWork;

public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    public async Task Commit()
    {
        await dbContext.SaveChangesAsync();
    }
}