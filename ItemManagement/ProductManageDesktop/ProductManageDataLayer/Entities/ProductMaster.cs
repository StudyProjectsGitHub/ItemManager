﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Entities
{
    public class ProductMaster
    {
        public ProductMaster()
        {
            ProductHistory = new List<ProductHistory>();

        }
        [Key]
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string BrandName { get; set; }

        public string Size { get; set; }

        public string HSN { get; set; }

        public decimal Purchase_Rate { get; set; }

        public decimal Sell_Rate { get; set; }

        public string Packing { get; set; }

        public int Quantity { get; set; }

        public int Reminder { get; set; }

        public string DealerName { get; set; }

        public DateTime Purchase_Date { get; set; }

        public DateTime LastUpdated_Date { get; set; }

        public virtual ICollection<ProductHistory> ProductHistory { get; set; }

    }
}
