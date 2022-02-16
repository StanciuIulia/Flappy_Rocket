using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace chestionar
{
    public partial class FlappyAlien : Form
    {
        private bool engel_gb1 = false;
        private bool engel_gb2 = false;
        private bool a = false;
        private bool b = false;
        private bool baslangic = true;

       
        Random rnd = new Random();
        PictureBox engel1;
        PictureBox engel2;
        PictureBox engel3;
        PictureBox engel4;
        public FlappyAlien()
        {
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
        }
        private void FlappyAlien_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pictureBox1.Top += -50;
            }
        }
        public void engel_yap1()
        {
            if (baslangic == true)
            {
                if (engel_gb1 == false)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(rnd.Next(150, 430), rnd.Next(-170, -20));
                    pb.Size = new Size(40, rnd.Next(230, 250));
                    pb.BackColor = Color.SkyBlue;
                    engel1 = pb;
                    panel1.Controls.Add(pb);
                    engel_gb1 = true;
                    a = true;

                }
            }
        }
        public void engel_yap11()
        {
            if (baslangic == false)
            {
                if (engel_gb1 == false)
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(engel3.Location.X + 200, rnd.Next(-170, -20));
                    pb.Size = new Size(40, rnd.Next(230, 250));
                    pb.BackColor = Color.SkyBlue ;
                    engel1 = pb;
                    panel1.Controls.Add(pb);
                    engel_gb1 = true;
                    a = true;

                }
            }
        }
        public void engel_yap2()
        {
            if (a == true)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(engel1.Location.X, engel1.Bottom + 150);
                pb.Size = new Size(40, rnd.Next(230, 250));
                pb.BackColor = Color.SkyBlue ;
                engel2 = pb;
                panel1.Controls.Add(pb);
                a = false;
            }

        }



        public void engel_uret1()
        {
            if (engel_gb2 == false)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(engel1.Location.X + 200, rnd.Next(-170, -20));
                pb.Size = new Size(40, rnd.Next(230, 250));
                pb.BackColor = Color.SkyBlue ;
                engel3 = pb;
                panel1.Controls.Add(pb);
                engel_gb2 = true;
                b = true;

            }
        }
        public void engel_uret2()
        {
            if (b == true)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(engel3.Location.X, engel3.Bottom + 150);
                pb.Size = new Size(40, rnd.Next(230, 250));
                pb.BackColor = Color.SkyBlue;
                engel4 = pb;
                panel1.Controls.Add(pb);
                b = false;
            }
        }


        void hareket()
        {
            engel1.Left += -10;
            engel2.Left += -10;
            engel3.Left += -10;
            engel4.Left += -10;

            if (engel1.Right - 10 <= pictureBox1.Left)
            {
                panel1.Controls.Remove(engel1);
                panel1.Controls.Remove(engel2);
                engel_gb1 = false;
                baslangic = false;

            }
            if (engel3.Right - 10 <= pictureBox1.Left)
            {
                panel1.Controls.Remove(engel3);
                panel1.Controls.Remove(engel4);
                engel_gb2 = false;
            }

            if (pictureBox1.Right >= engel1.Left && pictureBox1.Right <= engel1.Right && pictureBox1.Top <= engel1.Bottom)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;

            }
            if (pictureBox1.Right >= engel2.Left && pictureBox1.Right <= engel2.Right && pictureBox1.Bottom >= engel2.Top)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;

            }
            if (pictureBox1.Right >= engel3.Left && pictureBox1.Right <= engel3.Right && pictureBox1.Top <= engel3.Bottom)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;

            }

            if (pictureBox1.Right >= engel4.Left && pictureBox1.Right <= engel4.Right && pictureBox1.Bottom >= engel4.Top)
            {
                panel2.Location = new Point(100, 126);
                button1.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            engel_yap1();
            engel_yap2();
            engel_uret1();
            engel_uret2();
            engel_yap11();
            hareket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }
        public static void ThreadProc()
        {
            FlappyAlien form = new FlappyAlien();
            Application.Run(form);


        }
    }
}
