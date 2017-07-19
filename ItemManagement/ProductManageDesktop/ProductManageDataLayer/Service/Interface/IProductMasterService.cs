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
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="occupation">occupation value</param>
        /// <param name="maritalStatus">marital status</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        DataTable Search(DateTime startDate, DateTime endDate, string pName);
    }
}
