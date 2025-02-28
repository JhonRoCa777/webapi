using AutoMapper;
using webapi.Domain.Entities;
using webapi.Domain.Repositories;
using webapi.Infrastructure.Models;

namespace webapi.Infrastructure.Repositories
{
    public class TareaEFRepository : ITareaRepository
    {
        private readonly WebApiContext _Context;
        private readonly IMapper _Mapper;

        public TareaEFRepository
        (
            WebApiContext Context,
            IMapper Mapper
        )
        {
            _Context = Context;
            _Mapper = Mapper;
        }

        public Task<TareaDTO> CreateAsync(TareaDTO tarea)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int tareaID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TareaDTO>> GetAsync(EstadoDTO estado)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TareaDTO>> IndexAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TareaDTO> UpdateAsync(TareaDTO tarea, int tareaID)
        {
            throw new NotImplementedException();
        }
    }
}
