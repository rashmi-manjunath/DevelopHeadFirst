using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6Program1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty bdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)dinnerUpDown.Value, healthy.Checked, fancy.Checked);
            DisplayDinnerCost();

            bdayParty = new BirthdayParty((int)bdayUpDown.Value, fancyCheckBox.Checked, cakewriting.Text);
            DisplayBirthdayPartyCost();
            
        }

        private void DisplayBirthdayPartyCost()
        {
            cakewriting.Text = bdayParty.CakeWriting;
            decimal Cost = bdayParty.CalculateCost();
            cost.Text = Cost.ToString("c");
        }

        private void DisplayDinnerCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthy.Checked);
            cash.Text = Cost.ToString("c");
        }

        private void dinnerUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)dinnerUpDown.Value;
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

        private void bdayUpDown_ValueChanged(object sender, EventArgs e)
        {
            bdayParty.NumberOfPeople = (int)bdayUpDown.Value;
            bdayParty.CalculateCostOfDecorations(fancyCheckBox.Checked);
            DisplayBirthdayPartyCost();
        }

        private void fancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bdayParty.CalculateCostOfDecorations(fancyCheckBox.Checked);
            DisplayBirthdayPartyCost();
        }

        private void cakewriting_TextChanged(object sender, EventArgs e)
        {
            bdayParty.CakeWriting = cakewriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
