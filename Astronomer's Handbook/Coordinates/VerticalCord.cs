using System;

namespace Astronomer_s_Handbook.Coordinates
{
    /// <summary>
    /// Вертикальные координаты. Для положения между полюсами
    /// </summary>
    public class VerticalCord : Coordinate
    {
        public VerticalCord() : base() { }

        public VerticalCord(int d, int m, int s) : base(d,m,s) { }

        public VerticalCord(double seconds) 
        {
            // Предотвращаем выход за границы.
            if (Math.Abs(seconds) > AstroMath.SECONDS_IN_90_DEGREE)
            {
                // Знак числа.
                double k = Math.Abs(seconds) / seconds;
                seconds = k * AstroMath.SECONDS_IN_90_DEGREE - seconds
                    % AstroMath.SECONDS_IN_90_DEGREE;
            }

            // Получаем градусы из секунд.
            int deg = (int)Math.Floor(seconds + AstroMath.SECONDS_IN_90_DEGREE)
                / AstroMath.SECONDS_IN_DEGREE - 90;
            seconds -= deg * AstroMath.SECONDS_IN_DEGREE;
            seconds = Math.Abs(seconds);

            // Получаем минуты из секунд.
            int min = (int)Math.Floor(seconds)
                / AstroMath.SECONDS_IN_DEGREE;
            seconds -= min * AstroMath.SECONDS_IN_MINUTE;

            // Заполняем свойства результатами.
            Degrees = deg;
            Minutes = min;
            Seconds = (int)seconds;
        }

        public static VerticalCord GetMax()
        {
            return new VerticalCord(90, 0, 0);
        }

        public static VerticalCord GetMin()
        {
            return new VerticalCord(-90, 0, 0);
        }

        #region Перегрузка операторов

        public static VerticalCord operator -(VerticalCord v1, VerticalCord v2)
        {
            double s1 = v1.GetSeconds();
            double s2 = v2.GetSeconds();
            double delta = s1 - s2;
            return new VerticalCord(delta);
        }

        public static VerticalCord operator +(VerticalCord v1, VerticalCord v2)
        {
            double s1 = v1.GetSeconds();
            double s2 = v2.GetSeconds();
            double delta = s1 + s2;
            return new VerticalCord(delta);
        }

        public static VerticalCord operator *(VerticalCord v, int sign)
        {
            if (sign < 0)
                return new VerticalCord(-1 * v.Degrees, v.Minutes, v.Seconds);
            else
                return v;
        }

        #endregion

        protected override int ValidateDegrees(int value)
        {
            return (value < -90) ? -90 : (value > 90) ? 90 : value;
        }
    }
}
