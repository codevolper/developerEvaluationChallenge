using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository Interface for managing sales operations
/// </summary>
public interface ISaleRepository
{
    /// <summary>
    /// Creates a new sale in the repository
    /// </summary>
    /// <param name="sale"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<Sale> CreateSaleAsync(Sale sale, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a sale by its unique identifier
    /// </summary>
    /// <param name="saleNumber"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<Sale?> GetSaleByIdAsync(string saleNumber, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a sale in the repository
    /// </summary>
    /// <param name="sale"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<Sale> UpdateSaleAsync(Sale sale, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a sale from the repository
    /// </summary>
    /// <param name="saleNumber"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    Task<bool> DeleteSaleAsync(string saleNumber, CancellationToken cancellationToken = default);
}
