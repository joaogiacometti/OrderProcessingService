using Application.Requests.Orders;
using Application.Responses;
using Application.UseCases.Orders.Create;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Endpoints;

public static class OrderEndpoints
{
    public static void AddOrderEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/orders")
            .WithTags("orders");

        group.MapPost("", async ([FromServices] ICreateOrderUseCase useCase,
            [FromBody] RequestCreateOrder request) =>
        {
            var id = await useCase.Execute(request);

            return Results.Created(
                $"/orders/{id}",
                new { id }   
            );
        })
        .Produces<ResponseCreated>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest);
    }
}