using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Validator for GetUserCommand
/// </summary>
public class GetSaleValidator : AbstractValidator<GetSaleCommand>
{
    /// <summary>
    /// Initializes validation rules for GetUserCommand
    /// </summary>
    public GetSaleValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("User ID is required");

        RuleFor(x => x.SaleNumber)
            .NotEmpty()
            .WithMessage("Sale number is required");

        RuleForEach(x => x.Products)
            .Must(x => x.Quantity > 20)
            .WithMessage("Each product can have a maximum of 20 items");
    }
}
