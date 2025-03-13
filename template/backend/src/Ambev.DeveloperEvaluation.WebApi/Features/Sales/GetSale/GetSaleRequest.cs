using Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.GetSaleProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// Request object for getting a sale
/// </summary>
public class GetSaleRequest
{
    /// <summary>
    /// Unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Sale Number
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// The Sale Date
    /// </summary>
    public DateTime SaleDate { get; set; } = default;

    /// <summary>
    /// The customer name
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// the branch location
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// The list product in the sale
    /// </summary>
    public List<GetSaleProductRequest> Products { get; set; } = [];
}
