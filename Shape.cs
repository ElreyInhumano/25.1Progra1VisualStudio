using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    abstract class Shape
    {
        protected string name;

        protected Shape(string name)
        {
            this.name = name;
        }

        protected abstract string GetDetails();
    }
}
