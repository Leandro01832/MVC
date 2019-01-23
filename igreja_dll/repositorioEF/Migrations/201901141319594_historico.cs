namespace repositorioEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class historico : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Historico", "Data_fim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Historico", "Data_fim", c => c.DateTime(nullable: false));
        }
    }
}
