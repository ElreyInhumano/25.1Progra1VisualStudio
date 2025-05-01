using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Rectangle: Shape, IArea
    {

        protected float b, h;

        public Rectangle(string name, float b, float h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override string GetDetails()
        {
            return $"La base del rectángulo {name} es {b}, su altura es {h} y su área es {Area()}";
        }
        public float Area()
        {
            return b * h;
        }
    }
}
