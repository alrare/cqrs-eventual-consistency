using Orders.Application.Model;
using MediatR;

namespace Orders.Application.Commands;

/// <summary>
/// AddOrderCommand
/// </summary>
/// <param name="Order"></param>
/// <returns></returns>
public record AddOrderCommand(Order Order) : IRequest<Order>;  //Utilizar DTO
