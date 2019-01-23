namespace repositorioEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reuniao3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pessoa", "Reuniao_cronologiaid", "dbo.Reuniao");
            DropForeignKey("dbo.Reuniao", "Cargo_Lider_Treinamento_Lidertreinamentoid", "dbo.Lider_treinamento");
            DropForeignKey("dbo.Reuniao", "Cargo_Supervisor_Supervisorid", "dbo.Supervisor");
            DropForeignKey("dbo.Reuniao", "Cargo_Supervisor_Treinamento_Supervisortreinamentoid", "dbo.Supervisor_Treinamento");
            DropForeignKey("dbo.Reuniao", "Ministerio_ministerioid", "dbo.Ministerio");
            DropForeignKey("dbo.Reuniao", "Cargo_Lider_Liderid", "dbo.Lider");
            DropIndex("dbo.Pessoa", new[] { "Reuniao_cronologiaid" });
            DropIndex("dbo.Reuniao", new[] { "Cargo_Lider_Treinamento_Lidertreinamentoid" });
            DropIndex("dbo.Reuniao", new[] { "Cargo_Supervisor_Supervisorid" });
            DropIndex("dbo.Reuniao", new[] { "Cargo_Supervisor_Treinamento_Supervisortreinamentoid" });
            DropIndex("dbo.Reuniao", new[] { "Ministerio_ministerioid" });
            DropIndex("dbo.Reuniao", new[] { "Cargo_Lider_Liderid" });
            CreateTable(
                "dbo.ReuniaoPessoa",
                c => new
                    {
                        Reuniao_cronologiaid = c.Int(nullable: false),
                        Pessoa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reuniao_cronologiaid, t.Pessoa_Id })
                .ForeignKey("dbo.Reuniao", t => t.Reuniao_cronologiaid, cascadeDelete: true)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id, cascadeDelete: true)
                .Index(t => t.Reuniao_cronologiaid)
                .Index(t => t.Pessoa_Id);
            
            DropColumn("dbo.Pessoa", "Reuniao_cronologiaid");
            DropColumn("dbo.Reuniao", "Cargo_Lider_Treinamento_Lidertreinamentoid");
            DropColumn("dbo.Reuniao", "Cargo_Supervisor_Supervisorid");
            DropColumn("dbo.Reuniao", "Cargo_Supervisor_Treinamento_Supervisortreinamentoid");
            DropColumn("dbo.Reuniao", "Ministerio_ministerioid");
            DropColumn("dbo.Reuniao", "Cargo_Lider_Liderid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reuniao", "Cargo_Lider_Liderid", c => c.Int());
            AddColumn("dbo.Reuniao", "Ministerio_ministerioid", c => c.Int());
            AddColumn("dbo.Reuniao", "Cargo_Supervisor_Treinamento_Supervisortreinamentoid", c => c.Int());
            AddColumn("dbo.Reuniao", "Cargo_Supervisor_Supervisorid", c => c.Int());
            AddColumn("dbo.Reuniao", "Cargo_Lider_Treinamento_Lidertreinamentoid", c => c.Int());
            AddColumn("dbo.Pessoa", "Reuniao_cronologiaid", c => c.Int());
            DropForeignKey("dbo.ReuniaoPessoa", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.ReuniaoPessoa", "Reuniao_cronologiaid", "dbo.Reuniao");
            DropIndex("dbo.ReuniaoPessoa", new[] { "Pessoa_Id" });
            DropIndex("dbo.ReuniaoPessoa", new[] { "Reuniao_cronologiaid" });
            DropTable("dbo.ReuniaoPessoa");
            CreateIndex("dbo.Reuniao", "Cargo_Lider_Liderid");
            CreateIndex("dbo.Reuniao", "Ministerio_ministerioid");
            CreateIndex("dbo.Reuniao", "Cargo_Supervisor_Treinamento_Supervisortreinamentoid");
            CreateIndex("dbo.Reuniao", "Cargo_Supervisor_Supervisorid");
            CreateIndex("dbo.Reuniao", "Cargo_Lider_Treinamento_Lidertreinamentoid");
            CreateIndex("dbo.Pessoa", "Reuniao_cronologiaid");
            AddForeignKey("dbo.Reuniao", "Cargo_Lider_Liderid", "dbo.Lider", "Liderid");
            AddForeignKey("dbo.Reuniao", "Ministerio_ministerioid", "dbo.Ministerio", "ministerioid");
            AddForeignKey("dbo.Reuniao", "Cargo_Supervisor_Treinamento_Supervisortreinamentoid", "dbo.Supervisor_Treinamento", "Supervisortreinamentoid");
            AddForeignKey("dbo.Reuniao", "Cargo_Supervisor_Supervisorid", "dbo.Supervisor", "Supervisorid");
            AddForeignKey("dbo.Reuniao", "Cargo_Lider_Treinamento_Lidertreinamentoid", "dbo.Lider_treinamento", "Lidertreinamentoid");
            AddForeignKey("dbo.Pessoa", "Reuniao_cronologiaid", "dbo.Reuniao", "cronologiaid");
        }
    }
}
