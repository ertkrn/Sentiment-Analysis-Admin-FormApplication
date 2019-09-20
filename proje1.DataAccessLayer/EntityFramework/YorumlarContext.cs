using proje1.Entities;
using System.Data.Entity;

namespace proje1.DataAccessLayer.EntityFramework
{
    public class YorumlarContext : DbContext
    {
        public DbSet<Yorumlar> Yorumlar { get; set; }
        public DbSet<YorumSay> YorumSay { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder.Entity<PostBegeni>()
        //        .HasRequired(s => s.Uye)
        //        .WithMany()
        //        .WillCascadeOnDelete(false);

        //    base.OnModelCreating(modelBuilder);
        //}
        public YorumlarContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
