using FluentValidation;
using Products.Application.Commands;

namespace Products.Application.Validators;

public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
{
    /// <summary>
    /// AddProductCommandValidator
    /// </summary>
    public AddProductCommandValidator()
    {
        RuleFor(p => p.Product.Name)
            .NotEmpty()
            .WithMessage("El nombre del producto no puede ser nulo");

        RuleFor(p => p.Product.Name)
            .MaximumLength(50)
            .WithMessage("El nombre no debe ser mayor a 50 carácteres");
    }
}