namespace MarketYönetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "OrderDateTine");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderDateTine", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "OrderDateTime");
        }
    }
}
