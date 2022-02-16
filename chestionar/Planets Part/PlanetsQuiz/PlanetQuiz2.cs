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
    public partial class PlanetQuiz2 : Form
    {
        public PlanetQuiz2()
        {
            InitializeComponent();
        }

        private void PlanetQuiz2_Load(object sender, EventArgs e)
        {
            Random a1 = new Random();
            int ran1 = a1.Next(1, 5);
            if (ran1 == 1)
            {
                textBox1.Text = "The 'brightest' planet in the sky is...";
                button1.Text = "A) Venus.";
                button2.Text = "B) Mars.";
                button3.Text = "C) Jupiter.";
                button4.Text = "D) Saturn.";

            }

            else if (ran1 == 2)
            {
                textBox1.Text = "... means Earth spins on its axis.";
                button1.Text = "A) Rotation.";
                button2.Text = "B) Revolution.";
                button3.Text = "C) Oribit.";
                button4.Text = "D) Spinning.";
            }


            else if (ran1 == 3)
            {
                textBox1.Text = "Seasonal climatic variations are due to the...";
                button1.Text = "A) Earth's tilt and revolution.";
                button2.Text = "B) Revolution.";
                button3.Text = "C) Earth's tilt.";
                button4.Text = "D) Rotation and Revolution.";

            }

            else if (ran1 == 4)
            {
                textBox1.Text = "There are ... tides in a day.";
                button1.Text = "A) 4.";
                button2.Text = "B) 1.";
                button3.Text = "C) 3.";
                button4.Text = "D) 2.";
            }
        }

        public static int score = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "The 'brightest' planet in the sky is..." || textBox1.Text == "... means Earth spins on its axis." || textBox1.Text == "Seasonal climatic variations are due to the..." || textBox1.Text == "There are ... tides in a day.")
            {
                Random a2 = new Random();
                int ran2 = a2.Next(1, 3);
                if (ran2 == 1)
                {
                    score = 10;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "Which planet has its moons named after William Shakespeare's characters?";
                    button1.Text = "A) Mars.";
                    button2.Text = "B) Neptune.";
                    button3.Text = "C) Uranus.";
                    button4.Text = "D) Jupiter.";
                    label1.BackColor = System.Drawing.Color.DarkBlue;

                }

                else if (ran2 == 2)
                {
                    score = 10;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "How much larger the Sun is than Earth?";
                    button1.Text = "A) 500000 larger.";
                    button2.Text = "B) 200000 larger.";
                    button3.Text = "C) 300000 larger.";
                    button4.Text = "D) 50000 larger.";
                    label1.BackColor = System.Drawing.Color.DarkBlue;

                }

            }
            else if (textBox1.Text == "The fastest planet in the Solar System is..." || textBox1.Text == "Which Planet Has the Most Moons?" )
            {
                score = 40;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Which planet(planets) does(do) not have moons?";
                button1.Text = "A) Mercury.";
                button2.Text = "B) Mars.";
                button3.Text = "C) Mercury and Mars.";
                button4.Text = "D) Mercury and Venus.";
                label4.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "What is the surface temperature of Venus?")
            {
                score = 60;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Who was the first person to set foot on the Moon?";
                button1.Text = "A) Alan Shepard.";
                button2.Text = "B) Buzz Adrin.";
                button3.Text = "C) Charles Duke.";
                button4.Text = "D) Neil Armstrong.";
                label6.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "Which Planets Have Rings around Them?")
            {
                score = 100;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Which Is the Hottest Planet in the solar system?";
                button1.Text = "A) Mars.";
                button2.Text = "B) Mercury.";
                button3.Text = "C) Venus.";
                button4.Text = "D) Earth.";
                label10.BackColor = System.Drawing.Color.DarkBlue;
            }
            else
            {
                PlanetQuizSad form = new PlanetQuizSad();
                form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "What 3 main elements are the Gas Giants composed of?" || textBox1.Text == "Which planet is known as the Morning Star or the Evening Star?")
            {
                Random a3 = new Random();
                int ran3 = a3.Next(1, 3);
                if (ran3 == 1)
                {
                    score = 30;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    textBox1.Text = "The fastest planet in the Solar System is...";
                    button1.Text = "A) Mercury.";
                    button2.Text = "B) Earth.";
                    button3.Text = "C) Mars.";
                    button4.Text = "D) Venus.";
                    label3.BackColor = System.Drawing.Color.DarkBlue;

                }

                else if (ran3 == 2)
                {
                    score = 30;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    textBox1.Text = "Which Planet Has the Most Moons?";
                    button1.Text = "A) Jupiter.";
                    button2.Text = "B) Neptune.";
                    button3.Text = "C) Uranus.";
                    button4.Text = "D) Saturn.";
                    label3.BackColor = System.Drawing.Color.DarkBlue;
                }

            }
            else if (textBox1.Text == "Jupiter’s 4 biggest moons are...")
            {
                score = 90;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "Which Planets Have Rings around Them?";
                button1.Text = "A) Saturn, Jupiter, Uranus, and Neptune.";
                button2.Text = "B) Saturn, Jupiter and Neptune.";
                button3.Text = "C) Saturn and Uranus.";
                button4.Text = "D) Jupiter and Uranus.";
                label9.BackColor = System.Drawing.Color.DarkBlue;
            }
            
            else
            {
                PlanetQuizSad form = new PlanetQuizSad();
                form.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Which planet has its moons named after William Shakespeare's characters?" || textBox1.Text == "How much larger the Sun is than Earth?")
            {
                Random a4 = new Random();
                int ran4 = a4.Next(1, 3);
                if (ran4 == 1)
                {
                    score = 20;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What 3 main elements are the Gas Giants composed of?";
                    button1.Text = "A) Oxygen, Carbon Dioxide, and Helium.";
                    button2.Text = "B) Helium, Hydrogen, and Methane.";
                    button3.Text = "C) Hydrogen, Oxygen, and Helium.";
                    button4.Text = "D) Sulfuric Acid, Methane, and Hydrogen.";
                    label2.BackColor = System.Drawing.Color.DarkBlue;

                }

                else if (ran4 == 2)
                {
                    score = 20;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "Which planet is known as the Morning Star or the Evening Star?";
                    button1.Text = "A) Saturn.";
                    button2.Text = "B) Venus.";
                    button3.Text = "C) Jupiter.";
                    button4.Text = "D) Mars.";
                    label2.BackColor = System.Drawing.Color.DarkBlue;
                }

            }
            else if (textBox1.Text == "The Moon orbits the Earth every...")
            {
                score = 80;
                button1.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Jupiter’s 4 biggest moons are...";
                button1.Text = "A) Adrastea, Titan, Metis and Io";
                button2.Text = "B) Europa, Ganymede, Callisto and Io.";
                button3.Text = "C) Metis, Amalthea, Thebe and Dia.";
                button4.Text = "D) Leda, Europa, Elara and Callisto.";
                label8.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "Which Is the Hottest Planet in the solar system?")
            {
                score = 150;
                button1.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "What is the coldest place in the universe?";
                button1.Text = "A) A star.";
                button2.Text = "B) A planet";
                button3.Text = "C) A moon";
                button4.Text = "D) A nebula.";
                label11.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "What is the smallest planet in our solar system?")
            {
                PlanetQuizHappy form = new PlanetQuizHappy();
                form.Show();
                this.Hide();
            }
            else
            {
                PlanetQuizSad form = new PlanetQuizSad();
                form.Show();
                this.Hide();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Which planet(planets) does(do) not have moons?")
            {

                score = 50;
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "What is the surface temperature of Venus?";
                button1.Text = "A) Over 450 degrees Celsius.";
                button2.Text = "B) Under 200 degrees Celsius.";
                button3.Text = "C) Approx. 400 degrees Celsius.";
                button4.Text = "D) Approx. 300 degrees Celsius.";
                label5.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (textBox1.Text == "Who was the first person to set foot on the Moon?")
            {
                score = 70;
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "The Moon orbits the Earth every...";
                button1.Text = "A) 28.7 days.";
                button2.Text = "B) 29.5 days.";
                button3.Text = "C) 27.3 days.";
                button4.Text = "D) 28 days.";
                label7.BackColor = System.Drawing.Color.DarkBlue;
            }

            else if (textBox1.Text == "What is the coldest place in the universe?")
            {
                score = 200;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "What is the smallest planet in our solar system?";
                button1.Text = "A) Pluto.";
                button2.Text = "B) Venus.";
                button3.Text = "C) Mercury.";
                button4.Text = "D) Titan.";
                label12.BackColor = System.Drawing.Color.DarkBlue;
            }

            else
            {
                PlanetQuizSad form = new PlanetQuizSad();
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