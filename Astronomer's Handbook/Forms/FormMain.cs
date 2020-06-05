using Astronomer_s_Handbook.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Astronomer_s_Handbook
{
    public partial class FormMain : Form
    {
        // Небо. Хранит созвездия со звёздами.
        private Sky sky;
        // Человек. Хранит параметры наблюдателя.
        private Human human;
        // Результат фильрации поиска созвездий.
        private List<Constellation> lastConstellations;
        // Результат фильрации поиска звёзд.
        private List<Star> lastStars = new List<Star>();
        // Показывает, был ли последний поиск по звёздам.
        private bool isStarLast = false;

        public FormMain()
        {
            InitializeComponent();
            PrepareForm();
        }
   
        // Подгружает данные и задаёт начальные значения.
        private void PrepareForm()
        {
            // Асинхронно загружает изображение в PictureBox.
            IO.LoadImage(Properties.Resources.UrlRightPanel, pBoxRightPanel, false);

            sky = new Sky();
            // Подгружаем сохранённое небо.
            IO.UploadData(Properties.Resources.SkyFileName, ref sky);

            human = new Human();
            ConformDateTime();
            ConformCord(false);

            // Подгружаем сохранённого наблюдателя.
            if (IO.UploadData(Properties.Resources.HumanFileName, ref human))
                SetViewHuman(human);

            // Заполнение выпадающего списка для фильтрации поиска.
            cBoxSortedBy.DataSource = Filter.listSortedBy;

            lastConstellations = sky.Constellations;
            lastStars = sky.GetAllStars().ToList();
            RefreshLBoxSky();
        }

        // Поиск по заданным критериям.
        private void Search()
        {
            // Настройки фильтрации.
            bool isStar = rBOnlyStars.Checked;

            // Меняем состояние последнего поиска.
            isStarLast = isStar;

            bool isOnlyVisible = chBoxOnlyVisible.Checked;
            int index = cBoxSortedBy.SelectedIndex;
            string search = tBoxSearch.Text.ToLower();

            if (isStar)
            {
                lblTitle.Text = "Звёзды :";

                // Отфильтрованный список звёзд.
                List<Star> stars = Filter
                    .FilterStars(sky, human, isOnlyVisible, index, search);

                RefreshLBoxSky(stars);
                lastStars = stars;
            }
            else
            {
                lblTitle.Text = "Созвездия :";

                // Отфильтрованный список созвездий.
                List<Constellation> conses = Filter
                    .FilterConstellations(sky, human, isOnlyVisible, index, search);

                RefreshLBoxSky(conses);
                lastConstellations = conses;
            }
        }

        // Сохраняет всю информацию.
        private bool SaveAllData()
        {
            List<bool> res = new List<bool>();

            res.Add(IO.SaveData(Properties.Resources.SkyFileName, sky, false));
            res.Add(IO.SaveData(Properties.Resources.HumanFileName, human));

            return res.Aggregate((seed, curr) => seed && curr);
        }

        #region ConfData

        // Сохраняет координаты, введённые пользователем.
        private void ConformCord(bool auto = true)
        {
            if (!Visible && auto)
                return;
            // Получаем вертикальные координаты.
            int dv = (int)numLatitudeDegree.Value;
            int mv = (int)numLatitudeMinutes.Value;
            int sv = (int)numLatitudeSeconds.Value;

            human.Location.Latitude = new VerticalCord(dv, mv, sv);

            // Получаем горизонтальные координаты.
            int dh = (int)numLongtitudeDegree.Value;
            int mh = (int)numLongtitudeMinutes.Value;
            int sh = (int)numLongtitudeSeconds.Value;

            human.Location.Longitude = new HorizontalCord(dh, mh, sh);

        }

        // Сохраняет дату и время, введённые пользователем.
        private void ConformDateTime()
        {
            human.LocalTime = dTPickerCurrDateTime.Value;
        }

        private void SetViewHuman(Human human)
        {
            // Настройка времени.
            // dTPickerCurrDateTime.Value = human.LocalTime;
            // Время не подгружается, а берётся текущее

            // Настройка координат.
            GeographicCS gcs = human.Location;
            VerticalCord lat = gcs.Latitude;
            HorizontalCord lon = gcs.Longitude;

            numLatitudeDegree.Value = lat.Degrees;
            numLatitudeMinutes.Value = lat.Minutes;
            numLatitudeSeconds.Value = lat.Seconds;

            numLongtitudeDegree.Value = lon.Degrees;
            numLongtitudeMinutes.Value = lon.Minutes;
            numLongtitudeSeconds.Value = lon.Seconds;
        }

        // Обновляет источник данных для результата посика.
        private void RefreshLBoxSky()
        {
            if (isStarLast)
                RefreshLBoxSky(new List<Star>(lastStars));
            else
                RefreshLBoxSky(new List<Constellation>(lastConstellations));
        }

        private void RefreshLBoxSky<T>(List<T> list)
        {
            lBoxSky.DataSource = list;          
        }

        #endregion

        #region Forms

        // Отображает форму.
        private void ShowForm(Form f)
        {
            Hide();
            ShowInTaskbar = false;

            f.ShowDialog();

            ShowInTaskbar = true;
            Show();

            DialogResult result = f.DialogResult;
            // OK => произошло сохранение в форме.
            if (result == DialogResult.OK)
                Search();

        }

        // Открывает и отображает форму просмотра.
        private void OpenViewForm()
        {
            int index = lBoxSky.SelectedIndex;
            Form f = new Form();

            if (!isStarLast)
            {
                f = new FormViewConstellation(sky, lastConstellations[index], human);
            }
            else
            {
                f = new FormViewStar(sky, lastStars[index], human);
            }

            ShowForm(f);
        }

        private void OpenEditForm(bool isStar = false)
        {
            Form f = new Form();
            if (isStar)
            {
                f = new FormEditStar(sky);
            }
            else
            {
                f = new FormEditConstellation(sky);
            }

            ShowForm(f);
        }

        #endregion

        #region Events

        private void numLongtitudeDegree_ValueChanged(object sender, EventArgs e)
        {
            ConformCord();
        }

        private void dTPickerCurrDateTime_ValueChanged(object sender, EventArgs e)
        {
            ConformDateTime();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void bAddConstellation_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        private void bAddStar_Click(object sender, EventArgs e)
        {
            // Проверка на отсутствие созвездий
            if (sky.Constellations.Count == 0)
            {
                IO.ShowErrorMessage("Перед созданием звёзд, добавьте созвездия.", "Невозможно создать звезду");
                return;
            }

            OpenEditForm(true);
        }

        // Открывает окно просмотра звезды/созвездия.
        private void lBoxSky_PreviewKeyDown(object sender,
            PreviewKeyDownEventArgs e)
        {
            if (lBoxSky.SelectedIndex == -1)
                return;

            if (e.KeyCode == Keys.Enter)
            {
                OpenViewForm();
            }
        }

        // Открывает окно просмотра звезды/созвездия.
        private void lBoxSky_MouseDoubleClick(object sender,
            MouseEventArgs e)
        {
            if (lBoxSky.SelectedIndex == -1)
                return;

            if (e.Button == MouseButtons.Left)
            {
                OpenViewForm();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Сохранить изменения ?",
                "Вы собираетесь закрыть Справочник астронома",
               MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                // Сохраняем данные перед закрытием.
                bool res = SaveAllData();

                if (!res)
                {
                    // Неудачное сохранение.
                    e.Cancel = true;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                // Отмена закрытия.
                e.Cancel = true;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveAllData();
        }

        #endregion

    }
}
