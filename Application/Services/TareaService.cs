using System.Net;
using webapi.Application.Repositories;
using webapi.Domain.Entities;
using webapi.Domain.Repositories;

namespace webapi.Application.Services
{
    public class TareaService : ITareaService
    {
        private readonly ITareaRepository _TareaRepository;
        private readonly IUnitOfWorkRepository _UnitOfWorkRepository;

        public TareaService
        (
            ITareaRepository TareaRepository,
            IUnitOfWorkRepository UnitOfWorkRepository
        )
        {
            _TareaRepository = TareaRepository;
            _UnitOfWorkRepository = UnitOfWorkRepository;
        }

        public async Task<ResponseDTO<IEnumerable<TareaDTO>>> index()
        {
            ResponseDTO<IEnumerable<TareaDTO>> resp = new ResponseDTO<IEnumerable<TareaDTO>>();

            var tareas = await _TareaRepository.IndexAsync();

            resp.Data = tareas;

            return resp;
        }
    }
}
