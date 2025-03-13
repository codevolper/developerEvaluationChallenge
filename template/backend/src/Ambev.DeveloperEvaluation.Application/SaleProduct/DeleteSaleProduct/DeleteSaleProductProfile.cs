using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.DeleteSaleProduct;

/// <summary>
/// Profile for DeleteSaleProduct
/// </summary>
public class DeleteSaleProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of DeleteSaleProductProfile
    /// </summary>
    public DeleteSaleProductProfile()
    {
        CreateMap<SaleProduct, DeleteSaleProductResult>();
        CreateMap<DeleteSaleProductCommand, SaleProduct>();       
    }
}
