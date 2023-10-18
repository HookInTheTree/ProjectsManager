namespace ProjectsManager.Infrastructure;

public class InfrastructureOptions
{
    public string ConnectionString { get; }
    public InfrastructureOptions(string connectionString)
    {
        ConnectionString = connectionString;
    }
}