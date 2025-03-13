namespace Ambev.DeveloperEvaluation.Application.SalesProduct.UpdateSalesProduct;

/// <summary>
/// Represents the result of updating a sale product
/// </summary>
public class UpdateSaleProductResult
{
    /// <summary>
    /// Gets or sets the sale product identifier
    /// </summary>
    public required Guid SaleId { get; set; }

    /// <summary>
    /// Gets or sets the product identifier
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the quantity of the product
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit price of the product
    /// </summary>
    public decimal UnitPrice { get; set; } = default;

    /// <summary>
    /// Gets or sets the discount applied to the product
    /// </summary>
    public decimal Discount { get; set; } = default;

    /// <summary>
    /// Gets the total amount of the product
    /// </summary>
    public decimal TotalAmount => Quantity * UnitPrice - Discount;
}
