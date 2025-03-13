using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// Represents the request object for getting a sale
/// </summary>
public class GetSaleRequestValidator : AbstractValidator<GetSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of GetSaleRequestValidator
    /// </summary>
    public GetSaleRequestValidator()
    {
        RuleFor(x => x.SaleNumber)
        .NotEmpty()
        .WithMessage("The Sales Number is required");
    }
}