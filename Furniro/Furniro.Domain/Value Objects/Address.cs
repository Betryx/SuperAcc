namespace Furniro.Domain.ValueObjects;

public class Address
{
    public string Country 
    {   get => Country;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 256)
            {
                throw new ArgumentException("Държавата трябва да бъде между 2 и 256 символа.");
            }

            Country = value;
        }
    }

    public string City
    { 
        get => City;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 256)
            {
                throw new ArgumentException("Градът трябва да бъде между 2 и 256 символа.");
            }

            City = value;
        } 
    }
    
    public string AddressLine 
    { 
        get => AddressLine;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 512)
            {
                throw new ArgumentException("Адресът трябва да бъде между 2 и 512 символа.");
            }

            AddressLine = value;
        } 
    }
    public string PostalCode { get; set; }
}