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
    public partial class Aquarius : Form
    {
        public Aquarius()
        {
            InitializeComponent();
        }

        private void M2_Click(object sender, EventArgs e)
        {
            M2 newform = new M2();
                    newform.Show();
        }
        

        private void M72_Click(object sender, EventArgs e)
        {
            M72 newform = new M72();
            newform.Show();
        }

        private void M73_Click(object sender, EventArgs e)
        {
            M73 newform = new M73();
            newform.Show();
        }
    }
}
