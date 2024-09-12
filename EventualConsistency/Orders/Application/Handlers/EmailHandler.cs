using MediatR;
using Orders.Infraestructure.Persistence.Context;
using Orders.Notifications;

namespace Orders.Application.Handlers;

/*public class EmailHandler : INotificationHandler<OrderAddedNotifications>
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
     public async Task Handle(OrderAddedNotifications notification, CancellationToken cancellationToken)
    {
        await _context.EventOccured(notification.Order, "Enviar correo electrónico.");
        await Task.CompletedTask;
    } 
}*/

