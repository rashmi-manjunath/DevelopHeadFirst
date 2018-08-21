using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8Program7
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> retiredNumbers = new Dictionary<int, JerseyNumber>()
            {
                {3, new JerseyNumber("Babe Ruth",2000) },
                {4, new JerseyNumber("Lou Gehrig",1999) },
                {5, new JerseyNumber("Joe DiMiggio",2001) },
                {6, new JerseyNumber("Mickey Mantle",2002) },
                {7, new JerseyNumber("Yogi Brra",2003) },
                {8, new JerseyNumber("Phil Rizzuto",2004) },
                {9, new JerseyNumber("Don Mattingly",2011) },
                {40, new JerseyNumber("Jackie",2000) },
                {12, new JerseyNumber("Jackson",2014) },
            };
        public Form1()
        {
            InitializeComponent();
            foreach(int key in retiredNumbers.Keys)
            {
                number.Items.Add(key);
            }
        }

        private void number_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jersyNumber = retiredNumbers[(int)number.SelectedItem] as JerseyNumber;
            player.Text = jersyNumber.PlayerName;
            year.Text = jersyNumber.RetiredYear.ToString();
        }
    }
}
