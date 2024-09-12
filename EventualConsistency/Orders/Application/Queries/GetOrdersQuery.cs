using MediatR;
using Orders.Application.Model;

namespace Orders.Application.Queries;

/// <summary>
/// GetOrdersQuery
/// </summary>
/// <returns></returns>
public record GetOrdersQuery() : IRequest<IEnumerable<Order>>;
