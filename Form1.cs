using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        int horVelocity = 0;
        int verVelocity = 0;
        int ballStep = 3;
        bool mouseDown = false;

        private Point MouseDownLocation;

        Timer mainTimer = null;


        public Form1()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            verVelocity = ballStep;
            horVelocity = ballStep;

            Ball.Width = 40;
            Ball.Height = 40;
            Ball.BackColor = Color.Transparent;
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.Image = Properties.Resources.foot_ball;

            this.KeyDown += new KeyEventHandler(App_KeyDown);
            this.DoubleBuffered = true;

            UpdateBallStepLabel();
            InitializeMainTimer();
        }

        private void InitializeMainTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Interval = 20;
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            MoveBall();
            BallBorderCollide();
            BallRacketCollision();
        }

        private void MoveBall()
        {
            Ball.Top += verVelocity;
            Ball.Left += horVelocity;
        }

        private void BallRacketCollision()
        {
            if (Ball.Bounds.IntersectsWith(Racket.Bounds))
            {
                verVelocity *= -1;
            }
        }

        private void BallBorderCollide()
        {
            if(Ball.Top + Ball.Height > ClientRectangle.Height) //collide with bottom border
            {
                verVelocity *= -1;
                //verVelocity = -verVelocity;                
            }
            else if (Ball.Top < 0) //collide with top border
            {
                verVelocity *= -1;
                //verVelocity = -verVelocity;
            }
            else if(Ball.Left < 0) //collide with left border
            {
                horVelocity *= -1;
                //horVelocity = -horVelocity;
            }
            else if(Ball.Left + Ball.Width > ClientRectangle.Width) //collide with right border
            {
                horVelocity *= -1;
                //horVelocity = -horVelocity;
            }
        }

        private void App_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.X)
            {
                ballStep += 1;
                verVelocity = ballStep * (verVelocity / Math.Abs(verVelocity));
                horVelocity = ballStep * (horVelocity / Math.Abs(horVelocity));
                UpdateBallStepLabel();
            }
            else if(e.KeyCode == Keys.Z)
            {
                if(ballStep > 1)
                {
                    ballStep -= 1;
                    verVelocity = ballStep * (verVelocity / Math.Abs(verVelocity));
                    horVelocity = ballStep * (horVelocity / Math.Abs(horVelocity));
                    UpdateBallStepLabel();
                }
            }
        }

        private void UpdateBallStepLabel()
        {
            BallStepLabel.Text = "Ball Step: " + ballStep;
        }


        private void Racket_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Racket_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Racket_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Racket.Left = e.X + Racket.Left - MouseDownLocation.X;
                Racket.Top = e.Y + Racket.Top - MouseDownLocation.Y;
            }
        }
    }
}
