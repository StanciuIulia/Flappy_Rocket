using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chestionar
{
    public partial class PlanetQuizSad : Form
    {
        public PlanetQuizSad()
        {
            InitializeComponent();
        }

        private void PlanetQuizSad_Load(object sender, EventArgs e)
        {
            label1.Text = "Your score: " + PlanetQuiz2.score.ToString();
        }

        private void ButtonTryAgain_Click(object sender, EventArgs e)
        {
            PlanetQuiz1 form = new PlanetQuiz1();
            form.Show();
            this.Hide();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
