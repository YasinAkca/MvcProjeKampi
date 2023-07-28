﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_contentstatusadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "VontentStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contents", "VontentStatus");
        }
    }
}