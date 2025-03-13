using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.GetSaleProduct;

/// <summary>
/// Represents the profile for get sales product
/// </summary>
public class GetSalesProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetSalesProductProfile
    /// </summary>
    public GetSalesProductProfile()
    {
        CreateMap<SaleProduct, GetSaleProductResult>();
        CreateMap<GetSaleProductCommand, SaleProduct>();
    }
}
