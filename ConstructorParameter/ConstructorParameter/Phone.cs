using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorParameter
{
    public class Phone
    {
        public string model;
        public string name;
        public int year;
        public Phone(string phModel, string phName, int purchYear)
        {
            model = phModel;
            name = phName;
            year = purchYear;
        }
    }
}
