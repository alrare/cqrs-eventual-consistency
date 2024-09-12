using MediatR;
using Products.Infraestructure.Persistence.Context;
using Products.Notifications;

namespace Products.Application.Handlers;

public class EmailHandler : INotificationHandler<ProductAddedNotifications>
{

    private readonly DataContext _context;
    public EmailHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// EmailHandler
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task Handle(ProductAddedNotifications notification, CancellationToken cancellationToken)
    {
        await _context.EventOccured(notification.Product, "Enviar correo electrónico.");
        await Task.CompletedTask;
    }
}

