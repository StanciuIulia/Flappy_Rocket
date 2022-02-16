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
    public partial class Jupiter : Form
    {
        public Jupiter()
        {
            InitializeComponent();
        }

        private void Jupiter_Load(object sender, EventArgs e)
        {

        }

        private void buttonSatelitiJupiter_Click(object sender, EventArgs e)
        {
            SatelitiJupiter newform = new SatelitiJupiter ();
            newform.Show();

        }
    }
}
