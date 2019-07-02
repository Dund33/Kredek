using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab2Homework
{
    /// <summary>
    /// Class container for estates
    /// </summary>
    public class Estate : Resource
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        public Estate(uint initialAmount, uint cost)
           : base(initialAmount, 0, cost, 0)
        {}

       
        //We cant upgrade estates
        public override void Upgrade()
        {
            //Do nothing
        }

        //Theres no generation rate anymore
        public override void RefreshLabels()
        {
            NumberLabel.Text = Amount.ToString();
        }
    }
}
