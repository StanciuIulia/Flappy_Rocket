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
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            InitializeComponent();
        }

        private void Start_Page_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlanets_Click(object sender, EventArgs e)
        {
            Pagina_Planete newform = new Pagina_Planete ();
            newform.Show();

        }
        private void buttonConstelations_Click(object sender, EventArgs e)
        {
            Pagina_Constelatii newform = new Pagina_Constelatii();
            newform.Show();

        }

        private void FlappyAlienButton_Click(object sender, EventArgs e)
        {
            FlappyAlien newform = new FlappyAlien();
            newform.Show();
        }
    }

}
