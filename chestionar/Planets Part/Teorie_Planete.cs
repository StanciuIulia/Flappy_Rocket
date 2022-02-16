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
    public partial class Teorie_Planete : Form
    {
        public Teorie_Planete()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMercury_Click(object sender, EventArgs e)
        {
            Mercury newform = new Mercury();
            newform.Show();

        }

        private void buttonVenus_Click(object sender, EventArgs e)
        {
            Venus newform = new Venus();
            newform.Show();

        }

        private void buttonEarth_Click(object sender, EventArgs e)
        {
            Earth newform = new Earth();
            newform.Show();

        }

        private void buttonMars_Click(object sender, EventArgs e)
        {
            Mars newform = new Mars();
            newform.Show();

        }

        private void buttonJupiter_Click(object sender, EventArgs e)
        {
            Jupiter newform = new Jupiter();
            newform.Show();

        }

        private void buttonSaturn_Click(object sender, EventArgs e)
        {
            Saturn newform = new Saturn();
            newform.Show();

        }

        private void buttonUranus_Click(object sender, EventArgs e)
        {
            Uranus newform = new Uranus();
            newform.Show();

        }

        private void buttonNeptune_Click(object sender, EventArgs e)
        {
            Neptune newform = new Neptune();
            newform.Show();

        }
    }
}
