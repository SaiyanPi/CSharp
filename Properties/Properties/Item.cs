using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Item
    {
        private string name; // field
        
        public string Name // property
        { 
            get
            { 
                return name; 
            } 
            set 
            { 
                name = value; 
            }
        }
    }
}
