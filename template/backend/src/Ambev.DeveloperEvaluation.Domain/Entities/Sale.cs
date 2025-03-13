using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a sale in the system with authentication and profile information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Sale : BaseEntity, ISale
{
    /// <summary>
    /// Gets or sets the sale number.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sale date.
    /// </summary>
    public DateTime SaleDate { get; set; } = default;

    /// <summary>
    /// Gets or sets the customer name.
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the branch location.
    /// </summary>
    public string BranchLocation { get; set; } = string.Empty;

    /// <summary>
    /// gets or sets the sale products.
    /// </summary>
    public List<SaleProduct> Products { get;set; } = [];

    /// <summary>
    /// 
    /// </summary>
    //public bool IsCancelled { get; set; }

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
    string ISale.Id => Id.ToString();

    /// <summary>
    /// Validate the sale entity
    /// </summary>
    /// <returns>the current status</returns>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}