namespace RedRouteAI.Domain.Entities;

public class Rover : BaseEntity
{
    public string Name { get; private set; }
    public Location CurrentLocation { get; private set; }
    public RoverStatus Status { get; private set; }

    private readonly List<Order> _assignedOrders;

    public IReadOnlyCollection<Order> AssignedOrders => _assignedOrders.AsReadOnly();

    public Rover(string name, Location currentLocation, RoverStatus status = RoverStatus.Available)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        CurrentLocation = currentLocation ?? throw new ArgumentNullException(nameof(currentLocation));
        Status = status;
        _assignedOrders = [];
    }

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