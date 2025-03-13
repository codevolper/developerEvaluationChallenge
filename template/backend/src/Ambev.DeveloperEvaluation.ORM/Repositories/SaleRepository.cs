using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleRepository using Entity Framework Core
/// </summary>
public class SaleRepository : ISaleRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of SaleRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleRepository(DefaultContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new sale in the database
    /// </summary>
    /// <param name="sale">The sale to be created</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale</returns>
    public async Task<Sale> CreateSaleAsync(Sale sale, CancellationToken cancellationToken)
    {
        await _context.AddAsync(sale, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return sale;
    }

    /// <summary>
    /// Deletes a sale from the database
    /// </summary>
    /// <param name="id">The unique identifier of the sale</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the sale was deleted, false if not founded</returns>
    public async Task<bool> DeleteSaleAsync(string saleNumber, CancellationToken cancellationToken)
    {
        var sale = await GetSaleByIdAsync(saleNumber, cancellationToken);
        if (sale is null)
            return false;

        _context.Sales.Remove(sale);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    /// <summary>
    /// Retrieves a sale by its unique identifier
    /// </summary>
    /// <param name="Id">The unique identifier of the sale</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The sale if was founded</returns>
    public async Task<Sale?> GetSaleByIdAsync(string saleNumber, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.FirstOrDefaultAsync(s => s.SaleNumber == saleNumber, cancellationToken);            
    }

    /// <summary>
    /// Updates a sale in the database
    /// </summary>
    /// <param name="sale">The sale instance to be updated</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<Sale> UpdateSaleAsync(Sale sale, CancellationToken cancellationToken)
    {
        var existingSale = await _context.Sales.FindAsync([sale.Id], cancellationToken);
        if (existingSale == null)        
            throw new KeyNotFoundException($"Sale with ID {sale.Id} not found.");
        
        _context.Update(existingSale).CurrentValues.SetValues(sale);        
        
        await _context.SaveChangesAsync(cancellationToken);
        return existingSale;
    }
}
