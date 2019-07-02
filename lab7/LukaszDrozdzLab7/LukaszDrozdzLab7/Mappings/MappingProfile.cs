using AutoMapper;
using LukaszDrozdzLab7.Models;
using LukaszDrozdzLab7.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Jumper, GetStatisticJumperDTO>();
        }
    }
}
