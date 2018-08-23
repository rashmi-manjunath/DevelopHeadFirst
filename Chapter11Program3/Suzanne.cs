using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Program3
{
    class Suzanne
    {
        public GetSecretIngredient MySecretIngredientmethod
        {
            get
            {
                return new GetSecretIngredient(SuzannesSecretIngrident);
            }
        }
        private string SuzannesSecretIngrident(int amount)
        {
            return amount.ToString() + " ounces of cloves";
        }
    }
}
