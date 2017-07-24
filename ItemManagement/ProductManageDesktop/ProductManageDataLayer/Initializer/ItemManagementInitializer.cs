using ProductManageDataLayer.Context;
using ProductManageDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Initializer
{
   

    public class ItemManagementInitializer : CreateDatabaseIfNotExists<ProductManagementDbContext>
    {
        protected override void Seed(ProductManagementDbContext context)
        {
            //var dummy = new List<ProductMaster>{
            //    new ProductMaster { ProductID=1, Name = "Test"},
              
            //};

            //Products.ForEach(x => context.Products.Add(dummy));

            base.Seed(context);
        }
    }

    
}
