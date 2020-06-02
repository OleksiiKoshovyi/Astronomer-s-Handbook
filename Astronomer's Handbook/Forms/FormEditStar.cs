using Astronomer_s_Handbook.Coordinates;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Astronomer_s_Handbook
{
    public partial class FormEditStar : Form
    {
        private bool isAddForm = true;
        private Sky sky;
        private Constellation cons;
        private Star star;

        // Единицы измерения.
        private List<string> units = new List<string>() { 
            "Парсек", 
            "Световой год", 
            "Километр" };

        // Коэффициенты преобразования единиц измерения в парсеки
        private List<double> odds = new List<double>() {
            1,
            1/AstroMath.LIGHT_YEARS_IN_PARSEC,
            1/AstroMath.KILOMETRS_IN_PARSEC};

        /// <summary>
        /// Конструктор для создания звезды.
        /// </summary>
        /// <param name="sky">Небо со звёздами.</param>
        public FormEditStar(Sky sky)
        {
            InitializeComponent();
            PrepareAddForm(sky);
        }

        /// <summary>
        /// Форма для редактирования звезды.
        /// </summary>
        /// <param name="sky">Небо со звёздами.</param>
        /// <param name="star">Выбранная звезда.</param>
        public FormEditStar(Sky sky, Star star)
        {
            InitializeComponent();

            isAddForm = false;
            PrepareEditForm(sky, star);
        }

        private void PrepareAddForm(Sky sky)
        {
            bDel.Visible = false;
            Text = "Создание звезды";
            cBoxCons.DataSource = sky.Constellations;
            cBoxUnit.DataSource = units;

            this.sky = sky;
            cons = sky.Constellations[0];
        }

        private void PrepareEditForm(Sky sky, Star star)
        {
            Text = "Редактирование звезды";
            bDel.Visible = true;
            this.sky = sky;
            this.star = star;

            // Настройка созвездий.
            cBoxCons.DataSource = sky.Constellations;
            cons = Filter.GetConstellationFromStar(star, sky);
            cBoxCons.SelectedIndex = sky.Constellations.IndexOf(cons);

            // Заполнение данными.
            tBoxName.Text = star.Name;
            tBoxUrl.Text = star.Url;
            cBoxUnit.DataSource = units;

            tBoxDist.Text = Editor.ToString(star.Distance);
            tBoxMagn.Text = Editor.ToString(star.Magnitude);

            EquatorialCS equa = star.Location;
            VerticalCord decl = equa.Declination;
            HorizontalCord RA = equa.RightAscension;

            numDeclDegree.Value = decl.Degrees;
            numDeclMinutes.Value = decl.Minutes;
            numDeclSeconds.Value = decl.Seconds;

            numRADegree.Value = RA.Degrees / 15;
            numRAMinutes.Value = RA.Minutes;
            numRASeconds.Value = RA.Seconds;
        }

        private void SaveData()
        {
            string name = tBoxName.Text;


            if (!ValidateName(name) || !IsAllFieldsFilled())
                return;

            double distance = GetDistance();
            double magn = Editor.ToDouble(tBoxMagn.Text);
            string url = tBoxUrl.Text;

            VerticalCord vert = GetDeclination();
            HorizontalCord hor = GetRightAscension();
            EquatorialCS equa = new EquatorialCS(vert, hor);

            if (isAddForm)
            {
                Star star = new Star(equa, name, magn, distance, url);
                cons.Stars.Add(star);
            }
            else
            {
                star.Name = name;
                star.Distance = distance;
                star.Magnitude = magn;
                star.Location = equa;
                star.Url = url;

                Constellation old = Filter.GetConstellationFromStar(star, sky);
                if (!cons.Equals(old))
                {
                    cons.Stars.Add(star);
                    old.Stars.Remove(star);
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        #region Get data and Validate

        private bool IsAllFieldsFilled()
        {
            bool isName = !string.IsNullOrEmpty(tBoxName.Text);
            bool isDist = !string.IsNullOrEmpty(tBoxDist.Text);
            bool isMagn = !string.IsNullOrEmpty(tBoxMagn.Text);
            // bool isUrl  = !string.IsNullOrEmpty(tBoxUrl.Text);
            bool res = isName && isDist && isMagn;
            if (!res)
            {
                IO.ShowErrorMessage(
                "Пожалуйста, заполните все поля.",
                "Не все поля заполнены");
            }

            return res;

        }

        // Проверяет данные на правильность.
        private bool ValidateName(string name)
        {
            List<Star> stars = Filter.GetStarsFromConstellations(
                sky.Constellations);
            
            // Нельзя создать 
            if (stars.Where(s => s.Name == name).Count() != 0 )
            {
                if(!isAddForm && name == star.Name)
                {
                    return true;
                }

                IO.ShowErrorMessage("Звезда с таким название уже существует",
                    Text);
            }
            else if (string.IsNullOrEmpty(name))
            {
                IO.ShowErrorMessage("Название звезды не может быть пустым.",
                    Text);
            }
            else
            {
                return true;
            }
            return false;
        }

        // Проверяет расстояние на корректность
        [Obsolete]
        private bool ValidateDistance(double distance)
        {
            if (distance > 0)
                return true;

            IO.ShowErrorMessage(
                "Расстояние до зведы не может быть меньше или равно 0.",
                "Расстояние указано неверно");

            return false;
        }       

        private VerticalCord GetDeclination()
        {
            int deg = (int)numDeclDegree.Value;
            int min = (int)numDeclMinutes.Value;
            int sec = (int)numDeclSeconds.Value;

            return new VerticalCord(deg, min, sec);
        }

        private HorizontalCord GetRightAscension()
        {
            int deg = (int)numRADegree.Value * 15;
            int min = (int)numRAMinutes.Value;
            int sec = (int)numRASeconds.Value;

            return new HorizontalCord(deg, min, sec);
        }

        private double GetDistance()
        {
            double distance = Editor.ToDouble(tBoxDist.Text);
            return distance * odds[cBoxUnit.SelectedIndex];
        }

        #endregion

        #region Events

        // Сохраняет данные созвездия.
        private void bSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        // Удаляет созвездие с неба.
        private void bDel_Click(object sender, EventArgs e)
        {
            cons = Filter.GetConstellationFromStar(star, sky);
            cons.Stars.Remove(star);
            DialogResult = DialogResult.OK;
            Close();
        }

        // Пытается получить картинку.
        private void bCheck_Click(object sender, EventArgs e)
        {
            string url = tBoxUrl.Text;
            IO.LoadImage(url, pBoxPhoto);
        }

        private void cBoxCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxCons.DataSource != null && sky != null)
                cons = sky.Constellations[cBoxCons.SelectedIndex];
        }

        // Ввод только цифр с одной точкой.
        private void tBoxDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            if (e.KeyChar == '.')
            {
                if (tBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if(e.KeyChar == '-' && tBox.Name != "tBoxDist")
            {
                if (tBox.Text.Length != 0)
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        #endregion

    }
}