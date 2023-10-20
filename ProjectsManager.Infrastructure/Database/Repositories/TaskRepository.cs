using ProjectsManager.Domain.ProjectAggregate.Repositories;

namespace ProjectsManager.Infrastructure.Database.Repositories;

public class TaskRepository:ITaskRepository
{
    public Task<List<Task>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Task>> GetByCondition(Func<Task, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<Task> Update(Task model)
    {
        throw new NotImplementedException();
    }

    public Task<Task> Create(Task model)
    {
        throw new NotImplementedException();
    }

    public Task<Task> Remove(Task model)
    {
        throw new NotImplementedException();
    }
}