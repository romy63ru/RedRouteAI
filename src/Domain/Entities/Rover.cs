namespace RedRouteAI.Domain.Entities;

public class Rover(string name, Location currentLocation, RoverStatus status = RoverStatus.Available) : BaseEntity
{
    public string Name { get; private set; } = name ?? throw new ArgumentNullException(nameof(name));
    public Location CurrentLocation { get; private set; } = currentLocation ?? throw new ArgumentNullException(nameof(currentLocation));
    public RoverStatus Status { get; private set; } = status;

    private readonly List<Order> _assignedOrders = [];

    public IReadOnlyCollection<Order> AssignedOrders => _assignedOrders.AsReadOnly();

    public void AssignOrder(Order order)
    {
        if (Status != RoverStatus.Available)
            throw new DomainException("Rover is not available");

        _assignedOrders.Add(order);
        Status = RoverStatus.Busy;
    }

    public void CompleteOrder(Order order)
    {
        if (!_assignedOrders.Contains(order))
            throw new DomainException("Order not found");

        _assignedOrders.Remove(order);

        if (_assignedOrders.Count == 0)
            Status = RoverStatus.Available;
    }
}