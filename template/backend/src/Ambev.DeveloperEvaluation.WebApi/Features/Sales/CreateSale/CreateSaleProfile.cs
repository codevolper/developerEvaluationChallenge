using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Represents a profile for mapping the CreateSaleRequest to the CreateSaleCommand.
/// </summary>
public class CreateSaleProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleProfile"/> class.
    /// </summary>
    public CreateSaleProfile()
    {
        CreateMap<CreateSaleResult, CreateSaleResponse>();
        CreateMap<CreateSaleRequest, CreateSaleCommand>();        
    }
}