using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale;

/// <summary>
/// The validator for the DeleteSaleRequest
/// </summary>
public class DeleteSaleRequestValidator : AbstractValidator<DeleteSaleRequest>
{
    /// <summary>
    /// The Initializer for the DeleteSaleRequestValidator
    /// </summary>
    public DeleteSaleRequestValidator()
    {   
        RuleFor(sale => sale.SaleNumber)
            .NotEmpty();
    }
}
