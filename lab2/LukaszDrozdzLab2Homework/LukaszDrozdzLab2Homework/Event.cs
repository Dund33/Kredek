using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab2Homework
{
    abstract class Event
    {
        /// <summary>
        /// loss caused by the event
        /// </summary>
        protected float loss;

        /// <summary>
        /// descriptionof the event
        /// </summary>
        protected string description;

        /// <summary>
        /// Title of the event
        /// </summary>
        protected string title;

        /// <summary>
        /// Resource 
        /// </summary>
        protected Resource resource;

        /// <summary>
        /// Function checking if the event should take place
        /// </summary>
        public abstract void CheckConditions();

        /// <summary>
        /// The constructor
        /// </summary>
        public Event(Resource resource, string title, string description, float loss)
        {
            this.resource = resource;
            this.loss = loss;
            this.description = description;
            this.title = title;
        }

        /// <summary>
        /// Function applying the event
        /// </summary>
        protected void Apply()
        {
            resource.Amount -= (uint)(resource.Amount * loss);
            SystemSounds.Asterisk.Play();
            MessageBox.Show(description, title);
        }
    }
}
