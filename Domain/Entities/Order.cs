using Domain.Enums;

namespace Domain.Entities;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid(); 
    public string CustomerName { get; set; } = string.Empty;
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}