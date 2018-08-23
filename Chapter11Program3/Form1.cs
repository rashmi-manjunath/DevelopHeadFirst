using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11Program3
{
    public partial class Form1 : Form
    {
        GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();
        public Form1()
        {
            InitializeComponent();
        }

        private void getIngredient_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
                Console.WriteLine("I'll add " + ingredientMethod((int)amount.Value));
            else
                Console.WriteLine("I don't have a secret ingredient!");
        }

        private void getSuzanne_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredientmethod);
        }
        private void getAmy_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(amy.AmySecretIngridentMethod);
        }
    }
}
