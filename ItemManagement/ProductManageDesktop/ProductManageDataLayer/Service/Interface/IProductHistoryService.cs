﻿using System;
using ProductManageDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Service.Interface
{
    public interface IProductHistoryService
    {
        /// <summary>
        /// Service method to create ProductMaster
        /// </summary>
        /// <param name="clubMember">club member model</param>
        /// <returns>true or false</returns>
        bool Create(ProductHistory productHistory);

        /// <summary>
        /// Get all Summmary for product ID 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        DataTable GetAllSummaryByProductId(int productId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        bool DoesHistoryExists(int productId);

        /// <summary>
        /// Method to delete a ProductHistory
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        bool Delete(int id);
    }
}
