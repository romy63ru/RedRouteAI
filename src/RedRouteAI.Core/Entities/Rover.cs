namespace RedRouteAI.Core.Entities;

public class Rover
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public Location Location { get; set; } = new(0, 0);
    public string Status { get; set; } = "Idle";

    public Guid? CurrentOrderId { get; set; }
}