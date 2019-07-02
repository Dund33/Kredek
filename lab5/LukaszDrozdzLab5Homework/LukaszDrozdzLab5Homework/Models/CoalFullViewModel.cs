using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab5Homework.Models
{
    /// <summary>
    /// Class representing coal with full specification
    /// </summary>
    public class CoalFullViewModel : CoalBasicViewModel
    {
       
        //Technical properties of coal
        public double Wex { get; set; }
        public double Wa { get; set; }
        public double Wtr { get; set; }
        public double Ar { get; set; }
        public double Ad { get; set; }
        public double Str { get; set; }
        public double Std { get; set; }
        public double Vdaf { get; set; }
        public double Ri { get; set; }
        public double Qir { get; set; }
  
    }
}
