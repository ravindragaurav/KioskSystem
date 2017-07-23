using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Database
{
    public partial class KisokDatabase : DbContext
    {
        public KisokDatabase()
            : base("name=KisokDatabase")
        {
        }

        public virtual DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
