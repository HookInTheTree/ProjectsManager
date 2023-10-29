namespace ProjectsManager.Domain.Common;

public interface IRepository<T>
{
    Task<List<T>> GetAll();
    Task<List<T>> GetByCondition(Func<T, bool> predicate);
    Task<T> Update(T model);
    Task<T> Create(T model);
    Task<T> Remove(T model);
}