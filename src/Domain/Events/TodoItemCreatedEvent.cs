namespace RedRouteAI.Domain.Events;

public class TodoItemCreatedEvent(TodoItem item) : BaseEvent
{
    public TodoItem Item { get; } = item;
}
