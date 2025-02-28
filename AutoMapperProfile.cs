using AutoMapper;
using webapi.Domain.Entities;
using webapi.Infrastructure.Models;

namespace API_TODO
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tarea, TareaDTO>().ReverseMap();
        }
    }
}
