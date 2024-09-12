using MediatR;
using Orders.Application.Model;

namespace Orders.Application.Queries;

/// <summary>
/// GetProductByIdQuery
/// </summary>
/// <param name="Id"></param>
/// <returns></returns>
public record GetOrderByIdQuery(int Id) : IRequest<Order>;
