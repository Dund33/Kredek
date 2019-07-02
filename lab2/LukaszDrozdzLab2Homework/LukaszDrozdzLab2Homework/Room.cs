using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab2Homework
{
    /// <summary>
    /// Class container for rooms
    /// </summary>
    public class Room :Resource, IGenerated
    {
        public Room(uint initialAmount, uint generationRate, uint cost, uint upgradeCost)
           : base(initialAmount, generationRate, cost, upgradeCost)
        {}
        
    }
}
