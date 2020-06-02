using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Astronomer_s_Handbook
{
    public partial class FormEditConstellation : Form
    {
        private bool isAddForm = true;
        private Sky sky;
        private Constellation cons;
        private Star selStar;

        /// <summary>
        /// Форма создания созвездия.
        /// </summary>
        /// <param name="sky">Небо.</param>
        public FormEditConstellation(Sky sky)
        {
            InitializeComponent();
            PrepareAddForm(sky);
        }

        /// <summary>
        /// Форма редактирования созвездия.
        /// </summary>
        /// <param name="sky">Небо.</param>
        /// <param name="cons">Созвездие.</param>
        public FormEditConstellation(Sky sky, Constellation cons)
        {
            InitializeComponent();

            isAddForm = false;
            PrepareEditForm(sky, cons);
        }

        private void PrepareAddForm(Sky sky)
        {
            MinimumSize = new Size(Width, 310);
            Size = MinimumSize;
            pStars.Visible = false;
            bDel.Visible = false;
            pLeft.BorderStyle = BorderStyle.None;
            Text = "Создание созвездия";

            this.sky = sky;
        }

        private void PrepareEditForm(Sky sky, Constellation cons)
        {
            Text = "Редактирование созвездия";
            pStars.Visible = true;
            bDel.Visible = true;
            this.sky = sky;
            this.cons = cons;

            tBoxName.Text = cons.Name;
            tBoxUrl.Text = cons.Url;

            lBoxStars.DataSource = cons.Stars;
        }

        private void SaveData()
        {
            string url = tBoxUrl.Text;
            string name = tBoxName.Text;

            if (!ValidateData(name))
                return;
            if (isAddForm)
            {
                List<Star> stars = new List<Star>();
                Constellation curr = new Constellation(stars, name, url);
                sky.Constellations.Add(curr);
            }
            else
            {
                cons.Url = url;
                cons.Name = name;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // Проверяет данные на правильность.
        private bool ValidateData(string name)
        {
            if (sky.Constellations.Where(c => c.Name == name).Count() != ((isAddForm) ? 0 : 1))
            {
                IO.ShowErrorMessage("Созвездие с таким название уже существует",
                    Text);
            }
            else if (string.IsNullOrEmpty(name))
            {
                IO.ShowErrorMessage("Название созвездия не может быть пустым.",
                    Text);
            }
            else
            {
                return true;
            }
            return false;
        }

        #region Events

        // Создаёт контекстное меню.
        private void lBoxStars_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lBoxStars.SelectedIndex;

            if (index == -1)
                return;
            if (e.Button == MouseButtons.Right)
            {
                contextMS.Show(lBoxStars,e.Location);
                selStar = cons.Stars[index];
            }
        }

        // Удаляет звезду из созвездия.
        private void toolSM_MouseDown(object sender, MouseEventArgs e)
        {
            if (ReferenceEquals(selStar, null))
                return;

            if (e.Button == MouseButtons.Left)
            {
                cons.Stars.Remove(selStar);
                DialogResult = DialogResult.OK;
                lBoxStars.DataSource = new List<Star>(cons.Stars);
            }
        }

        // Сохраняет данные созвездия.
        private void bSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        // Удаляет созвездие с неба.
        private void bDel_Click(object sender, EventArgs e)
        {
            sky.Constellations.Remove(cons);
            DialogResult = DialogResult.OK;
            Close();
        }

        // Пытается получить картинку.
        private void bCheck_Click(object sender, EventArgs e)
        {
            string url = tBoxUrl.Text;
            IO.LoadImage(url, pBoxPhoto);
        }

        #endregion
    }
}
