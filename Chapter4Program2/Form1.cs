using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4Program2
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.whoAmI();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.whoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant swap;
            swap = lloyd;
            lloyd = lucinda;
            lucinda = swap;
            MessageBox.Show("Objects swapped"); 
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    lloyd = lucinda;
        //    lloyd.EarSize = 4352;
        //    lloyd.whoAmI();
        //}
    }
}
