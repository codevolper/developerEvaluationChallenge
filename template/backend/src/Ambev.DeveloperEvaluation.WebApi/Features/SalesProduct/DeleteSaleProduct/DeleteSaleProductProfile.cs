using Ambev.DeveloperEvaluation.Application.SalesProduct.DeleteSaleProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.DeleteSaleProduct;

/// <summary>
/// Represents the profile for the delete sale product
/// </summary>
public class DeleteSaleProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteSaleProductProfile"/> class.
    /// </summary>
    public DeleteSaleProductProfile()
    {
        CreateMap<SaleProduct, DeleteSaleProductResult>();
        CreateMap<DeleteSaleProductCommand, SaleProduct>();

    }
}
