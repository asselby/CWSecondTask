using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
   public class Territory
    {
        public int Id { get; set; }
        public int TerritorryId { get; set; }
        public int EmployeeId { get; set; }
        public string TerritoryDescription { get; set; }
        public  EmployeeTerritory EmplTerrits { get; set; }
    }
}
