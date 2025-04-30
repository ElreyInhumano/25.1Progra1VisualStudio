using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Rectangle: Shape, IArea
    {

        protected int b, h;

        protected Rectangle(string name, int b, int h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        protected override string GetDetails()
        {
            return $"La base de{name} es {b}, su altura es {h} y su área es {Area()}";
        }
        public float Area()
        {
            return b * h;
        }
    }
}
