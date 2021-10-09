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
            InitializeComponent();
            string version = "v1.0.0";
            int money = 100;
            string moneyString = money.ToString();

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
            int num = random.Next(1, 4);
            int num2 = random.Next(1, 4);
            int num3 = random.Next(1, 4);

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
                Console.WriteLine("Won1");
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
                Console.WriteLine("Won2");
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
                Console.WriteLine("Won3");
            }
            else
            {
                Console.WriteLine("Loose");
            }
        }
    }
}
