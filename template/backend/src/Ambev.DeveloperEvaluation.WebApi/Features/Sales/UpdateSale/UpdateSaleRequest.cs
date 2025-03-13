using Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.CreateSaleProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.UpdateSalesProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Represents a request to update a sale in the system.
/// </summary>
public class UpdateSaleRequest
{
    /// <summary>
    /// Gets or sets the sale number. Must be unique.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the sale number. Must be unique.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sale date.
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Get or sets the customer name property.
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Get or sets the branch location property.
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// Get or sets a list of the products property.
    /// </summary>
    public List<UpdateSaleProductRequest> Products { get; set; } = [];
}