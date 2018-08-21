using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5Program1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown.Value,healthy.Checked, fancy.Checked);
            dinnerParty.CalculateCostOfDecorations(fancy.Checked);
            dinnerParty.SetHealthyOption(healthy.Checked);
            DisplayDinnerCost();
        }
        private void DisplayDinnerCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthy.Checked);
            cash.Text = Cost.ToString("c");
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown.Value;
           // dinnerParty.CalculateCostOfDecorations(healthy.Checked);
            DisplayDinnerCost();
        }
        private void fancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancy.Checked);
            DisplayDinnerCost();
        }
        private void healthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthy.Checked);
            DisplayDinnerCost();
        }
    }
}
