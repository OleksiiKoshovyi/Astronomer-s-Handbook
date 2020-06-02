using System;

namespace Astronomer_s_Handbook.Coordinates
{
    /// <summary>
    /// Горизонтальная система координат.
    /// Показывает положение звёзд относительно наблюдателя на земле.
    /// </summary>
    public class HorizontalCS : CoordinateSystem
    {
        public HorizontalCS() : base() { }

        public HorizontalCS(VerticalCord vertical,
            HorizontalCord horizontal) : base(vertical, horizontal) { }

        /// <summary>
        /// Азимут. Угол от Северного полюса по часовой стрелке.
        /// </summary>
        public HorizontalCord Azimuth
        {
            get => horizontal;
            set => horizontal = value;
        }
        /// <summary>
        /// Высота над горизонтом.
        /// </summary>
        public VerticalCord Altitude
        {
            get => vertical;
            set => vertical = value;
        }
    }
}
