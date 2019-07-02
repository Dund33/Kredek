using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LukaszDrozdzLab7Homework.Models;
using LukaszDrozdzLab7Homework.Models.DTO;

namespace LukaszDrozdzLab7Homework.Services
{
    public class DestroyerService : IDestroyerService
    {
        private readonly StarFleet _context;
        private readonly IMapper _mapper;

        public DestroyerService(StarFleet context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get basic info about a destroyer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetBasicDestroyerDTO GetBasicDestroyerDTO(int id)
        {
            var destroyer = _context.Destroyers.FirstOrDefault(c => c.ID == id);
            var basicDestroyer = _mapper.Map<GetBasicDestroyerDTO>(destroyer);
            return basicDestroyer;
        }

        /// <summary>
        /// Get full info about a destroyer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetFullDestroyerDTO GetFullDestroyerDTO(int id)
        {
            var destroyer = _context.Destroyers.FirstOrDefault(c => c.ID == id);
            var fullDestroyer = _mapper.Map<GetFullDestroyerDTO>(destroyer);
            return fullDestroyer;
        }
    }
}
