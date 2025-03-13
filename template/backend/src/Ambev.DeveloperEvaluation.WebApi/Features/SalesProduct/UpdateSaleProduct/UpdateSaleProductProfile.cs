using Ambev.DeveloperEvaluation.Application.SalesProduct.UpdateSalesProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.UpdateSalesProduct;

/// <summary>
/// Represents a profile for mapping the update sale product request and response.
/// </summary>
public class UpdateSaleProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateSaleProductProfile"/> class.
    /// </summary>
    public UpdateSaleProductProfile()
    {
        CreateMap<UpdateSaleProductResult, UpdateSaleProductResponse>();
        CreateMap<UpdateSaleProductRequest, UpdateSaleProductCommand>();
    }
}
