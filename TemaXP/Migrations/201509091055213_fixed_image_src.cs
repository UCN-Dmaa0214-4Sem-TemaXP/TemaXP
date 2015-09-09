namespace TemaXP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixed_image_src : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Arts", "Image", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Arts", "Image", c => c.String(maxLength: 100));
        }
    }
}
