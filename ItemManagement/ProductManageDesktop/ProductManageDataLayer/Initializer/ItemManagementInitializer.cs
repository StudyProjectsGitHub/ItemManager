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
            var clubMembers = new List<ClubMember>{
                new ClubMember {Id=1, Name = "Pete Darson"},
            };

            clubMembers.ForEach(category => context.ClubMembers.Add(category));
            base.Seed(context);
        }
    }


}
