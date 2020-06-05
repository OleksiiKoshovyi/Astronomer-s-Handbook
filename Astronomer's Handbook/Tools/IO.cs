using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Astronomer_s_Handbook
{
    /// <summary>
    /// Класс для взаимодействя с внешними файлами
    /// </summary>
    class IO
    {

        /// <summary>
        /// Получить объект, сериализированный из json в текстовом файле.
        /// </summary>
        /// <typeparam name="T">Тип получаемого объекта.</typeparam>
        /// <param name="filename">Название текстового файла.</param>
        /// <param name="obj">Изменяемый объект.</param>
        public static bool UploadData<T>(string filename, ref T obj)
        {
            // Если такого файла нет, выходим из функции.
            if (!File.Exists($"{filename}.txt"))
                return false;
            TextReader reader = new StreamReader($"{filename}.txt");

            try
            {
                // Считываем весь текст из фала.
                string json = reader.ReadToEnd();
                if (json == "")
                    return false;


                // Десериализируем json в объект T.
                T result = JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Arrays
                });

                // Проверка на null.
                if (!ReferenceEquals(result, null))
                    obj = result;

                return true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message,
                    "Ошибка получения данных");
                return false;
            }
            finally
            {
                // В любом случае выполнения закрываем соединение с файлом.
                reader.Close();
            }
        }

        /// <summary>
        /// Сериализует объект в json и записывает в текстовый файл.
        /// </summary>
        /// <typeparam name="T">Тип сохраняемого объекта</typeparam>
        /// <param name="filename">Название файла,
        /// в который сохраняется json.</param>
        /// <param name="obj">Сохраняемый объект.</param>
        public static bool SaveData(
            string filename,
            object obj,
            bool isOkShown = true,
            bool isErrorShown = true)
        {
            // Если файл не существует, создаём его.
            if (!File.Exists($"{filename}.txt"))
                File.Create($"{filename}.txt");

            TextWriter writer = new StreamWriter($"{filename}.txt");

            // Сериализируем объект типа T в json.
            string json = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Arrays
            });


            try
            {
                // Записываем весь текст в файл.
                writer.Write(json);
                if (isOkShown)
                {
                    MessageBox.Show("Данные успешно сохранены",
                        "Результат сохранения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                if (isErrorShown)
                {
                    ShowErrorMessage(ex.Message,
                        "Ошибка сохранения данных");
                }
                return false;
            }
            finally
            {
                // При любом результате операции закрываем соединение с файлом.
                writer.Close();
            }
        }

        /// <summary>
        /// Асинхронная загрузка изображения в PictureBox.
        /// </summary>
        /// <param name="url">Ссылка на изображение.</param>
        /// <param name="pBox">PictureBox.</param>
        public static bool LoadImage(string url, PictureBox pBox, 
            bool isErrorShown = true)
        {
            if (!CheckForInternetConnection(isErrorShown))
                return false;
            try
            {
                pBox.LoadAsync(url);
                return true;
            }
            catch (Exception ex)
            {
                if(isErrorShown)
                    ShowErrorMessage(ex.Message, "Ошибка загрузки изображения");
                return false;
            }
        }

        /// <summary>
        /// Возвращает состояние подключения к интернету.
        /// </summary>
        /// <returns>Состояние подключения к интернету.</returns>
        public static bool CheckForInternetConnection(bool isErrorShown = true)
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch(Exception ex)
            {
                if (isErrorShown)
                {
                    ShowErrorMessage(ex.Message, "Отсутствует интернет-соединение");
                }

                return false;
            }
        }

        /// <summary>
        /// Отображает сообщение об ошибке.
        /// </summary>
        /// <param name="message">Сообщение об ошибке.</param>
        /// <param name="title">Заголовок ошибки.</param>
        public static void ShowErrorMessage(string message, string title)
        {
            MessageBox.Show(message,
                   title,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

    }
}
