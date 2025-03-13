using Ambev.DeveloperEvaluation.Application.SalesProduct.GetSaleProduct;

using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Command for retrieving a user by their ID
/// </summary>
public record GetSaleCommand : IRequest<GetSaleResult>
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
    /// Gets the sale date
    /// </summary>
    public DateTime SaleDate { get; set; } = default;

    /// <summary>
    /// Gets the customer name
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets the branch location
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// Gets the products
    /// </summary>
    public List<GetSaleProductCommand> Products { get; set; } = [];

    /// <summary>
    /// Initializes a new instance of GetUserCommand
    /// </summary>
    /// <param name="saleNumber">The sale number of the user to retrieve</param>
    public GetSaleCommand(string saleNumber)
    {
        SaleNumber = saleNumber;
    }
}
