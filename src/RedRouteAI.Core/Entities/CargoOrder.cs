using RedRouteAI.Core.Enums;

namespace RedRouteAI.Core.Entities;

public class CargoOrder
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid FromBaseId { get; set; }
    public Guid ToBaseId { get; set; }

    public string Description { get; set; } = string.Empty;
    public Guid? AssignedRoverId { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}