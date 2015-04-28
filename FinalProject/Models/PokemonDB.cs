using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class PokemonDB : DbContext
    {
        public PokemonDB() : base("DefaultConnection") { }
        public DbSet<Evolution> Evolutions { get; set; }
        public DbSet<Type> Types { get; set; }

        public System.Data.Entity.DbSet<FinalProject.Models.Pokemon> Pokemon { get; set; }

    }
}