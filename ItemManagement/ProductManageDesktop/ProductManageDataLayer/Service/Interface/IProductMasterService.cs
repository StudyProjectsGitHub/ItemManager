using ProductManageDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Service.Interface
{
    public interface IProductMasterService
    {
        /// <summary>
        /// Service method to create ProductMaster
        /// </summary>
        /// <param name="clubMember">club member model</param>
        /// <returns>true or false</returns>
        bool Create(ProductMaster product);

        /// <summary>
        /// Service method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetAll();

        /// <summary>
        /// Get all stocks whoes quantity is getting out of stock and reached the reminder level
        /// </summary>
        /// <returns></returns>
        DataTable GetAllReminders();
        /// <summary>
        /// Method to update ProductMaster details
        /// </summary>
        /// <param name="clubMember">club member</param>
        /// <returns></returns>
        bool Update(ProductMaster product);

        /// <summary>
        /// Method to delete a ProductMaster
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        bool Delete(int id);


        /// <summary>
        /// Method to get all ProductMaster
        /// </summary>
        /// <returns>Data table</returns>
        DataRow GetById(int Id);

        /// <summary>
        /// Search Product
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pBrand"></param>
        /// <param name="pSize"></param>
        /// <returns></returns>
        DataTable Search(string pName, string pBrand, string pSize);

        /// <summary>
        /// Get By Id For Edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductMaster GetByIdForEdit(int id);
    }
}
