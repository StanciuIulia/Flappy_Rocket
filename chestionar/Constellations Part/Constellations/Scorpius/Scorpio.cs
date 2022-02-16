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
    public partial class Scorpio : Form
    {
        public Scorpio()
        {
            InitializeComponent();
        }

        private void M4_Click(object sender, EventArgs e)
        {
            M4 newform = new M4();
            newform.Show();
        }

        private void M6_Click(object sender, EventArgs e)
        {
            M6 newform = new M6();
            newform.Show();
        }

        private void M7_Click(object sender, EventArgs e)
        {
            M7 newform = new M7();
            newform.Show();
        }

        private void M80_Click(object sender, EventArgs e)
        {
            M80 newform = new M80();
            newform.Show();
        }
    }
}
