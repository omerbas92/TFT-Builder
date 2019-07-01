using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tftWEB.Models
{
    public class TFTContext : DbContext
    {
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemRelation> ItemRelations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tft.db");
        }
    }

    public class Champion
    {
        public int Id { get; set; }

        public int Gold { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public ChampionOrigin Origin { get; set; }
        public ChampionClass Class { get; set; }
    }

    public class ChampionOrigin
    {
        public Origins Id { get; set; }
        public string GeneralDescription { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }

    public enum Origins
    {
        Demon = 1,
        Dragon = 2,
        Exile = 3,
        Glacial = 4,
        Robot = 5,
        Imperial = 6,
        Noble = 7,
        Ninja = 8,
        Pirate = 9,
        Phantom = 10,
        Wild = 11,
        Void = 12,
        Yordle = 13,
    }

    public class ChampionClass
    {
        public Classes Id { get; set; }
        public string GeneralDescription { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }

    public enum Classes
    {
        Assassin = 1,
        Blademaster = 2,
        Brawler = 3,
        Elementalist = 4,
        Guardian = 5,
        Gunslinger = 6,
        Knight = 7,
        Ranger = 8,
        Shapeshifter = 9,
        Sorcerer = 10
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }

    public class ItemRelation
    {
        public int Id { get; set; }
        public Item PreviousItem1 { get; set; }
        public Item PreviousItem2 { get; set; }
        public Item NextItem { get; set; }
    }
}
