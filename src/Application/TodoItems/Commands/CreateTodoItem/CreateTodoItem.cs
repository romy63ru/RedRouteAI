using RedRouteAI.Application.Common.Interfaces;
using RedRouteAI.Domain.Entities;
using RedRouteAI.Domain.Events;

namespace RedRouteAI.Application.TodoItems.Commands.CreateTodoItem;

public record CreateTodoItemCommand : IRequest<int>
{
    public int ListId { get; init; }

    public string? Title { get; init; }
}

public class CreateTodoItemCommandHandler(IApplicationDbContext context) : IRequestHandler<CreateTodoItemCommand, int>
{
    private readonly IApplicationDbContext _context = context;

    public async Task<int> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
    {
        var entity = new TodoItem
        {
            ListId = request.ListId,
            Title = request.Title,
            Done = false
        };

        entity.AddDomainEvent(new TodoItemCreatedEvent(entity));

        _context.TodoItems.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
