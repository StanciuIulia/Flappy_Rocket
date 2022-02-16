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
    public partial class Saturn : Form
    {
        public Saturn()
        {
            InitializeComponent();
        }

        private void buttonStructuraSaturn_Click(object sender, EventArgs e)
        {
            StructuraSaturn newform = new StructuraSaturn();
            newform.Show();

        }
        private void buttonSatelitiSaturn_Click(object sender, EventArgs e)
        {
            SatelitiSaturn newform = new SatelitiSaturn();
            newform.Show();

        }
    }
}
