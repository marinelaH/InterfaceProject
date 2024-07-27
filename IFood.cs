using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    // create an interface that it can inherit from some classes
    public interface IFood
    {
        string GetInfo(string name);
    }
}
