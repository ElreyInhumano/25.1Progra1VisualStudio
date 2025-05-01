using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Square: Rectangle
    {
        public Square(string name, float l): base(name, l, l)
        {
        }

        public override string GetDetails()
        {
            return $"El lado del cuadrado {name} es {b}, y su área es {Area()}";
        }
    }
}
