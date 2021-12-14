using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatciVeUlkeleri2.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext() : base("name=Erisebilirlik")
        {

        }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Sanatci> Sanatcilar { get; set; }
    }
}
