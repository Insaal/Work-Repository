namespace Rosneft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initial5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Repairs", "DateCreate", c => c.String(nullable: false));
            AddColumn("dbo.Repairs", "TimeCreate", c => c.String(nullable: false));
            AddColumn("dbo.Repairs", "DateEnd", c => c.String());
            AddColumn("dbo.Repairs", "TimeEnd", c => c.String());
            AddColumn("dbo.RepairDescriptions", "DateOfWork", c => c.String());
            AddColumn("dbo.RepairDescriptions", "TimeOfWork", c => c.String());
            DropColumn("dbo.Repairs", "DateTimeCreate");
            DropColumn("dbo.Repairs", "DateTimeEnd");
            DropColumn("dbo.RepairDescriptions", "DateTimeOfWork");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RepairDescriptions", "DateTimeOfWork", c => c.String());
            AddColumn("dbo.Repairs", "DateTimeEnd", c => c.String());
            AddColumn("dbo.Repairs", "DateTimeCreate", c => c.String(nullable: false));
            DropColumn("dbo.RepairDescriptions", "TimeOfWork");
            DropColumn("dbo.RepairDescriptions", "DateOfWork");
            DropColumn("dbo.Repairs", "TimeEnd");
            DropColumn("dbo.Repairs", "DateEnd");
            DropColumn("dbo.Repairs", "TimeCreate");
            DropColumn("dbo.Repairs", "DateCreate");
        }
    }
}
