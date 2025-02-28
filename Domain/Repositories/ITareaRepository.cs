using webapi.Domain.Entities;

namespace webapi.Domain.Repositories
{
    public interface ITareaRepository
        : IIndexAsync,
        ICreateAsync, IUpdateAsync,
        IDeleteAsync, IFilterByStateAsync
    { }

    public interface IIndexAsync
    { Task<IEnumerable<TareaDTO>> IndexAsync(); }

    public interface ICreateAsync
    { Task<TareaDTO> CreateAsync(TareaDTO tarea); }

    public interface IUpdateAsync
    { Task<TareaDTO> UpdateAsync(TareaDTO tarea, int tareaID); }

    public interface IDeleteAsync
    { Task<bool> DeleteAsync(int tareaID); }

    public interface IFilterByStateAsync
    { Task<IEnumerable<TareaDTO>> GetAsync(EstadoDTO estado); }
}
