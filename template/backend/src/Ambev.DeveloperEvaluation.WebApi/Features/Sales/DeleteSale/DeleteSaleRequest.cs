namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale;

/// <summary>
/// Represents the request to delete a sale
/// </summary>
public class DeleteSaleRequest
{
    /// <summary>
    /// Unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Sales Number of the sale
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;
}
