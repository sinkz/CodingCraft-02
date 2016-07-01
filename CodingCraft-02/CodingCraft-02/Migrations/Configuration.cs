namespace CodingCraft_02.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodingCraft_02.Models.CodingCraft02Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
       
        }

        protected override void Seed(CodingCraft_02.Models.CodingCraft02Context context)
        {
         
        }
    }
}
