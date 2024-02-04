using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorMethodExercise
{
    class Groceries //class created
    {
        public string name; //fields created
        public string amount;
        public int price;

        public Groceries(string gname, string gamount, int gprice ) //constructor created
        {
            name = gname;
            amount = gamount;
            price = gprice;
        }

    }
}
