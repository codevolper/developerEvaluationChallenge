using Ambev.DeveloperEvaluation.Application.SalesProduct.GetSaleProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.GetSaleProduct;

/// <summary>
/// Represents the profile for the GetSaleProduct.
/// </summary>
public class GetSaleProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the Sale product mapping.
    /// </summary>
    public GetSaleProductProfile()
    {
        CreateMap<GetSaleProductRequest, GetSaleProductCommand>();
        CreateMap<GetSaleProductResult, GetSaleProductResponse>(); 
    }
}
