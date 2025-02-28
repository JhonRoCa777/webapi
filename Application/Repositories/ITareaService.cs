using webapi.Domain.Entities;

namespace webapi.Application.Repositories
{
    public interface ITareaService
    {
        Task<ResponseDTO<IEnumerable<TareaDTO>>> index();
    }
}
