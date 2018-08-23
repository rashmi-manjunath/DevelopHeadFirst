using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12Program1
{
    public partial class fieldForm : Form
    {
        public fieldForm()
        {
            InitializeComponent();
        }
        public Renderer renderer;
        private void fieldForm_Paint(object sender, PaintEventArgs e)
        {
            renderer.PaintField(e.Graphics);
        }
    }
}
