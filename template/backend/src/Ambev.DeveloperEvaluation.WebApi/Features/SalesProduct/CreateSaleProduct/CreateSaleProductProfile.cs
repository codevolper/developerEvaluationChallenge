using Ambev.DeveloperEvaluation.Application.SalesProduct.CreateSaleProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SalesProduct.CreateSaleProduct;

/// <summary>
/// Represents the <see cref="CreateSaleProductProfile"/> class.
/// </summary>
public class CreateSaleProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleProductProfile"/> class.
    /// </summary>
    public CreateSaleProductProfile()
    {
        CreateMap<CreateSaleProductRequest, CreateSaleProductCommand>();
        CreateMap<CreateSaleProductResult, CreateSaleProductResponse>();        
    }
}
