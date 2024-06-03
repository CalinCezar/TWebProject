namespace Forums.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UDbTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 30),
                        InfoBlog = c.String(maxLength: 150),
                        Profession = c.String(maxLength: 50),
                        PhoneNumber = c.String(maxLength: 20),
                        Photo = c.String(),
                        LastLogin = c.DateTime(nullable: false),
                        LasIP = c.String(maxLength: 30),
                        Level = c.Int(nullable: false),
                        Fullname = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UDbTables");
        }
    }
}
