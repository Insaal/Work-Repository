namespace Rosneft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initial4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Repairs", "DateCreate", c => c.String(nullable: false));
            AlterColumn("dbo.Repairs", "DateEnd", c => c.String());
            AlterColumn("dbo.RepairDescriptions", "DateOfWork", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RepairDescriptions", "DateOfWork", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Repairs", "DateEnd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Repairs", "DateCreate", c => c.DateTime(nullable: false));
        }
    }
}
