using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chestionar.Properties;

namespace chestionar
{

    public partial class Joc_Constelatii : Form

    {
        private bool _allowClick = true;
        private PictureBox _FirstGuess;
        private readonly Random _random = new Random();
        private readonly Timer _clickTimer = new Timer();
        int ticks = 60;
        readonly Timer timer = new Timer { Interval = 1000 };

        public Joc_Constelatii()
        {
            InitializeComponent();
            SetRandomImages();
            HideImages();
            StartGameTiimer();
            _clickTimer.Interval = 1000;
            _clickTimer.Tick += _clickTimer_Tick;

        }


        private PictureBox[] PictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static Image[] Images => new Image[]
                    {

                        Resources.img21 ,
                        Resources.img23 ,
                        Resources.img24 ,
                        Resources.img27 ,
                        Resources.img28 ,
                        Resources.img29 ,
                        Resources.img33 ,
                        Resources.img34 ,
                        Resources.img35 ,
                        Resources.img36


                    };

        private void StartGameTiimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                ticks--;
                if (ticks == -1)
                {
                    timer.Stop();
                    MessageBox.Show("Time is up!", "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetImages();

                }

                var time = TimeSpan.FromSeconds(ticks);
                lbltime.Text = "00:" + time.ToString("ss");

            };
        }

        private void ResetImages()

        {
            foreach (var pic in PictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }

            HideImages();
            SetRandomImages();
            ticks = 60;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Image = Resources.img20;

            }
        }

        private PictureBox GetFreeSlot()
        {
            int num;
            do
            {
                num = _random.Next(0, PictureBoxes.Count());
            }

            while (PictureBoxes[num].Tag != null);
            return PictureBoxes[num];
        }

        private void SetRandomImages()
        {
            foreach (var image in Images)
            {
                GetFreeSlot().Tag = image;
                GetFreeSlot().Tag = image;
            }
        }

        private void ClickImage(object sender, EventArgs e)
        {
            if (!_allowClick) return;
            var pic = (PictureBox)sender;

            if (_FirstGuess == null)
            {
                _FirstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            pic.Image = (Image)pic.Tag;
            if (pic.Image == _FirstGuess.Image && pic != _FirstGuess)
            {
                pic.Visible = _FirstGuess.Visible = false;
                {
                    _FirstGuess = pic;
                }

                HideImages();
            }

            else
            {
                _allowClick = false;
                _clickTimer.Start();
            }
            _FirstGuess = null;
            if (PictureBoxes.Any(p => p.Visible))
                return;
            MessageBox.Show("Congrats! You won!", "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ResetImages();
        }

        private void _clickTimer_Tick(object sender, EventArgs e)
        {
            HideImages();
            _allowClick = true;
            _clickTimer.Stop();
        }
      

        private void Joc_Constelatii_Load(object sender, EventArgs e)
        {

        }
    }
}
