namespace repositorioEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class historico2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Historico", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.Historico", new[] { "Pessoa_Id" });
            RenameColumn(table: "dbo.Historico", name: "Pessoa_Id", newName: "pessoaid");
            AlterColumn("dbo.Historico", "pessoaid", c => c.Int(nullable: false));
            CreateIndex("dbo.Historico", "pessoaid");
            AddForeignKey("dbo.Historico", "pessoaid", "dbo.Pessoa", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Historico", "pessoaid", "dbo.Pessoa");
            DropIndex("dbo.Historico", new[] { "pessoaid" });
            AlterColumn("dbo.Historico", "pessoaid", c => c.Int());
            RenameColumn(table: "dbo.Historico", name: "pessoaid", newName: "Pessoa_Id");
            CreateIndex("dbo.Historico", "Pessoa_Id");
            AddForeignKey("dbo.Historico", "Pessoa_Id", "dbo.Pessoa", "Id");
        }
    }
}
