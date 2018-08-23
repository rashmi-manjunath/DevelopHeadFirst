using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U clicked the form");
        }
        private void saySomething(object sender,EventArgs e)
        {
            MessageBox.Show("something");
        }
        private void saySomethingElse(object sender, EventArgs e)
        {
            MessageBox.Show("something else");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(saySomething);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(saySomethingElse);
        }
    }
}
