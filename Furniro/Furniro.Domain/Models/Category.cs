using System.Drawing;
using Furniro.Domain.Enteties.abstaction;

namespace Furniro.Domain.Enteties;

class Category : Base
{
    public string Name { 
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

    public Image CoverPhoto { 
        get => CoverPhoto ;
        set => CoverPhoto = value;
     }
}