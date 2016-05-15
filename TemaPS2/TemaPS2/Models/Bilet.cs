using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TemaPS2.Models
{
    public partial class Bilet
    {
        public int ID { get; set; }
        public int Rand { get; set; }
        public int  Numar { get; set; }
        public int IdSpectacol { get; set; }
        public virtual Spectacol Spectacol { get; set; }

    }

    public class BiletDbContext : DbContext
    {
        public DbSet<Bilet> Bilets { get; set; }
    }
}