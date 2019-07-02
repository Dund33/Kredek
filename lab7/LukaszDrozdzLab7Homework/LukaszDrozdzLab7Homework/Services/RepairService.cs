using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LukaszDrozdzLab7Homework.Models;
using LukaszDrozdzLab7Homework.Models.DTO;

namespace LukaszDrozdzLab7Homework.Services
{
    public class RepairService : IRepairService
    {
        private readonly StarFleet _context;
        private readonly IMapper _mapper;

        public RepairService(StarFleet context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get the info about the repairs
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetRepairDTO GetRepairDTO(int id)
        {
            var repair = _context.Repairs.FirstOrDefault(c => c.ShipID == id);
            var basicRepair = _mapper.Map<GetRepairDTO>(repair);
            return basicRepair;
        }
    }
}
