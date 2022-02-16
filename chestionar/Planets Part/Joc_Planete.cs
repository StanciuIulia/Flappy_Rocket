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

    public partial class Joc_Planete : Form

    {
        private bool _allowClick = true;
        private PictureBox _FirstGuess;
        private readonly Random _random = new Random();
        private readonly Timer _clickTimer = new Timer();
        int ticks = 120;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private Label label1;
        private Label LabelTime;
        readonly Timer timer = new Timer { Interval = 1000 };

        public Joc_Planete()
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

                        Resources.img1 ,
                        Resources.img2 ,
                        Resources.img3 ,
                        Resources.img4 ,
                        Resources.img5 ,
                        Resources.img6 ,
                        Resources.img7 ,
                        Resources.img9 ,
                        Resources.img10 ,
                        Resources.img11 ,
                        Resources.img12 ,
                        Resources.img13 ,
                        Resources.img8 ,
                        Resources.img14,
                        Resources.img15,
                        Resources.img16,
                        Resources.img17,
                        Resources.img18

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
                LabelTime.Text = time.ToString("mm") + ":" + time.ToString("ss");

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
            ticks = 120;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Image = Resources.img0;
               
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(274, 812);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(192, 63);
            this.LabelTime.TabIndex = 37;
            this.LabelTime.Text = "00:00";
            // 
            // pictureBox36
            // 
            this.pictureBox36.Location = new System.Drawing.Point(620, 620);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(100, 100);
            this.pictureBox36.TabIndex = 35;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox35
            // 
            this.pictureBox35.Location = new System.Drawing.Point(500, 620);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(100, 100);
            this.pictureBox35.TabIndex = 34;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox34
            // 
            this.pictureBox34.Location = new System.Drawing.Point(380, 620);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(100, 100);
            this.pictureBox34.TabIndex = 33;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(260, 620);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(100, 100);
            this.pictureBox33.TabIndex = 32;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox32
            // 
            this.pictureBox32.Location = new System.Drawing.Point(140, 620);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(100, 100);
            this.pictureBox32.TabIndex = 31;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox31
            // 
            this.pictureBox31.Location = new System.Drawing.Point(620, 500);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(100, 100);
            this.pictureBox31.TabIndex = 30;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox30
            // 
            this.pictureBox30.Location = new System.Drawing.Point(500, 500);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(100, 100);
            this.pictureBox30.TabIndex = 29;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox29
            // 
            this.pictureBox29.Location = new System.Drawing.Point(380, 500);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(100, 100);
            this.pictureBox29.TabIndex = 28;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox28
            // 
            this.pictureBox28.Location = new System.Drawing.Point(260, 500);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(100, 100);
            this.pictureBox28.TabIndex = 27;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox27
            // 
            this.pictureBox27.Location = new System.Drawing.Point(140, 500);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(100, 100);
            this.pictureBox27.TabIndex = 26;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(620, 380);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(100, 100);
            this.pictureBox26.TabIndex = 25;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(140, 140);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(100, 100);
            this.pictureBox25.TabIndex = 24;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(260, 140);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(100, 100);
            this.pictureBox24.TabIndex = 23;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(380, 140);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(100, 100);
            this.pictureBox23.TabIndex = 22;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(500, 140);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(100, 100);
            this.pictureBox22.TabIndex = 21;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(620, 140);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(100, 100);
            this.pictureBox21.TabIndex = 20;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(140, 260);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(100, 100);
            this.pictureBox20.TabIndex = 19;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(260, 260);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(100, 100);
            this.pictureBox19.TabIndex = 18;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(380, 260);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(100, 100);
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(500, 260);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(100, 100);
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(620, 260);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(100, 100);
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(140, 380);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(100, 100);
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(260, 380);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(100, 100);
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(380, 380);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 100);
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(500, 380);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(100, 100);
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(20, 620);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 100);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(20, 500);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(20, 380);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(20, 260);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(20, 140);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(620, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(500, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(380, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(260, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(140, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ClickImage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ClickImage);
            // 
            // Joc_Planete
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(744, 961);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Joc_Planete";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}