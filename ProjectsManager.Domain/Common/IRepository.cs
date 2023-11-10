namespace ProjectsManager.Domain.Common;

public interface IRepository<T, TID>:IAsyncDisposable
{
    Task<List<T>> GetAll();
    Task<T> GetById(TID id);
    Task<List<T>> GetByCondition(Func<T, bool> predicate);
    Task<T> Update(T model);
    Task Insert(T model);
    Task<T> Remove(TID model);
    Task Save();
}