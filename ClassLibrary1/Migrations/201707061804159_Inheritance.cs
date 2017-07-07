namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        TestFiled = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "ID", "dbo.People");
            DropForeignKey("dbo.Admins", "ID", "dbo.People");
            DropIndex("dbo.Clients", new[] { "ID" });
            DropIndex("dbo.Admins", new[] { "ID" });
            DropTable("dbo.Clients");
            DropTable("dbo.Admins");
            DropTable("dbo.People");
        }
    }
}
