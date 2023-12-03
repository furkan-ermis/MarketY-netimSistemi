namespace MarketYönetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsDelete", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "İsDelete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "İsDelete", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "IsDelete");
        }
    }
}
