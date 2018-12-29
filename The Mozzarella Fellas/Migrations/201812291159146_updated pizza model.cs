namespace The_Mozzarella_Fellas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedpizzamodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Toppings", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.Pizzas", "Type_Id", "dbo.Types");
            DropIndex("dbo.Pizzas", new[] { "Type_Id" });
            DropIndex("dbo.Toppings", new[] { "Pizza_Id" });
            DropTable("dbo.Pizzas");
            DropTable("dbo.Toppings");
            DropTable("dbo.Types");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Toppings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pizza_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Toppings", "Pizza_Id");
            CreateIndex("dbo.Pizzas", "Type_Id");
            AddForeignKey("dbo.Pizzas", "Type_Id", "dbo.Types", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Toppings", "Pizza_Id", "dbo.Pizzas", "Id");
        }
    }
}
