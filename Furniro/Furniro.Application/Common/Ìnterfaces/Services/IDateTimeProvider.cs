namespace Furniro.Application.Common.Interfaces.Serives;

public interface IDateTimeProvider
{
    DateTime Now { get; }
    DateTime UtcNow { get; }
}