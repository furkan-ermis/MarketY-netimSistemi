namespace MarketYönetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buyProduck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyProducts", "IsDelete", c => c.Boolean(nullable: false));
            DropColumn("dbo.BuyProducts", "İsDelete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BuyProducts", "İsDelete", c => c.Boolean(nullable: false));
            DropColumn("dbo.BuyProducts", "IsDelete");
        }
    }
}
