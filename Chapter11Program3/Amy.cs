using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Program3
{
    class Amy
    {
        public GetSecretIngredient AmySecretIngridentMethod
        {
            get
            {
                return new GetSecretIngredient(AmySecretIngrident);
            }
        }

        private string AmySecretIngrident(int amount)
        {
            if (amount < 10)
                return amount.ToString() + " cans of sardiness -- you need more!";
            else
                return amount.ToString() + " cans of sardiness";
        }
    }
}
