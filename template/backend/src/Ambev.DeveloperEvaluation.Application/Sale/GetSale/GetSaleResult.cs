using Ambev.DeveloperEvaluation.Application.SalesProduct.GetSaleProduct;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Represents the result of a sale retrieval
/// </summary>
public class GetSaleResult
{
    /// <summary>
    /// The unique identifier of the user to retrieve
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Gets the sale number
    /// </summary>
    public string SaleNumber { get; } = string.Empty;

    /// <summary>
    /// Gets or set the sale date
    /// </summary>
    public DateTime SaleDate { get; set; } = default;

    /// <summary>
    /// Gets or set the customer name
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or set the branch location
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or set the products
    /// </summary>
    public List<GetSaleProductResult> Products { get; set; } = [];
}
