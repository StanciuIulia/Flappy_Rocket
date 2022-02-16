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
    public partial class Taurus : Form
    {
        public Taurus()
        {
            InitializeComponent();
        }

        private void TaurusText_TextChanged(object sender, EventArgs e)
        {

        }

        private void M1_Click(object sender, EventArgs e)
        {
            M1 newform = new M1();
            newform.Show();
        }

        private void M45_Click(object sender, EventArgs e)
        {
            M45 newform = new M45();
            newform.Show();
        }
    }
}
