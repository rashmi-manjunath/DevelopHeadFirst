using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Using debugger to see variable change.


            //int number = 15;
            //number = number + 10;
            //number = 36 * 15;
            //number = 12 - (42 / 7);
            //number += 10;
            //number *= 3;
            //number = 71 / 3;
            //MessageBox.Show("Value of Number :" +number);

            //int count = 0;
            //count++;
            //count--;

            //string result = "hell0";
            //result += " again " + result;
            //MessageBox.Show(result);
            //result = "The Value of count is: " + count;
            //MessageBox.Show(result);
            //result = "";

            //bool yesNo = false;
            //bool anotherBool = true;
            //yesNo = !anotherBool;


            //Display Variables
            String name = "Demo";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;

            MessageBox.Show("Name is: " + name
                + "\n x is " + x
                + "\n d is " + d, "Know about variables");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("Value of x is 10");
            }
            else
            {
                MessageBox.Show("Value of x is not 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 5;
            string name = "Bob";
            if ((x == 3) && (name == "Joe"))
            {
                MessageBox.Show("x is 3 and Name is Joe");
            }
            MessageBox.Show("This line runs no matter what");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int p = 2;
            //for (int q = 2; q < 32; q = q * 2)
            //{
            //    while (p < q)
            //    {
            //        p = p * 2;
            //    }
            //    q = p - q;
            //}

            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show("The answer is " + count);
        }
    }
}

