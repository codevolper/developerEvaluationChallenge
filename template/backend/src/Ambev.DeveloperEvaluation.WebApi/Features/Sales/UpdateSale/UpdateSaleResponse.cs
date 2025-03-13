using Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.UpdateSalesProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Represents the response for updating a sale.
/// </summary>
public class UpdateSaleResponse : UpdateSaleProfile
{
    /// <summary>
    /// Unique identifier of the sale.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the sale number.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sale date.
    /// </summary>
    public DateTime SaleDate { get; set; } = default;

    /// <summary>
    /// Gets or sets the customer name.
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the branch location.
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the products of the sale.
    /// </summary>
    public List<UpdateSaleProductResponse> Products { get; set; } = [];
}
