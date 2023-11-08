namespace ProjectsManager.Domain.Common;

public interface IRepository<T>:IAsyncDisposable
{
    Task<List<T>> GetAll();
    Task<List<T>> GetByCondition(Func<T, bool> predicate);
    Task<T> Update(T model);
    Task Insert(T model);
    Task<T> Remove(T model);
    Task Save();
}