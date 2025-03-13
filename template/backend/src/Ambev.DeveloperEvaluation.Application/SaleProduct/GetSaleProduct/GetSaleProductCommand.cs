using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.GetSaleProduct;

/// <summary>
/// Represents the command to get a sale product
/// </summary>
public class GetSaleProductCommand : IRequest<GetSaleProductResult>
{
    /// <summary>
    /// Gets or sets the sale product id
    /// </summary>
    public required Guid SaleId { get; set; }

    /// <summary>
    /// Gets or sets the product name
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the quantity
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit price
    /// </summary>
    public decimal UnitPrice { get; set; } = default;

    /// <summary>
    /// Gets or sets the discount
    /// </summary>
    public decimal Discount { get; set; } = default;

    /// <summary>
    /// Gets the total amount
    /// </summary>
    public decimal TotalAmount => Quantity * UnitPrice - Discount;
}
