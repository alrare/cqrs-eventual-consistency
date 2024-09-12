using MediatR;
using Orders.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Orders.Application.Commands;
using Orders.Application.Model;

namespace Orders.Application.Commands.Handlers;

public class AddOrderHandler : IRequestHandler<AddOrderCommand, Order>
{
    private readonly DataContext _context;

    public AddOrderHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// AddOrdersHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Order> Handle(AddOrderCommand request, CancellationToken cancellationToken)
    {
        _context.Orders.Add(request.Order);
        await _context.SaveChangesAsync();
        return request.Order;
    }
}
