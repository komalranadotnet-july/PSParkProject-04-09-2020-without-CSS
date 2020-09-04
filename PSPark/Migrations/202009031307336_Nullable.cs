namespace PSPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PhoneNo", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PhoneNo", c => c.Int(nullable: false));
        }
    }
}
