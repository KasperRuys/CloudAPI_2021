using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_API_2021.Model
{
    public class Champion
    {
        public int ChampionID { get; set; }
        public string ChampionName { get; set; }
        public string ChampionStory { get; set; }
        public string ChampionRole { get; set; }
        
        public Faction ChampionFaction { get; set; }
    }
}
