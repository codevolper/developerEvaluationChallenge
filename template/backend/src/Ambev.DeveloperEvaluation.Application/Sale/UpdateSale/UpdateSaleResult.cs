using Ambev.DeveloperEvaluation.Application.SalesProduct.UpdateSalesProduct;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Represents the result of updating a sale
/// </summary>
public class UpdateSaleResult
{
    /// <summary>
    /// Gets or sets the sale identifier
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
    /// Gets or sets the products
    /// </summary>
    public List<UpdateSaleProductResult> Products { get; set; } = [];  
}
