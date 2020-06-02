using System;

namespace Astronomer_s_Handbook.Coordinates
{
    /// <summary>
    /// Географическая система координат.
    /// Показывает положение человека относительно сторон света.
    /// </summary>
    public class GeographicCS : CoordinateSystem
    {
        public GeographicCS() :base() { }

        public GeographicCS(VerticalCord vertical,
            HorizontalCord horizontal) :base(vertical, horizontal) { }

        /// <summary>
        /// Долгота.
        /// Угол от Гринвича до меридиана местности.
        /// </summary>
        public HorizontalCord Longitude
        {
            get => horizontal;
            set => horizontal = value;
        }
        /// <summary>
        /// Широта.
        /// Угол от Экватора до параллели местности.
        /// </summary>
        public VerticalCord Latitude
        {
            get => vertical;
            set => vertical = value;
        }
    }
}
