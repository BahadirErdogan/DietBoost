namespace DietBoost.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Calorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Carbs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Protein = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PieceGram = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PortionGram = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PieceCalorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PortionCalorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GramCalorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.MealDetails",
                c => new
                    {
                        MealID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Portion = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.MealID, t.FoodID })
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.MealID, cascadeDelete: true)
                .Index(t => t.MealID)
                .Index(t => t.FoodID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MealType = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 40),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Password = c.String(nullable: false, maxLength: 32),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WeightGoal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserType = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MealDetails", "MealID", "dbo.Meals");
            DropForeignKey("dbo.Meals", "UserID", "dbo.Users");
            DropForeignKey("dbo.MealDetails", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.Meals", new[] { "UserID" });
            DropIndex("dbo.MealDetails", new[] { "FoodID" });
            DropIndex("dbo.MealDetails", new[] { "MealID" });
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.MealDetails");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}
