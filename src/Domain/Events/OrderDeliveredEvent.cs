
namespace RedRouteAI.Domain.Events
{
    public class OrderDeliveredEvent(int orderId, DateTime deliveredAt) : BaseEvent
    {
        public int OrderId { get; } = orderId;
        public DateTime DeliveredAt { get; } = deliveredAt;

        public DateTime OccurredOn { get; } = DateTime.UtcNow;
    }
}