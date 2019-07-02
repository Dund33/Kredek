using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszDrozdzLab2Homework
{
    class RandomEvent : Event
    {
        //Random generator used to determine if the event should take place
        private Random random;

        //Used to calculate the space of possibilities
        private int range;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="loss"></param>
        /// <param name="probability"></param>
        public RandomEvent(Resource resource, string title, string description, float loss, float probability)
            :base(resource, title, description, loss)
        {
            random = new Random();
            range = (int)(1 / probability);
        }

        /// <summary>
        /// Use random to determine if the event should take place
        /// </summary>
        public override void CheckConditions()
        {
            int selectedNo = random.Next(0, range);
            if (selectedNo == 1) Apply();
        }
    }
}
