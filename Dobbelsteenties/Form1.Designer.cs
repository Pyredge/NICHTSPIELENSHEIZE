using System;

namespace Dobbelsteenties
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
            this.button1 = new System.Windows.Forms.Button();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.Dice4 = new System.Windows.Forms.PictureBox();
            this.Dice5 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(321, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gooien!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.gooien_Click);
            // 
            // Dice1
            // 
            this.Dice1.Location = new System.Drawing.Point(70, 60);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(107, 101);
            this.Dice1.TabIndex = 1;
            this.Dice1.TabStop = false;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice2
            // 
            this.Dice2.Location = new System.Drawing.Point(207, 60);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(107, 101);
            this.Dice2.TabIndex = 2;
            this.Dice2.TabStop = false;
            // 
            // Dice3
            // 
            this.Dice3.Location = new System.Drawing.Point(350, 60);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(107, 101);
            this.Dice3.TabIndex = 3;
            this.Dice3.TabStop = false;
            // 
            // Dice4
            // 
            this.Dice4.Location = new System.Drawing.Point(486, 60);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(107, 101);
            this.Dice4.TabIndex = 4;
            this.Dice4.TabStop = false;
            // 
            // Dice5
            // 
            this.Dice5.Location = new System.Drawing.Point(627, 60);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(107, 101);
            this.Dice5.TabIndex = 5;
            this.Dice5.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Dobbelen";
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.PictureBox Dice3;
        private System.Windows.Forms.PictureBox Dice4;
        private System.Windows.Forms.PictureBox Dice5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}

