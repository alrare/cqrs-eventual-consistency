using Orders.Application.Model;
using MediatR;

namespace Orders.Application.Commands;

/// <summary>
/// DeleteOrderCommand
/// </summary>
/// <param name="Order"></param>
/// <returns></returns>
public record DeleteOrderCommand(Order Order) : IRequest<Order>; //Utilizar DTO
