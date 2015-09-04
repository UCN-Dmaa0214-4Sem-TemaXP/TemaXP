namespace TemaXP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        Name = c.String(maxLength: 200),
                        Artist = c.String(maxLength: 200),
                        Number = c.Int(nullable: false),
                        Description = c.String(maxLength: 300),
                        Image = c.String(maxLength: 100),
                        StartingBid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Auction_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auctions", t => t.Auction_Id)
                .Index(t => t.Auction_Id);
            
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        BidAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Member_Id = c.Int(),
                        Art_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .ForeignKey("dbo.Arts", t => t.Art_Id)
                .Index(t => t.Member_Id)
                .Index(t => t.Art_Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Department = c.String(maxLength: 100),
                        CPR = c.String(),
                        Address = c.String(maxLength: 300),
                        Postal = c.String(maxLength: 100),
                        City = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Arts", "Auction_Id", "dbo.Auctions");
            DropForeignKey("dbo.Bids", "Art_Id", "dbo.Arts");
            DropForeignKey("dbo.Bids", "Member_Id", "dbo.Members");
            DropIndex("dbo.Bids", new[] { "Art_Id" });
            DropIndex("dbo.Bids", new[] { "Member_Id" });
            DropIndex("dbo.Arts", new[] { "Auction_Id" });
            DropTable("dbo.Auctions");
            DropTable("dbo.Members");
            DropTable("dbo.Bids");
            DropTable("dbo.Arts");
        }
    }
}
