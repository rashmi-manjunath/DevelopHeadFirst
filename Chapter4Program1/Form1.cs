using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4Program1
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTravelled;
        double reimbruseRate = .39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
            label4.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage <= endingMileage)
            {
                milesTravelled = endingMileage - startingMileage;
                amountOwed = milesTravelled * reimbruseRate;
                label4.Show();
                label4.Text = "Rs." + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting mleage must be less than the ending mileage", "Cannot Calulate Mileage");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTravelled + " miles", "Miles Travelled");
        }
    }
}
