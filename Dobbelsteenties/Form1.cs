using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int dice1;
        int dice2;
        int dice3;
        int dice4;
        int dice5;
        private void gooien_Click(object sender, EventArgs e)
        {
                Random rnd = new Random();
            //dice1 = rnd.Next(1, 7);
            dice1 = 1;
                dice2 = rnd.Next(1, 7);
                dice3 = rnd.Next(1, 7);
                dice4 = rnd.Next(1, 7);
                dice5 = rnd.Next(1, 7);
            

            switch (dice1)
            {
                case 1:
                    Dice1.ImageLocation = @"C:\Resources\Dice 1.png";
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
