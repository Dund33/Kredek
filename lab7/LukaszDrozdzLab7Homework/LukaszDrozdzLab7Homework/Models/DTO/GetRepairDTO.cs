using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab7Homework.Models.DTO
{
    public class GetRepairDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int ShipID { get; set; }
        public DateTime Date { get; set; }
    }
}
