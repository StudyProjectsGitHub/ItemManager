using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManageDataLayer.Entities
{
   public class ClubMember
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
