﻿namespace BouncingBall
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
            this.Ball = new System.Windows.Forms.PictureBox();
            this.BallStepLabel = new System.Windows.Forms.Label();
            this.Racket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.OrangeRed;
            this.Ball.Location = new System.Drawing.Point(319, 264);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(100, 98);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // BallStepLabel
            // 
            this.BallStepLabel.AutoSize = true;
            this.BallStepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BallStepLabel.Location = new System.Drawing.Point(12, 9);
            this.BallStepLabel.Name = "BallStepLabel";
            this.BallStepLabel.Size = new System.Drawing.Size(122, 44);
            this.BallStepLabel.TabIndex = 1;
            this.BallStepLabel.Text = "label1";
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.DarkOrchid;
            this.Racket.Location = new System.Drawing.Point(267, 409);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(223, 34);
            this.Racket.TabIndex = 2;
            this.Racket.TabStop = false;
            this.Racket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Racket_MouseDown);
            this.Racket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Racket_MouseMove);
            this.Racket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Racket_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 518);
            this.Controls.Add(this.Racket);
            this.Controls.Add(this.BallStepLabel);
            this.Controls.Add(this.Ball);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label BallStepLabel;
        private System.Windows.Forms.PictureBox Racket;
    }
}

