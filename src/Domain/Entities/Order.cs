public class Order : BaseEntity
{
    public Location PickupLocation { get; private set; }
    public Location Destination { get; private set; }
    public bool Delivered { get; private set; }

    public Order(Location pickupLocation, Location destination)
    {
        PickupLocation = pickupLocation ?? throw new ArgumentNullException(nameof(pickupLocation));
        Destination = destination ?? throw new ArgumentNullException(nameof(destination));
        Delivered = false;
    }

    public void MarkAsDelivered()
    {
        if (Delivered)
            throw new DomainException("Order already delivered");

        Delivered = true;
        AddDomainEvent(new OrderDeliveredEvent(this.Id, DateTime.UtcNow));
    }
}