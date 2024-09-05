namespace Furniro.Domain.ValueObjects;

public class Client
{
    public string FirstName 
    {   
        get => FirstName; 
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 256)
                throw new ArgumentException("Name must be between 2 and 256 characters.");
            FirstName = value;
        }
    }
    public string LastName
    {
        get => LastName; 
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 256)
                throw new ArgumentException("Name must be between 2  and 256 characters.");
            LastName = value;
        }
     }
}