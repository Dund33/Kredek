using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LukaszDrozdzLab7.Models;
using LukaszDrozdzLab7.Models.DTO;

namespace LukaszDrozdzLab7.Services
{
    public class JumperService : IJumperService
    {
        private readonly SkiJumpingContest _context;
        private readonly IMapper _mapper;
        public JumperService(SkiJumpingContest context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GetStatisticJumperDTO GetStatisticJumper(int id)
        {
            var jumper = _context.Jumpers.FirstOrDefault(c => c.ID == id);

            var statisticDTO = _mapper.Map<GetStatisticJumperDTO>(jumper);

            return statisticDTO;
        }
    }
}
