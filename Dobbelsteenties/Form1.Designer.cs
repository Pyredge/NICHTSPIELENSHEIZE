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
            this.HoldButtonDice4_Click_1 = new System.Windows.Forms.Button();
            this.HoldButtonDice5_Click_1 = new System.Windows.Forms.Button();
            this.HoldButtonDice2_Click = new System.Windows.Forms.Button();
            this.HoldButtonDice1_Click = new System.Windows.Forms.Button();
            this.HoldButtonDice3_Click = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(382, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gooien!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.gooien_Click);
            // 
            // Dice1
            // 
            this.Dice1.Location = new System.Drawing.Point(142, 28);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(107, 101);
            this.Dice1.TabIndex = 1;
            this.Dice1.TabStop = false;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice2
            // 
            this.Dice2.Location = new System.Drawing.Point(293, 28);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(107, 101);
            this.Dice2.TabIndex = 2;
            this.Dice2.TabStop = false;
            // 
            // Dice3
            // 
            this.Dice3.Location = new System.Drawing.Point(454, 28);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(107, 101);
            this.Dice3.TabIndex = 3;
            this.Dice3.TabStop = false;
            // 
            // Dice4
            // 
            this.Dice4.Location = new System.Drawing.Point(598, 28);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(107, 101);
            this.Dice4.TabIndex = 4;
            this.Dice4.TabStop = false;
            // 
            // Dice5
            // 
            this.Dice5.Location = new System.Drawing.Point(746, 28);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(107, 101);
            this.Dice5.TabIndex = 5;
            this.Dice5.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(382, 293);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(305, 58);
            this.textBox.TabIndex = 6;
            // 
            // checken
            // 
            this.checken.Location = new System.Drawing.Point(543, 369);
            this.checken.Name = "checken";
            this.checken.Size = new System.Drawing.Size(144, 70);
            this.checken.TabIndex = 7;
            this.checken.Text = "Checken";
            this.checken.UseVisualStyleBackColor = true;
            this.checken.Click += new System.EventHandler(this.checken_Click);
            // 
            // HoldButtonDice4_Click_1
            // 
            this.HoldButtonDice4_Click_1.Location = new System.Drawing.Point(159, 144);
            this.HoldButtonDice4_Click_1.Name = "HoldButtonDice4_Click_1";
            this.HoldButtonDice4_Click_1.Size = new System.Drawing.Size(75, 23);
            this.HoldButtonDice4_Click_1.TabIndex = 8;
            this.HoldButtonDice4_Click_1.Text = "button2";
            this.HoldButtonDice4_Click_1.UseVisualStyleBackColor = true;
            this.HoldButtonDice4_Click_1.Click += new System.EventHandler(this.HoldButtonDice4_Click_1_Click);
            // 
            // HoldButtonDice5_Click_1
            // 
            this.HoldButtonDice5_Click_1.Location = new System.Drawing.Point(308, 146);
            this.HoldButtonDice5_Click_1.Name = "HoldButtonDice5_Click_1";
            this.HoldButtonDice5_Click_1.Size = new System.Drawing.Size(75, 23);
            this.HoldButtonDice5_Click_1.TabIndex = 9;
            this.HoldButtonDice5_Click_1.Text = "button3";
            this.HoldButtonDice5_Click_1.UseVisualStyleBackColor = true;
            this.HoldButtonDice5_Click_1.Click += new System.EventHandler(this.HoldButtonDice5_Click_1_Click);
            // 
            // HoldButtonDice2_Click
            // 
            this.HoldButtonDice2_Click.Location = new System.Drawing.Point(472, 146);
            this.HoldButtonDice2_Click.Name = "HoldButtonDice2_Click";
            this.HoldButtonDice2_Click.Size = new System.Drawing.Size(75, 23);
            this.HoldButtonDice2_Click.TabIndex = 10;
            this.HoldButtonDice2_Click.Text = "button4";
            this.HoldButtonDice2_Click.UseVisualStyleBackColor = true;
            this.HoldButtonDice2_Click.Click += new System.EventHandler(this.HoldButtonDice2_Click_Click);
            // 
            // HoldButtonDice1_Click
            // 
            this.HoldButtonDice1_Click.Location = new System.Drawing.Point(612, 146);
            this.HoldButtonDice1_Click.Name = "HoldButtonDice1_Click";
            this.HoldButtonDice1_Click.Size = new System.Drawing.Size(75, 23);
            this.HoldButtonDice1_Click.TabIndex = 11;
            this.HoldButtonDice1_Click.Text = "button5";
            this.HoldButtonDice1_Click.UseVisualStyleBackColor = true;
            this.HoldButtonDice1_Click.Click += new System.EventHandler(this.HoldButtonDice1_Click_Click);
            // 
            // HoldButtonDice3_Click
            // 
            this.HoldButtonDice3_Click.Location = new System.Drawing.Point(759, 146);
            this.HoldButtonDice3_Click.Name = "HoldButtonDice3_Click";
            this.HoldButtonDice3_Click.Size = new System.Drawing.Size(75, 23);
            this.HoldButtonDice3_Click.TabIndex = 12;
            this.HoldButtonDice3_Click.Text = "button6";
            this.HoldButtonDice3_Click.UseVisualStyleBackColor = true;
            this.HoldButtonDice3_Click.Click += new System.EventHandler(this.HoldButtonDice3_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1138, 552);
            this.Controls.Add(this.HoldButtonDice3_Click);
            this.Controls.Add(this.HoldButtonDice1_Click);
            this.Controls.Add(this.HoldButtonDice2_Click);
            this.Controls.Add(this.HoldButtonDice5_Click_1);
            this.Controls.Add(this.HoldButtonDice4_Click_1);
            this.Controls.Add(this.checken);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.button1);
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

        private void checken_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private System.Windows.Forms.Button HoldButtonDice4_Click_1;
        private System.Windows.Forms.Button HoldButtonDice5_Click_1;
        private System.Windows.Forms.Button HoldButtonDice2_Click;
        private System.Windows.Forms.Button HoldButtonDice1_Click;
        private System.Windows.Forms.Button HoldButtonDice3_Click;
    }
}

