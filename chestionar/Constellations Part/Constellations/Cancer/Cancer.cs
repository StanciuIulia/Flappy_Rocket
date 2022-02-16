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
    public partial class Cancer : Form
    {
        public Cancer()
        {
            InitializeComponent();
        }

        private void M44_Click(object sender, EventArgs e)
        {
            M44 newform = new M44();
            newform.Show();
        }

        private void M67_Click(object sender, EventArgs e)
        {
            M67 newform = new M67();
            newform.Show();
        }
    }
}
