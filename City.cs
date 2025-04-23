using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    abstract class City
    {
        protected string name;
        protected float taxes;
        protected bool building1;
        protected bool building2;
        protected bool building3;
        protected bool park1;
        protected bool park2;
        protected bool park3;

        protected City(string name, float taxes, bool building1, bool building2,
            bool building3, bool park1, bool park2, bool park3)
        {
            this.name = name;
            this.taxes = taxes;
            this.building1 = building1;
            this.building2 = building2;
            this.building3 = building3;
            this.park1 = park1;
            this.park2 = park2;
            this.park3 = park3;
        }

        
    }
}
