using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.UpdateSalesProduct;

/// <summary>
/// Represents a request to update a sale product in the system.
/// </summary>
public class UpdateSaleProductRequestValidator : AbstractValidator<UpdateSaleProductRequest>
{
    /// <summary>
    /// Initializes a new instance of UpdateSaleProductRequestValidator
    /// </summary>
    public UpdateSaleProductRequestValidator()
    {
        RuleFor(saleProduct => saleProduct.Id).NotEmpty();
    }
}
