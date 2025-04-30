using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Rectangle: Shape
    {

        protected int b, h;

        protected Rectangle(string name, int b, int h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        protected override string GetDetails()
        {
            throw new NotImplementedException();
        }

    }
}
