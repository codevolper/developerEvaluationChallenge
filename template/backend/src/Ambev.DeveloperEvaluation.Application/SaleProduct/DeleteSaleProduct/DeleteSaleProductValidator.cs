using Ambev.DeveloperEvaluation.Application.SalesProduct.DeleteSaleProduct;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.DeleteSaleProduct;

/// <summary>
/// Represents the validator for the delete sale product command
/// </summary>
public class DeleteSaleProductValidator : AbstractValidator<DeleteSaleProductCommand>
{
    /// <summary>
    /// initializes a new instance of DeleteSaleProductValidator
    /// </summary>
    public DeleteSaleProductValidator()
    {
        RuleFor(x => x.SaleId)
            .NotEmpty()
            .WithMessage("Sale Id is required");
    }
}
