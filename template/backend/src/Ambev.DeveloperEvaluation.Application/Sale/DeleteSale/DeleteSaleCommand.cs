using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;

/// <summary>
/// Command for delete a sale
/// </summary>
public class DeleteSaleCommand : IRequest<DeleteSaleResponse>
{
    /// <summary>
    /// The unique identifier of the sale to delete
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// 
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Initialize a new instance of DeleteSaleCommand
    /// </summary>
    /// <param name="id"></param>
    public DeleteSaleCommand(string saleNumber)
    {
        SaleNumber = saleNumber; 
    }
}
