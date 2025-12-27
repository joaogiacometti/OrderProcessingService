using Domain.Entities;
using Domain.Repositories.Orders;

namespace Infrastructure.Persistence.Repositories;

public class OrderRepository(AppDbContext dbContext) : IOrderWriteRepository
{
    public async Task Create(Order entity)
    {
        await dbContext.Orders.AddAsync(entity);
    }
}