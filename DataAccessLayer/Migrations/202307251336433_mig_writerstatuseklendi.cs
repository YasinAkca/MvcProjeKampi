namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writerstatuseklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "HeadingStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "HeadingStatus");
        }
    }
}
