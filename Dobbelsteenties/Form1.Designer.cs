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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.Dice4 = new System.Windows.Forms.PictureBox();
            this.Dice5 = new System.Windows.Forms.PictureBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vijfGelijkeLabel = new System.Windows.Forms.Label();
            this.vierGelijkeLabel = new System.Windows.Forms.Label();
            this.hogeStraatLabel = new System.Windows.Forms.Label();
            this.lageStraatLabel = new System.Windows.Forms.Label();
            this.fullHouseLabel = new System.Windows.Forms.Label();
            this.drieGelijkeLabel = new System.Windows.Forms.Label();
            this.eindScoreLabel = new System.Windows.Forms.Label();
            this.HoldButtonDice1 = new System.Windows.Forms.Button();
            this.HoldButtonDice2 = new System.Windows.Forms.Button();
            this.HoldButtonDice3 = new System.Windows.Forms.Button();
            this.HoldButtonDice4 = new System.Windows.Forms.Button();
            this.HoldButtonDice5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.aantalWorpenDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gooien!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.gooien_Click);
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.Color.Transparent;
            this.Dice1.Image = ((System.Drawing.Image)(resources.GetObject("Dice1.Image")));
            this.Dice1.Location = new System.Drawing.Point(70, 60);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(107, 101);
            this.Dice1.TabIndex = 1;
            this.Dice1.TabStop = false;
            // 
            // Dice2
            // 
            this.Dice2.BackColor = System.Drawing.Color.Transparent;
            this.Dice2.Image = ((System.Drawing.Image)(resources.GetObject("Dice2.Image")));
            this.Dice2.Location = new System.Drawing.Point(207, 60);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(107, 101);
            this.Dice2.TabIndex = 2;
            this.Dice2.TabStop = false;
            // 
            // Dice3
            // 
            this.Dice3.BackColor = System.Drawing.Color.Transparent;
            this.Dice3.Image = ((System.Drawing.Image)(resources.GetObject("Dice3.Image")));
            this.Dice3.Location = new System.Drawing.Point(373, 60);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(107, 101);
            this.Dice3.TabIndex = 3;
            this.Dice3.TabStop = false;
            // 
            // Dice4
            // 
            this.Dice4.BackColor = System.Drawing.Color.Transparent;
            this.Dice4.Image = ((System.Drawing.Image)(resources.GetObject("Dice4.Image")));
            this.Dice4.Location = new System.Drawing.Point(486, 60);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(107, 101);
            this.Dice4.TabIndex = 4;
            this.Dice4.TabStop = false;
            // 
            // Dice5
            // 
            this.Dice5.BackColor = System.Drawing.Color.Transparent;
            this.Dice5.Image = ((System.Drawing.Image)(resources.GetObject("Dice5.Image")));
            this.Dice5.Location = new System.Drawing.Point(627, 60);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(107, 101);
            this.Dice5.TabIndex = 5;
            this.Dice5.TabStop = false;
            this.Dice5.Click += new System.EventHandler(this.Dice5_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(386, 386);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(217, 32);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = " Klik op \"Gooien!\"";
            this.lbl_result.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Candara", 10.75F);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(12, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 133);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Yahtzee\r\nGrote Straat\r\nKleine Straat\r\nFull House \r\nDrie Gelijke\r\nVier Gelijke\r\nKa" +
    "ns\r\n\r\nTotaal Score\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vijfGelijkeLabel
            // 
            this.vijfGelijkeLabel.AutoSize = true;
            this.vijfGelijkeLabel.BackColor = System.Drawing.Color.White;
            this.vijfGelijkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vijfGelijkeLabel.Location = new System.Drawing.Point(124, 194);
            this.vijfGelijkeLabel.Name = "vijfGelijkeLabel";
            this.vijfGelijkeLabel.Size = new System.Drawing.Size(16, 17);
            this.vijfGelijkeLabel.TabIndex = 8;
            this.vijfGelijkeLabel.Text = "0";
            this.vijfGelijkeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // vierGelijkeLabel
            // 
            this.vierGelijkeLabel.AutoSize = true;
            this.vierGelijkeLabel.BackColor = System.Drawing.Color.White;
            this.vierGelijkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vierGelijkeLabel.Location = new System.Drawing.Point(124, 279);
            this.vierGelijkeLabel.Name = "vierGelijkeLabel";
            this.vierGelijkeLabel.Size = new System.Drawing.Size(16, 17);
            this.vierGelijkeLabel.TabIndex = 9;
            this.vierGelijkeLabel.Text = "0";
            // 
            // hogeStraatLabel
            // 
            this.hogeStraatLabel.AutoSize = true;
            this.hogeStraatLabel.BackColor = System.Drawing.Color.White;
            this.hogeStraatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.hogeStraatLabel.Location = new System.Drawing.Point(124, 211);
            this.hogeStraatLabel.Name = "hogeStraatLabel";
            this.hogeStraatLabel.Size = new System.Drawing.Size(16, 17);
            this.hogeStraatLabel.TabIndex = 10;
            this.hogeStraatLabel.Text = "0";
            // 
            // lageStraatLabel
            // 
            this.lageStraatLabel.AutoSize = true;
            this.lageStraatLabel.BackColor = System.Drawing.Color.White;
            this.lageStraatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lageStraatLabel.Location = new System.Drawing.Point(124, 228);
            this.lageStraatLabel.Name = "lageStraatLabel";
            this.lageStraatLabel.Size = new System.Drawing.Size(16, 17);
            this.lageStraatLabel.TabIndex = 11;
            this.lageStraatLabel.Text = "0";
            // 
            // fullHouseLabel
            // 
            this.fullHouseLabel.AutoSize = true;
            this.fullHouseLabel.BackColor = System.Drawing.Color.White;
            this.fullHouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fullHouseLabel.Location = new System.Drawing.Point(124, 245);
            this.fullHouseLabel.Name = "fullHouseLabel";
            this.fullHouseLabel.Size = new System.Drawing.Size(16, 17);
            this.fullHouseLabel.TabIndex = 12;
            this.fullHouseLabel.Text = "0";
            this.fullHouseLabel.Click += new System.EventHandler(this.fullHouseLabel_Click);
            // 
            // drieGelijkeLabel
            // 
            this.drieGelijkeLabel.AutoSize = true;
            this.drieGelijkeLabel.BackColor = System.Drawing.Color.White;
            this.drieGelijkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.drieGelijkeLabel.Location = new System.Drawing.Point(124, 262);
            this.drieGelijkeLabel.Name = "drieGelijkeLabel";
            this.drieGelijkeLabel.Size = new System.Drawing.Size(16, 17);
            this.drieGelijkeLabel.TabIndex = 13;
            this.drieGelijkeLabel.Text = "0";
            this.drieGelijkeLabel.Click += new System.EventHandler(this.drieGelijkeLabel_Click);
            // 
            // eindScoreLabel
            // 
            this.eindScoreLabel.AutoSize = true;
            this.eindScoreLabel.BackColor = System.Drawing.Color.White;
            this.eindScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.eindScoreLabel.Location = new System.Drawing.Point(102, 333);
            this.eindScoreLabel.Name = "eindScoreLabel";
            this.eindScoreLabel.Size = new System.Drawing.Size(16, 17);
            this.eindScoreLabel.TabIndex = 22;
            this.eindScoreLabel.Tag = "";
            this.eindScoreLabel.Text = "0";
            this.eindScoreLabel.Click += new System.EventHandler(this.eindScoreLabel_Click);
            // 
            // HoldButtonDice1
            // 
            this.HoldButtonDice1.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoldButtonDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HoldButtonDice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoldButtonDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButtonDice1.ForeColor = System.Drawing.Color.Teal;
            this.HoldButtonDice1.Location = new System.Drawing.Point(46, 120);
            this.HoldButtonDice1.Name = "HoldButtonDice1";
            this.HoldButtonDice1.Size = new System.Drawing.Size(107, 23);
            this.HoldButtonDice1.TabIndex = 27;
            this.HoldButtonDice1.Text = "Hold";
            this.HoldButtonDice1.UseVisualStyleBackColor = false;
            this.HoldButtonDice1.Click += new System.EventHandler(this.HoldButtonDice1_Click);
            // 
            // HoldButtonDice2
            // 
            this.HoldButtonDice2.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoldButtonDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HoldButtonDice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoldButtonDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButtonDice2.ForeColor = System.Drawing.Color.Teal;
            this.HoldButtonDice2.Location = new System.Drawing.Point(183, 119);
            this.HoldButtonDice2.Name = "HoldButtonDice2";
            this.HoldButtonDice2.Size = new System.Drawing.Size(107, 23);
            this.HoldButtonDice2.TabIndex = 26;
            this.HoldButtonDice2.Text = "Hold";
            this.HoldButtonDice2.UseVisualStyleBackColor = false;
            this.HoldButtonDice2.Click += new System.EventHandler(this.HoldButtonDice2_Click);
            // 
            // HoldButtonDice3
            // 
            this.HoldButtonDice3.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoldButtonDice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HoldButtonDice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoldButtonDice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButtonDice3.ForeColor = System.Drawing.Color.Teal;
            this.HoldButtonDice3.Location = new System.Drawing.Point(326, 120);
            this.HoldButtonDice3.Name = "HoldButtonDice3";
            this.HoldButtonDice3.Size = new System.Drawing.Size(107, 23);
            this.HoldButtonDice3.TabIndex = 25;
            this.HoldButtonDice3.Text = "Hold";
            this.HoldButtonDice3.UseVisualStyleBackColor = false;
            this.HoldButtonDice3.Click += new System.EventHandler(this.HoldButtonDice3_Click);
            // 
            // HoldButtonDice4
            // 
            this.HoldButtonDice4.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoldButtonDice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HoldButtonDice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoldButtonDice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButtonDice4.ForeColor = System.Drawing.Color.Teal;
            this.HoldButtonDice4.Location = new System.Drawing.Point(462, 120);
            this.HoldButtonDice4.Name = "HoldButtonDice4";
            this.HoldButtonDice4.Size = new System.Drawing.Size(107, 23);
            this.HoldButtonDice4.TabIndex = 24;
            this.HoldButtonDice4.Text = "Hold";
            this.HoldButtonDice4.UseVisualStyleBackColor = false;
            this.HoldButtonDice4.Click += new System.EventHandler(this.HoldButtonDice4_Click);
            // 
            // HoldButtonDice5
            // 
            this.HoldButtonDice5.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoldButtonDice5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HoldButtonDice5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoldButtonDice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButtonDice5.ForeColor = System.Drawing.Color.Teal;
            this.HoldButtonDice5.Location = new System.Drawing.Point(603, 120);
            this.HoldButtonDice5.Name = "HoldButtonDice5";
            this.HoldButtonDice5.Size = new System.Drawing.Size(107, 23);
            this.HoldButtonDice5.TabIndex = 23;
            this.HoldButtonDice5.Text = "Hold";
            this.HoldButtonDice5.UseVisualStyleBackColor = false;
            this.HoldButtonDice5.Click += new System.EventHandler(this.HoldButtonDice5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(927, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 58);
            this.button2.TabIndex = 28;
            this.button2.Text = "Spelregels";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Spelregels_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(124, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "0";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(927, 427);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(124, 58);
            this.Reset.TabIndex = 30;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // aantalWorpenDisplay
            // 
            this.aantalWorpenDisplay.Enabled = false;
            this.aantalWorpenDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.aantalWorpenDisplay.Location = new System.Drawing.Point(963, 12);
            this.aantalWorpenDisplay.Multiline = true;
            this.aantalWorpenDisplay.Name = "aantalWorpenDisplay";
            this.aantalWorpenDisplay.Size = new System.Drawing.Size(158, 73);
            this.aantalWorpenDisplay.TabIndex = 31;
            this.aantalWorpenDisplay.Text = "0";
            this.aantalWorpenDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aantalWorpenDisplay.TextChanged += new System.EventHandler(this.aantalWorpenDisplay_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(25, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Totaal Score";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.time1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aantalWorpenDisplay);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HoldButtonDice1);
            this.Controls.Add(this.HoldButtonDice2);
            this.Controls.Add(this.HoldButtonDice3);
            this.Controls.Add(this.HoldButtonDice4);
            this.Controls.Add(this.HoldButtonDice5);
            this.Controls.Add(this.eindScoreLabel);
            this.Controls.Add(this.drieGelijkeLabel);
            this.Controls.Add(this.fullHouseLabel);
            this.Controls.Add(this.lageStraatLabel);
            this.Controls.Add(this.hogeStraatLabel);
            this.Controls.Add(this.vierGelijkeLabel);
            this.Controls.Add(this.vijfGelijkeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dobbelen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Dice2_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.PictureBox Dice3;
        private System.Windows.Forms.PictureBox Dice4;
        private System.Windows.Forms.PictureBox Dice5;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label vijfGelijkeLabel;
        private System.Windows.Forms.Label vierGelijkeLabel;
        private System.Windows.Forms.Label hogeStraatLabel;
        private System.Windows.Forms.Label lageStraatLabel;
        private System.Windows.Forms.Label fullHouseLabel;
        private System.Windows.Forms.Label drieGelijkeLabel;
        private System.Windows.Forms.Label eindScoreLabel;
        private System.Windows.Forms.Button HoldButtonDice1;
        private System.Windows.Forms.Button HoldButtonDice2;
        private System.Windows.Forms.Button HoldButtonDice3;
        private System.Windows.Forms.Button HoldButtonDice4;
        private System.Windows.Forms.Button HoldButtonDice5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox aantalWorpenDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

