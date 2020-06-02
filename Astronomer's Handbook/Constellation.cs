using System.Collections.Generic;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Созвездие. Содержит коллекцию звёзд.
    /// </summary>
    public class Constellation
    {
        /// <summary>
        /// Коллекция звёзд.
        /// </summary>
        public List<Star> Stars;
        /// <summary>
        /// Название созвездия.
        /// </summary>
        public string Name;
        /// <summary>
        /// Ссылка на изображение созвездия.
        /// </summary>
        public string Url;
        public Constellation() : this(new List<Star>(), "")
        {

        }

        public Constellation(List<Star> stars, string name, string url ="")
        {
            Stars = stars;
            Name = name;
            Url = url;
        }

        public double Magnitude { get => GetSumMagnitude();}

        /// <summary>
        /// Вычисляет суммарную звёздную величину скопления объектов.
        /// При расчёте учитывается, что звёздная величина 
        /// имеет логарифмическую зависимость от яркости.
        /// </summary>
        /// <returns>Суммарная звёздная величина созвездия.</returns>
        public double GetSumMagnitude()
        {
            if (Stars.Count == 0)
                return int.MaxValue;

            double seed = 0;

            foreach (Star star in Stars)
            {
                seed += AstroMath.GetRelativeLuminosity(star.Magnitude);
            }

            return AstroMath.GetMagnitudeFromRelLuminosity(seed);
        }

        /// <summary>
        /// Возвращает видимость созвездия.
        /// Созвездие видимо, если хотя бы одна звезда из него
        /// находится над горизонтом.
        /// </summary>
        /// <param name="h">Наблюдатель.</param>
        /// <returns>Видимость созвездия.</returns>
        public bool IsVisible(Human h)
        {
            foreach (Star star in Stars)
            {
                if (star.IsVisible(h))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Возвращает перечисление звёзд в созвездии.
        /// </summary>
        /// <returns>Перечисление звёзд в созвездии.</returns>
        public IEnumerator<Star> GetEnumerator()
        {
            return Stars.GetEnumerator();
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? "Неизвестное созвездие" : Name;
        }
    }
}
