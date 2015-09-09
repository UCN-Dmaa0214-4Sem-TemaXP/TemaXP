namespace TemaXP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Auction_IsDone_Member_Point_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auctions", "IsDone", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "Point", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Point");
            DropColumn("dbo.Auctions", "IsDone");
        }
    }
}
