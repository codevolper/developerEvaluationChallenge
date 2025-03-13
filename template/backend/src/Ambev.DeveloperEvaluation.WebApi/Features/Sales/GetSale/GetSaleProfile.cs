using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// Mapping profile for the GetSale feature
/// </summary>
public class GetSaleProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of GetSaleProfile
    /// </summary>
    public GetSaleProfile()
    {
        CreateMap<GetSaleResult, GetSaleResponse>();
        CreateMap<string, Application.Sales.GetSale.GetSaleCommand>()
            .ConstructUsing(saleNumber => new Application.Sales.GetSale.GetSaleCommand(saleNumber));        
    }
}
