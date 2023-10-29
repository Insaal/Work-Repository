namespace Rosneft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bushes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BushName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DepartmentName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Surname = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Patronymic = c.String(nullable: false),
                        DepartmentId = c.Guid(nullable: false),
                        TeamId = c.Guid(nullable: false),
                        PostId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FieldName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserName = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PostName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TeamName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.Posts");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityUsers");
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.Fields");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Bushes");
        }
    }
}
