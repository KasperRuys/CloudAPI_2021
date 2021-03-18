using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Project_API_2021.Model
{
    public class LeagueOfLegendsContext : DbContext
    {
        public LeagueOfLegendsContext(DbContextOptions<LeagueOfLegendsContext> options) : base(options)
        {

        }
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Faction> Factions { get; set; }
       
    }
}
