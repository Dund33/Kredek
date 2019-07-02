using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszDrozdzLab2
{
    public class Square : Shape
    {

        public Square(float size = 1)
        {
            this.size = size;
        }

        public override float Area()
        {
            return size * size;
        }

        public override void ChangeSize()
        {
            string input = Prompt.ShowDialog("Change size", "Enter new side lenght");
            size = float.Parse(input);
        }

        public override string ToString()
        {
            return "SQUAARE";
        }

        public override float Perimeter()
        {
            return 4 * size;
        }
    }
}
