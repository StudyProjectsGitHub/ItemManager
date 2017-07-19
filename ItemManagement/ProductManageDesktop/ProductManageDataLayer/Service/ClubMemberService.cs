using ProductManageDataLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManageDataLayer.Entities;
using ProductManageDataLayer.Context;

namespace ProductManageDataLayer.Service
{
    public class ClubMemberService : IClubMemberService
    {
        public bool Create(ClubMember clubMember)
        {
            using (var context = new ProductManagementDbContext())
            {
                context.ClubMembers.Add(clubMember);
                return context.SaveChanges() > 0;
            }
        }
    }
}
