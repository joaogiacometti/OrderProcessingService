using Application.Requests.Orders;
using Domain.Entities;
using Domain.Repositories;
using Domain.Repositories.Orders;

namespace Application.UseCases.Orders.Create;

public class CreateOrderUseCase(
    IOrderWriteRepository orderWriteRepository,
    IUnitOfWork unitOfWork) : ICreateOrderUseCase
{
    public async Task<Guid> Execute(RequestCreateOrder request)
    {
        var entity = new Order(customerName: request.CustomerName);
        
        await orderWriteRepository.Create(entity);
        await unitOfWork.Commit();
        
        return entity.Id;
    }
}