using SharingSkills_Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SharingSkills.Models
{
    public class EFDbContext: DbContext
    {
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}