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
    public partial class Sagittarius : Form
    {
        public Sagittarius()
        {
            InitializeComponent();
        }

        private void Msaggitarius_Click(object sender, EventArgs e)
        {
            Msaggitarius newform = new Msaggitarius();
            newform.Show();
        }
    }
}
