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
    }
}
