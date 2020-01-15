using System;
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

        #region Declaration

        Image[] diceImages;
        int[] dice;
        Random rand;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        int[] diceResults;

        private void gooien_Click(object sender, EventArgs e)
        {
            RollDice();
            GetResults();
            ResetResults();

        }

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
                Dice1.Image = diceImages[dice[0]];
                Dice2.Image = diceImages[dice[1]];
                Dice3.Image = diceImages[dice[2]];
                Dice4.Image = diceImages[dice[3]];
                Dice5.Image = diceImages[dice[4]];
            }
        }

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
            if (fiveKind)
                lbl_result.Text = "Five of a Kind";
            else if (fourKind)
                lbl_result.Text = "Four of a Kind";
            else if (highStraight)
                lbl_result.Text = "High Straight";
            else if (lowStraight)
                lbl_result.Text = "Low Straight";
            else if (fullHouse)
                lbl_result.Text = "Full House";
            else if (threeKind)
                lbl_result.Text = "three of a Kind";
            else if (twoPair)
                lbl_result.Text = "Two Pair";
            else if (onePair)
                lbl_result.Text = "One Pair";
            else if (haveSix)
                lbl_result.Text = "Six High";
            else if (haveFive)
                lbl_result.Text = "Five High";
            else if (haveFour)
                lbl_result.Text = "Four High";
            else if (haveThree)
                lbl_result.Text = "Three High";
            else if (haveTwo)
                lbl_result.Text = "Two high";
            else if (haveOne)
                lbl_result.Text = "One High";
        }

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
            diceImages[1] = Image.FromFile(@"..\..\Properties\Resources\dice1.png");
            diceImages[2] = Image.FromFile(@"..\..\Properties\Resources\dice2.png");
            diceImages[3] = Image.FromFile(@"..\..\Properties\Resources\dice3.png");
            diceImages[4] = Image.FromFile(@"..\..\Properties\Resources\dice4.png");
            diceImages[5] = Image.FromFile(@"..\..\Properties\Resources\dice5.png");
            diceImages[6] = Image.FromFile(@"..\..\Properties\Resources\dice6.png");

            dice = new int[5] {0, 0, 0, 0, 0 };

            rand = new Random();
            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 };
        }
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

    }
}




