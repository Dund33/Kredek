using LukaszDrozdzLab7.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7.Services
{
    public interface IJumperService
    {
        GetStatisticJumperDTO GetStatisticJumper(int id);
    }
}
