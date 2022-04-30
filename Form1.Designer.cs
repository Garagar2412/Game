
namespace My_Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.Label();
            this.txtScoreR = new System.Windows.Forms.Label();
            this.sun = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.person = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(111, 29);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Счёт: 0";
            // 
            // txtScore2
            // 
            this.txtScore2.AutoSize = true;
            this.txtScore2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtScore2.Location = new System.Drawing.Point(151, 188);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(0, 29);
            this.txtScore2.TabIndex = 4;
            // 
            // txtScoreR
            // 
            this.txtScoreR.AutoSize = true;
            this.txtScoreR.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScoreR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScoreR.Location = new System.Drawing.Point(624, 9);
            this.txtScoreR.Name = "txtScoreR";
            this.txtScoreR.Size = new System.Drawing.Size(139, 29);
            this.txtScoreR.TabIndex = 5;
            this.txtScoreR.Text = "Рекорд: 0";
            // 
            // sun
            // 
            this.sun.Image = global::My_Game.Properties.Resources.sun;
            this.sun.Location = new System.Drawing.Point(319, 23);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(163, 131);
            this.sun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sun.TabIndex = 7;
            this.sun.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Image = global::My_Game.Properties.Resources.pol;
            this.floor.Location = new System.Drawing.Point(-13, 403);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(823, 50);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 3;
            this.floor.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::My_Game.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(629, 357);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::My_Game.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(501, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // person
            // 
            this.person.Image = global::My_Game.Properties.Resources.running;
            this.person.Location = new System.Drawing.Point(62, 327);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(73, 76);
            this.person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.person.TabIndex = 6;
            this.person.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 442);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.person);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.txtScoreR);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "My Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.sun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtScore2;
        private System.Windows.Forms.Label txtScoreR;
        private System.Windows.Forms.PictureBox person;
        private System.Windows.Forms.PictureBox sun;
    }
}

