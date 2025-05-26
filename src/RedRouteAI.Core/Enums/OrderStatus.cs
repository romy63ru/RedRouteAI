namespace RedRouteAI.Core.Enums;

/// <summary>
/// Represents the status of an order.
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// The order is pending and has not yet been processed.
    /// </summary>
    Pending,

    /// <summary>
    /// The order is currently being processed.
    /// </summary>
    InProgress,

    /// <summary>
    /// The order has been delivered successfully.
    /// </summary>
    Delivered,

    /// <summary>
    /// The order processing has failed.
    /// </summary>
    Failed
}