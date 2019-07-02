using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszDrozdzLab2
{
    public class Triangle : Shape, IResizeable
    {
        float size2;

        public override float Area()
        {
            return size * size2 / 2;
        }

        public override void ChangeSize()
        {
            size = float.Parse(Prompt.ShowDialog("size1","size1"));
            size2 = float.Parse(Prompt.ShowDialog("size2", "size2"));
        }

        public Triangle(float size2=1): base()
        {
            this.size2 = size2;
        }


        public override float Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
