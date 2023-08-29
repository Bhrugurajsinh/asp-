namespace Computer_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Computer_ID = c.Long(nullable: false, identity: true),
                        Computer_Name = c.String(),
                        Computer_Price = c.String(),
                        Document_Date = c.DateTime(nullable: false),
                        OS = c.String(),
                    })
                .PrimaryKey(t => t.Computer_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Computers");
        }
    }
}
