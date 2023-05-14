namespace DiscExchanges.Repositories;

public interface IRepository<T>
{
    T GetSingle(int id);
}