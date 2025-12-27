using Application.Requests.Orders;

namespace Application.UseCases.Orders.Create;

public interface ICreateOrderUseCase
{
    Task<Guid> Execute(RequestCreateOrder request);
}