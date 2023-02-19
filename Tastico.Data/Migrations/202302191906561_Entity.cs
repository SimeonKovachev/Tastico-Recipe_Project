namespace Tastico.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Ingredients = c.String(),
                        Instructions = c.String(),
                        CuisineId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        DifficultyLevelId = c.Int(nullable: false),
                        Portions = c.Int(nullable: false),
                        TimeForCreation = c.Int(nullable: false),
                        TimeForCooking = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Cuisines", t => t.CuisineId, cascadeDelete: true)
                .ForeignKey("dbo.DifficultyLevels", t => t.DifficultyLevelId, cascadeDelete: true)
                .Index(t => t.CuisineId)
                .Index(t => t.CategoryId)
                .Index(t => t.DifficultyLevelId);
            
            CreateTable(
                "dbo.Cuisines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DifficultyLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "DifficultyLevelId", "dbo.DifficultyLevels");
            DropForeignKey("dbo.Recipes", "CuisineId", "dbo.Cuisines");
            DropForeignKey("dbo.Recipes", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Recipes", new[] { "DifficultyLevelId" });
            DropIndex("dbo.Recipes", new[] { "CategoryId" });
            DropIndex("dbo.Recipes", new[] { "CuisineId" });
            DropTable("dbo.DifficultyLevels");
            DropTable("dbo.Cuisines");
            DropTable("dbo.Recipes");
            DropTable("dbo.Categories");
        }
    }
}
