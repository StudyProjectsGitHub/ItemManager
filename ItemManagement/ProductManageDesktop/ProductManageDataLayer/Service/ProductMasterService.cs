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
    public class ProductMasterService : IProductMasterService
    {
   
        /// <summary>
        /// Save Products in the database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Create(ProductMaster product)
        {
            using (var context = new ProductManagementDbContext())
            {
                context.Products.Add(product);
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Service method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAll()
        {
            using (var context = new ProductManagementDbContext())
            {
                IList<ProductMaster> lstProducts = context.Products.ToList();
                return lstProducts.ToDataTable<ProductMaster>();
            }
        }

        /// <summary>
        /// Service method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAllReminders()
        {
            using (var context = new ProductManagementDbContext())
            {
                IList<ProductMaster> lstProducts = context.Products.Where(x=>x.Quantity <= x.Reminder).ToList();
                return lstProducts.ToDataTable<ProductMaster>();
            }
        }

        /// <summary>
        /// Service method to get club member by Id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>Data row</returns>
        public DataRow GetById(int id)
        {
            using (var context = new ProductManagementDbContext())
            {
                ProductMaster product = context.Products
                    .Where(i => i.ProductID == id)
                    .SingleOrDefault();
                return product.ToDataRow<ProductMaster>();
            }
        }


        /// <summary>
        /// Service method to get club member by Id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>Data row</returns>
        public ProductMaster GetByIdForEdit(int id)
        {
            using (var context = new ProductManagementDbContext())
            {
                ProductMaster product = context.Products
                    .Where(i => i.ProductID == id)
                    .SingleOrDefault();
                return product;
            }
        }

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="occupation">occupation value</param>
        /// <param name="maritalStatus">marital status</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        public DataTable Search( string name, string brand, string size)
        {
            using (var context = new ProductManagementDbContext())
            {
                List<ProductMaster> members = context.Products.Where(i => i.Name.Contains(name) && i.BrandName.Contains(brand) && i.Size.Contains(size)).ToList();
                return members.ToDataTable<ProductMaster>();
            }
        }


        /// <summary>
        /// Service method to update club member
        /// </summary>
        /// <param name="productMaster">club member</param>
        /// <returns>true / false</returns>
        public bool Update(ProductMaster productMaster)
        {
            using (var context = new ProductManagementDbContext())
            {
                context.Products.Attach(productMaster);
                context.Entry(productMaster).State = EntityState.Modified;
                return context.SaveChanges() > 0;
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
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                return context.SaveChanges() > 0;
            }
        }
    }
}
