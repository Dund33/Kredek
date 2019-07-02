using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszDrozdzLab2
{
    public class Circle : Shape
    {
        public Circle(float radius = 1)
        {
            size = radius;
        }
        /// <summary>
        /// Calculates da area of da circle
        /// </summary>
        /// <returns>Da area of da circle</returns>
        public override float Area()
        {
            return (float)Math.PI * size * size;
        }

        public override void ChangeSize()
        {
            string input = Prompt.ShowDialog("Change size", "Enter new side lenght");
            size = float.Parse(input);
        }

        /// <summary>
        /// Default ToString override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "CIRCLEEEE REEEEE";
        }

        public override float Perimeter()
        {
            return (float)Math.PI * size;
        }
    }
}
