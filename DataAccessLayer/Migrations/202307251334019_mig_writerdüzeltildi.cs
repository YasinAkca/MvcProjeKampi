namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writerdüzeltildi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "YazarID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "YazarID" });
            RenameColumn(table: "dbo.Contents", name: "YazarID", newName: "Writer_YazarID");
            AddColumn("dbo.Contents", "WriterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Contents", "Writer_YazarID", c => c.Int());
            CreateIndex("dbo.Contents", "Writer_YazarID");
            AddForeignKey("dbo.Contents", "Writer_YazarID", "dbo.Writers", "YazarID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "Writer_YazarID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "Writer_YazarID" });
            AlterColumn("dbo.Contents", "Writer_YazarID", c => c.Int(nullable: false));
            DropColumn("dbo.Contents", "WriterID");
            RenameColumn(table: "dbo.Contents", name: "Writer_YazarID", newName: "YazarID");
            CreateIndex("dbo.Contents", "YazarID");
            AddForeignKey("dbo.Contents", "YazarID", "dbo.Writers", "YazarID", cascadeDelete: true);
        }
    }
}
