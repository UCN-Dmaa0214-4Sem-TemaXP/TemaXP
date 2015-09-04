namespace TemaXP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueNumber : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Arts", "Number", unique: true, name: "Number");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Arts", "Number");
        }
    }
}
