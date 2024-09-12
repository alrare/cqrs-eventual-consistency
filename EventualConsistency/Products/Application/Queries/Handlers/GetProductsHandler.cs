using MediatR;
using Products.Infraestructure.Persistence.Context;
using Products.Application.Model;
using Products.Application.Queries;

namespace Products.Application.Queries.Handlers;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly DataContext _context;
    public GetProductsHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// GetProductsHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        return await _context.GetAllProducts();

    }
}


