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
            this.button1 = new System.Windows.Forms.Button();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.Dice4 = new System.Windows.Forms.PictureBox();
            this.Dice5 = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.checken = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(341, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gooien!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.gooien_Click);
            // 
            // Dice1
            // 
            this.Dice1.Location = new System.Drawing.Point(1359, 15);
            this.Dice1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(143, 124);
            this.Dice1.TabIndex = 1;
            this.Dice1.TabStop = false;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice2
            // 
            this.Dice2.Location = new System.Drawing.Point(1359, 146);
            this.Dice2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(143, 124);
            this.Dice2.TabIndex = 2;
            this.Dice2.TabStop = false;
            // 
            // Dice3
            // 
            this.Dice3.Location = new System.Drawing.Point(1359, 278);
            this.Dice3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(143, 124);
            this.Dice3.TabIndex = 3;
            this.Dice3.TabStop = false;
            // 
            // Dice4
            // 
            this.Dice4.Location = new System.Drawing.Point(1359, 410);
            this.Dice4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(143, 124);
            this.Dice4.TabIndex = 4;
            this.Dice4.TabStop = false;
            // 
            // Dice5
            // 
            this.Dice5.Location = new System.Drawing.Point(1359, 542);
            this.Dice5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(143, 124);
            this.Dice5.TabIndex = 5;
            this.Dice5.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(341, 215);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(405, 70);
            this.textBox.TabIndex = 6;
            // 
            // checken
            // 
            this.checken.Location = new System.Drawing.Point(556, 336);
            this.checken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checken.Name = "checken";
            this.checken.Size = new System.Drawing.Size(192, 86);
            this.checken.TabIndex = 7;
            this.checken.Text = "Checken";
            this.checken.UseVisualStyleBackColor = true;
            this.checken.Click += new System.EventHandler(this.checken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1517, 679);
            this.Controls.Add(this.checken);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "--";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button checken;
    }
}

