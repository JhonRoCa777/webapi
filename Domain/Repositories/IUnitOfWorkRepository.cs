namespace webapi.Domain.Repositories
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        Task<int> SaveAllAsync();
    }
}
