
namespace RedRouteAI.Domain.Events
{
    public class OrderDeliveredEvent : BaseEvent
    {
        public int OrderId { get; }
        public DateTime DeliveredAt { get; }

        public DateTime OccurredOn { get; } = DateTime.UtcNow;

        public OrderDeliveredEvent(int orderId, DateTime deliveredAt)
        {
            OrderId = orderId;
            DeliveredAt = deliveredAt;
        }
    }
}