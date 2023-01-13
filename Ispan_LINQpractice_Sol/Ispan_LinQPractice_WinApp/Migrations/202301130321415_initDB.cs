namespace Ispan_LinQPractice_WinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MebberId = c.Int(nullable: false, identity: true),
                        MemberName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        CityId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MebberId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "CityId", "dbo.Cities");
            DropIndex("dbo.Members", new[] { "CityId" });
            DropTable("dbo.Members");
            DropTable("dbo.Cities");
        }
    }
}
