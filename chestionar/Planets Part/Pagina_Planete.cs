using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace chestionar
{
    public partial class Pagina_Planete : Form
    {
        public Pagina_Planete()
        {
            InitializeComponent();
        }

        private void Pagina_Planete_Load(object sender, EventArgs e)
        {
          
    }

        private void buttonTeorie_Click (object sender, EventArgs e)
        {
            Teorie_Planete newform = new Teorie_Planete();
            newform.Show();

        }

        private void buttonJoc_Click(object sender, EventArgs e)
        {
            Joc_Planete  newform = new Joc_Planete ();
            newform.Show();

        }

        private void RoundButtonChestionar_Click(object sender, EventArgs e)
        {
            PlanetQuiz1 newform = new PlanetQuiz1();
            newform.Show();

        }
    }
}
