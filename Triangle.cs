using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Triangle: Shape, IArea
    {
        private float b, h;

        public Triangle(string name, float b, float h): base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override string GetDetails()
        {
            return $"La base del triángulo {name} es {b}, su altura es {h} y su área es {Area()}";
        }
        public float Area()
        {
            return b * h / 2;
        }
    }
}
