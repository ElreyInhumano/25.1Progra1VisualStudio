using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Square: Rectangle, IArea
    {
        private Square(string name, int b, int h): base(name, b, h)
        {
        }

        protected override string GetDetails()
        {
            return $"El lado de {name} es {b}, y su área es {Area()}";
        }
        new public float Area()
        {
            return b * b;
        }
    }
}
