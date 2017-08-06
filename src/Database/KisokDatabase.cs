using System.Data.Entity;

namespace Database
{
    public partial class KisokDatabase : DbContext
    {
        public KisokDatabase(): base("name=KisokDatabase")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<QuantityType> QuantityTypes { get; set; }
    }
}
