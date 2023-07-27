namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_düzenleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Writers", "HeadingStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "HeadingStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Headings", "HeadingStatus");
        }
    }
}
