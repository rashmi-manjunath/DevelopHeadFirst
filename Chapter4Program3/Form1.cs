using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuMaker menu = new MenuMaker();

            label1.Text = menu.getMenuItem();
            label2.Text = menu.getMenuItem();
            label3.Text = menu.getMenuItem();
            label4.Text = menu.getMenuItem();
            label5.Text = menu.getMenuItem();
            label6.Text = menu.getMenuItem();
            label7.Text = menu.getMenuItem();
            label8.Text = menu.getMenuItem();
            label9.Text = menu.getMenuItem();

        }
    }
}
