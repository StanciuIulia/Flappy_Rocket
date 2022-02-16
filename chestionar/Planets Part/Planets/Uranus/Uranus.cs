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
    public partial class Uranus : Form
    {
        public Uranus()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSatelitiUranus_Click(object sender, EventArgs e)
        {
            SatelitiUranus newform = new SatelitiUranus();
            newform.Show();

        }
    }
}
