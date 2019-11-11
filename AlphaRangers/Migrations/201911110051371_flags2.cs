namespace AlphaRangers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flags2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Green = c.Int(nullable: false),
                        Yellow = c.Int(nullable: false),
                        Red = c.Int(nullable: false),
                        Shutdown = c.Int(nullable: false),
                        WasReaded = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Flags");
        }
    }
}
