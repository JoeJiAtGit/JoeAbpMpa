namespace JoeAbpMpa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AssetEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        AssetNo = c.String(nullable: false, maxLength: 128),
                        AssetDescription = c.String(),
                        DeviceId = c.String(nullable: false, maxLength: 128),
                        AssetCategoryId = c.Int(nullable: false),
                        AssetStatusId = c.Int(nullable: false),
                        DateAcquired = c.DateTime(nullable: false),
                        DateUsed = c.DateTime(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Remark = c.String(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.AssetNo)
                .ForeignKey("dbo.AssetCategories", t => t.AssetCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AssetStatus", t => t.AssetStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Devices", t => t.DeviceId, cascadeDelete: true)
                .ForeignKey("dbo.AbpUsers", t => t.User_Id)
                .Index(t => t.DeviceId)
                .Index(t => t.AssetCategoryId)
                .Index(t => t.AssetStatusId)
                .Index(t => t.DepartmentId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AssetStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        Manufacturer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assets", "User_Id", "dbo.AbpUsers");
            DropForeignKey("dbo.Assets", "DeviceId", "dbo.Devices");
            DropForeignKey("dbo.Assets", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Assets", "AssetStatusId", "dbo.AssetStatus");
            DropForeignKey("dbo.Assets", "AssetCategoryId", "dbo.AssetCategories");
            DropIndex("dbo.Assets", new[] { "User_Id" });
            DropIndex("dbo.Assets", new[] { "DepartmentId" });
            DropIndex("dbo.Assets", new[] { "AssetStatusId" });
            DropIndex("dbo.Assets", new[] { "AssetCategoryId" });
            DropIndex("dbo.Assets", new[] { "DeviceId" });
            DropTable("dbo.Devices");
            DropTable("dbo.Departments");
            DropTable("dbo.AssetStatus");
            DropTable("dbo.Assets");
            DropTable("dbo.AssetCategories");
        }
    }
}
