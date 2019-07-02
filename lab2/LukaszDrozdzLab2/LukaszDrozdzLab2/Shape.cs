using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszDrozdzLab2
{
    /// <summary>
    /// Class shape
    /// </summary>
    public abstract class Shape : IResizeable
    {
        /// <summary>
        /// No idea what to write. It'a a sort of sizey thing ain't it?
        /// </summary>
        protected float size;
        /// <summary>
        /// Calculates the area
        /// </summary>
        /// <returns></returns>
        public abstract float Area();

        public abstract void ChangeSize();

        public abstract float Perimeter();
       
    }
}
