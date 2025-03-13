using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.UpdateSalesProduct;

/// <summary>
/// Represents the mapping profile for the sale product update
/// </summary>
public class UpdateSaleProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the UpdateSaleProductProfile
    /// </summary>
    public UpdateSaleProductProfile()
    {
        CreateMap<SaleProduct, UpdateSaleProductResult>();
        CreateMap<UpdateSaleProductCommand, SaleProduct>();
    }
}
