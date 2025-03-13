using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;

/// <summary>
/// Handler for processing DeleteSaleCommand request
/// </summary>
public class DeleteSaleHanlder : IRequestHandler<DeleteSaleCommand, DeleteSaleResponse>
{
    private readonly ISaleRepository _saleRepository;

    /// <summary>
    /// Initialize a new instance of the DeleteSaleHandler
    /// </summary>
    /// <param name="saleRepository"></param>
    public DeleteSaleHanlder(ISaleRepository saleRepository)
    {
        _saleRepository = saleRepository;
    }

    /// <summary>
    /// Handles the DeleteSaleCommand request
    /// </summary>
    /// <param name="request">The DeleteSale command</param>
    /// <param name="cancellationToken">Cancelation Token</param>
    /// <returns>The transaction status after delete operation</returns>
    public async Task<DeleteSaleResponse> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
    {
        var validator = new DeleteSaleValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if(!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var success = await _saleRepository.DeleteSaleAsync(request.SaleNumber, cancellationToken);

        if (!success)
            throw new KeyNotFoundException($"Sale with Sale number {request.SaleNumber} not found");

        return new DeleteSaleResponse { Success = true };

    }
}
