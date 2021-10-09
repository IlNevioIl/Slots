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
            //Getting Money Ammount
            string moneyString = labelAmmount.Text.ToString();
            int moneyInt = Convert.ToInt32(moneyString);

            if (moneyInt <= 0)
            {
                return;
            }

            //The fee (its 10)
            int moneyNew = moneyInt - 10;
            string moneyNewString = moneyNew.ToString();
            labelAmmount.Text = moneyNewString;

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
                Console.WriteLine("Won1");
            }
            else if (num == 2 && num2 == 2 && num3 == 2)
            {
                Console.WriteLine("Won2");
            }
            else if (num == 3 && num2 == 3 && num3 == 3)
            {
                Console.WriteLine("Won3");
            }
            else
            {
                Console.WriteLine("Loose");
            }
        }
    }
}
