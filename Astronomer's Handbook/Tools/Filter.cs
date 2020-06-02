using System.Collections.Generic;
using System.Linq;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Представляет константы и статические методы
    /// для Фильтрации поиска.
    /// </summary>
    public static class Filter
    {
        /// <summary>
        /// Выполняет фильтрацию списка звёзд.
        /// </summary>
        /// <param name="sky">Небо.</param>
        /// <param name="human">Наблюдатель.</param>
        /// <param name="isOnlyVisible">поиск видимых звёзд.</param>
        /// <param name="index">Индекс фильтра сортировки.</param>
        /// <param name="search">Поисковой запрос.</param>
        /// <returns>Отфильтрованный список звёзд.</returns>
        public static List<Star> FilterStars(
            Sky sky, Human human,
            bool isOnlyVisible,
            int index, string search = "")
        {
            List<Star> stars;

            // Параметр: только видимые.
            if (isOnlyVisible)
            {
                stars = GetVisibleStars(sky.Constellations, human);
            }
            else
            {
                stars = GetStarsFromConstellations(sky.Constellations);
            }

            if (!string.IsNullOrEmpty(search))
            {
                stars = WhereEquals(stars, search);
            }

            return OrderBy(stars, index);

        }

        /// <summary>
        /// Выполняет фильтрацию списка созвездий.
        /// </summary>
        /// <param name="sky">Небо.</param>
        /// <param name="human">Наблюдатель.</param>
        /// <param name="isOnlyVisible">поиск видимых созвездий.</param>
        /// <param name="index">Индекс фильтра сортировки.</param>
        /// <param name="search">Поисковой запрос.</param>
        /// <returns>Отфильтрованный список созвездий.</returns>
        public static List<Constellation> FilterConstellations(
            Sky sky, Human human,
            bool isOnlyVisible,
            int index, string search = "")
        {
            List<Constellation> conses = sky.Constellations;

            // Параметр: только видимые.
            if (isOnlyVisible)
            {
                conses = GetVisibleConstellation(sky.Constellations, human);
            }

            if (!string.IsNullOrEmpty(search))
            {
                conses = WhereEquals(conses, search);
            }

            return OrderBy(conses, index);
        }

        #region Searching

        /// <summary>
        /// Настройки панели фильтров.
        /// </summary>
        public static List<string> listSortedBy =
            new List<string>() { "Алфавит", "Яркость" };       

        /// <summary>
        /// Сортирует список по алфавиту.
        /// </summary>
        /// <typeparam name="T">Тип данных списка.</typeparam>
        /// <param name="list">Список.</param>
        /// <returns>Отсортированный список</returns>
        public static List<T> OrderByAlphabet<T>(List<T> list)
        {
            return list.OrderBy(t => t.ToString()).ToList();
        }

        /// <summary>
        /// Сортирует звёзды по яркости.
        /// </summary>
        /// <param name="list">Список со звёздами.</param>
        /// <returns>Отсортированный список со звёздами.</returns>
        public static List<Star> OrderByLuminosity(List<Star> list)
        {
            // Чем ярче объект, тем меньше го звёздная величина.
            return list.OrderBy(s => s.Magnitude).ToList();
        }

        /// <summary>
        /// Сортирует созвездия по яркости.
        /// </summary>
        /// <param name="list">Список созвездий.</param>
        /// <returns>Отсортированный список созвездий.</returns>
        public static List<Constellation> OrderByLuminosity(
            List<Constellation> list)
        {
            return list.OrderBy(c => c.GetSumMagnitude()).ToList();
        }

        /// <summary>
        /// Сортирует список звёзд по указаному образцу.
        /// </summary>
        /// <param name="list">Список звёзд.</param>
        /// <param name="index">Индекс фильтра сортировки.</param>
        /// <returns>Отсортированный список звёзд.</returns>
        public static List<Star> OrderBy(List<Star> list, int index)
        {
            if (list.Count == 0)
                return list;

            switch (index)
            {           
                case 0:
                    return OrderByAlphabet(list);
                case 1:
                    return OrderByLuminosity(list);
                default:
                    return list;
            }
        }

        /// <summary>
        /// Сортирует список созвездий по указаному образцу.
        /// </summary>
        /// <param name="list">Список созвездий.</param>
        /// <param name="index">Индекс фильтра сортировки.</param>
        /// <returns>Отсортированный список созвездий.</returns>
        public static List<Constellation> OrderBy(
            List<Constellation> list,
            int index)
        {
            if (list.Count == 0)
                return list;

            switch (index)
            {
                case 0:
                    return OrderByAlphabet(list);
                case 1:
                    return OrderByLuminosity(list);
                default:
                    return list;
            }
        }

        /// <summary>
        /// Возвращает список,
        /// елементы которого в виде текста совпадают с поисковой строкой.
        /// </summary>
        /// <typeparam name="T">Тип элементов списка.</typeparam>
        /// <param name="list">Список.</param>
        /// <param name="search">Поисковая строка.</param>
        /// <returns>Отфильтрованный список.</returns>
        public static List<T> WhereEquals<T>(List<T> list, string search)
        {
            search = search.ToLower();
            return list.Where(
                s => s.ToString().ToLower().Contains(search)).ToList();
        }

        #endregion

        /// <summary>
        /// Возвращает список всех звёзд из коллекции созвездий.
        /// </summary>
        /// <param name="list">Список созвездий</param>
        /// <returns>Список звёзд</returns>
        public static List<Star> GetStarsFromConstellations(
            List<Constellation> constellations)
        {
            return constellations.SelectMany(c => c.Stars).ToList();
        }

        /// <summary>
        /// Возвращает созвездие, соответствующее данной звезде.
        /// </summary>
        /// <param name="star">Звезда.</param>
        /// <param name="sky">Небо.</param>
        /// <returns>Соответствующее созвездие.</returns>
        public static Constellation GetConstellationFromStar(Star star, Sky sky)
        {
            foreach (Constellation c in sky.Constellations)
            {
                foreach (Star s in c)
                {
                    if(ReferenceEquals(s, star))
                    {
                        return c;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Возвращает список видимых созвездий.
        /// </summary>
        /// <param name="list">Список созвездий.</param>
        /// <param name="human">Наблюдатель.</param>
        /// <returns>Список видимых созвездий.</returns>
        public static List<Constellation> GetVisibleConstellation(
            List<Constellation> list, Human human)
        {
            return list.Where(c => c.IsVisible(human)).ToList();
        }

        /// <summary>
        /// Возвращаетсписок видимых звёзд.
        /// </summary>
        /// <param name="list">Список звёзд.</param>
        /// <param name="human">Наблюдатель.</param>
        /// <returns>Список видимых звёзд.</returns>
        public static List<Star> GetVisibleStars(
           List<Constellation> list, Human human)
        {
            return GetStarsFromConstellations(list)
                .Where(s => s.IsVisible(human))
                .ToList();
        }

    }
}
