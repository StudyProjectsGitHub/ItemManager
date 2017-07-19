using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Entities
{
   public class ProductHistory
    {
        public ProductHistory()
        {
          
        }

        [Key]
        public int ProductHistoryID { get; set; }
        public virtual ProductMaster Products { get; set; }
        public string SentTo { get; set; }
        public int Updated_Quantity { get; set; }
        public DateTime Date_Modified { get; set; }
    }
}
