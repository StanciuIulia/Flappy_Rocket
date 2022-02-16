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
    public partial class PlanetQuiz1 : Form
    {
        public PlanetQuiz1()
        {
            InitializeComponent();
        }

        private void PlanetsQuiz1_Load(object sender, EventArgs e)
        {

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStartTest_Click(object sender, EventArgs e)
        {
            PlanetQuiz2 form = new PlanetQuiz2();
            form.Show();
            this.Close();
        }
    }
}
