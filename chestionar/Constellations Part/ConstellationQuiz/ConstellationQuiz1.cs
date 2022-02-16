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
    public partial class ConstellationQuiz1 : Form
    {
        public ConstellationQuiz1()
        {
            InitializeComponent();
        }

        private void ConstellationQuiz1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ConstellationQuiz2 form = new ConstellationQuiz2();
            form.Show();
            this.Close();
        }
    }
}
