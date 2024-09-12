using MediatR;
using Products.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Products.Application.Commands;
using Products.Application.Model;
using Newtonsoft.Json;

using MassTransit;
using MassTransit.Transports;

namespace Products.Application.Commands.Handlers;

public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
{
    private readonly DataContext _context;
    //private IPublishEndpoint _publishEndpoint;
    private ISendEndpointProvider _sendEndpoint;

    //public AddProductHandler(DataContext context, IPublishEndpoint publishEndpoint)
    public AddProductHandler(DataContext context, ISendEndpointProvider sendEndpoint)
    {
        _context = context;
        //_publishEndpoint = publishEndpoint;
        _sendEndpoint = sendEndpoint;
    }

    /// <summary>
    /// AddProductHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        _context.Products.Add(request.Product);
        await _context.SaveChangesAsync();

        if (_context is not null)
        {
            //await _publishEndpoint.Publish<Product>(_context);
            var endpoint = await _sendEndpoint.GetSendEndpoint(new Uri("rabbitmq://localhost/product-queue"));

             // Serializar a JSON
            //string jsonString = JsonConvert.SerializeObject(request.Product);
            //Console.WriteLine(jsonString);
            //await endpoint.Send(jsonString);

            await endpoint.Send(new Product { Id = 1, Name = "Producto1", Description = "Producto1Description" });
        }    
        
        return request.Product;
    }
}
