using System;
using System.Windows.Forms;

namespace Astronomer_s_Handbook
{
    public partial class FormViewConstellation : Form
    {
        private Sky sky;
        private Constellation cons;
        private Human human;
        public FormViewConstellation(Sky sky, Constellation cons, Human human)
        {
            InitializeComponent();

            this.sky = sky;
            this.cons = cons;
            this.human = human;

            PrepareForm();
        }

        private void PrepareForm()
        {
            lblName.Text = cons.Name;

            if (IO.LoadImage(cons.Url, pBoxPhoto, false))
            {
                pBoxPhoto.Image = Properties.Resources.conses;
            }

            if (cons.Stars.Count != 0)
            {
                if (cons.IsVisible(human))
                    lblVisibility.Text = "Созвездие видно";
                else
                    lblVisibility.Text = "Созвездие не видно";

                double magn = cons.GetSumMagnitude();
                lblSumarMagnitude.Text = $"{Editor.Round(magn, 3)} m";
            }

            RefreshLBoxStars();
        }

        private void RefreshLBoxStars()
        {
            lBoxStars.DataSource = cons.Stars;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            FormEditConstellation Fec = new FormEditConstellation(sky, cons);
            Hide();
            Fec.ShowDialog();
            Show();
            DialogResult = Fec.DialogResult;
            Close();
        }
    }
}
