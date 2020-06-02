using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomer_s_Handbook.Coordinates
{
    /// <summary>
    /// Система координат. Включает в себя два вида координат:
    /// горизонтальные и вертикальные
    /// </summary>
    public abstract class CoordinateSystem
    {

        public CoordinateSystem()
        {
            vertical = new VerticalCord();
            horizontal = new HorizontalCord();
        }

        public CoordinateSystem(VerticalCord v, HorizontalCord h)
        {
            vertical = v;
            horizontal = h;
        }

        protected VerticalCord vertical;
        protected HorizontalCord horizontal;
    }
}
