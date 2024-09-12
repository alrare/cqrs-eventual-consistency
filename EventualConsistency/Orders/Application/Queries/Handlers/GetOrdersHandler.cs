using MediatR;
using Orders.Infraestructure.Persistence.Context;
using Orders.Application.Model;
using Orders.Application.Queries;

namespace Orders.Application.Queries.Handlers;

public class GetOrdersHandler : IRequestHandler<GetOrdersQuery, IEnumerable<Order>>
{
    private readonly DataContext _context;
    public GetOrdersHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// GetOrdersHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
    {
        return await _context.GetAllOrders();

    }
}