namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_Content : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "Writer_YazarID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "Writer_YazarID" });
            RenameColumn(table: "dbo.Contents", name: "Writer_YazarID", newName: "YazarID");
            AddColumn("dbo.Contents", "ContentStatus", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Contents", "YazarID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contents", "YazarID");
            AddForeignKey("dbo.Contents", "YazarID", "dbo.Writers", "YazarID", cascadeDelete: true);
            DropColumn("dbo.Contents", "VontentStatus");
            DropColumn("dbo.Contents", "WriterID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "WriterID", c => c.Int(nullable: false));
            AddColumn("dbo.Contents", "VontentStatus", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Contents", "YazarID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "YazarID" });
            AlterColumn("dbo.Contents", "YazarID", c => c.Int());
            DropColumn("dbo.Contents", "ContentStatus");
            RenameColumn(table: "dbo.Contents", name: "YazarID", newName: "Writer_YazarID");
            CreateIndex("dbo.Contents", "Writer_YazarID");
            AddForeignKey("dbo.Contents", "Writer_YazarID", "dbo.Writers", "YazarID");
        }
    }
}
