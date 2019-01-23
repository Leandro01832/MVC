namespace repositorioEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reuniao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reuniao",
                c => new
                    {
                        cronologiaid = c.Int(nullable: false, identity: true),
                        Data_reuniao = c.DateTime(nullable: false),
                        Horario_inicio = c.DateTime(nullable: false),
                        Horario_fim = c.DateTime(nullable: false),
                        Local_reuniao = c.String(nullable: false),
                        Cargo_Lider_Treinamento_Lidertreinamentoid = c.Int(),
                        Cargo_Supervisor_Supervisorid = c.Int(),
                        Cargo_Supervisor_Treinamento_Supervisortreinamentoid = c.Int(),
                        Cargo_Lider_Liderid = c.Int(),
                    })
                .PrimaryKey(t => t.cronologiaid)
                .ForeignKey("dbo.Lider_treinamento", t => t.Cargo_Lider_Treinamento_Lidertreinamentoid)
                .ForeignKey("dbo.Supervisor", t => t.Cargo_Supervisor_Supervisorid)
                .ForeignKey("dbo.Supervisor_Treinamento", t => t.Cargo_Supervisor_Treinamento_Supervisortreinamentoid)
                .ForeignKey("dbo.Lider", t => t.Cargo_Lider_Liderid)
                .Index(t => t.Cargo_Lider_Treinamento_Lidertreinamentoid)
                .Index(t => t.Cargo_Supervisor_Supervisorid)
                .Index(t => t.Cargo_Supervisor_Treinamento_Supervisortreinamentoid)
                .Index(t => t.Cargo_Lider_Liderid);
            
            AddColumn("dbo.Pessoa", "Reuniao_cronologiaid", c => c.Int());
            CreateIndex("dbo.Pessoa", "Reuniao_cronologiaid");
            AddForeignKey("dbo.Pessoa", "Reuniao_cronologiaid", "dbo.Reuniao", "cronologiaid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reuniao", "Cargo_Lider_Liderid", "dbo.Lider");
            DropForeignKey("dbo.Reuniao", "Cargo_Supervisor_Treinamento_Supervisortreinamentoid", "dbo.Supervisor_Treinamento");
            DropForeignKey("dbo.Reuniao", "Cargo_Supervisor_Supervisorid", "dbo.Supervisor");
            DropForeignKey("dbo.Reuniao", "Cargo_Lider_Treinamento_Lidertreinamentoid", "dbo.Lider_treinamento");
            DropForeignKey("dbo.Pessoa", "Reuniao_cronologiaid", "dbo.Reuniao");
            DropIndex("dbo.Reuniao", new[] { "Cargo_Lider_Liderid" });
            DropIndex("dbo.Reuniao", new[] { "Cargo_Supervisor_Treinamento_Supervisortreinamentoid" });
            DropIndex("dbo.Reuniao", new[] { "Cargo_Supervisor_Supervisorid" });
            DropIndex("dbo.Reuniao", new[] { "Cargo_Lider_Treinamento_Lidertreinamentoid" });
            DropIndex("dbo.Pessoa", new[] { "Reuniao_cronologiaid" });
            DropColumn("dbo.Pessoa", "Reuniao_cronologiaid");
            DropTable("dbo.Reuniao");
        }
    }
}
