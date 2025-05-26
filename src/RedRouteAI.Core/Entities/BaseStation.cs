using RedRouteAI.Core.ValueObjects;

namespace RedRouteAI.Core.Entities;

public class BaseStation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public Location Location { get; set; } = new(0, 0);

    public ICollection<CargoOrder> OutgoingOrders { get; set; } = new List<CargoOrder>();
    public ICollection<CargoOrder> IncomingOrders { get; set; } = new List<CargoOrder>();
}