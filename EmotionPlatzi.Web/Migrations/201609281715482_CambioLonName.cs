namespace EmotionPlatzi.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioLonName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmoPictures", "Path", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmoPictures", "Path", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
