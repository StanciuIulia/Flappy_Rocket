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
    public partial class Pisces : Form
    {
        public Pisces()
        {
            InitializeComponent();
        }

        private void M74_Click(object sender, EventArgs e)
        {
            M74  newform = new M74();
            newform.Show();
        }
    }
}
