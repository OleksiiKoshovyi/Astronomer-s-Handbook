using Astronomer_s_Handbook.Coordinates;
using System;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Представляет константы и статические методы
    /// для астрономических вычислений.
    /// </summary>
    static class AstroMath
    {

        #region Константы величин

        /// <summary>
        /// Количество километров в световом годе
        /// </summary>
        public const double KILOMETRS_IN_LIGHT_YEARS = 9467280000000;
        /// <summary>
        /// Количество световых лет в парсеке
        /// </summary>
        public const double LIGHT_YEARS_IN_PARSEC = 3.26156;
        /// <summary>
        /// Количество километров в парсеках
        /// </summary>
        public const double KILOMETRS_IN_PARSEC = 30878101756800;

        /// <summary>
        /// Количество секунд в 90 градусах.
        /// </summary>
        public const int SECONDS_IN_90_DEGREE = 3600*90;
        /// <summary>
        /// Количество секунд в 1 градусе.
        /// </summary>
        public const int SECONDS_IN_DEGREE = 3600;
        /// <summary>
        /// Количество секунд в 1 минуте.
        /// </summary>
        public const int SECONDS_IN_MINUTE = 60;

        /// <summary>
        /// Количество градусов в 1 радиане
        /// </summary>
        public const double DEGREES_IN_RADIAN = 180/Math.PI;

        #endregion

        #region Звёздная величина и яркость

        /// <summary>
        /// Считает абсолютную звёздную величину
        /// </summary>
        /// <param name="distance">Расстояние до звезды в парсеках</param>
        /// <param name="magnitude">Звёздная величина</param>
        /// <returns>Абсолютная звёздная величина</returns>
        public static double GetAbsMagnitude(double distance, double magnitude)
        {
            // Формула Погсона для абсолютной звёздной величины
            return magnitude - 5 * Math.Log10(distance / 10);
        }

        /// <summary>
        /// Вычисляет, во сколько раз ярче звёзды,
        /// разница звёздных величин которых равна 1
        /// </summary>
        /// <returns>Отношение яркостей соседних
        /// по величине магнитуды звёзд</returns>
        public static double GetMagnitudeStep()
        {
            return Math.Pow(10.0, 0.4);
        }

        /// <summary>
        /// Вычисляет яркость звезды по отношению яркости звезды 0m
        /// </summary>
        /// <param name="magmitude">Звёздная величина звезды</param>
        /// <returns>Относительная яркость</returns>
        public static double GetRelativeLuminosity(double magmitude)
        {
            return Math.Pow(GetMagnitudeStep(), -magmitude);
        }

        /// <summary>
        /// Вычисляет звёздную величину объекта
        /// с заданной относительной яркостью
        /// </summary>
        /// <param name="relLum">Относительная яркость > 0</param>
        /// <returns>Звёздная величина</returns>
        public static double GetMagnitudeFromRelLuminosity(double relLum)
        {
            if (relLum <= 0)
                throw new InvalidOperationException();
            return -Math.Log(relLum,GetMagnitudeStep());
        }

        #endregion

        #region Конвертер расстояний

        /// <summary>
        /// Переводит расстояние в парсеки из километров.
        /// </summary>
        /// <param name="km">Расстояние в километрах.</param>
        /// <returns>Расстояние в парсеках.</returns>
        public static double GetPсFromKm(double km)
        {
            return km / KILOMETRS_IN_PARSEC;
        }

        /// <summary>
        /// Переводит расстояние в парсеки из световых лет.
        /// </summary>
        /// <param name="ly">Расстояние в световых годах.</param>
        /// <returns>Расстояние в парсеках.</returns>
        public static double GetPсFromLy(double ly)
        {
            return ly / LIGHT_YEARS_IN_PARSEC;
        }

        /// <summary>
        /// Переводит расстояние в километры из парсеков.
        /// </summary>
        /// <param name="pc">Расстояние в парсеках.</param>
        /// <returns>Расстояние в километрах.</returns>
        public static double GetKmFromPc(double pc)
        {
            return pc * KILOMETRS_IN_PARSEC;
        }

        /// <summary>
        /// Переводит расстояние в километры из световых лет.
        /// </summary>
        /// <param name="ly">Расстояние в световых годах.</param>
        /// <returns>Расстояние в километрах.</returns>
        public static double GetKmFromLy(double ly)
        {
            return ly * KILOMETRS_IN_PARSEC / LIGHT_YEARS_IN_PARSEC;
        }

        /// <summary>
        /// Переводит расстояние в световые годы из километров.
        /// </summary>
        /// <param name="km">Расстояние в километрах.</param>
        /// <returns>Расстояние в световых годах.</returns>
        public static double GetLyFromKm(double km)
        {
            return km / KILOMETRS_IN_LIGHT_YEARS;
        }

        /// <summary>
        /// Переводит расстояние в световые годы из парсек.
        /// </summary>
        /// <param name="km">Расстояние в паресках.</param>
        /// <returns>Расстояние в световых годах.</returns>
        public static double GetLyFromPc(double pc)
        {
            return pc * LIGHT_YEARS_IN_PARSEC;
        }

        #endregion

        #region Конвертер углов

        /// <summary>
        /// Переводит угол в градусы из радиан.
        /// </summary>
        /// <param name="rad">Угол в радианах.</param>
        /// <returns>Угол в градусах</returns>
        public static double GetDegFromRad(double rad)
        {
            return rad * DEGREES_IN_RADIAN;
        }

        /// <summary>
        /// Переводит угол в радианы из градусов.
        /// </summary>
        /// <param name="deg">Угол в градусах.</param>
        /// <returns>Угол в радианах</returns>
        public static double GetRadFromDeg(double deg)
        {
            return deg / DEGREES_IN_RADIAN;
        }

        /// <summary>
        /// Переводит угол в секунды из градусов.
        /// </summary>
        /// <param name="deg">Угол в градусах.</param>
        /// <returns>Угол в градусах.</returns>
        public static double GetSecondsFromGeg(double deg)
        {
            return deg * SECONDS_IN_DEGREE;
        }

        /// <summary>
        /// Переводит угол в градусы из секунд.
        /// </summary>
        /// <param name="seconds">Угол в секундах.</param>
        /// <returns>Угол в градусах.</returns>
        public static double GetDegFromSeconds(double seconds)
        {
            return seconds / SECONDS_IN_DEGREE;
        }

        /// <summary>
        /// Переводит угол в секунды из минут.
        /// </summary>
        /// <param name="min">Угол в минутах.</param>
        /// <returns>Угол в секундах.</returns>
        public static double GetSecondsFromMin(double min)
        {
            return min * SECONDS_IN_MINUTE;
        }

        /// <summary>
        /// Переводит угол в минуты из секунд.
        /// </summary>
        /// <param name="seconds">Угол в секундах.</param>
        /// <returns>Угол в минутах.</returns>
        public static double GetMinFromSeconds(double seconds)
        {
            return seconds / SECONDS_IN_MINUTE;
        }

        #endregion

        #region Видимость звёзд

        /// <summary>
        /// Показывает, видима ли звезда для наблюдателя.
        /// </summary>
        /// <param name="s">Звезда</param>
        /// <param name="h">Наблюдатель</param>
        /// <returns>Видима ли звезда</returns>
        public static bool IsStarVisible(Star s, Human h) 
        {
            HorizontalCS horCS = GetCurrentStarLocation(s, h);

            return horCS.Altitude.GetDegrees() >= 0;
        }

        /// <summary>
        /// Показывает, видима ли звезда для наблюдателя.
        /// </summary>
        /// <param name="horCS">Горизонтальная система координат.</param>
        /// <returns>Видима ли звезда</returns>
        public static bool IsStarVisible(HorizontalCS horCS)
        {
            return horCS.Altitude.GetDegrees() >= 0;
        }

        /// <summary>
        /// Показывает, постоянно линаходится звезда над горизонтом.
        /// </summary>
        /// <param name="s">Звезда</param>
        /// <param name="gcs">Земные координаты наблюдателя</param>
        /// <returns>Постоянство нахождения над горизонтом</returns>
        public static bool IsAlwaysVisible(Star s, GeographicCS gcs)
        {
            // Широта наблюдателя.
            int degree = gcs.Latitude.Degrees;

            // Если он на экваторе, нет незаходящих звёзд.
            if (degree == 0)
                return false;

            // Координаты ближайшего полюса.
            VerticalCord vertical = (degree > 0) 
                ? VerticalCord.GetMax() 
                : VerticalCord.GetMin();

            // Минимальное склонение незаходящих звёзд.
            VerticalCord minLatitude = vertical - gcs.Latitude;

            return (degree > 0) 
                ? minLatitude < s.Location.Declination 
                : minLatitude > s.Location.Declination;
        }

        /// <summary>
        /// Показывает, постоянно линаходится звезда над горизонтом.
        /// </summary>
        /// <param name="s">Звезда</param>
        /// <param name="h">Наблюдатель</param>
        /// <returns>Постоянство нахождения над горизонтом</returns>
        public static bool IsAlwaysVisible(Star s, Human h)
        {
            return IsAlwaysVisible(s, h.Location);
        }

        /// <summary>
        /// Показывает, видно ли когда-нибудь звезду.
        /// </summary>
        /// <param name="s">Звезда.</param>
        /// <param name="gcs">Координаты наблюдателя.</param>
        /// <returns>Потенциальная видимость звезды.</returns>
        public static bool IsEverVisible(Star s, GeographicCS gcs)
        {
            // Широта наблюдателя.
            int degree = gcs.Latitude.Degrees;

            // Если он на экваторе, все звёзды когда-нибудь будут видны.
            if (degree == 0)
                return true;

            // Координаты ближайшего полюса.
            VerticalCord vertical = (degree > 0)
                ? VerticalCord.GetMax()
                : VerticalCord.GetMin();

            // Минимальная склонение видимости звёзд.
            VerticalCord minLatitude = (vertical - gcs.Latitude)*(-1);

            return (degree > 0)
                ? minLatitude < s.Location.Declination
                : minLatitude > s.Location.Declination;
        }

        /// <summary>
        /// Показывает, видно ли когда-нибудь звезду.
        /// </summary>
        /// <param name="s">Звезда.</param>
        /// <param name="h">НАблюдатель</param>
        /// <returns>Потенциальная видимость звезды.</returns>
        public static bool IsEverVisible(Star s, Human h)
        {
            return IsEverVisible(s, h.Location);
        }

        #endregion

        #region Конвертер расстояний

        /// <summary>
        /// Возвращает Юлианскую дату из Григорианской.
        /// </summary>
        /// <param name="date">Григорианская дата.</param>
        /// <returns>Юлианская дата</returns>
        public static double ToJulianDate(DateTime date)
        {
            return date.ToOADate() + 2415018.5;
        }

        /// <summary>
        /// Возвращает Модифицированную Юлианскую дату из Григорианской.
        /// </summary>
        /// <param name="date">Григорианская дата.</param>
        /// <returns>Юлианская дата</returns>
        public static double ToModJulianDate(DateTime date)
        {
            return ToJulianDate(date) - 2400000.5;
        }

        /// <summary>
        /// Вычисление гринвичского среднего звёздного времени GMST
        /// </summary>
        /// <param name="mjd">Всемирное время в Мод. Юл. дате</param>
        /// <returns>Гринвиччское среднее звёздное время</returns>
        public static double GetGMST(double mjd)
        {
            double mjd0 = Math.Floor(mjd);

            // Время, отсчитываемое в юлианских столетиях по 36525 суток 
            // в системе всемирного времени UT1 от эпохи J2000.
            double TU = (mjd0 - 51544.5) / 36525;

            double a1 = 1.753368559233266;
            double a2 = 628.3319706888409;
            double a3 = 6.770714 * Math.Pow(10, -6);
            double a4 = 4.51 * Math.Pow(10, -11);

            double S0 = a1 + a2 * TU + a3 * Math.Pow(TU, 2) - a4 * Math.Pow(TU, 3);

            double b1 = 6.300388098984891;
            double b2 = 3.707456 * Math.Pow(10, -10);
            double b3 = 3.707 * Math.Pow(10, -14);
            double r = b1 + b2 * TU - b3 * Math.Pow(TU, 2);

            // Гринвиччское среднее звёздное время в радианах.
            double S = S0 + r * (mjd - mjd0);

            // Гринвиччское среднее звёздное время в градусах.
            double deg = GetDegFromRad(S);

            return deg % 360;
        }

        #endregion

        /// <summary>
        /// Возвращает положение звезды в Горизонтальной системе координат.
        /// То есть, координаты относительно горизонта и направления на Север.
        /// </summary>
        /// <param name="s">Звезда.</param>
        /// <param name="h">Наблюдатель.</param>
        /// <returns>Координаты звезды в горизонтальной системе координат.</returns>
        public static HorizontalCS GetCurrentStarLocation(Star s, Human h)
        {
            // 1.Вычисление модифицированной юлианской даты на начало суток MD.

            // Lon – долгота наблюдателя.
            double Lon = h.Location.Longitude.GetDegrees();
            // Lat - широта.
            double Lat = h.Location.Latitude.GetDegrees();

            // Время по Гринвичу.
            DateTime utc = h.UTC;

            // Прямое восхождение звезды.
            double RA = s.Location.RightAscension.GetDegrees();
            // Склонение звезды.
            double Dec = s.Location.Declination.GetDegrees();

            // Модифицировання Юлианская дата.
            double MD = ToModJulianDate(utc);

            // 2.Вычисление местного звездного времени на момент всемирного времени UT.

            // Гринвическое среднее звездное время в градусах.
            double Sg = GetGMST(MD);
            // Местное звездное время, среднее.
            double St = Sg + Lon;

            //3.Часовой угол звезды и высота над горизонтом.

            // Часовой угол.
            double Th = (St - RA) % 360;

            // Cos(z) = Sin(Lat) * Sin(Dec) + Cos(Lat) * Cos(Dec) * Cos(Th).
            // Косинус зенитного угла.
            double z = Math.Acos(
                Math.Sin(GetRadFromDeg(Lat))
                * Math.Sin(GetRadFromDeg(Dec))
                + Math.Cos(GetRadFromDeg(Lat))
                * Math.Cos(GetRadFromDeg(Dec))
                * Math.Cos(GetRadFromDeg(Th)));

            // Перевод в секунды.
            z = GetDegFromRad(z);

            // Высота над горизонтом.
            double H = 90 - z;

            // Az = atn2(Sin(Th) * Cos(Dec), (sin(H) * Sin(Lat) - Sin(Dec)) / Cos(Lat)).
            // Азимут звезды в радианах.
            double Az = Math.Atan2(
                Math.Sin(GetRadFromDeg(Th))
                * Math.Cos(GetRadFromDeg(Dec)),
                ( Math.Sin(GetRadFromDeg(H)) * Math.Cos(GetRadFromDeg(Lat)) - Math.Sin(GetRadFromDeg(Dec)))
                / Math.Cos(GetRadFromDeg(Lat)));

            // Азимут звезды в градусах.
            double az = GetDegFromRad(Az);

            // Формируем координаты в горизонтальной системе координат.
            VerticalCord altitude = new VerticalCord(GetSecondsFromGeg(H));
            HorizontalCord azimuth = new HorizontalCord(GetSecondsFromGeg(az));

            return new HorizontalCS(altitude, azimuth);
        }

    }
}
