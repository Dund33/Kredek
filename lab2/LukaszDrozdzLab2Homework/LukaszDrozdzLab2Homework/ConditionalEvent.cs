using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszDrozdzLab2Homework
{
    /// <summary>
    /// Class representing conditional event
    /// </summary>
    class ConditionalEvent : Event
    {
        /// <summary>
        /// Triggering threshold
        /// </summary>
        private uint threshold;

        /// <summary>
        /// The constructor
        /// </summary>
        public ConditionalEvent(Resource resource, string title, string description, float loss, uint threshold)
            :base(resource, title, description, loss)
        {
            this.threshold = threshold;
        }

        /// <summary>
        /// Check if the event should take place
        /// </summary>
        public override void CheckConditions()
        {
            if (resource.Amount >= threshold)
            {
                Apply();
            }
        }
    }
}
