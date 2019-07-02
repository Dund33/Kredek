using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LukaszDrozdzLab7Homework.Models;
using LukaszDrozdzLab7Homework.Models.DTO;

namespace LukaszDrozdzLab7Homework.Services
{
    public class CruiserService : ICruiserService
    {
        private readonly StarFleet _context;
        private readonly IMapper _mapper;

        public CruiserService(StarFleet context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get some basic info about a cruiser
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetBasicCruiserDTO GetBasicCruiserDTO(int id)
        {
            var cruiser = _context.Cruisers.FirstOrDefault(c => c.ID == id);
            var basicCruiser = _mapper.Map<GetBasicCruiserDTO>(cruiser);
            Console.WriteLine("Doing basic cruiser");
            return basicCruiser;
        }

        /// <summary>
        /// Get full info about a cruiser
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetFullCruiserDTO GetFullCruiserDTO(int id)
        {
            var cruiser = _context.Cruisers.FirstOrDefault(c => c.ID == id);
            var fullCruiser = _mapper.Map<GetFullCruiserDTO>(cruiser);
            Console.WriteLine("Doing full cruiser");
            return fullCruiser;
        }
    }
}
