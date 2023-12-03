namespace MarketYönetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrder2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsStatu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "IsStatu");
        }
    }
}
