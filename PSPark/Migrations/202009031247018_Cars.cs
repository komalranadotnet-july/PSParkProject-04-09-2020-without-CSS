namespace PSPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CustomerName", c => c.String());
            AddColumn("dbo.Cars", "Name", c => c.String());
            AddColumn("dbo.Cars", "customer_Id", c => c.Int());
            CreateIndex("dbo.Cars", "customer_Id");
            AddForeignKey("dbo.Cars", "customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "customer_Id", "dbo.Customers");
            DropIndex("dbo.Cars", new[] { "customer_Id" });
            DropColumn("dbo.Cars", "customer_Id");
            DropColumn("dbo.Cars", "Name");
            DropColumn("dbo.Cars", "CustomerName");
        }
    }
}
