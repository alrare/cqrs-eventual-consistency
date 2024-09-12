using MediatR;
using Products.Application.Model;

namespace Products.Notifications
{
    /// <summary>
    /// ProductAddedNotifications
    /// </summary>
    /// <param name="Product"></param>
    /// <returns></returns>
    public record ProductAddedNotifications(Product Product) : INotification
    {

    }

}
