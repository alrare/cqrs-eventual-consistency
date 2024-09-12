﻿using MediatR;
using Orders.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Orders.Application.Commands;
using Orders.Application.Model;

namespace Orders.Application.Commands.Handlers;

public class UpdateOrderHandler : IRequestHandler<UpdateOrderCommand, Order>
{
    private readonly DataContext _context;

    public UpdateOrderHandler(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// UpdateOrderHandler
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Order> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        _context.Orders.Update(request.Order);

        await _context.SaveChangesAsync();

        return request.Order;
    }
}