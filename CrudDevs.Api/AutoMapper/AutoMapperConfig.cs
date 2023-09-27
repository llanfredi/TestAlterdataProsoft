using AutoMapper;
using Domain.Commands.Requests;
using Domain.DTOs;
using Domain.Entities;

namespace Service.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<DevEntity, AddDevRequest>().ReverseMap();
            CreateMap<DevEntity, UpdateDevRequest>().ReverseMap();
            CreateMap<DevEntity, DeleteDevRequest>().ReverseMap();

            CreateMap<DevEntity, DevDto>().ForMember(x => x.DescTipoDev, dst => dst.MapFrom(src => src.TipoDev.DescTipoDev)).ReverseMap();

            CreateMap<TipoDevEntity, TipoDevDto>().ReverseMap();
        }
    }
}
