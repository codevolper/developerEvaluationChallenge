namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.UpdateSalesProduct;

/// <summary>
/// Response for updating a sale product
/// </summary>
public class UpdateSaleProductResponse
{
    /// <summary>
    /// Gets or sets the unique identifier of the sale
    /// </summary>
    public required Guid SaleId { get; set; }

    /// <summary>
    /// gets or sets the product name description
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
    /// Gets or sets the discount tiers for quantity
    /// </summary>
    public decimal Discount { get; set; } = default;

    /// <summary>
    /// Gets the total amount of the sale product
    /// </summary>
    public decimal TotalAmount => Quantity * UnitPrice - Discount;
}
