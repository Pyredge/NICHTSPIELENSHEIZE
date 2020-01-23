using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelsteenties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public int[] Dice = new int[5];
        int dice1;
        int dice2;
        int dice3;
        int dice4;
        int dice5;
        int HoldDice1;
        int HoldDice2;
        int HoldDice3;
        int HoldDice4;
        int HoldDice5;
        bool HoldConditionDice1;
        bool HoldConditionDice2;
        bool HoldConditionDice3;
        bool HoldConditionDice4;
        bool HoldConditionDice5;

        public void gooien_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            #region If condities van de dice
            // Hij checkt eerst de "HoldConditionDice1', of de gebruiker hem wil houden. als de boolean conditie ''false'' is geeft hij de Dice een nieuw nummer, en dus veranderd de afbeelding van de dobbelstenen. Als hij 'true' is doet hij niks, omdat de gebruiker de dobbelsteen wil houden.
            if (HoldConditionDice1 == false)
            {
                dice1 = rnd.Next(1, 7);

            }
            else
            {

            }

            if (HoldConditionDice2 == false)
            {
                dice2 = rnd.Next(1, 7);

            }
            else
            {

            }
            if (HoldConditionDice3 == false)
            {
                dice3 = rnd.Next(1, 7);
            }
            else
            {

            }
            if (HoldConditionDice4 == false)
            {
                dice4 = rnd.Next(1, 7);
            }
            else
            {

            }
            if (HoldConditionDice5 == false)
            {
                dice5 = rnd.Next(1, 7);
            }



            #endregion
            switch (dice1)
            {
                case 1:
                    Dice1.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 1.png" ;
                    break;
                case 2:
                    Dice1.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 2.png";
                    break;
                case 3:
                    Dice1.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 3.png";
                    break;
                case 4:
                    Dice1.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 4.png";
                    break;
                case 5:
                    Dice1.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 5.png";
                    break;
                case 6:
                    Dice1.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 6.png";
                    break;

            }
            switch (dice2)
            {
                case 1:
                    Dice2.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 1.png";
                    break;
                case 2:
                    Dice2.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 2.png";
                    break;
                case 3:
                    Dice2.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 3.png";
                    break;
                case 4:
                    Dice2.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 4.png";
                    break;
                case 5:
                    Dice2.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 5.png";
                    break;
                case 6:
                    Dice2.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 6.png";
                    break;

            }
            switch (dice3)
            {
                case 1:
                    Dice3.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 1.png";
                    break;
                case 2:
                    Dice3.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 2.png";
                    break;
                case 3:
                    Dice3.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 3.png";
                    break;
                case 4:
                    Dice3.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 4.png";
                    break;
                case 5:
                    Dice3.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 5.png";
                    break;
                case 6:
                    Dice3.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 6.png";
                    break;

            }
            switch (dice4)
            {
                case 1:
                    Dice4.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 1.png";
                    break;
                case 2:
                    Dice4.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 2.png";
                    break;
                case 3:
                    Dice4.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 3.png";
                    break;
                case 4:
                    Dice4.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 4.png";
                    break;
                case 5:
                    Dice4.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 5.png";
                    break;
                case 6:
                    Dice4.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 6.png";
                    break;

            }
            switch (dice5)
            {
                case 1:
                    Dice5.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 1.png";
                    break;
                case 2:
                    Dice5.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 2.png";
                    break;
                case 3:
                    Dice5.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 3.png";
                    break;
                case 4:
                    Dice5.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 4.png";
                    break;
                case 5:
                    Dice5.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 5.png";
                    break;
                case 6:
                    Dice5.ImageLocation = @"C:\Users\ankid\source\repos\Yahtzee\Dobbelsteenties\Resources\Dice 6.png";
                    break;
            }

        }
        private void Dice1_Click(object sender, EventArgs e)
        {

        }

       /* private void checken_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Dice.Length; i++)
            {
                for (int j = 1; j < Dice.Length; j++)
                {
                    if (Dice[i]==Dice[j])
                    {
                        textBox.Text = Convert.ToString(Dice[j]);
                    }
                }
            }
        }*/

        private void HoldButtonDice4_Click_1_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice1 == false)  // Hij kijkt eerst of de HoldCondition is gelijk aan ''false'', als hij het zal uitvoeren zonder te kijken zal de gebruiker niet weten of hij de dobbelstenen ''hold''.
            {
                HoldConditionDice1 = true;// hij veranderd de conditie naar ''true'', omdat de gebruiker de dobbelstenen wil houden. 
                HoldButtonDice4_Click_1.Text = "Holding.."; // Veranderd de Hold button naar ''Holding..", om het makkelijker te maken om te zien of de gebruiker de dobbelstenen op ''hold'' heeft.
                HoldButtonDice4_Click_1.ForeColor = Color.Crimson;  // veranderd de "ForeColor'' naar Crimson zodat het makkelijker te zien is of de gebruker de dobbelstenen op ''Hold'' gezet heeft of niet.
            }
            else if (HoldConditionDice1 == true) // Hij kijkt eerst of de "hold'' conditie true is, zodat hij niet naar 'hold' veranderd als je juist je dobbelsteen niet wil houden, en de gebruiker verward.
            {
                HoldConditionDice1 = false; // Natuurlijk veranderd hij het naar false, omdat de gebruiker de dobbelsteen niet wil houden. Zonder dit zal het programma hetzelfde stuk code uitvoeren.
                HoldButtonDice4_Click_1.Text = "Hold";  //Veranderd de text in "HoldButtonDice'' naar "hold" zodat de gebruiker het weet dat hij niet meer de dobbelsteen houd.
                HoldButtonDice4_Click_1.ForeColor = Color.Teal; //De button gaat terug naar zijn neutrale kleur, en de gebruiker weet dat het dobbelsteen niet meer wordt gehouden.
            }
        }

        private void HoldButtonDice5_Click_1_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice2 == false)
            {

                HoldButtonDice5_Click_1.Text = "Holding..";
                HoldButtonDice5_Click_1.ForeColor = Color.Crimson;
                HoldConditionDice2 = true;
            }
            else if (HoldConditionDice2 == true)
            {

                HoldButtonDice5_Click_1.Text = "Hold";
                HoldButtonDice5_Click_1.ForeColor = Color.Teal;
                HoldConditionDice2 = false;
            }

        }

        private void HoldButtonDice2_Click_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice3 == false)
            {
                HoldConditionDice3 = true;
                HoldButtonDice2_Click.Text = ("Holding..");
                HoldButtonDice2_Click.ForeColor = Color.Crimson;
            }
            else if (HoldConditionDice3 == true)
            {
                HoldConditionDice3 = false;
                HoldButtonDice2_Click.Text = ("Hold");
                HoldButtonDice2_Click.ForeColor = Color.Teal;
            }
        }

        private void HoldButtonDice1_Click_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice4 == false)
            {
                HoldConditionDice4 = true;
                HoldButtonDice1_Click.Text = ("Holding..");
                HoldButtonDice1_Click.ForeColor = Color.Crimson;

            }
            else if (HoldConditionDice4 == true)
            {
                HoldConditionDice4 = false;
                HoldButtonDice1_Click.Text = ("Hold");
                HoldButtonDice1_Click.ForeColor = Color.Teal;
            }
        }

        private void HoldButtonDice3_Click_Click(object sender, EventArgs e)
        {
            if (HoldConditionDice5 == false)
            {
                HoldConditionDice5 = true;
                HoldButtonDice3_Click.Text = ("Holding..");
                HoldButtonDice3_Click.ForeColor = Color.Crimson;
            }
            else if (HoldConditionDice5 == true)
            {
                HoldConditionDice5 = false;
                HoldButtonDice3_Click.Text = ("Hold");
                HoldButtonDice3_Click.ForeColor = Color.Teal;
            }
        }
    }
}