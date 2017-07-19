using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Entities
{
    public class ProductMaster
    {
        [Key]
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string HSN { get; set; }

        public decimal Purchase_Rate { get; set; }

        public string Packing { get; set; }

        public decimal Sell_Rate { get; set; }

        public int Quantity { get; set; }

        public int Reminder { get; set; }

        public string DealerName { get; set; }

        public DateTime Purchase_Date { get; set; }

        public DateTime LastUpdated_Date { get; set; }

    }
}
