namespace ProductSearch.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration
        : DbMigrationsConfiguration<ProductSearch.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;          // <—
            AutomaticMigrationDataLossAllowed = false;  // keep false for safety
        }

        protected override void Seed(ProductSearch.Models.ApplicationDbContext context)
        {
            // optional: seed data
        }
    }
}
