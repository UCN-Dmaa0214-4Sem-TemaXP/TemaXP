namespace TemaXP.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TemaXP.Model.AuctionDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TemaXP.Model.AuctionDBContext";
        }

        protected override void Seed(TemaXP.Model.AuctionDBContext context)
        {
            context.Database.ExecuteSqlCommand("ALTER TABLE dbo.Arts DROP CONSTRAINT [FK_dbo.Arts_dbo.Auctions_AuctionId];");
            context.Database.ExecuteSqlCommand("ALTER TABLE dbo.Arts ADD CONSTRAINT [FK_dbo.Arts_dbo.Auctions_AuctionId] FOREIGN KEY (AuctionId) REFERENCES dbo.Auctions(Id) ON UPDATE NO ACTION ON DELETE SET NULL;");
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
