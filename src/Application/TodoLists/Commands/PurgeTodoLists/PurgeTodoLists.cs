using RedRouteAI.Application.Common.Interfaces;
using RedRouteAI.Application.Common.Security;
using RedRouteAI.Domain.Constants;

namespace RedRouteAI.Application.TodoLists.Commands.PurgeTodoLists;

[Authorize(Roles = Roles.Administrator)]
[Authorize(Policy = Policies.CanPurge)]
public record PurgeTodoListsCommand : IRequest;

public class PurgeTodoListsCommandHandler(IApplicationDbContext context) : IRequestHandler<PurgeTodoListsCommand>
{
    private readonly IApplicationDbContext _context = context;

    public async Task Handle(PurgeTodoListsCommand request, CancellationToken cancellationToken)
    {
        _context.TodoLists.RemoveRange(_context.TodoLists);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
