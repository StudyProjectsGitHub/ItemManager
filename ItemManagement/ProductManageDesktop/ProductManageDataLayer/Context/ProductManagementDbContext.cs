using ProductManageDataLayer.Entities;
using ProductManageDataLayer.Initializer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Context
{


    public class ProductManagementDbContext : DbContext
    {
        public ProductManagementDbContext()
            : base("ItemDatabase.DbConnection")
        {
            Database.SetInitializer<ProductManagementDbContext>(new ItemManagementInitializer());
            Configuration.ProxyCreationEnabled = false;
        }


        public DbSet<ClubMember> ClubMembers { get; set; }

        public DbSet<ProductMaster> Products { get; set; }

        public DbSet<ProductHistory> ProductHistorys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClubMember>().HasKey<int>(l => l.Id);
            modelBuilder.Entity<ProductMaster>().HasKey<int>(l => l.ProductID);

            //one-to-many 
            //configure one-to-many
            modelBuilder.Entity<ProductHistory>()
                         .HasRequired<ProductMaster>(s => s.Products) // Student entity requires Standard 
                         .WithMany(s => s.ProductHistory).WillCascadeOnDelete(false); // Standard entity includes many Students entities


        }

    }
}
