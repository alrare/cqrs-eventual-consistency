using MediatR;
using Orders.Application.Model;

namespace Orders.Notifications
{
    /// <summary>
    /// OrderAddedNotifications
    /// </summary>
    /// <param name="Order"></param>
    /// <returns></returns>
    public record OrderAddedNotifications(Order order) : INotification
    {

    }

}
