using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.DeleteSaleProduct;

/// <summary>
/// Request validator for deleting a product from a sale
/// </summary>
public class DeleteSaleProductRequestValidator : AbstractValidator<DeleteSaleProductRequest>
{
    /// <summary>
    /// Initializes a new instance of DeleteSaleProductRequestValidator
    /// </summary>
    public DeleteSaleProductRequestValidator()
    {
       RuleFor(x => x.SaleId).NotEmpty();
    }
}
