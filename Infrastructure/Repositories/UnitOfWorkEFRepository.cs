using webapi.Domain.Repositories;
using webapi.Infrastructure.Models;

namespace webapi.Infrastructure.Repositories
{
    public class UnitOfWorkEFRepository : IUnitOfWorkRepository
    {
        private readonly WebApiContext _Context;

        public UnitOfWorkEFRepository(WebApiContext Context)
        {
            _Context = Context;
        }

        public async Task<int> SaveAllAsync() => await _Context.SaveChangesAsync();

        public void Dispose() => _Context.Dispose();
    }
}
