using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
   public class EmployeeTerritory
    {

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int TerritoryId { get; set; }
        public ICollection< Employee>  Employees { get; set; }
        public ICollection<Territory> Territories { get; set; }
    }
}
