using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SalesProduct.CreateSaleProduct;

/// <summary>
/// Represents the profile for creating a sale product
/// </summary>
public class CreateSaleProductProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of CreateSaleProductProfile
    /// </summary>
    public CreateSaleProductProfile()
    {
        CreateMap<SaleProduct, CreateSaleProductResult>();
        CreateMap<CreateSaleProductCommand, SaleProduct>();
    }
}