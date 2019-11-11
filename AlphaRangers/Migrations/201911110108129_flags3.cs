namespace AlphaRangers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flags3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Flags", "Green", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Flags", "Yellow", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Flags", "Red", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Flags", "Shutdown", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Flags", "WasReaded", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Flags", "WasReaded", c => c.Int(nullable: false));
            AlterColumn("dbo.Flags", "Shutdown", c => c.Int(nullable: false));
            AlterColumn("dbo.Flags", "Red", c => c.Int(nullable: false));
            AlterColumn("dbo.Flags", "Yellow", c => c.Int(nullable: false));
            AlterColumn("dbo.Flags", "Green", c => c.Int(nullable: false));
        }
    }
}
