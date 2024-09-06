using System.Drawing;
using Furniro.Domain.Common.Models;
using Furniro.Domain.Aggregates;

namespace Furniro.Domain.Enteties;

public class Product : BaseClass
{
    public string Name { 
        get => Name; 
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 512)
                throw new ArgumentException("Name must be between 3 and 512 characters.");
            Name = value;
        }
    }

    public string ShortDescription { 
        get => ShortDescription;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 512)
                throw new ArgumentException("Short description must be between 3 and 512 characters.");
            ShortDescription = value;
        }
    }

    public string Description
    {
        get => Description;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 32)
                throw new ArgumentException("Description must be at least 32 characters long.");
            Description = value;
        }
    }

    public decimal Price
    {
        get => Price;
        set
        {
            if (value < 0)
                throw new ArgumentException("Price cannot be negative.");
            Price = value;
        }
    }

    public int? Discount
    {
        get => Discount;
        set
        {
            if (value.HasValue && (value < 0 || value > 100))
                throw new ArgumentException("Discount must be between 0 and 100.");
            Discount = value;
        }
    }

    public int Quality
    {
        get => Quality;
        set
        {
            if (value < 0)
                throw new ArgumentException("Quality cannot be negative.");
            Quality = value;
        }
    }

    public bool? MarkAsNew
    {
        get => MarkAsNew;
        set => MarkAsNew = value;
    }

    public string FileName
    {
        get => FileName;
        set => FileName = value;
    }


    public byte[] CoverPhoto
    {
        get => CoverPhoto;
        set
        {
            if (value == null)
                throw new ArgumentNullException("CoverPhoto", "Cover photo is required.");
            CoverPhoto = value;
        }
    }

    public List<byte[]> AdditionalPhotos
    {
        get => AdditionalPhotos;
        set => AdditionalPhotos = value;
    }

    public IEnumerable<string> Sizes
    {
        get => Sizes ??= new List<string>();
        set => Sizes = value;
    }

    public IEnumerable<string> Colors
    {
        get => Colors ??= new List<string>();
        set => Colors = value;
    }

    public virtual Category Category { get; set; }

    public Guid CategoryId { get; set; }
}   	