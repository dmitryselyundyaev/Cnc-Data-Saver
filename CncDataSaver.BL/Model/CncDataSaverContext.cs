using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaver.BL.Model
{
    public class CncDataSaverContext : DbContext
    {
        public CncDataSaverContext() : base("DataSaverConncection") { }

        public DbSet<Channel1> Channel1 { get; set; }
        public DbSet<Channel2> Channel2 { get; set; }
        public DbSet<Macro> Macros { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OffsetData> OffsetData { get; set; }
    }
}
