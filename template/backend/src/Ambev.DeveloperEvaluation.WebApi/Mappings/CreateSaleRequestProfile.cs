using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

/// <summary>
/// Mapping profile for CreateSaleRequest
/// </summary>
public class CreateSaleRequestProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of CreateSaleRequestProfile
    /// </summary>
    public CreateSaleRequestProfile()
    {
        CreateMap<CreateSaleRequest, CreateSaleCommand>();       
    }
}
