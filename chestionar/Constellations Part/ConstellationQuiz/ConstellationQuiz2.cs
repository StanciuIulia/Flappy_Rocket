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
    public partial class ConstellationQuiz2 : Form
    {
        public ConstellationQuiz2()
        {
            InitializeComponent();
        }

        private void ConstellationQuiz2_Load(object sender, EventArgs e)
        {
            Random a1 = new Random();
            int ran1 = a1.Next(1, 5);
            if (ran1 == 1)
            {
                textBox1.Text = "How many constellations are there on the night sky?";
                button1.Text = "A) 88.";
                button2.Text = "B) 12.";
                button3.Text = "C) 140.";
                button4.Text = "D) Over one million.";

            }

            else if (ran1 == 2)
            {
                textBox1.Text = "The hottest place in the universe is located in which constellation?";
                button1.Text = "A) Virgo.";
                button2.Text = "B) Leo.";
                button3.Text = "C) Saggitarius.";
                button4.Text = "D) Pisces.";
            }


            else if (ran1 == 3)
            {
                textBox1.Text = "What is the closest star to the Sun?";
                button1.Text = "A) Proxima Centauri.";
                button2.Text = "B) Betelgeuse.";
                button3.Text = "C) Rigel.";
                button4.Text = "D) Beta Taurus.";

            }

            else if (ran1 == 4)
            {
                textBox1.Text = "What is the largest type of star in the universe?";
                button1.Text = "A) Red supergiant stars.";
                button2.Text = "B) Blue supergiant stars.";
                button3.Text = "C) White dwarfs.";
                button4.Text = "D) White supergiant stars.";
            }
        }

        public static int score = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "How many constellations are there on the night sky?" || textBox1.Text == "The hottest place in the universe is located in which constellation?" || textBox1.Text == "What is the closest star to the Sun?" || textBox1.Text == "What is the largest type of star in the universe?")
            {
                Random a2 = new Random();
                int ran2 = a2.Next(1, 3);
                if (ran2 == 1)
                {
                    score = 10;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What constellation was named after a flying horse?";
                    button1.Text = "A) Orion.";
                    button2.Text = "B) Ursa major.";
                    button3.Text = "C) Ophiucus.";
                    button4.Text = "D) Pegasus.";
                    label1.BackColor = System.Drawing.Color.DarkBlue;

                }

                else if (ran2 == 2)
                {
                    score = 10;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What constellation has the Big Dipper as part of its pattern?";
                    button1.Text = "A) Pegasus";
                    button2.Text = "B) Draco";
                    button3.Text = "C) Ursa Minor";
                    button4.Text = "D) Ursa Major";
                    label1.BackColor = System.Drawing.Color.DarkBlue;

                }

            }
            else if (textBox1.Text == "The constellation pattern may take the shape of an ___, ___, ____, ___, or object such as a crown or compass." || textBox1.Text == "At the equator, the stars move in a ______ across the sky.")
            {
                score = 40;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Orion is visible during the winter night sky and is one of the most recognizable constellations – it contains some of the____stars that we can see and is named for the hunter from Greek mythology.";
                button1.Text = "A) darkest";
                button2.Text = "B) biggest";
                button3.Text = "C) brightest";
                button4.Text = "D) smallest";
                label4.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "Which direction do constellations move across the sky?")
            {
                score = 70;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Which star, contained in Canis Major, is the brightest in the sky?";
                button1.Text = "A) Aquila.";
                button2.Text = "B) Alderaban.";
                button3.Text = "C) Rigel.";
                button4.Text = "D) Sirius.";
                label7.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "Twenty-two constellation names begin with the same letter. Which letter?")
            {
                score = 200;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Which are the 2 most visible meteor showers?";
                button1.Text = "A) Perseids and Lyrids.";
                button2.Text = "B) Leonids and Perseids.";
                button3.Text = "C) Geminids and Orionids.";
                button4.Text = "D) Orionids and Leonids.";
                label12.BackColor = System.Drawing.Color.DarkBlue;
            }
            else
            {
                ConstellationQuizSad form = new ConstellationQuizSad();
                form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "What group of constellations are used in astrology?" || textBox1.Text == "What is the largest constellation by area in the sky?")
            {
                Random a3 = new Random();
                int ran3 = a3.Next(1, 3);
                if (ran3 == 1)
                {
                    score = 30;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    textBox1.Text = "The constellation pattern may take the shape of an ___, ___, ____, ___, or object such as a crown or compass.";
                    button1.Text = "A) Animal, mythological creature, men, women.";
                    button2.Text = "B) Planets, stars, animals, people.";
                    button3.Text = "C) Men, animals, stars, planets.";
                    button4.Text = "D) Stars, animals, people, men.";
                    label3.BackColor = System.Drawing.Color.DarkBlue;

                }

                else if (ran3 == 2)
                {
                    score = 30;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    textBox1.Text = "At the equator, the stars move in a ______ across the sky.";
                    button1.Text = "A) Straight line.";
                    button2.Text = "B) Circle.";
                    button3.Text = "C) Slow motion";
                    button4.Text = "D) They stand still";
                    label3.BackColor = System.Drawing.Color.DarkBlue;
                }

            }
            else if (textBox1.Text == "How many zodiacal constellations are there?")
            {
                score = 60;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "Which direction do constellations move across the sky?";
                button1.Text = "A) East to west.";
                button2.Text = "B) North to south.";
                button3.Text = "C) South to north.";
                button4.Text = "D) West to east.";
                label6.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "What is the only constellation named after something from the Bible?")
            {
                score = 150;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "Twenty-two constellation names begin with the same letter. Which letter?";
                button1.Text = "A) C.";
                button2.Text = "B) S.";
                button3.Text = "C) P.";
                button4.Text = "D) D.";
                label11.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "Which are the 2 most visible meteor showers?")
            {
                score = 300;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "Which sort of star is the Sun?";
                button1.Text = "A) White dwarf.";
                button2.Text = "B) Supergiant.";
                button3.Text = "C) Main sequence.";
                button4.Text = "D)  Giant.";
                label13.BackColor = System.Drawing.Color.DarkBlue;
            }
            else
            {
                ConstellationQuizSad form = new ConstellationQuizSad();
                form.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "What constellation was named after a flying horse?" || textBox1.Text == "What constellation has the Big Dipper as part of its pattern?")
            {
                Random a4 = new Random();
                int ran4 = a4.Next(1, 3);
                if (ran4 == 1)
                {
                    score = 20;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    textBox1.Text = "What group of constellations are used in astrology?";
                    button1.Text = "A) Northern constellations.";
                    button2.Text = "B) Zodiac constellations.";
                    button3.Text = "C) Ancient constellations.";
                    button4.Text = "D) Predictive constellations.";
                    label2.BackColor = System.Drawing.Color.DarkBlue;

                }

                else if (ran4 == 2)
                {
                    score = 20;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    textBox1.Text = "What is the largest constellation by area in the sky?";
                    button1.Text = "A) Cancer.";
                    button2.Text = "B) Hydra.";
                    button3.Text = "C) Cygnus.";
                    button4.Text = "D) Leo.";
                    label2.BackColor = System.Drawing.Color.DarkBlue;
                }

            }
            else if (textBox1.Text == "Which star, contained in Canis Major, is the brightest in the sky?")
            {
                score = 80;
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "What shape is Cassiopeia said to form?";
                button1.Text = "A) O";
                button2.Text = "B) L";
                button3.Text = "C) S";
                button4.Text = "D) M/W.";
                label8.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "What shape is Cassiopeia said to form?")
            {
                score = 90;
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "What is an asterism?";
                button1.Text = "A) A star that is part of multiple constellations.";
                button2.Text = "B) A grouping of constellations that create a larger pattern.";
                button3.Text = "C) A group of stars with a name that is smaller than a constellation.";
                button4.Text = "D) A star that is not part of any constellations.";
                label9.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "What happens when a supermassive star cools and collapses?")
            {
                ConstellationQuizHappy form = new ConstellationQuizHappy();
                form.Show();
                this.Hide();
            }
            else
            {
                ConstellationQuizSad form = new ConstellationQuizSad();
                form.Show();
                this.Hide();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Orion is visible during the winter night sky and is one of the most recognizable constellations – it contains some of the____stars that we can see and is named for the hunter from Greek mythology.")
            {

                score = 50;
                button1.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "How many zodiacal constellations are there?";
                button1.Text = "A) 12.";
                button2.Text = "B) 13.";
                button3.Text = "C) 6.";
                button4.Text = "D) 88.";
                label5.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "What is an asterism?")
            {
                score = 100;
                button1.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "What is the only constellation named after something from the Bible?";
                button1.Text = "A) Castor.";
                button2.Text = "B) Columba.";
                button3.Text = "C) Genesis.";
                button4.Text = "D) Serpens.";
                label10.BackColor = System.Drawing.Color.DarkBlue;
            }

            else if (textBox1.Text == "Which sort of star is the Sun?")
            {
                score = 400;
                button1.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "What happens when a supermassive star cools and collapses?";
                button1.Text = "A) When a massive star cools and collapses, it becomes a red giant.";
                button2.Text = "B) When a massive star cools and collapses, it becomes a black dwarf star.";
                button3.Text = "C) When a massive star cools and collapses, it becomes a nebula.";
                button4.Text = "D) When a massive star cools and collapses, it becomes a black hole.";
                label14.BackColor = System.Drawing.Color.DarkBlue;
            }

            else
            {
                ConstellationQuizSad form = new ConstellationQuizSad();
                form.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
