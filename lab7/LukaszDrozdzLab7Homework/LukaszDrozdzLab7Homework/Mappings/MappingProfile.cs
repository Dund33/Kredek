using LukaszDrozdzLab7Homework.Models;
using LukaszDrozdzLab7Homework.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace LukaszDrozdzLab7Homework.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Add all the necessary mappings
            CreateMap<Destroyer, GetBasicDestroyerDTO>();
            CreateMap<Destroyer, GetFullDestroyerDTO>();
            CreateMap<Cruiser, GetFullCruiserDTO>();
            CreateMap<Cruiser, GetBasicCruiserDTO>();
            CreateMap<CruiserRepair, GetRepairDTO>();
            CreateMap<DestroyerRepair, GetRepairDTO>();
        }
    }
}
