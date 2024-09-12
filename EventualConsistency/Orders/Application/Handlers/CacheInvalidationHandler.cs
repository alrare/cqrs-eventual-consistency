using MediatR;
using Orders.Infraestructure.Persistence.Context;
using Orders.Notifications;

namespace Orders.Application.Handlers;

/* public class CacheInvalidationHandler : INotificationHandler<OrderAddedNotifications>
{
    private readonly DataContext _context;
    public CacheInvalidationHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// CacheInvalidationHandler
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task Handle(OrderAddedNotifications notification, CancellationToken cancellationToken)
    {
        await _context.EventOccured(notification.Order, "Cache invalida.");
        await Task.CompletedTask;
    } 
}*/