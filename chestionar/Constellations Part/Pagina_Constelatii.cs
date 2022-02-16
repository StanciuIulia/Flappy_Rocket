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
    public partial class Pagina_Constelatii : Form
    {
        public Pagina_Constelatii()
        {
            InitializeComponent();
        }

        private void buttonJocConstelatii_Click(object sender, EventArgs e)
        {
            Joc_Constelatii newform = new Joc_Constelatii ();
            newform.Show();

        }

        private void Pagina_Constelatii_Load(object sender, EventArgs e)
        {

        }

        private void Pisces_Click(object sender, EventArgs e)
        {
            Pisces newform = new Pisces ();
            newform.Show();
        }

        private void Aries_Click(object sender, EventArgs e)
        {
            Aries newform = new Aries();
            newform.Show();
        }

        private void Taurus_Click(object sender, EventArgs e)
        {
            Taurus newform = new Taurus();
            newform.Show();
        }

        private void Gemini_Click(object sender, EventArgs e)
        {
           Gemini newform = new Gemini();
            newform.Show();
        }

        private void Cancer_Click(object sender, EventArgs e)
        {
            Cancer  newform = new Cancer();
            newform.Show();
        }

        private void Leo_Click(object sender, EventArgs e)
        {
           Leo newform = new Leo();
            newform.Show();
        }

        private void Aquarius_Click(object sender, EventArgs e)
        {
            Aquarius newform = new Aquarius();
            newform.Show();
        }

        private void Capricornus_Click(object sender, EventArgs e)
        {
            Capricornus newform = new Capricornus ();
            newform.Show();
        }

        private void CanisMajor_Click(object sender, EventArgs e)
        {
            CanisMajor newform = new CanisMajor();
            newform.Show();
        }

        private void Orion_Click(object sender, EventArgs e)
        {
            Orion newform = new Orion();
            newform.Show();
        }

        private void UrsaMinor_Click(object sender, EventArgs e)
        {
            UrsaMinor newform = new UrsaMinor();
            newform.Show();
        }

        private void Sagittarius_Click(object sender, EventArgs e)
        {
            Sagittarius newform = new Sagittarius();
            newform.Show();
        }

        private void Scorpio_Click(object sender, EventArgs e)
        {
            Scorpio newform = new Scorpio();
            newform.Show();
        }

        private void Libra_Click(object sender, EventArgs e)
        {
            Libra newform = new Libra();
            newform.Show();
        }

        private void Virgo_Click(object sender, EventArgs e)
        {
            Virgo newform = new Virgo();
            newform.Show();
        }

        private void Ophiucus_Click(object sender, EventArgs e)
        {
            Ophiucus newform = new Ophiucus();
            newform.Show();
        }

        private void Cygnus_Click(object sender, EventArgs e)
        {
            Cygnus newform = new Cygnus();
            newform.Show();
        }

        private void UrsaMajor_Click(object sender, EventArgs e)
        {
            UrsaMajor newform = new UrsaMajor();
            newform.Show();
        }

        private void Pagina_Constelatii_Load_1(object sender, EventArgs e)
        {

        }

        private void ButtonTeorieConstelatii_Click(object sender, EventArgs e)
        {
            ConstellationQuiz1 newform = new ConstellationQuiz1();
            newform.Show();
        }

        private void Lyra_Click(object sender, EventArgs e)
        {
            Lyra newform = new Lyra();
            newform.Show();
        }
    }
}
