using AutoMapper;
using Domain.Commands.Requests;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<DevEntity, AddDevRequest>().ReverseMap();
            CreateMap<DevEntity, UpdateDevRequest>().ReverseMap();
            CreateMap<DevEntity, DeleteDevRequest>().ReverseMap();
        }

        
    }
}
