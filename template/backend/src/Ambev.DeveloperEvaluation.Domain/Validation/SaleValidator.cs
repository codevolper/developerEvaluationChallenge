using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

/// <summary>
/// Represents a sale validator
/// </summary>
public class SaleValidator : AbstractValidator<Sale>
{
    /// <summary>
    /// Initializes a new instance of SaleValidator
    /// </summary>
    public SaleValidator()
    {
        RuleFor(sale => sale.Id).NotEmpty();
    }
}
