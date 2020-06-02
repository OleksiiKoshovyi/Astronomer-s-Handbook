using System;
using System.Globalization;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Класс для быстрого форматирования текста
    /// </summary>
    public static class Editor
    {
        /// <summary>
        /// Преобразовывает числа с двойной точности в строку.
        /// Происходит округление.
        /// </summary>
        /// <param name="num">Число двойной точности.</param>
        /// <param name="part">Часть после запятой.</param>
        /// <returns>Строка.</returns>
        public static string Round(double num, int part)
        {
            return Math.Round(num, part).ToString();
        }

        /// <summary>
        /// Преобразовывает число двойной точности в строку.
        /// Разделитель дробной части берётся по умолчанию.
        /// </summary>
        /// <param name="num">Число двойно точности.</param>
        /// <returns>Строка.</returns>
        public static string ToString(double num)
        {
            return num.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Преобразовывает текст в число двойной точности.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns>Число двойной точности.</returns>
        public static double ToDouble(string text)
        {
            try
            {
                return double.Parse(text, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                IO.ShowErrorMessage(ex.Message,
                    "Ошибка конвертации");
                return 0;
            }

        }

    }
}
