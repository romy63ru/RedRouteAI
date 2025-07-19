public class RouteOptimizer : IRoverScheduler
{
    public Rover? FindBestRover(IEnumerable<Rover> rovers, Order order)
    {
        return rovers
            .Where(r => r.Status == RoverStatus.Available)
            .OrderBy(r => r.CurrentLocation.DistanceTo(order.PickupLocation))
            .FirstOrDefault();
    }
}