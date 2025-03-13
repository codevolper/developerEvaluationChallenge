using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Denormalized Sale Product from Product domain
/// </summary>
public class SaleProduct : BaseEntity, ISaleProduct
{
    /// <summary>
    /// Guid unique indetifier for a sale
    /// </summary>
    public required Guid SaleId { get; set; } 

    /// <summary>
    /// Product name description
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Quantity of the product item in the sale
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// An Unit Price of the product
    /// </summary>
    public decimal UnitPrice { get; set; } = default;


    /// <summary>
    /// Discount Tiers for quantity
    /// 4+ items: 10% discount
    /// 10-20 items: 20% discount
    /// </summary>
    private decimal _discount;
    public decimal Discount 
    { 
        get
        {            
            if (Quantity >= 4 && Quantity < 10)
            {
                _discount =  UnitPrice * Quantity * 0.1m;
            }
            else if (Quantity >= 10 && Quantity <= 20)
            {
                _discount = UnitPrice * Quantity * 0.2m;
            }
            else
            {
                _discount =  0;
            }
            return _discount;
        }
        set 
        { 
            _discount = value; 
        }
    }

    /// <summary>
    /// Total Amount of the product item in the sale
    /// </summary>
    public decimal TotalAmount => Quantity * UnitPrice - Discount;

    /// <summary>
    /// 
    /// </summary>
    //public Sale Sale { get; set; } = new();

    /// <summary>
    /// The user name for validate process
    /// </summary>
    public string Username => Username;

    /// <summary>
    /// The role for validate process
    /// </summary>
    public string Role => Role.ToString();

    /// <summary>
    /// The sale identifier
    /// </summary>
    string ISaleProduct.Id => Id.ToString();
}
