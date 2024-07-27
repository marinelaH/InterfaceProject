using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class Vegetable : IFood
    {
        public string GetInfo(string name)
        {
            return $"New vegetable that you created is {name}";
        }
    }
}
