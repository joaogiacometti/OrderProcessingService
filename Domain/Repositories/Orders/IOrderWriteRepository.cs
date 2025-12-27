using Domain.Entities;

namespace Domain.Repositories.Orders;

public interface IOrderWriteRepository
{
    Task Create(Order entity);
}