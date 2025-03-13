using Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.CreateSaleProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>
public class CreateSaleRequest
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
    /// Gets or sets the customer name.
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the branch location.
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the products in the sale.
    /// </summary>
    public List<CreateSaleProductRequest> Products { get; set; } = [];
}