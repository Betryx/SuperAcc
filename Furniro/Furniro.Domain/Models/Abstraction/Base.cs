using System.ComponentModel.DataAnnotations;

namespace Furniro.Domain.Enteties.abstaction;

class Base
{
    public Guid Id { get; set;}
    public DateTime CreationDate { get; set; }
    public DateTime LastUpdatedDate { get; set; }
}