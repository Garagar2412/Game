using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game
{
    public partial class Form1 : Form
    {
        bool jumping = false; // логическое значение для проверки, прыгает ли игрок или нет
        int jumpSpead; // целое число для установки скорости прыжка
        int force = 12; // сила прыжка в целом
        int score = 0; // целое число баллов по умолчанию установлено равным 0
        int rec; // целое число для установки рекорда
        int obstracleSpeed = 10; // скорость по умолчанию для препятствий
        Random rand = new Random(); // создаем новый случайный класс

        public Form1()
        {
            InitializeComponent();

            GameReset(); // запускаем функцию сброса игры
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            // привязываем целое число скорости прыжка к полям с картинками игрока и местоположению
            person.Top += jumpSpead;

            // показать счет на текстовой метке счета
            txtScore.Text = "Счёт: " + score;
            if (rec < score)
            {
                rec = score;
            }

            // если прыжок истинный и сила меньше 0 
            // затем меняем переход на false
            if (jumping && force < 0)
            {
                jumping = false;
            }

            // если прыжок верен 
            // затем меняем скорость прыжка на -12 
            // уменьшить силу на 1
            if (jumping)
            {
                jumpSpead = -12;
                force -= 1;
            }
            else
            {
                // иначе изменить скорость прыжка на 12
                jumpSpead = 12;
            }

            foreach(Control x in this.Controls)
            {
                // это X - это окно с изображением, и оно имеет тег препятствия
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstracleSpeed; // смещаем препятствия влево

                    if (x.Left < -120)
                    {
                        // если препятствия ушли за пределы экрана 
                        // затем мы возрождаем его справа 
                        // в данном случае мы вычисляем ширину формы и случайное число от 200 до 800
                        x.Left = this.ClientSize.Width + rand.Next(200, 800);
                        // мы добавим единицу к счету
                        score++;
                    }

                    // если тираннозавр сталкивается с препятствиями
                    if (person.Bounds.IntersectsWith(x.Bounds))
                    {
                        // останавливаем таймер
                        gameTimer.Stop();
                        // меняем изображение персонажа на мертвое
                        person.Image = Properties.Resources.dead;
                        // меняем изображение солнца на тучку
                        sun.Image = Properties.Resources.XlOE;
                        // показать, нажмите R, чтобы перезапустить
                        txtScore2.Text += "Нажмите R чтобы перезапустить игру!";
                    }
                }
            }

            // если вершина персонажа больше или равна 264 И 
            // прыжок неверный
            if (person.Top > 264 && jumping == false)
            {
                // далее делаем следующее
                force = 12; // устанавливаем силу на 12
                person.Top = floor.Top - person.Height; // так же размещаем плеер поверх картинки
                jumpSpead = 0; // устанавливаем скорость прыжка на 0
            }

            // если счет равен или больше 10
            if (score >= 10)
            {
                // скорость препятствия изменится на 12
                obstracleSpeed = 12;
            }
            // если счет равен или больше 20
            else if (score >= 20)
            {
                // скорость препятствия изменится на 15
                obstracleSpeed = 15;
            }
            // если счет равен или больше 40
            else if (score >= 40)
            {
                // скорость препятствия изменится на 18
                obstracleSpeed = 18;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //если игрок нажал пробел и прыгнуло логическое значение false
            // тогда мы устанавливаем прыжок в true
            if (e.KeyCode == Keys.Space &&  jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            //при отпускании клавиш проверяем правильность прыжка 
            // если это так, нам нужно вернуть значение false, чтобы игрок снова мог прыгать
            if (jumping)
            {
                jumping = false;
            }

            // если клавиша R нажата и отпущена, то мы запускаем функцию сброса
            if (e.KeyCode == Keys.R)
            {
                GameReset();
            }
        }

        private void GameReset() 
        {
            // Это функция сброса
            force = 12; // устанавливаем силу на 12
            person.Top = floor.Top - person.Height; // так же размещаем плеер поверх картинки
            jumpSpead = 0; // устанавливаем скорость прыжка на 0
            jumping = false; // изменить прыжок на false
            score = 0; // установить счет равным 0
            obstracleSpeed = 10; // устанавливаем скорость препятствия обратно на 10
            txtScore.Text = "Счёт: " + score; // меняем счет
            txtScore2.Text = ""; //убираем надпись "Нажмите R чтобы перезапустить игру!"
            txtScoreR.Text = "Рекорд: " + rec; // меняем рекорд
            person.Image = Properties.Resources.running; // меняем изображение персонажа на бегущее
            sun.Image = Properties.Resources.sun; // меняем изображение солнца
            person.Top = 284; // начальная похиция персонажа
            pictureBox3.Top = 270; // начальная позиция 1 препятствия 
            pictureBox4.Top = 290; // начальная позиция 2 препятствия 

            foreach (Control x in this.Controls)
            {
                // это X - это окно с изображением, и оно имеет тег препятствия
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    // генерируем случайное число в целочисленной позиции от 600 до 1000
                    int position = rand.Next(600, 1000);
                    // изменяем левую позицию препятствия на случайное начало игры
                    x.Left = 640 + (x.Left + position + x.Width * 3);

                }
            }

            gameTimer.Start(); // запускаем таймер
        }
    }
}