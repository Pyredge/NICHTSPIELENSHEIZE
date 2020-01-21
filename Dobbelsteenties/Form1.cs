﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Dobbelsteenties
{
    public partial class Form1 : Form
    {
        int eenPaar;
        int tweePaar;
        int driePaar;
        int fullhouse;
        int yahtzee;
        int vierGelijk;
        bool HoldConditionDice1;
        bool HoldConditionDice2;
        bool HoldConditionDice3;
        bool HoldConditionDice4;
        bool HoldConditionDice5;

        int kansen;
        #region Declaration
        //Hier heb ik ze een variable gegeven


        Image[] diceImages;
        int[] dice;
        Random rand;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        int[] diceResults;

        // Ik heb dit hier zo aangemaakt, zodat wanneer je op de knop "gooien!" klikt dat die die codes kan uitvoeren allemaal.

        private void gooien_Click(object sender, EventArgs e)
        {
            kansen =+1;
            if (kansen == 3)
            {
                eenPaar = 0;
                fullhouse = 0;
                yahtzee = 0;
            }
            RollDice();
            GetResults();
            ResetResults();
            ScoreResults();

        }

        //Dit stukje code is dat wanneer je op "Gooien!" klikt dat er random dobbelstenen komen

        private void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);

                switch (dice[i])
                {
                    case 1:

                        diceResults[0]++;
                        break;
                    case 2:
                        diceResults[1]++;
                        break;
                    case 3:
                        diceResults[2]++;
                        break;
                    case 4:
                        diceResults[3]++;
                        break;
                    case 5:
                        diceResults[4]++;
                        break;
                    case 6:
                        diceResults[5]++;
                        break;
                }
            }
            {
                if (HoldConditionDice1 == false)
                {
                    Dice1.Image = diceImages[dice[0]];
                }
                if (HoldConditionDice2 == false)
                {
                    Dice2.Image = diceImages[dice[1]];
                }
                if (HoldConditionDice3 == false)
                {
                    Dice3.Image = diceImages[dice[2]];
                }
                if (HoldConditionDice4 == false)
                {
                    Dice4.Image = diceImages[dice[3]];
                }
                if (HoldConditionDice5 == false)
                {
                    Dice5.Image = diceImages[dice[4]];
                }

            }
        }
        //deze stukje code berekent het resultaat van wat je hebt als je de dobbelstenen hebt gegooid
        //ook heb ik allemaal bool gemaakt, zodat ik ze op true kan zetten IF deze dobbelstenen true zijn

        private void GetResults()
        {
            bool fiveKind = false, fourKind = false, highStraight = false,
                lowStraight = false, fullHouse = false, threeKind = false, twoPair = false,
                onePair = false, haveSix = false, haveFive = false, haveFour = false, haveThree = false,
                haveTwo = false, haveOne = false;

            for (int i = 0; i < diceResults.Length; i++)
            {
                if (diceResults[i] == 5)
                    fiveKind = true;
                else if (diceResults[i] == 4)
                    fourKind = true;
                else if (diceResults[1] == 1 &&
                         diceResults[2] == 1 &&
                         diceResults[3] == 1 &&
                         diceResults[4] == 1 &&
                         diceResults[5] == 1)
                    highStraight = true;
                else if (diceResults[1] == 1 &&
                         diceResults[2] == 1 &&
                         diceResults[3] == 1 &&
                         diceResults[4] == 1 &&
                         diceResults[5] == 1)
                    lowStraight = true;
                else if (diceResults[i] == 3)
                {
                    threeKind = true;

                    for (int j = 0; j < diceResults.Length; j++)
                    {
                        if (diceResults[j] == 2)
                            fullHouse = true;
                    }
                }
                else if (diceResults[i] == 2)
                {
                    onePair = true;

                    for (int j = i + 1; j < diceResults.Length; j++)
                    {
                        if (diceResults[j] == 2)
                            twoPair = true;
                    }
                }
            }
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);
                switch (dice[i])
                {
                    case 1:
                        haveSix = true;
                        break;
                    case 2:
                        haveFive = true;
                        break;
                    case 3:
                        haveFour = true;
                        break;
                    case 4:
                        haveThree = true;
                        break;
                    case 5:
                        haveTwo = true;
                        break;
                    case 6:
                        haveOne = true;
                        break;
                }
            }

            //Hier laat die dus zien welke resultaat je krijgt van de dobbelstenen


            if (fiveKind)
            {
                lbl_result.Text = "Five of a Kind";
            }
            else if (fourKind)
            {
                lbl_result.Text = "Four of a Kind";
            }
            else if (highStraight)
            {
                lbl_result.Text = "High Straight";
            }
            else if (lowStraight)
            {
                lbl_result.Text = "Low Straight";
            }
            else if (fullHouse)
            {
                lbl_result.Text = "Full House";
            }
            else if (threeKind)
            {
                lbl_result.Text = "Three of a Kind";
            }
            else if (twoPair)
            {
                lbl_result.Text = "Two Pair";
            }
            else if (onePair)
            {
                lbl_result.Text = "One Pair";
            }
            else if (haveSix)
            {
                lbl_result.Text = "Six High";
            }
            else if (haveFive)
            {
                lbl_result.Text = "Five High";
            }
            else if (haveFour)
            {
                lbl_result.Text = "Four High";
            }
            else if (haveThree)
            {
                lbl_result.Text = "Three High";
            }
            else if (haveTwo)
            {
                lbl_result.Text = "Two high";
            }
            else if (haveOne)
            {
                lbl_result.Text = "One High";
            }
        }


        //Ook wanneer je op de knop "Gooien!" klikt reset hij automatisch de dobbelstenen zodat hij niet door berekent. Zo kan die ook het aantal keren berekenen.

        private void ResetResults()
        {
            for (int i = 0; i < diceResults.Length; i++)
                diceResults[i] = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // De image file path maakt gebruik van ..\.. waarmee deze twee folders omhoog gaat (Tom) 
            //https://stackoverflow.com/questions/17193825/loading-picturebox-image-from-resource-file-with-path-part-3

            diceImages = new Image[7];
            diceImages[1] = Image.FromFile(@"Properties\Resources\dice1.png");
            diceImages[2] = Image.FromFile(@"Properties\Resources\dice2.png");
            diceImages[3] = Image.FromFile(@"Properties\Resources\dice3.png");
            diceImages[4] = Image.FromFile(@"Properties\Resources\dice4.png");
            diceImages[5] = Image.FromFile(@"Properties\Resources\dice5.png");
            diceImages[6] = Image.FromFile(@"Properties\Resources\dice6.png");

            dice = new int[5] {0, 0, 0, 0, 0 };

            rand = new Random();
            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 };
        }
        #region hold button
        private void HoldButtonDice1_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice1 == false)
            {
                HoldConditionDice1 = true;
                HoldButtonDice1.Text = ("Holding..");
                HoldButtonDice1.ForeColor = Color.Crimson;

            }
            else if (HoldConditionDice1 == true)
            {
                HoldConditionDice1 = false;
                HoldButtonDice1.Text = ("Hold");
                HoldButtonDice1.ForeColor = Color.Teal;
            }
        }
        private void HoldButtonDice2_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice2 == false)
            {
                HoldConditionDice2 = true;
                HoldButtonDice2.Text = ("Holding..");
                HoldButtonDice2.ForeColor = Color.Crimson;
            }
            else if (HoldConditionDice2 == true)
            {
                HoldConditionDice2 = false;
                HoldButtonDice2.Text = ("Hold");
                HoldButtonDice2.ForeColor = Color.Teal;
            }
        }
        private void HoldButtonDice3_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice3 == false)
            {
                HoldConditionDice3 = true;
                HoldButtonDice3.Text = ("Holding..");
                HoldButtonDice3.ForeColor = Color.Crimson;
            }
            else if (HoldConditionDice3 == true)
            {
                HoldConditionDice3 = false;
                HoldButtonDice3.Text = ("Hold");
                HoldButtonDice3.ForeColor = Color.Teal;
            }
        }
        private void HoldButtonDice4_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice4 == false)  // Hij kijkt eerst of de HoldCondition is gelijk aan ''false'', als hij het zal uitvoeren zonder te kijken zal de gebruiker niet weten of hij de dobbelstenen ''hold''.
            {
                HoldConditionDice4 = true;// hij veranderd de conditie naar ''true'', omdat de gebruiker de dobbelstenen wil houden. 
                HoldButtonDice4.Text = "Holding.."; // Veranderd de Hold button naar ''Holding..", om het makkelijker te maken om te zien of de gebruiker de dobbelstenen op ''hold'' heeft.
                HoldButtonDice4.ForeColor = Color.Crimson;  // veranderd de "ForeColor'' naar Crimson zodat het makkelijker te zien is of de gebruker de dobbelstenen op ''Hold'' gezet heeft of niet.
            }
            else if (HoldConditionDice4 == true) // Hij kijkt eerst of de "hold'' conditie true is, zodat hij niet naar 'hold' veranderd als je juist je dobbelsteen niet wil houden, en de gebruiker verward.
            {
                HoldConditionDice4 = false; // Natuurlijk veranderd hij het naar false, omdat de gebruiker de dobbelsteen niet wil houden. Zonder dit zal het programma hetzelfde stuk code uitvoeren.
                HoldButtonDice4.Text = "Hold";  //Veranderd de text in "HoldButtonDice'' naar "hold" zodat de gebruiker het weet dat hij niet meer de dobbelsteen houd.
                HoldButtonDice4.ForeColor = Color.Teal; //De button gaat terug naar zijn neutrale kleur, en de gebruiker weet dat het dobbelsteen niet meer wordt gehouden.
            }
        }
        private void HoldButtonDice5_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice5 == false)
            {

                HoldButtonDice5.Text = "Holding..";
                HoldButtonDice5.ForeColor = Color.Crimson;
                HoldConditionDice5 = true;
            }
            else if (HoldConditionDice5 == true)
            {

                HoldButtonDice5.Text = "Hold";
                HoldButtonDice5.ForeColor = Color.Teal;
                HoldConditionDice5 = false;
            }
        }
        #endregion


        #region useless buttons
        private void Dice2_click(object sender, EventArgs e)
        {

        }

        private void Dice3_Click(object sender, EventArgs e)
        {

        }

        private void Dice4_Click(object sender, EventArgs e)
        {

        }

        private void Dice5_Click(object sender, EventArgs e)
        {

        }


        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void Dice1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void ScoreResults()
        {

        }

        private void fullHouseLabel_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void Spelregels_Click(object sender, EventArgs e)
        {
            Spelregels openForm = new Spelregels();
            openForm.Show();
        }
    }
}




