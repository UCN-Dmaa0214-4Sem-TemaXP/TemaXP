namespace TemaXP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixed_auctionART : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Arts", name: "Auction_Id", newName: "AuctionId");
            RenameIndex(table: "dbo.Arts", name: "IX_Auction_Id", newName: "IX_AuctionId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Arts", name: "IX_AuctionId", newName: "IX_Auction_Id");
            RenameColumn(table: "dbo.Arts", name: "AuctionId", newName: "Auction_Id");
        }
    }
}
