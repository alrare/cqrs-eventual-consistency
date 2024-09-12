using Orders.Application.Model;
using MediatR;

namespace Orders.Application.Commands;

/// <summary>
/// UpdateOrderCommand
/// </summary>
/// <param name="Order"></param>
/// <returns></returns>
public record UpdateOrderCommand(Order Order) : IRequest<Order>; //Utilizar DTO
