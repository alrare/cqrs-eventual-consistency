using MediatR;
using Products.Application.Model;

namespace Products.Application.Queries;

/// <summary>
/// GetProductsQuery
/// </summary>
/// <returns></returns>
public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
