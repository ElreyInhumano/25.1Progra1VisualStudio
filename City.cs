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
        public float priceBuild;
        public float pricePark;
        public float buildsCount;
        public bool building1;
        public bool building2;
        public bool building3;
        public bool park1;
        public bool park2;
        public bool park3;

        protected City(string name, float taxes, float priceBuild, float pricePark, float buildsCount, bool building1, bool park1)
        {
            this.name = name;
            this.taxes = taxes;
            this.priceBuild = priceBuild;
            this.pricePark = pricePark;
            this.buildsCount = buildsCount;
            this.building1 = building1;
            this.park1 = park1;
        }

        public abstract string GetDetails();
    }
}
