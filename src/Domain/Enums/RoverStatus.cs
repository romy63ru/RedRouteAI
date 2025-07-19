namespace RedRouteAI.Domain.Enums;

/// <summary>
/// Represents the operational status of a rover.
/// </summary>
public enum RoverStatus
{
    /// <summary>
    /// The rover is available for assignment or tasks.
    /// </summary>
    Available,

    /// <summary>
    /// The rover is currently busy and cannot be assigned new tasks.
    /// </summary>
    Busy
}