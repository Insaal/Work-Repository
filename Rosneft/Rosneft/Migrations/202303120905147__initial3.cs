namespace Rosneft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Holes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TeamId = c.Guid(nullable: false),
                        FieldId = c.Guid(nullable: false),
                        BushId = c.Guid(nullable: false),
                        HoleId = c.Guid(nullable: false),
                        DateTimeCreate = c.DateTime(nullable: false),
                        ArchiveRepair = c.Boolean(nullable: false),
                        DateTimeEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RepairDescriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RepairId = c.Guid(nullable: false),
                        DescriptionOfWork = c.String(),
                        DateTimeOfWork = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RepairDescriptions");
            DropTable("dbo.Repairs");
            DropTable("dbo.Holes");
        }
    }
}
