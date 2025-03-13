using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleProductRepository using Entity Framework Core
/// </summary>
public class SaleProductRepository : ISaleProductRepository
{
    private readonly DefaultContext _context;
    /// <summary>
    /// Initializes a new instance of SaleProductRepository
    /// </summary>
    public SaleProductRepository(DefaultContext context) 
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new sale product in the database
    /// </summary>
    /// <param name="saleProduct">An instance of a product in a sale</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The created product sold</returns>
    public async Task<SaleProduct> CreateSaleProductAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default)
    {
        await _context.AddAsync(saleProduct, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return saleProduct;
    }

    /// <summary>
    /// Deletes a sale product from the database
    /// </summary>
    /// <param name="id">The unique identifier of the product to delete</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>True if the user was deleted, false if not found</returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task<bool> DeleteSaleProductAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retrieves a sale product by its unique identifier
    /// </summary>
    /// <param name="Id">The unique identifier of the product</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The product if founded</returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task<SaleProduct?> GetSaleProductByIdAsync(Guid Id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Update a sale product in the database
    /// </summary>
    /// <param name="saleProduct">The product to be updated</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The product updated</returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<SaleProduct> UpdateSaleProductAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default)
    {
        var entry = _context.Update(saleProduct);
        await _context.SaveChangesAsync(cancellationToken);
        return entry.Entity;
    }
}
