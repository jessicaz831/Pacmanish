namespace Unit1Assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrLoop = new System.Windows.Forms.Timer(this.components);
            this.lblWin = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picObject8 = new System.Windows.Forms.PictureBox();
            this.picObject7 = new System.Windows.Forms.PictureBox();
            this.picObject6 = new System.Windows.Forms.PictureBox();
            this.picObject9 = new System.Windows.Forms.PictureBox();
            this.picObject10 = new System.Windows.Forms.PictureBox();
            this.picObject5 = new System.Windows.Forms.PictureBox();
            this.picObject4 = new System.Windows.Forms.PictureBox();
            this.picObject2 = new System.Windows.Forms.PictureBox();
            this.picObject3 = new System.Windows.Forms.PictureBox();
            this.picObject1 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLoop
            // 
            this.tmrLoop.Enabled = true;
            this.tmrLoop.Tick += new System.EventHandler(this.tmrLoop_Tick);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("NSimSun", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.White;
            this.lblWin.Location = new System.Drawing.Point(307, 336);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(385, 97);
            this.lblWin.TabIndex = 11;
            this.lblWin.Text = "You Win";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(94, 282);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(109, 29);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "label1";
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.ForeColor = System.Drawing.Color.White;
            this.lblResume.Location = new System.Drawing.Point(460, 237);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(109, 29);
            this.lblResume.TabIndex = 16;
            this.lblResume.Text = "Resume";
            this.lblResume.Click += new System.EventHandler(this.lblResume_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(474, 322);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(77, 29);
            this.lblHelp.TabIndex = 17;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.White;
            this.lblRestart.Location = new System.Drawing.Point(454, 420);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(125, 29);
            this.lblRestart.TabIndex = 18;
            this.lblRestart.Text = "Restart";
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(26, 693);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(77, 29);
            this.lblBack.TabIndex = 19;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("NSimSun", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(250, 282);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(532, 97);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Pacman-ish";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(474, 420);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(77, 29);
            this.lblPlay.TabIndex = 21;
            this.lblPlay.Text = "Play";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // picPause
            // 
            this.picPause.Image = global::Unit1Assignment.Properties.Resources.pause;
            this.picPause.Location = new System.Drawing.Point(987, 0);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(52, 50);
            this.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPause.TabIndex = 15;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            // 
            // picEnemy
            // 
            this.picEnemy.Image = global::Unit1Assignment.Properties.Resources.ghostright;
            this.picEnemy.Location = new System.Drawing.Point(0, 0);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(103, 104);
            this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy.TabIndex = 12;
            this.picEnemy.TabStop = false;
            // 
            // picObject8
            // 
            this.picObject8.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject8.Location = new System.Drawing.Point(112, 652);
            this.picObject8.Name = "picObject8";
            this.picObject8.Size = new System.Drawing.Size(30, 30);
            this.picObject8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject8.TabIndex = 10;
            this.picObject8.TabStop = false;
            // 
            // picObject7
            // 
            this.picObject7.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject7.Location = new System.Drawing.Point(808, 451);
            this.picObject7.Name = "picObject7";
            this.picObject7.Size = new System.Drawing.Size(30, 30);
            this.picObject7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject7.TabIndex = 9;
            this.picObject7.TabStop = false;
            // 
            // picObject6
            // 
            this.picObject6.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject6.Location = new System.Drawing.Point(247, 419);
            this.picObject6.Name = "picObject6";
            this.picObject6.Size = new System.Drawing.Size(30, 30);
            this.picObject6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject6.TabIndex = 8;
            this.picObject6.TabStop = false;
            // 
            // picObject9
            // 
            this.picObject9.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject9.Location = new System.Drawing.Point(539, 596);
            this.picObject9.Name = "picObject9";
            this.picObject9.Size = new System.Drawing.Size(30, 30);
            this.picObject9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject9.TabIndex = 7;
            this.picObject9.TabStop = false;
            // 
            // picObject10
            // 
            this.picObject10.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject10.Location = new System.Drawing.Point(996, 711);
            this.picObject10.Name = "picObject10";
            this.picObject10.Size = new System.Drawing.Size(30, 30);
            this.picObject10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject10.TabIndex = 6;
            this.picObject10.TabStop = false;
            // 
            // picObject5
            // 
            this.picObject5.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject5.Location = new System.Drawing.Point(918, 237);
            this.picObject5.Name = "picObject5";
            this.picObject5.Size = new System.Drawing.Size(30, 30);
            this.picObject5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject5.TabIndex = 5;
            this.picObject5.TabStop = false;
            // 
            // picObject4
            // 
            this.picObject4.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject4.Location = new System.Drawing.Point(441, 165);
            this.picObject4.Name = "picObject4";
            this.picObject4.Size = new System.Drawing.Size(30, 30);
            this.picObject4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject4.TabIndex = 4;
            this.picObject4.TabStop = false;
            // 
            // picObject2
            // 
            this.picObject2.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject2.Location = new System.Drawing.Point(808, 36);
            this.picObject2.Name = "picObject2";
            this.picObject2.Size = new System.Drawing.Size(30, 30);
            this.picObject2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject2.TabIndex = 3;
            this.picObject2.TabStop = false;
            // 
            // picObject3
            // 
            this.picObject3.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject3.Location = new System.Drawing.Point(65, 199);
            this.picObject3.Name = "picObject3";
            this.picObject3.Size = new System.Drawing.Size(30, 30);
            this.picObject3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject3.TabIndex = 2;
            this.picObject3.TabStop = false;
            // 
            // picObject1
            // 
            this.picObject1.Image = global::Unit1Assignment.Properties.Resources.pacmandot;
            this.picObject1.Location = new System.Drawing.Point(12, 12);
            this.picObject1.Name = "picObject1";
            this.picObject1.Size = new System.Drawing.Size(30, 30);
            this.picObject1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picObject1.TabIndex = 1;
            this.picObject1.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::Unit1Assignment.Properties.Resources.pacmanright;
            this.picPlayer.Location = new System.Drawing.Point(479, 336);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(100, 94);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1038, 753);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picObject8);
            this.Controls.Add(this.picObject7);
            this.Controls.Add(this.picObject6);
            this.Controls.Add(this.picObject9);
            this.Controls.Add(this.picObject10);
            this.Controls.Add(this.picObject5);
            this.Controls.Add(this.picObject4);
            this.Controls.Add(this.picObject2);
            this.Controls.Add(this.picObject3);
            this.Controls.Add(this.picObject1);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picObject1;
        private System.Windows.Forms.PictureBox picObject3;
        private System.Windows.Forms.PictureBox picObject2;
        private System.Windows.Forms.PictureBox picObject4;
        private System.Windows.Forms.PictureBox picObject5;
        private System.Windows.Forms.PictureBox picObject10;
        private System.Windows.Forms.PictureBox picObject9;
        private System.Windows.Forms.PictureBox picObject6;
        private System.Windows.Forms.PictureBox picObject7;
        private System.Windows.Forms.PictureBox picObject8;
        private System.Windows.Forms.Timer tmrLoop;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlay;
    }
}

