namespace Bowyer.EntityFrameworkCore.Interfaces
{
    public interface IIdentifiable<TIdentifier>
    {
        TIdentifier Id { get; }
    }

    public interface IIdentifiable : IIdentifiable<int>
    {
    }
}