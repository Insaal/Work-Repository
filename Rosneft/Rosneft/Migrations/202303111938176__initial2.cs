namespace Rosneft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OperationName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PipeDiameters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Diameter = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProtectorTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProtectorTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeOfDescentEquipments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TypeOfDescentEquipments");
            DropTable("dbo.ProtectorTypes");
            DropTable("dbo.PipeDiameters");
            DropTable("dbo.Operations");
        }
    }
}
