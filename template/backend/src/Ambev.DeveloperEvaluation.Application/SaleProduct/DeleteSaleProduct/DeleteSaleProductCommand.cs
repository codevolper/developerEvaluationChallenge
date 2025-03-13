using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.DeleteSaleProduct;

/// <summary>
/// Represents the command to delete a sale product
/// </summary>
public class DeleteSaleProductCommand : IRequest<DeleteSaleProductResponse>
{
    /// <summary>
    /// Gets or sets the sale product id
    /// </summary>
    public required Guid SaleId { get; set; }

    /// <summary>
    /// Gets or sets the product id
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product quantity
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the product unit price
    /// </summary>
    public decimal UnitPrice { get; set; } = default;

    /// <summary>
    /// Gets or sets the product discount
    /// </summary>
    public decimal Discount { get; set; } = default;

    /// <summary>
    /// Gets the total amount of the product
    /// </summary>
    public decimal TotalAmount => Quantity * UnitPrice - Discount;
}
