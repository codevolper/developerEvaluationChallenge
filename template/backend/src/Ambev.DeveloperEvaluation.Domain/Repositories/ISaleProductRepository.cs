using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for managing Sale Products
/// </summary>
public interface ISaleProductRepository
{
    /// <summary>
    /// Create a new Sale Product
    /// </summary>
    /// <param name="saleProduct"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<SaleProduct> CreateSaleProductAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all Sale Products
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<SaleProduct?> GetSaleProductByIdAsync(Guid Id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Sale Product
    /// </summary>
    /// <param name="saleProduct"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<SaleProduct> UpdateSaleProductAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete Sale Product
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<bool> DeleteSaleProductAsync(Guid id, CancellationToken cancellationToken = default);
}
