namespace Game_Cars
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bg1 = new PictureBox();
            player = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            bg2 = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            time = new PictureBox();
            labelLose = new Label();
            btnRestart = new Button();
            coin = new PictureBox();
            labelCoins = new Label();
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)time).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // bg1
            // 
            bg1.BackgroundImage = (Image)resources.GetObject("bg1.BackgroundImage");
            bg1.Location = new Point(1, 0);
            bg1.Name = "bg1";
            bg1.Size = new Size(840, 650);
            bg1.TabIndex = 0;
            bg1.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(175, 519);
            player.Name = "player";
            player.Size = new Size(110, 120);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // bg2
            // 
            bg2.BackgroundImage = (Image)resources.GetObject("bg2.BackgroundImage");
            bg2.Location = new Point(0, -650);
            bg2.Name = "bg2";
            bg2.Size = new Size(840, 650);
            bg2.TabIndex = 3;
            bg2.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(302, -130);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(110, 120);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 4;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(430, -400);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(110, 120);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 5;
            enemy2.TabStop = false;
            // 
            // time
            // 
            time.Image = (Image)resources.GetObject("time.Image");
            time.Location = new Point(749, 12);
            time.Name = "time";
            time.Size = new Size(42, 41);
            time.SizeMode = PictureBoxSizeMode.StretchImage;
            time.TabIndex = 6;
            time.TabStop = false;
            time.Click += time_Click;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.Red;
            labelLose.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelLose.ForeColor = SystemColors.ButtonHighlight;
            labelLose.Location = new Point(298, 187);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(250, 46);
            labelLose.TabIndex = 7;
            labelLose.Text = "Вы проиграли!";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Lime;
            btnRestart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestart.Location = new Point(323, 339);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(196, 40);
            btnRestart.TabIndex = 8;
            btnRestart.Text = "Играть снова";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // coin
            // 
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(369, 57);
            coin.Name = "coin";
            coin.Size = new Size(35, 35);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 9;
            coin.TabStop = false;
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.PeachPuff;
            labelCoins.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCoins.ForeColor = SystemColors.ActiveCaptionText;
            labelCoins.Location = new Point(1, 0);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(117, 32);
            labelCoins.TabIndex = 10;
            labelCoins.Text = "Монет: 0.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(840, 650);
            Controls.Add(labelCoins);
            Controls.Add(coin);
            Controls.Add(btnRestart);
            Controls.Add(labelLose);
            Controls.Add(time);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(player);
            Controls.Add(bg1);
            Controls.Add(bg2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)time).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg1;
        private PictureBox player;
        private System.Windows.Forms.Timer timer;
        private PictureBox bg2;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox time;
        private Label labelLose;
        private Button btnRestart;
        private PictureBox coin;
        private Label labelCoins;
    }
}