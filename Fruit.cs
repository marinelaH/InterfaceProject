using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    // fruit can implement more than one interface
    // all methods that are in Interfaces should to implement in this class
    internal class Fruit : IFood, IVegetable
    {
        public string Emri { get; set; }
        public int Kalorite { get; set; }
        public Fruit(string name, int calories)
        {
            Emri = name;
            Kalorite = calories;
        }
        public string GetInfo(string name)
        {
            return $"This is a {name}";
        }

        public string ReturnVitamins()
        {
            return "This orange has many vitamins";
        }
    }
}
