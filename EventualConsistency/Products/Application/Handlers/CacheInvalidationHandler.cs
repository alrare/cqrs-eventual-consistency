using MediatR;
using Products.Infraestructure.Persistence.Context;
using Products.Notifications;

namespace Products.Application.Handlers;

public class CacheInvalidationHandler : INotificationHandler<ProductAddedNotifications>
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
    public async Task Handle(ProductAddedNotifications notification, CancellationToken cancellationToken)
    {
        await _context.EventOccured(notification.Product, "Cache invalida.");
        await Task.CompletedTask;
    }
}