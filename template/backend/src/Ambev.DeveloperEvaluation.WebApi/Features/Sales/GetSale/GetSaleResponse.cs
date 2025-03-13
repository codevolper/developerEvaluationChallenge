using Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.GetSaleProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// Represents the response for a sale
/// </summary>
public class GetSaleResponse
{
    /// <summary>
    /// Unique identifier for a sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the sale number
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sale date
    /// </summary>
    public DateTime SaleDate { get; set; } = default;

    /// <summary>
    /// Gets or sets the customer name
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the branch location
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the total amount of the sale
    /// </summary>
    public List<GetSaleProductResponse> Products { get; set; } = [];
}