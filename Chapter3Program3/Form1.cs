using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3Program2
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Name = "Joe", Cash = 50 };

            bob = new Guy() { Name = "Bob", Cash = 100 };

            updateForm();
        }

        public void updateForm()
        {
            joesCashLabel.Text = joe.Name + " has Rs." + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has Rs." + bob.Cash;
            bankCashLabel.Text = "The bank has Rs." + bank;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.receiveCash(10);
                updateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.giveCash(5);
            updateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                //bob.Cash += joe.giveCash(10);
                bob.receiveCash(joe.giveCash(10));
                updateForm();
            }
            else
            {
                MessageBox.Show(joe.Name + " doesn't have cash to give");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                //joe.Cash += bob.giveCash(5);
                joe.receiveCash(bob.giveCash(5));
                updateForm();
            }
            else
            {
                MessageBox.Show(bob.Name + " doesn't have cash to give");
            }
        }
    }
}
