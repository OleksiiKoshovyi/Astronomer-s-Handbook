using System;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Координаты на сферической карте
    /// </summary>
    public abstract class Coordinate
    {
        private int degrees;
        private int minutes;
        private int seconds;

        public Coordinate() :this(0,0,0)
        {

        }

        public Coordinate(int d, int m, int s)
        {
            Degrees = d;
            Minutes = m;
            Seconds = s;
        }

        public Coordinate(double seconds)
        {
            double deg = Math.Floor(AstroMath.GetDegFromSeconds(seconds));
            seconds -= AstroMath.GetSecondsFromGeg(deg);

            double min = Math.Floor(AstroMath.GetMinFromSeconds(seconds));
            seconds -= AstroMath.GetSecondsFromMin(min);

            degrees = (int)deg;
            Minutes = (int)min;
            Seconds = (int)seconds;
        }

        public int Degrees 
        {
            get => degrees;
            set => degrees = ValidateDegrees(value);
        }
        public int Minutes 
        {
            get => minutes;
            set => minutes = ValidateCoordinate(value);
        }
        public int Seconds
        {
            get => seconds;
            set => seconds = ValidateCoordinate(value);
        }

        /// <summary>
        /// Возвращает величину угла в секундах
        /// </summary>
        /// <returns>Величина угла в секундах</returns>
        public int GetSeconds()
        {
            // Коэффициент сохранения знака.
            int k = 1;
            if (degrees != 0)
                k = degrees / Math.Abs(degrees);

            return k * (Math.Abs(degrees) * 3600 + minutes * 60 + seconds);
        }

        public double getMinutes()
        {
            return (double)GetSeconds() / 60;
        }

        public double GetDegrees()
        {
            return (double)GetSeconds() / 3600;
        }

        #region Перегрузка операторов

        public static bool operator >(Coordinate v1, Coordinate v2)
        {
            return v1.GetSeconds() > v2.GetSeconds();
        }

        public static bool operator <(Coordinate v1, Coordinate v2)
        {
            return v1.GetSeconds() < v2.GetSeconds();
        }

        public static bool operator ==(Coordinate v1, Coordinate v2)
        {
            return v1.GetSeconds() == v2.GetSeconds();
        }

        public static bool operator !=(Coordinate v1, Coordinate v2)
        {
            return v1.GetSeconds() != v2.GetSeconds();
        }

        #endregion

        #region Переопределение методов объекта

        public override int GetHashCode()
        {
            return GetSeconds();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !obj.GetType().Equals(GetType()))
                return false;
            return ((Coordinate)obj).GetSeconds() == GetSeconds();
        }

        public override string ToString()
        {
            return $"{Degrees}°{Minutes}\'{Seconds}\'\'";
        }

        #endregion

        protected virtual int ValidateDegrees(int value)
        {
            return value;
        }

        private int ValidateCoordinate(int value)
        {
            return (value < 0) ? 0 : (value > 59) ? 59 : value;
        }
    }
}
