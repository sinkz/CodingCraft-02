using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodingCraft_02.Models
{
    public class CodingCraft02Context : IdentityDbContext<ApplicationUser>
    {
        public CodingCraft02Context()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static CodingCraft02Context Create()
        {
            return new CodingCraft02Context();
        }
        public DbSet<CodingCraft_02.Models.Produto> Produtos { get; set; }

    }
}