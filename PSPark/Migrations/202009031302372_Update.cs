namespace PSPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "customer_Id", "dbo.Customers");
            DropIndex("dbo.Cars", new[] { "customer_Id" });
            DropColumn("dbo.Cars", "CustomerName");
            DropColumn("dbo.Cars", "Name");
            DropColumn("dbo.Cars", "customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "customer_Id", c => c.Int());
            AddColumn("dbo.Cars", "Name", c => c.String());
            AddColumn("dbo.Cars", "CustomerName", c => c.String());
            CreateIndex("dbo.Cars", "customer_Id");
            AddForeignKey("dbo.Cars", "customer_Id", "dbo.Customers", "Id");
        }
    }
}
