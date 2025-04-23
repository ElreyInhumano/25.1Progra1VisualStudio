using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class LimaCity : City
    {
        public LimaCity(string name, float taxes, bool building1, bool building2,
            bool building3, bool park1, bool park2, bool park3) : base(name, taxes, building1, building2,
            building3, park1, park2, park3)
        {

        }
    }
}
