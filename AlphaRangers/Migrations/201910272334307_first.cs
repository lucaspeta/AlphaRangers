namespace AlphaRangers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baja",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Velocidade = c.Int(nullable: false),
                        FreioQtd = c.Int(nullable: false),
                        VoltasQtd = c.Int(nullable: false),
                        Temperatura = c.Int(nullable: false),
                        Bateria = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Baja");
        }
    }
}
