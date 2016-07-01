using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using CodingCraft_02.Migrations;

namespace CodingCraft_02.Models
{
    public class CodingCraft02Context : IdentityDbContext<ApplicationUser>
    {
        public CodingCraft02Context()
            : base("CodingCraft02", throwIfV1Schema: false)
        {
        }

        static CodingCraft02Context()
        {
            Database.SetInitializer<CodingCraft02Context>(new MigrateDatabaseToLatestVersion<CodingCraft02Context, Configuration>());
        }

        public static CodingCraft02Context Create()
        {
            return new CodingCraft02Context();
        }
        public DbSet<CodingCraft_02.Models.Produto> Produtos { get; set; }
        public DbSet<CodingCraft_02.Models.CategoriaProduto> CategoriaProdutos { get; set; }
        public DbSet<CodingCraft_02.Models.GrupoProduto> GrupoProdutos { get; set; }

    }
}