using System.ComponentModel.DataAnnotations;
using Furniro.Domain.Common.Models;
using Furniro.Domain.ValueObjects;
using Furniro.Domain.Enteties;

namespace Furniro.Domain.Aggregates;

public class Order : BaseClass
{
    public ICollection<Product>? Products { get; set; }
    public ICollection<int>? PRoductQualities { get; set; }

    public string CompanyName { 
        get => CompanyName;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 256)
                throw new ArgumentException("Company name must be between 2 and 256 characters.");
            CompanyName = value;
        }
    }

    public Client? Client { get; set; }

    public Address? Address { get; set; }

    public string? PhoneNumber { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public string AdditionalInforamtion 
    { 
        get => AdditionalInforamtion; 
        set
        {
            if(value.Length > 1024)
            {
                throw new ArgumentException("Additional information can't be longer that 1024 symbols");
            }

            AdditionalInforamtion = value;
        } 
    }

}