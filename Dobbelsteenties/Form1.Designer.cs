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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vijfGelijkeLabel = new System.Windows.Forms.Label();
            this.vierGelijkeLabel = new System.Windows.Forms.Label();
            this.hogeStraatLabel = new System.Windows.Forms.Label();
            this.lageStraatLabel = new System.Windows.Forms.Label();
            this.fullHouseLabel = new System.Windows.Forms.Label();
            this.drieGelijkeLabel = new System.Windows.Forms.Label();
            this.tweePaarLabel = new System.Windows.Forms.Label();
            this.eenPaarLabel = new System.Windows.Forms.Label();
            this.sixHighLabel = new System.Windows.Forms.Label();
            this.vijfHighLabel = new System.Windows.Forms.Label();
            this.vierHighLabel = new System.Windows.Forms.Label();
            this.drieHighLabel = new System.Windows.Forms.Label();
            this.tweeHighLabel = new System.Windows.Forms.Label();
            this.eenHighLabel = new System.Windows.Forms.Label();
            this.eindScoreLabel = new System.Windows.Forms.Label();
            this.HoldButtonDice1 = new System.Windows.Forms.Button();
            this.HoldButtonDice2 = new System.Windows.Forms.Button();
            this.HoldButtonDice3 = new System.Windows.Forms.Button();
            this.HoldButtonDice4 = new System.Windows.Forms.Button();
            this.HoldButtonDice5 = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(581, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gooien!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.gooien_Click);
            // 
            // Dice1
            // 
            this.Dice1.Image = ((System.Drawing.Image)(resources.GetObject("Dice1.Image")));
            this.Dice1.Location = new System.Drawing.Point(93, 74);
            this.Dice1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(143, 124);
            this.Dice1.TabIndex = 1;
            this.Dice1.TabStop = false;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice2
            // 
            this.Dice2.Image = ((System.Drawing.Image)(resources.GetObject("Dice2.Image")));
            this.Dice2.Location = new System.Drawing.Point(276, 74);
            this.Dice2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(143, 124);
            this.Dice2.TabIndex = 2;
            this.Dice2.TabStop = false;
            this.Dice2.Click += new System.EventHandler(this.Dice2_Click);
            // 
            // Dice3
            // 
            this.Dice3.Image = ((System.Drawing.Image)(resources.GetObject("Dice3.Image")));
            this.Dice3.Location = new System.Drawing.Point(467, 74);
            this.Dice3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(143, 124);
            this.Dice3.TabIndex = 3;
            this.Dice3.TabStop = false;
            this.Dice3.Click += new System.EventHandler(this.Dice3_Click);
            // 
            // Dice4
            // 
            this.Dice4.Image = ((System.Drawing.Image)(resources.GetObject("Dice4.Image")));
            this.Dice4.Location = new System.Drawing.Point(648, 74);
            this.Dice4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(143, 124);
            this.Dice4.TabIndex = 4;
            this.Dice4.TabStop = false;
            this.Dice4.Click += new System.EventHandler(this.Dice4_Click);
            // 
            // Dice5
            // 
            this.Dice5.Image = ((System.Drawing.Image)(resources.GetObject("Dice5.Image")));
            this.Dice5.Location = new System.Drawing.Point(836, 74);
            this.Dice5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(143, 124);
            this.Dice5.TabIndex = 5;
            this.Dice5.TabStop = false;
            this.Dice5.Click += new System.EventHandler(this.Dice5_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(539, 389);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(288, 39);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "Click op \'Gooien!\'.";
            this.lbl_result.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Candara", 10.75F);
            this.textBox1.Location = new System.Drawing.Point(16, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 303);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Five of a Kind\r\nFour of a Kind\r\nHigh Straight\r\nLow Straight\r\nFull House \r\nThree o" +
    "f a Kind\r\nTwo Pair\r\nOne Pair\r\nSix High\r\nFive High\r\nFour High\r\nThree High\r\nTwo Hi" +
    "gh\r\nOne High";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vijfGelijkeLabel
            // 
            this.vijfGelijkeLabel.AutoSize = true;
            this.vijfGelijkeLabel.BackColor = System.Drawing.Color.White;
            this.vijfGelijkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vijfGelijkeLabel.Location = new System.Drawing.Point(165, 236);
            this.vijfGelijkeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vijfGelijkeLabel.Name = "vijfGelijkeLabel";
            this.vijfGelijkeLabel.Size = new System.Drawing.Size(20, 22);
            this.vijfGelijkeLabel.TabIndex = 8;
            this.vijfGelijkeLabel.Text = "0";
            this.vijfGelijkeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // vierGelijkeLabel
            // 
            this.vierGelijkeLabel.AutoSize = true;
            this.vierGelijkeLabel.BackColor = System.Drawing.Color.White;
            this.vierGelijkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vierGelijkeLabel.Location = new System.Drawing.Point(165, 257);
            this.vierGelijkeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vierGelijkeLabel.Name = "vierGelijkeLabel";
            this.vierGelijkeLabel.Size = new System.Drawing.Size(20, 22);
            this.vierGelijkeLabel.TabIndex = 9;
            this.vierGelijkeLabel.Text = "0";
            // 
            // hogeStraatLabel
            // 
            this.hogeStraatLabel.AutoSize = true;
            this.hogeStraatLabel.BackColor = System.Drawing.Color.White;
            this.hogeStraatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.hogeStraatLabel.Location = new System.Drawing.Point(165, 277);
            this.hogeStraatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hogeStraatLabel.Name = "hogeStraatLabel";
            this.hogeStraatLabel.Size = new System.Drawing.Size(20, 22);
            this.hogeStraatLabel.TabIndex = 10;
            this.hogeStraatLabel.Text = "0";
            // 
            // lageStraatLabel
            // 
            this.lageStraatLabel.AutoSize = true;
            this.lageStraatLabel.BackColor = System.Drawing.Color.White;
            this.lageStraatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lageStraatLabel.Location = new System.Drawing.Point(165, 298);
            this.lageStraatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lageStraatLabel.Name = "lageStraatLabel";
            this.lageStraatLabel.Size = new System.Drawing.Size(20, 22);
            this.lageStraatLabel.TabIndex = 11;
            this.lageStraatLabel.Text = "0";
            this.lageStraatLabel.Click += new System.EventHandler(this.lageStraatLabel_Click);
            // 
            // fullHouseLabel
            // 
            this.fullHouseLabel.AutoSize = true;
            this.fullHouseLabel.BackColor = System.Drawing.Color.White;
            this.fullHouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fullHouseLabel.Location = new System.Drawing.Point(165, 319);
            this.fullHouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullHouseLabel.Name = "fullHouseLabel";
            this.fullHouseLabel.Size = new System.Drawing.Size(20, 22);
            this.fullHouseLabel.TabIndex = 12;
            this.fullHouseLabel.Text = "0";
            this.fullHouseLabel.Click += new System.EventHandler(this.fullHouseLabel_Click);
            // 
            // drieGelijkeLabel
            // 
            this.drieGelijkeLabel.AutoSize = true;
            this.drieGelijkeLabel.BackColor = System.Drawing.Color.White;
            this.drieGelijkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.drieGelijkeLabel.Location = new System.Drawing.Point(165, 340);
            this.drieGelijkeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drieGelijkeLabel.Name = "drieGelijkeLabel";
            this.drieGelijkeLabel.Size = new System.Drawing.Size(20, 22);
            this.drieGelijkeLabel.TabIndex = 13;
            this.drieGelijkeLabel.Text = "0";
            // 
            // tweePaarLabel
            // 
            this.tweePaarLabel.AutoSize = true;
            this.tweePaarLabel.BackColor = System.Drawing.Color.White;
            this.tweePaarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tweePaarLabel.Location = new System.Drawing.Point(165, 361);
            this.tweePaarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tweePaarLabel.Name = "tweePaarLabel";
            this.tweePaarLabel.Size = new System.Drawing.Size(20, 22);
            this.tweePaarLabel.TabIndex = 14;
            this.tweePaarLabel.Text = "0";
            // 
            // eenPaarLabel
            // 
            this.eenPaarLabel.AutoSize = true;
            this.eenPaarLabel.BackColor = System.Drawing.Color.White;
            this.eenPaarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.eenPaarLabel.Location = new System.Drawing.Point(165, 382);
            this.eenPaarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eenPaarLabel.Name = "eenPaarLabel";
            this.eenPaarLabel.Size = new System.Drawing.Size(20, 22);
            this.eenPaarLabel.TabIndex = 15;
            this.eenPaarLabel.Text = "0";
            // 
            // sixHighLabel
            // 
            this.sixHighLabel.AutoSize = true;
            this.sixHighLabel.BackColor = System.Drawing.Color.White;
            this.sixHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.sixHighLabel.Location = new System.Drawing.Point(165, 402);
            this.sixHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sixHighLabel.Name = "sixHighLabel";
            this.sixHighLabel.Size = new System.Drawing.Size(20, 22);
            this.sixHighLabel.TabIndex = 16;
            this.sixHighLabel.Text = "0";
            // 
            // vijfHighLabel
            // 
            this.vijfHighLabel.AutoSize = true;
            this.vijfHighLabel.BackColor = System.Drawing.Color.White;
            this.vijfHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vijfHighLabel.Location = new System.Drawing.Point(165, 423);
            this.vijfHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vijfHighLabel.Name = "vijfHighLabel";
            this.vijfHighLabel.Size = new System.Drawing.Size(20, 22);
            this.vijfHighLabel.TabIndex = 17;
            this.vijfHighLabel.Text = "0";
            // 
            // vierHighLabel
            // 
            this.vierHighLabel.AutoSize = true;
            this.vierHighLabel.BackColor = System.Drawing.Color.White;
            this.vierHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vierHighLabel.Location = new System.Drawing.Point(165, 444);
            this.vierHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vierHighLabel.Name = "vierHighLabel";
            this.vierHighLabel.Size = new System.Drawing.Size(20, 22);
            this.vierHighLabel.TabIndex = 18;
            this.vierHighLabel.Text = "0";
            // 
            // drieHighLabel
            // 
            this.drieHighLabel.AutoSize = true;
            this.drieHighLabel.BackColor = System.Drawing.Color.White;
            this.drieHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.drieHighLabel.Location = new System.Drawing.Point(165, 465);
            this.drieHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drieHighLabel.Name = "drieHighLabel";
            this.drieHighLabel.Size = new System.Drawing.Size(20, 22);
            this.drieHighLabel.TabIndex = 19;
            this.drieHighLabel.Text = "0";
            // 
            // tweeHighLabel
            // 
            this.tweeHighLabel.AutoSize = true;
            this.tweeHighLabel.BackColor = System.Drawing.Color.White;
            this.tweeHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tweeHighLabel.Location = new System.Drawing.Point(165, 486);
            this.tweeHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tweeHighLabel.Name = "tweeHighLabel";
            this.tweeHighLabel.Size = new System.Drawing.Size(20, 22);
            this.tweeHighLabel.TabIndex = 20;
            this.tweeHighLabel.Text = "0";
            // 
            // eenHighLabel
            // 
            this.eenHighLabel.AutoSize = true;
            this.eenHighLabel.BackColor = System.Drawing.Color.White;
            this.eenHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.eenHighLabel.Location = new System.Drawing.Point(165, 507);
            this.eenHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eenHighLabel.Name = "eenHighLabel";
            this.eenHighLabel.Size = new System.Drawing.Size(20, 22);
            this.eenHighLabel.TabIndex = 21;
            this.eenHighLabel.Text = "0";
            // 
            // eindScoreLabel
            // 
            this.eindScoreLabel.AutoSize = true;
            this.eindScoreLabel.BackColor = System.Drawing.Color.White;
            this.eindScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.eindScoreLabel.Location = new System.Drawing.Point(124, 561);
            this.eindScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eindScoreLabel.Name = "eindScoreLabel";
            this.eindScoreLabel.Size = new System.Drawing.Size(93, 22);
            this.eindScoreLabel.TabIndex = 22;
            this.eindScoreLabel.Text = "EindScore";
            // 
            // HoldButtonDice1
            // 
            this.HoldButtonDice1.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoldButtonDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HoldButtonDice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoldButtonDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButtonDice1.ForeColor = System.Drawing.Color.Teal;
            this.HoldButtonDice1.Location = new System.Drawing.Point(61, 148);
            this.HoldButtonDice1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HoldButtonDice1.Name = "HoldButtonDice1";
            this.HoldButtonDice1.Size = new System.Drawing.Size(143, 28);
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
            this.HoldButtonDice2.Location = new System.Drawing.Point(244, 146);
            this.HoldButtonDice2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HoldButtonDice2.Name = "HoldButtonDice2";
            this.HoldButtonDice2.Size = new System.Drawing.Size(143, 28);
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
            this.HoldButtonDice3.Location = new System.Drawing.Point(435, 148);
            this.HoldButtonDice3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HoldButtonDice3.Name = "HoldButtonDice3";
            this.HoldButtonDice3.Size = new System.Drawing.Size(143, 28);
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
            this.HoldButtonDice4.Location = new System.Drawing.Point(616, 148);
            this.HoldButtonDice4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HoldButtonDice4.Name = "HoldButtonDice4";
            this.HoldButtonDice4.Size = new System.Drawing.Size(143, 28);
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
            this.HoldButtonDice5.Location = new System.Drawing.Point(804, 148);
            this.HoldButtonDice5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HoldButtonDice5.Name = "HoldButtonDice5";
            this.HoldButtonDice5.Size = new System.Drawing.Size(143, 28);
            this.HoldButtonDice5.TabIndex = 23;
            this.HoldButtonDice5.Text = "Hold";
            this.HoldButtonDice5.UseVisualStyleBackColor = false;
            this.HoldButtonDice5.Click += new System.EventHandler(this.HoldButtonDice5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1417, 699);
            this.Controls.Add(this.HoldButtonDice1);
            this.Controls.Add(this.HoldButtonDice2);
            this.Controls.Add(this.HoldButtonDice3);
            this.Controls.Add(this.HoldButtonDice4);
            this.Controls.Add(this.HoldButtonDice5);
            this.Controls.Add(this.eindScoreLabel);
            this.Controls.Add(this.eenHighLabel);
            this.Controls.Add(this.tweeHighLabel);
            this.Controls.Add(this.drieHighLabel);
            this.Controls.Add(this.vierHighLabel);
            this.Controls.Add(this.vijfHighLabel);
            this.Controls.Add(this.sixHighLabel);
            this.Controls.Add(this.eenPaarLabel);
            this.Controls.Add(this.tweePaarLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label vijfGelijkeLabel;
        private System.Windows.Forms.Label vierGelijkeLabel;
        private System.Windows.Forms.Label hogeStraatLabel;
        private System.Windows.Forms.Label lageStraatLabel;
        private System.Windows.Forms.Label fullHouseLabel;
        private System.Windows.Forms.Label drieGelijkeLabel;
        private System.Windows.Forms.Label tweePaarLabel;
        private System.Windows.Forms.Label eenPaarLabel;
        private System.Windows.Forms.Label sixHighLabel;
        private System.Windows.Forms.Label vijfHighLabel;
        private System.Windows.Forms.Label vierHighLabel;
        private System.Windows.Forms.Label drieHighLabel;
        private System.Windows.Forms.Label tweeHighLabel;
        private System.Windows.Forms.Label eenHighLabel;
        private System.Windows.Forms.Label eindScoreLabel;
        private System.Windows.Forms.Button HoldButtonDice1;
        private System.Windows.Forms.Button HoldButtonDice2;
        private System.Windows.Forms.Button HoldButtonDice3;
        private System.Windows.Forms.Button HoldButtonDice4;
        private System.Windows.Forms.Button HoldButtonDice5;
    }
}

