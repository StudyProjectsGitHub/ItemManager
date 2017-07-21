using ProductManageDataLayer.Context;
using ProductManageDataLayer.Entities;
using ProductManageDataLayer.Extension;
using ProductManageDataLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Service
{
    public class ProductHistoryService : IProductHistoryService
    {

        /// <summary>
        /// Save Products in the database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Create(ProductHistory productHistory)
        {
            using (var context = new ProductManagementDbContext())
            {
                context.ProductHistorys.Add(productHistory);
                return context.SaveChanges() > 0;
            }
        }


        /// <summary>
        /// Get all summmary for Products
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAllSummaryByProductId(int productId)
        {
            using (var context = new ProductManagementDbContext())
            {
                IList<ProductHistory> lstProductSummarys = context.ProductHistorys.Where(x => x.ProductID == productId).ToList();
                return lstProductSummarys.ToDataTable<ProductHistory>();
            }
        }

        public bool DoesHistoryExists(int productId)
        {
            using (var context = new ProductManagementDbContext())
            {
                return context.ProductHistorys.Any(x => x.ProductID == productId);

            }

        }

        /// <summary>
        /// Method to delete a club member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        public bool Delete(int id)
        {
            using (var context = new ProductManagementDbContext())
            {
                var product = context.ProductHistorys.Where(x=>x.ProductID == id);
                context.ProductHistorys.RemoveRange(product);
                return context.SaveChanges() > 0;
            }
        }


    }
}
