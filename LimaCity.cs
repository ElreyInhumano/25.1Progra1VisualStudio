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
            bool building3, bool park1, bool park2, bool park3) : base(name, taxes, building1, park1)
        {
            this.building2 = building2;
            this.building3 = building3;
            this.park2 = park2;
            this.park3 = park3;
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
