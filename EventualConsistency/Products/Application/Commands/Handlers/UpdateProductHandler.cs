using MediatR;
using Products.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Products.Application.Commands;
using Products.Application.Model;

namespace Products.Application.Commands.Handlers;

public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Product>
{
    private readonly DataContext _context;

    public UpdateProductHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// UpdateProductHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        _context.Products.Update(request.Product);

        await _context.SaveChangesAsync();

        return request.Product;
    }
}
