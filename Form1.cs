using System;
using System.Windows.Forms;

namespace My_Game
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpead;
        int force = 12;
        int score = 0;
        int rec;
        int obstracleSpeed = 10;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            person.Top += jumpSpead;

            txtScore.Text = "Счёт: " + score;
            if (rec < score)
            {
                rec = score;
            }

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpead = -12;
                force -= 1;
            }
            else
            {
                jumpSpead = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstracleSpeed;

                    if (x.Left < -120)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 800);
                        score++;
                    }

                    if (person.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        person.Image = Properties.Resources.dead;
                        sun.Image = Properties.Resources.XlOE;
                        txtScore2.Text += "Нажмите R чтобы перезапустить игру!";
                    }
                }
            }

            if (person.Top > 264 && jumping == false)
            {
                force = 12;
                person.Top = floor.Top - person.Height;
                jumpSpead = 0;
            }


            if (score >= 10)
            {
                obstracleSpeed = 12;
            }

            else if (score >= 20)
            {
                obstracleSpeed = 15;
            }

            else if (score >= 40)
            {
                obstracleSpeed = 18;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (jumping)
            {
                jumping = false;
            }


            if (e.KeyCode == Keys.R)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            person.Top = floor.Top - person.Height;
            jumpSpead = 0;
            jumping = false;
            score = 0;
            obstracleSpeed = 10;
            txtScore.Text = "Счёт: " + score;
            txtScore2.Text = "";
            txtScoreR.Text = "Рекорд: " + rec;
            person.Image = Properties.Resources.running;
            sun.Image = Properties.Resources.sun;
            person.Top = 284;
            pictureBox3.Top = 270;
            pictureBox4.Top = 290;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    int position = rand.Next(600, 1000);
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }

            gameTimer.Start();
        }
    }
}