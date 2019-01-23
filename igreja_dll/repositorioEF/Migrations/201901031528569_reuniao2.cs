namespace repositorioEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reuniao2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reuniao", "Ministerio_ministerioid", c => c.Int());
            CreateIndex("dbo.Reuniao", "Ministerio_ministerioid");
            AddForeignKey("dbo.Reuniao", "Ministerio_ministerioid", "dbo.Ministerio", "ministerioid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reuniao", "Ministerio_ministerioid", "dbo.Ministerio");
            DropIndex("dbo.Reuniao", new[] { "Ministerio_ministerioid" });
            DropColumn("dbo.Reuniao", "Ministerio_ministerioid");
        }
    }
}
