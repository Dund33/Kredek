using LukaszDrozdzLab7Homework.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Services
{
    public interface IRepairService
    {
       GetRepairDTO GetRepairDTO(int id);
        
    }
}
