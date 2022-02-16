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
    public partial class Orion : Form
    {
        public Orion()
        {
            InitializeComponent();
        }

        private void M42_Click(object sender, EventArgs e)
        {
            M42 newform = new M42();
            newform.Show();
        }

        private void M43_Click(object sender, EventArgs e)
        {
            M43 newform = new M43();
            newform.Show();
        }

        private void M78_Click(object sender, EventArgs e)
        {
            M78 newform = new M78();
            newform.Show();
        }
    }
}
