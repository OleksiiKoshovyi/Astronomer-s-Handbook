using Astronomer_s_Handbook.Coordinates;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Звезда. Содержит свойства характерные звёздам.
    /// </summary>
    public class Star 
    {
        /// <summary>
        /// Название звезды
        /// </summary>
        public string Name;
        /// <summary>
        /// Ссылка на изображение звезды
        /// </summary>
        public string Url;
        /// <summary>
        /// Относительная звёздная величина
        /// </summary>
        public double Magnitude;
        /// <summary>
        /// Расстояние до звезды в парсеках
        /// </summary>
        public double Distance;
        /// <summary>
        /// Местоположение в экваториальной системе координат
        /// </summary>
        public EquatorialCS Location;

        public Star()
        {
            Location = new EquatorialCS();
            Magnitude = 0;
            Distance = 10;
        }

        public Star(EquatorialCS location, string name,
            double magnitude, double distance, string url = "")
        {
            Location = location;
            Name = name;
            Url = url;
            Magnitude = magnitude;
            Distance = distance;
        }

        /// <summary>
        /// Абсолютная звёздная величина
        /// </summary>
        public double AbsMagnitude
        {
            get => AstroMath.GetAbsMagnitude(Distance, Magnitude);
        }

        /// <summary>
        /// Указывает, видно ли данную звезду в заданных месте и времени
        /// </summary>
        /// <param name="horizontal">Текущее местоположение</param>
        /// <param name="date">Заданные дата и время</param>
        /// <returns>Возвращает видимость звезды на небе</returns>
        public bool IsVisible(Human human)
        {
            return AstroMath.IsStarVisible(this, human);
        }

        /// <summary>
        /// Указывает, видно ли звезду в заданном месте когда-нибудь
        /// </summary>
        /// <param name="horizontal">Текущее местоположение</param>
        /// <returns>Возвращает возможность видимости звезды</returns>
        public bool IsEverVisible(Human human)
        {
            return AstroMath.IsEverVisible(this, human);
        }

        /// <summary>
        /// Указывает, видно ли звезду в заданном месте всегда
        /// </summary>
        /// <param name="geographic">Текущее местоположение</param>
        /// <returns>Возвращает постоянность видимости звезды</returns>
        public bool IsAlwaysVisible(Human human)
        {
            return AstroMath.IsAlwaysVisible(this, human);
        }

        /// <summary>
        /// Возвращает положение звезды на небе наблюдателя.
        /// </summary>
        /// <param name="human">Наблюдатель</param>
        /// <returns>Положение звезды на небе наблюдателя.</returns>
        public HorizontalCS GetCurrLocation(Human human)
        {
            return AstroMath.GetCurrentStarLocation(this, human);
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? "Неизвестная звезда" : Name;
        }

    }
}
