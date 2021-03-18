using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_API_2021.Model
{
    public class Faction
    {
        public int FactionID { get; set; }
        public string FactionName { get; set; }
        public string FactionDesciption { get; set; }

        public ICollection<Champion> FactionChampions { get; set; }
    }

}
