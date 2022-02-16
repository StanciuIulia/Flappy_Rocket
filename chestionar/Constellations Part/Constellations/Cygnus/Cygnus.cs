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
    public partial class Cygnus : Form
    {
        public Cygnus()
        {
            InitializeComponent();
        }

        private void M29_Click(object sender, EventArgs e)
        {
            M29 newform = new M29 ();
            newform.Show();
        }

        private void M39_Click(object sender, EventArgs e)
        {
            M39 newform = new M39();
            newform.Show();
        }
    }
}
