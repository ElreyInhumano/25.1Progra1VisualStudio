using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Square: Rectangle, IArea
    {
        public Square(string name, float b, float h): base(name, b, h)
        {
        }

        public override string GetDetails()
        {
            return $"El lado del cuadrado {name} es {b}, y su área es {Area()}";
        }
        new public float Area()
        {
            return b * b;
        }
    }
}
