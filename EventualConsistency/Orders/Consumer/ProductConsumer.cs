using MassTransit;
using Products.Application.Model;
using System.Threading.Tasks;

public class ProductConsumer : IConsumer<Product>
{
    public async Task Consume(ConsumeContext<Product> context)
    {
        var product = context.Message;
        // Procesar el producto aquí
        await Task.Yield();
    }
}