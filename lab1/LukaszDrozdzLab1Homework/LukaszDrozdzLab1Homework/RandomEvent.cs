using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszDrozdzLab1Homework
{
    class RandomEvent
    {
        /// <summary>
        /// Array containing loss coefficients of the resources. 
        /// </summary>
        public double[] Losses { get; set; }

        /// <summary>
        /// Unique ID of the event.
        /// </summary>
        public int SpecificNumber { get; set; }

        /// <summary>
        /// Description of the event.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The title of the event.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Constructs a new object of the type RandomEvent
        /// </summary>
        /// <param name="losses">Losses coefficients array</param>
        /// <param name="specificNumber">Unique ID</param>
        /// <param name="title">Title displayed in the MessageBox</param>
        /// <param name="description">Description displayed in the MessageBox</param>
        public RandomEvent(double[] losses, int specificNumber, string title, string description)
        {
            Losses = losses;
            SpecificNumber = specificNumber;
            Title = title;
            Description = description;
        }
    }
}
