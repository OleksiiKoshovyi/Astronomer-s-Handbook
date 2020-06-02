using Astronomer_s_Handbook.Coordinates;
using System;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Представляет модель наблюдателя. 
    /// Имеет текущее время и местоположение.
    /// </summary>
    public class Human
    {
        /// <summary>
        /// Текущее время.
        /// </summary>
        public DateTime LocalTime;
        /// <summary>
        /// Местоположение.
        /// </summary>
        public GeographicCS Location;

        public Human() :this(new DateTime(), new GeographicCS()) { }

        public Human(DateTime dateTime, GeographicCS location)
        {
            LocalTime = dateTime;
            Location = location;
        }

        /// <summary>
        /// Текущее время по UTC
        /// </summary>
        public DateTime UTC
        {
            get => LocalTime.ToUniversalTime();
            set => LocalTime = value.ToLocalTime();
        }
    }
}
