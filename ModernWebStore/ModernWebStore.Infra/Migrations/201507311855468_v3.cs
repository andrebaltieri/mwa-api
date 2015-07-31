namespace ModernWebStore.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Image", c => c.String(maxLength: 4000));
        }
    }
}
