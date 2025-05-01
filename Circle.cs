using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class Circle: Shape, IArea
    {
        private float r;
        public Circle(string name, float r): base(name)
        {
            this.r = r;
        }

        public override string GetDetails()
        {
            return $"El radio del círculo {name} es {r}, y su área es {Area()}";
        }
        public float Area()
        {
            return r * r * 3.1416f;
        }
    }
}
