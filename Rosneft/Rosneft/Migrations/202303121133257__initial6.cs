namespace Rosneft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operations", "NormMin", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operations", "NormMin");
        }
    }
}
