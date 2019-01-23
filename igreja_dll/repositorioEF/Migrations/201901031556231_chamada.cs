namespace repositorioEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chamada : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Chamada");
            AddColumn("dbo.Chamada", "Numero_chamada", c => c.Int(nullable: false));
            AlterColumn("dbo.Chamada", "chamadaid", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Chamada", "chamadaid");
            CreateIndex("dbo.Chamada", "chamadaid");
            AddForeignKey("dbo.Chamada", "chamadaid", "dbo.Pessoa", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chamada", "chamadaid", "dbo.Pessoa");
            DropIndex("dbo.Chamada", new[] { "chamadaid" });
            DropPrimaryKey("dbo.Chamada");
            AlterColumn("dbo.Chamada", "chamadaid", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Chamada", "Numero_chamada");
            AddPrimaryKey("dbo.Chamada", "chamadaid");
        }
    }
}
