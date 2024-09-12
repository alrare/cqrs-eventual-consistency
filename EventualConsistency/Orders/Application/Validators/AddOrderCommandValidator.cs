using FluentValidation;
using Orders.Application.Commands;

namespace Orders.Application.Validators;

public class AddOrderCommandValidator : AbstractValidator<AddOrderCommand>
{
    /// <summary>
    /// AddOrderCommandValidator
    /// </summary>
    public AddOrderCommandValidator()
    {
        RuleFor(p => p.Order.Quantity)
            .GreaterThan(0)
            .WithMessage("La cantidad de la orden no puede ser cero");
    }
}