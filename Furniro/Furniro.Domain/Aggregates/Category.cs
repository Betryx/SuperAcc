using System.Drawing;
using Furniro.Domain.Common.Models;
using Furniro.Domain.Enteties;


namespace Furniro.Domain.Aggregates;

public class Category : BaseClass
{
    public string Name 
    { 
        get => Name; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            
            if (value.Length < 3 || value.Length > 256)
                throw new ArgumentException("Name must be between 3 and 256 characters.");

            Name = value;
        } 
    }

    public Image CoverPhoto
    { 
        get => CoverPhoto ;
        set => CoverPhoto = value;
     }

    public virtual ICollection<Product>? Products { get; set; }
}