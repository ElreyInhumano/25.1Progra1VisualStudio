using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    class LimaCity : City, IObtainTaxes
    {
        public LimaCity(string name, float taxes, float priceBuild, float pricePark, float buildsCount, bool building1, bool park1, bool building2,
            bool building3, bool park2, bool park3) : base(name, taxes, priceBuild, pricePark, buildsCount, building1, park1)
        {
            this.building2 = building2;
            this.building3 = building3;
            this.park2 = park2;
            this.park3 = park3;
        }

        public float ObtainTaxes()
        {
            if(buildsCount == 0)
            {
                return taxes;
            }
            else if(buildsCount == 1)
            {
                return taxes * 2;
            }
            else if(buildsCount == 2)
            {
                return taxes * 3;
            }
            else if(buildsCount == 3)
            {
                return taxes * 4;
            }
            else if(buildsCount == 4)
            {
                return taxes * 5;
            }
            else if(buildsCount == 5)
            {
                return taxes * 6;
            }
            else
            {
                return taxes * 7;
            }
        }
        public override string GetDetails()
        {
            if(building1 && building2 && building3 && park1 && park2 && park3)
            {
                return $"La ciudad {name} genera {taxes} y tiene 3 edificios y 3 parques";
            } 
            else if(building1 && building2 && building3 && park1 && park2)
            {
                return $"La ciudad {name} genera {taxes} y tiene 3 edificios y 2 parques";
            }
            else if(building1 && building2 && building3 && park1)
            {
                return $"La ciudad {name} genera {taxes} y tiene 3 edificios y 1 parque";
            }
            else if(building1 && building2 && building3)
            {
                return $"La ciudad {name} genera {taxes} y tiene 3 edificios y 0 parques";
            }
            else if(building1 && building2 && park1 && park2 && park3)
            {
                return $"La ciudad {name} genera {taxes} y tiene 2 edificios y 3 parques";
            }
            else if(building1 && park1 && park2 && park3)
            {
                return $"La ciudad {name} genera {taxes} y tiene 1 edificio y 3 parques";
            }
            else if(park1 && park2 && park3)
            {
                return $"La ciudad {name} genera {taxes} y tiene 0 edificios y 3 parques";
            }
            else if(building1 && building2 && park1 && park2)
            {
                return $"La ciudad {name} genera {taxes} y tiene 2 edificios y 2 parques";
            }
            else if(building1 && building2 && park1)
            {
                return $"La ciudad {name} genera {taxes} y tiene 2 edificios y 1 parque";
            }
            else if(building1 && building2)
            {
                return $"La ciudad {name} genera {taxes} y tiene 2 edificios y 0 parques";
            }
            else if(building1 && park1 && park2)
            {
                return $"La ciudad {name} genera {taxes} y tiene 1 edificio y 2 parques";
            }
            else if(park1 && park2)
            {
                return $"La ciudad {name} genera {taxes} y tiene 0 edificios y 2 parques";
            }
            else if(building1 && park1)
            {
                return $"La ciudad {name} genera {taxes} y tiene 1 edificio y 1 parque";
            }
            else if(building1)
            {
                return $"La ciudad {name} genera {taxes} y tiene 1 edificio y 0 parques";
            }
            else if(park1)
            {
                return $"La ciudad {name} genera {taxes} y tiene 0 edificios y 1 parque";
            }
            else
            {
                return $"La ciudad {name} genera {taxes} y no tiene edificios ni parques";
            }
        }
    }
}
