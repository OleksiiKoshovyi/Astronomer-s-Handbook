using System;

namespace Astronomer_s_Handbook.Coordinates
{
    /// <summary>
    /// Горизонтальные координаты. Для параллельного экватору положения
    /// </summary>
    public class HorizontalCord : Coordinate
    {
        public HorizontalCord() : base() { }

        public HorizontalCord(int d, int m, int s) : base(d, m, s) { }

        public HorizontalCord(double seconds) :base(seconds) { }

        protected override int ValidateDegrees(int value)
        {
            return (value < 0) ? 0 : (value > 360) ? 360 : value;
        }
    }
}
