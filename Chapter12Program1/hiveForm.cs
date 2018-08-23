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
    public partial class hiveForm : Form 
    {
        public hiveForm()
        {
            InitializeComponent();
            BackgroundImage = Renderer.ResizeImage(
                    Properties.Resources.Hive__inside_,
                    ClientRectangle.Width, ClientRectangle.Height);
        }
        public Renderer renderer;
        private void hiveForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void hiveForm_Paint(object sender, PaintEventArgs e)
        {
            renderer.PaintHive(e.Graphics);
        }
    }
}
