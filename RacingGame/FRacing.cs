using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class FRacing : Form
    {
        private Point point;
        private bool dragging;
        private bool gameOver = false;
        private double calcTime;
        private int speed;
        private int speedEnemy;
        private int levelGame = 1;

        public FRacing()
        {
            InitializeComponent();

            this.picHighway.MouseDown += MouseClickDown;
            this.picHighway.MouseUp += MouseClickUp;
            this.picHighway.MouseMove += MouseClickMove;

            this.picHighwayBack.MouseDown += MouseClickDown;
            this.picHighwayBack.MouseUp += MouseClickUp;
            this.picHighwayBack.MouseMove += MouseClickMove;

            lblGameOver.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;

            setStartData();
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            point.X = e.X;
            point.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currentPoint.X - point.X, currentPoint.Y - point.Y + picHighway.Top);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void setStartData()
        {
            gameOver = false;
            calcTime = 0;
            speed = 2;
            speedEnemy = 3;
            levelGame = 1;
        }

    private void timer1_Tick(object sender, EventArgs e)
        {
            calcTime += 1;
            lblLevel.Text = $"{levelGame.ToString()}({calcTime.ToString()})";
            if (calcTime > 1000)
            {
                calcTime = 0;
                speed++;
                speedEnemy++;
                levelGame++; 
            }

            this.picHighway.Top += (int)speed;
            this.picHighwayBack.Top += (int)speed;

            this.picEnemy1.Top += (int)speedEnemy;
            this.picEnemy2.Top += (int)speedEnemy;

            if (this.picHighway.Top >= 520)
            {
                this.picHighway.Top = 0;
                this.picHighwayBack.Top = -520;
            }

            if (this.picEnemy1.Top >= 650)
            {
                this.picEnemy1.Top = -140;
                Random random = new Random();
                this.picEnemy1.Left = random.Next(110, 270);
            }                

            if (this.picEnemy2.Top >= 650)
            {
                this.picEnemy2.Top = -440;
                Random random = new Random();
                this.picEnemy2.Left = random.Next(320, 480);
            }

            if(this.picCar.Bounds.IntersectsWith(this.picEnemy1.Bounds) ||
                this.picCar.Bounds.IntersectsWith(this.picEnemy2.Bounds) )
            {
                gameOver = true;
                this.timer1.Enabled = false;
                lblGameOver.Visible = true;
                btnRestart.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver)
                return;

            int speed = 20;
            if((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && this.picCar.Left > 110)
                this.picCar.Left -= (int)speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && this.picCar.Right < 510)
                this.picCar.Left += (int)speed;

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            btnRestart.Visible = false;
            this.picEnemy1.Top = -140;
            this.picEnemy2.Top = -440;
            timer1.Enabled = true;            
            setStartData();
        }
    }
}
