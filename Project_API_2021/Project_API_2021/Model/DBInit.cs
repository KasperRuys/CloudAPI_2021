using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_API_2021.Model;
using Microsoft.EntityFrameworkCore;

namespace Project_API_2021.Model
{
    public class DBInit
    {
        public static void Initialize(LeagueOfLegendsContext context)
        {
            context.Database.EnsureCreated();
            
            if (!context.Factions.Any())
            {
                Faction fa0 = new Faction()
                {
                    FactionChampions = new List<Champion>(),
                    FactionDesciption = "TestDescription",
                    FactionName = "FactionName"
                };
                context.Factions.Add(fa0);
                context.SaveChanges();
                if (!context.Champions.Any())
                {
                    Champion ch0 = new Champion()
                    {
                        ChampionFaction = fa0,
                        ChampionName = "Testname",
                        ChampionRole = "Top",
                        ChampionStory = "A story"
                    };
            }
            }
            
        }
    }
}
