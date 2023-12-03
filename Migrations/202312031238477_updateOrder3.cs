namespace MarketYönetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrder3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "IsStatu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "IsStatu", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "IsStatus");
        }
    }
}
