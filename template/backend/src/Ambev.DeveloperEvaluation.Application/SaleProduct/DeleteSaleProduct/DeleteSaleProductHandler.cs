using Ambev.DeveloperEvaluation.Application.SalesProduct.DeleteSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.DeleteSaleProduct;

/// <summary>
/// Represents the handler for the DeleteSaleProductCommand
/// </summary>
public class DeleteSaleProductHandler : IRequestHandler<DeleteSaleProductCommand, DeleteSaleProductResponse>    
{
    private readonly ISaleProductRepository _saleProductRepository;

    /// <summary>
    /// Initializes a new instance of the DeleteSaleProductHandler class
    /// </summary>
    public DeleteSaleProductHandler(ISaleProductRepository saleProductRepository)
    {
        _saleProductRepository = saleProductRepository;
    }

    /// <summary>
    /// Deletes a sale product
    /// </summary>
    /// <param name="request">Sale Product command object </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns></returns>
    /// <exception cref="ValidationException">Validate the sale product rules</exception>
    public async Task<DeleteSaleProductResponse> Handle(DeleteSaleProductCommand request, CancellationToken cancellationToken)
    {
        var validator = new DeleteSaleProductValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var success = await _saleProductRepository.DeleteSaleProductAsync(request.SaleId, cancellationToken);
        
        if (!success)
            throw new KeyNotFoundException($"Sale with Sale Id {request.SaleId} not found");

        return new DeleteSaleProductResponse { Success = true };
    }
}
