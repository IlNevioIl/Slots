using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //init
            InitializeComponent();
            string version = "v1.2.0";
            int money = 1000;
            //Converting int to string
            string moneyString = money.ToString();

            //Setting the labels 
            labelAmmount.Text = moneyString;
            labelVersion.Text = version;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            //Getting MoneyAmmount String
            string moneyString = labelAmmount.Text.ToString();
            //Converting String to int to do the math
            int moneyInt = Convert.ToInt32(moneyString);

            //Check if you have enough money
            if (moneyInt <= 0)
            {
                MessageBox.Show("You dont have enough money", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The fee (its 10)
            int moneyWithFee = moneyInt - 10;
            //Converting int to string
            string moneyWithFeeString = moneyWithFee.ToString();
            //Setting the label to the new ammount
            labelAmmount.Text = moneyWithFeeString;

            //Getting 3 random numbers between 1 and 3
            Random random = new Random();
            int num = random.Next(1, 5);
            int num2 = random.Next(1, 5);
            int num3 = random.Next(1, 5);

            //Changing the image (For slot1)
            if(num == 1)
            {
                pictureBox1.Image = Properties.Resources.herz;
            }
            else if(num == 2)
            {
                pictureBox1.Image = Properties.Resources.karo;
            }
            else if(num == 3)
            {
                pictureBox1.Image = Properties.Resources.kreuz;
            }
            else if (num == 4)
            {
                pictureBox1.Image = Properties.Resources.pik;
            }

            //Changing the image (For slot2)
            if (num2 == 1)
            {
                pictureBox2.Image = Properties.Resources.herz;
            }
            else if (num2 == 2)
            {
                pictureBox2.Image = Properties.Resources.karo;
            }
            else if (num2 == 3)
            {
                pictureBox2.Image = Properties.Resources.kreuz;
            }
            else if (num2 == 4)
            {
                pictureBox2.Image = Properties.Resources.pik;
            }

            //Changing the image (For slot3)
            if (num3 == 1)
            {
                pictureBox3.Image = Properties.Resources.herz;
            }
            else if (num3 == 2)
            {
                pictureBox3.Image = Properties.Resources.karo;
            }
            else if (num3 == 3)
            {
                pictureBox3.Image = Properties.Resources.kreuz;
            }
            else if (num3 == 4)
            {
                pictureBox3.Image = Properties.Resources.pik;
            }

            //Random Numbers to String for the Label
            string numString = num.ToString();
            string num2String = num2.ToString();
            string num3String = num3.ToString();

            //Naming the labels
            label1.Text = numString;
            label2.Text = num2String;
            label3.Text = num3String;


            //Check if the 3 numbers are the same
            if (num == 1 && num2 == 1 && num3 == 1)
            {
                //Getting MoneyAmmount String
                string moneyString1 = labelAmmount.Text.ToString();
                //Converting String to int to do the math
                int moneyInt1 = Convert.ToInt32(moneyString1);
                //Setting the ammount +100
                int moneyInt1New = moneyInt1 + 100;
                //Converting money int to a string
                string moneyString1New = moneyInt1New.ToString();
                //Setting the money label to the string ammount
                labelAmmount.Text = moneyString1New;
                MessageBox.Show("You got +100", "Won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == 2 && num2 == 2 && num3 == 2)
            {
                //Getting MoneyAmmount String
                string moneyString2 = labelAmmount.Text.ToString();
                //Converting String to int to do the math
                int moneyInt2 = Convert.ToInt32(moneyString2);
                //Setting the ammount +100
                int moneyInt2New = moneyInt2 + 100;
                //Converting money int to a string
                string moneyString2New = moneyInt2New.ToString();
                //Setting the money label to the string ammount
                labelAmmount.Text = moneyString2New;
                MessageBox.Show("You got +100", "Won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == 3 && num2 == 3 && num3 == 3)
            {
                //Getting MoneyAmmount String
                string moneyString3 = labelAmmount.Text.ToString();
                //Converting String to int to do the math
                int moneyInt3 = Convert.ToInt32(moneyString3);
                //Setting the ammount +100
                int moneyInt3New = moneyInt3 + 100;
                //Converting money int to a string
                string moneyString3New = moneyInt3New.ToString();
                //Setting the money label to the string ammount
                labelAmmount.Text = moneyString3New;
                MessageBox.Show("You got +100", "Won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == 4 && num2 == 4 && num3 == 4)
            {
                //Getting MoneyAmmount String
                string moneyString4 = labelAmmount.Text.ToString();
                //Converting String to int to do the math
                int moneyInt4 = Convert.ToInt32(moneyString4);
                //Setting the ammount +100
                int moneyInt4New = moneyInt4 + 100;
                //Converting money int to a string
                string moneyString4New = moneyInt4New.ToString();
                //Setting the money label to the string ammount
                labelAmmount.Text = moneyString4New;
                MessageBox.Show("You got +100", "Won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Nothing because you lost
            }
        }
    }
}