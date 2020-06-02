using System;

namespace Astronomer_s_Handbook.Coordinates
{
    /// <summary>
    /// Первая экваториальная система координат.
    /// Показывает положение звёзд относительно небесного экватора 
    /// и точки весеннего равноденствия.
    /// </summary>
    public class EquatorialCS : CoordinateSystem
    {
        public EquatorialCS() : base() { }

        public EquatorialCS(VerticalCord vertical,
            HorizontalCord horizontal) : base(vertical, horizontal) { }

        /// <summary>
        /// Прямое восхождение.
        /// Угол между точкой весеннего равноденствия и звездой.
        /// </summary>
        public HorizontalCord RightAscension 
        {
            get => horizontal;
            set => horizontal = value;
        }
        /// <summary>
        /// Склонение.
        /// Угол от экватора до звезды в направлении к полюсу.
        /// </summary>
        public VerticalCord Declination 
        {
            get => vertical;
            set => vertical = value;
        }
    }
}
