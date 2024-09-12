using MediatR;
using Orders.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Orders.Application.Commands;
using Orders.Application.Model;

namespace Orders.Application.Commands.Handlers;

public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommand, Order>
{
    private readonly DataContext _context;

    public DeleteOrderHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// DeleteOrderHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Order> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        _context.Orders.Remove(request.Order);

        await _context.SaveChangesAsync();

        return request.Order;
    }
}
