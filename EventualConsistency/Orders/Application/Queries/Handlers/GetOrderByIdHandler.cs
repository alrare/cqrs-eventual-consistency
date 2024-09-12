using MediatR;
using Orders.Infraestructure.Persistence.Context;
using Orders.Application.Model;
using Orders.Application.Queries;

namespace Orders.Application.Queries.Handlers;

public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, Order>
{
    private readonly DataContext _context;
    public GetOrderByIdHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// GetOrderByIdHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken) =>
        await _context.GetOrderById(request.Id);
}