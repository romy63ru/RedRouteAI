public class Order(Location pickupLocation, Location destination) : BaseEntity
{
    public Location PickupLocation { get; private set; } = pickupLocation ?? throw new ArgumentNullException(nameof(pickupLocation));
    public Location Destination { get; private set; } = destination ?? throw new ArgumentNullException(nameof(destination));
    public bool Delivered { get; private set; } = false;

    public void MarkAsDelivered()
    {
        if (Delivered)
            throw new DomainException("Order already delivered");

        Delivered = true;
        AddDomainEvent(new OrderDeliveredEvent(this.Id, DateTime.UtcNow));
    }
}