using Domain.Enums;

namespace Domain.Entities;

public class Order
{
    public Guid Id { get; private set; } = Guid.NewGuid(); 
    public string CustomerName { get; private set; }
    public OrderStatus Status { get; private set; } = OrderStatus.Pending;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;

    public Order(string customerName)
    {
        Validate(customerName);
        CustomerName = customerName;
    }

    private static void Validate(string customerName)
    {
        if (string.IsNullOrWhiteSpace(customerName))
            throw new ArgumentException("Customer name is required");
    }
}