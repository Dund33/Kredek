using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab2Homework
{
    /// <summary>
    /// Class container for floors
    /// </summary>
    public class Floor : Resource, IGenerated
    {
        /// <summary>
        /// Constuctor
        /// </summary>
        public Floor(uint initialAmount, uint generationRate, uint cost, uint updateCost)
           : base(initialAmount, generationRate, cost, updateCost)
        {}

    }
}
