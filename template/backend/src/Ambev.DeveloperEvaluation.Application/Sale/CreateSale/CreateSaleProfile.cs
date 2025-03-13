using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Represents the mapping profile for the sale creation.
/// </summary>
public class CreateSaleProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the Sale mapping class.
    /// </summary>
    public CreateSaleProfile()
    {          
        CreateMap<Sale, CreateSaleResult>();
        CreateMap<CreateSaleCommand, Sale>();
    }
}
