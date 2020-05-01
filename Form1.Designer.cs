namespace BouncingBall
{
    partial class Field
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
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.Racket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Coral;
            this.Ball.Location = new System.Drawing.Point(365, 86);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(100, 100);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.Location = new System.Drawing.Point(12, 9);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(122, 44);
            this.SpeedLabel.TabIndex = 1;
            this.SpeedLabel.Text = "label1";
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.Aqua;
            this.Racket.Location = new System.Drawing.Point(291, 346);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(254, 38);
            this.Racket.TabIndex = 2;
            this.Racket.TabStop = false;
            this.Racket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Racket_MouseDown);
            this.Racket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Racket_MouseMove);
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Racket);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.Ball);
            this.Name = "Field";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.PictureBox Racket;
    }
}

