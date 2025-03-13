namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.GetSaleProduct;

/// <summary>
/// Represents the request for getting a sale product
/// </summary>
public class GetSaleProductRequest
{
    /// <summary>
    /// Unique identifier of the sale
    /// </summary>
    public required Guid SaleId { get; set; }

    /// <summary>
    /// Gets or sets the product name
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the quantity of the product item in the sale
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit price of the product
    /// </summary>
    public decimal UnitPrice { get; set; } = default;

    /// <summary>
    /// Gets or sets the discount of the product
    /// </summary>
    public decimal Discount { get; set; } = default;

    /// <summary>
    /// Gets the total amount of the product
    /// </summary>
    public decimal TotalAmount => Quantity * UnitPrice - Discount;
}
