using MediatR;
using Products.Application.Model;

namespace Products.Application.Queries;

/// <summary>
/// GetProductByIdQuery
/// </summary>
/// <param name="Id"></param>
/// <returns></returns>
public record GetProductByIdQuery(int Id) : IRequest<Product>;
