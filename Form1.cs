﻿using System;
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
    public partial class Field : Form
    {
        private int verVelocity = 0;
        private int horVelocity = 0;
        private int speed = 2;
        bool mouseDown = false;

        private Timer mainTimer = null;
        private Point MouseDownLocation;

        public Field()
        {
            InitializeComponent();
            InitializeField();
            InitializeMainTimer();
        }

        private void InitializeField()
        {
            verVelocity = speed;
            horVelocity = speed;
            this.BackColor = Color.LightBlue;
            this.DoubleBuffered = true;
            this.KeyDown += new KeyEventHandler(Field_KeyDown);
            UpdateSpeedLabel();
            Ball.Image = Properties.Resources.foot_ball;
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.Height = 40;
            Ball.Width = 40;
            Ball.BackColor = Color.Transparent;           
        }
        
        private void InitializeMainTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Interval = 10;
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            MoveTheBall();
            BallBorderCollision();
            BallRacketCollision();
        }

        private void MoveTheBall()
        {
            Ball.Top += verVelocity;
            Ball.Left += horVelocity;
        }

        private void BallBorderCollision()
        {
            if(Ball.Top + Ball.Height > ClientRectangle.Height)
            {
                verVelocity = -speed;
            }
            else if (Ball.Top < 0)
            {
                verVelocity = speed;
            }
            if (Ball.Left + Ball.Width > ClientRectangle.Width)
            {
                horVelocity = -speed;
            }
            else if (Ball.Left < 0)
            {
                horVelocity = speed;
            }
        }

        private void Field_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.X)
            {
                speed += 1; //speed++
                UpdateVelocities();
                UpdateSpeedLabel();
            }
            else if(e.KeyCode == Keys.Z)
            {
                if(speed > 1)
                {
                    speed -= 1; //speed--
                    UpdateVelocities();
                    UpdateSpeedLabel();
                }                
            }
        }

        private void UpdateSpeedLabel()
        {
            SpeedLabel.Text = "Ball speed: " + speed;
        }

        private void UpdateVelocities()
        {
            verVelocity = speed * (verVelocity / Math.Abs(verVelocity));
            horVelocity = speed * (horVelocity / Math.Abs(horVelocity));
        }

        private void BallRacketCollision()
        {
            if (Ball.Bounds.IntersectsWith(Racket.Bounds))
            {
                verVelocity = -verVelocity;
            }
        }

         private void Racket_MouseDown(object sender, MouseEventArgs e)
        {
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
