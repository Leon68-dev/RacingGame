namespace RacingGame
{
    partial class Racing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Racing));
            this.picHighway = new System.Windows.Forms.PictureBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picHighwayBack = new System.Windows.Forms.PictureBox();
            this.picEnemy1 = new System.Windows.Forms.PictureBox();
            this.picEnemy2 = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHighway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighwayBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).BeginInit();
            this.SuspendLayout();
            // 
            // picHighway
            // 
            this.picHighway.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picHighway.Image = ((System.Drawing.Image)(resources.GetObject("picHighway.Image")));
            this.picHighway.Location = new System.Drawing.Point(0, 0);
            this.picHighway.Name = "picHighway";
            this.picHighway.Size = new System.Drawing.Size(840, 650);
            this.picHighway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHighway.TabIndex = 0;
            this.picHighway.TabStop = false;
            // 
            // picCar
            // 
            this.picCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picCar.Image = ((System.Drawing.Image)(resources.GetObject("picCar.Image")));
            this.picCar.Location = new System.Drawing.Point(380, 506);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(80, 128);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 1;
            this.picCar.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picHighwayBack
            // 
            this.picHighwayBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picHighwayBack.Image = ((System.Drawing.Image)(resources.GetObject("picHighwayBack.Image")));
            this.picHighwayBack.Location = new System.Drawing.Point(0, -650);
            this.picHighwayBack.Name = "picHighwayBack";
            this.picHighwayBack.Size = new System.Drawing.Size(840, 650);
            this.picHighwayBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHighwayBack.TabIndex = 2;
            this.picHighwayBack.TabStop = false;
            // 
            // picEnemy1
            // 
            this.picEnemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy1.Image")));
            this.picEnemy1.Location = new System.Drawing.Point(215, -140);
            this.picEnemy1.Name = "picEnemy1";
            this.picEnemy1.Size = new System.Drawing.Size(80, 128);
            this.picEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemy1.TabIndex = 3;
            this.picEnemy1.TabStop = false;
            // 
            // picEnemy2
            // 
            this.picEnemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy2.Image")));
            this.picEnemy2.Location = new System.Drawing.Point(495, -440);
            this.picEnemy2.Name = "picEnemy2";
            this.picEnemy2.Size = new System.Drawing.Size(80, 128);
            this.picEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemy2.TabIndex = 4;
            this.picEnemy2.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.Location = new System.Drawing.Point(303, 144);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(224, 46);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.Location = new System.Drawing.Point(330, 234);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(182, 39);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevel.Location = new System.Drawing.Point(12, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(14, 16);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "0";
            // 
            // Racing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picEnemy2);
            this.Controls.Add(this.picEnemy1);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.picHighwayBack);
            this.Controls.Add(this.picHighway);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Racing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picHighway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighwayBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHighway;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picHighwayBack;
        private System.Windows.Forms.PictureBox picEnemy1;
        private System.Windows.Forms.PictureBox picEnemy2;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblLevel;
    }
}

