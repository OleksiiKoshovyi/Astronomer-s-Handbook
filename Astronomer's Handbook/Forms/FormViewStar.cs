using Astronomer_s_Handbook.Coordinates;
using System;
using System.Windows.Forms;

namespace Astronomer_s_Handbook
{
    public partial class FormViewStar : Form
    {
        private Sky sky;
        private Star star;
        private Human human;
        public FormViewStar(Sky sky, Star star, Human human)
        {
            InitializeComponent();

            this.sky = sky;
            this.star = star;
            this.human = human;

            PrepareForm();
        }

        private void PrepareForm()
        {
            lblName.Text = star.Name;

            if(IO.LoadImage(star.Url, pBoxPhoto, false))
            {
                pBoxPhoto.Image = Properties.Resources.star;
            }

            lblConstellation.Text
                = Filter.GetConstellationFromStar(star, sky).ToString();

            lblDist.Text = $"{Editor.Round(star.Distance, 3)} Пк";
            lblMagn.Text = $"{Editor.Round(star.Magnitude, 3)} m";
            lblAbsMagn.Text = $"{Editor.Round(star.AbsMagnitude, 3)} M";
            lblDecl.Text = star.Location.Declination.ToString();
            lblRA.Text = star.Location.RightAscension.ToString();

            HorizontalCS horCS = star.GetCurrLocation(human);
            lblAzimuth.Text = horCS.Azimuth.ToString();
            lblAltitude.Text = horCS.Altitude.ToString();

            if (!star.IsEverVisible(human))
            {
                lblVisibility.Text = "Всегда невидима для вашей местности";
            }
            else if (star.IsAlwaysVisible(human))
            {
                lblVisibility.Text = "Всегда над горизонтом";
            }
            else if (AstroMath.IsStarVisible(horCS))
            {
                lblVisibility.Text = "Сейчас над горизонтом";
            }
            else
            {
                lblVisibility.Text = "Сейчас не видно";
            }

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            FormEditStar Fes = new FormEditStar(sky, star);
            Hide();
            Fes.ShowDialog();
            Show();
            DialogResult = Fes.DialogResult;
            Close();
        }
    }
}
