public interface IRoverScheduler
{
    Rover? FindBestRover(IEnumerable<Rover> rovers, Order order);
}