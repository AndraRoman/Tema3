using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TemaPS2.Models
{
    public class Spectacol
    {
        public int SpectacolID { get; set; }
        public string Titlul { get; set; }
        public string Regia { get; set; }
        public string Distributia { get; set; }
        public Nullable<System.DateTime> DataPremierei { get; set; }
        public Nullable<int> NrBilete { get; set; }
    }
    public class SpectacolDbContext : DbContext
    {
        public DbSet<Spectacol> Spectacole { get; set; }
    }

}