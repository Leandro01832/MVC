namespace repositorioEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class igreja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Celula",
                c => new
                    {
                        Celulaid = c.Int(nullable: false, identity: true),
                        Cel_nome = c.String(nullable: false),
                        Dia_semana = c.String(nullable: false),
                        Horario = c.Time(nullable: false, precision: 7),
                        Maximo_pessoa = c.Int(nullable: false),
                        Lider_ = c.Int(nullable: false),
                        Lidertreinamento_ = c.Int(nullable: false),
                        Supervisor_ = c.Int(nullable: false),
                        Supervisortreinamento_ = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Celulaid)
                .ForeignKey("dbo.Supervisor", t => t.Supervisor_, cascadeDelete: true)
                .ForeignKey("dbo.Supervisor_Treinamento", t => t.Supervisortreinamento_, cascadeDelete: true)
                .ForeignKey("dbo.Lider", t => t.Lider_, cascadeDelete: true)
                .ForeignKey("dbo.Lider_treinamento", t => t.Lidertreinamento_, cascadeDelete: true)
                .Index(t => t.Lider_)
                .Index(t => t.Lidertreinamento_)
                .Index(t => t.Supervisor_)
                .Index(t => t.Supervisortreinamento_);
            
            CreateTable(
                "dbo.Endereco_celula",
                c => new
                    {
                        enderecoid = c.Int(nullable: false),
                        Cel_bairro = c.String(nullable: false),
                        Cel_rua = c.String(nullable: false),
                        Cel_numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.enderecoid)
                .ForeignKey("dbo.Celula", t => t.enderecoid)
                .Index(t => t.enderecoid);
            
            CreateTable(
                "dbo.Lider",
                c => new
                    {
                        Liderid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Liderid)
                .ForeignKey("dbo.Pessoa", t => t.Liderid)
                .Index(t => t.Liderid);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Data_nascimento = c.DateTime(nullable: false),
                        Rg = c.String(nullable: false),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Estado_civil = c.String(nullable: false),
                        Sexo_masculino = c.Boolean(nullable: false),
                        Sexo_feminino = c.Boolean(nullable: false),
                        Falescimento = c.Boolean(nullable: false),
                        Status = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Falta = c.Int(nullable: false),
                        celula_ = c.Int(),
                        Img = c.Binary(),
                        imgtipo = c.String(),
                        classe = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Celula", t => t.celula_)
                .Index(t => t.Cpf, unique: true, name: "CPF")
                .Index(t => t.celula_);
            
            CreateTable(
                "dbo.Lider_treinamento",
                c => new
                    {
                        Lidertreinamentoid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Lidertreinamentoid)
                .ForeignKey("dbo.Pessoa", t => t.Lidertreinamentoid)
                .Index(t => t.Lidertreinamentoid);
            
            CreateTable(
                "dbo.Supervisor",
                c => new
                    {
                        Supervisorid = c.Int(nullable: false),
                        Maximo_celula = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Supervisorid)
                .ForeignKey("dbo.Pessoa", t => t.Supervisorid)
                .Index(t => t.Supervisorid);
            
            CreateTable(
                "dbo.Supervisor_Treinamento",
                c => new
                    {
                        Supervisortreinamentoid = c.Int(nullable: false),
                        Maximo_celula = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Supervisortreinamentoid)
                .ForeignKey("dbo.Pessoa", t => t.Supervisortreinamentoid)
                .Index(t => t.Supervisortreinamentoid);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false),
                        Pais = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                        Cidade = c.String(nullable: false),
                        Bairro = c.String(nullable: false),
                        Rua = c.String(nullable: false),
                        Numero_casa = c.Int(nullable: false),
                        Cep = c.Long(nullable: false),
                        Complemento = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EnderecoId)
                .ForeignKey("dbo.Pessoa", t => t.EnderecoId)
                .Index(t => t.EnderecoId);
            
            CreateTable(
                "dbo.Historico",
                c => new
                    {
                        historicoid = c.Int(nullable: false, identity: true),
                        Data_inicio = c.DateTime(nullable: false),
                        Falta = c.Int(nullable: false),
                        Data_fim = c.DateTime(nullable: false),
                        Pessoa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.historicoid)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Ministerio",
                c => new
                    {
                        ministerioid = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Proposito = c.String(nullable: false),
                        Maximo_pessoa = c.Int(nullable: false),
                        lider_ministerio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ministerioid)
                .ForeignKey("dbo.Lider", t => t.lider_ministerio, cascadeDelete: true)
                .Index(t => t.lider_ministerio);
            
            CreateTable(
                "dbo.Telefone",
                c => new
                    {
                        telefoneid = c.Int(nullable: false),
                        Fone = c.String(),
                        Celular = c.String(),
                        Whatsapp = c.String(),
                    })
                .PrimaryKey(t => t.telefoneid)
                .ForeignKey("dbo.Pessoa", t => t.telefoneid)
                .Index(t => t.telefoneid);
            
            CreateTable(
                "dbo.Chamada",
                c => new
                    {
                        chamadaid = c.Int(nullable: false, identity: true),
                        Data_inicio = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.chamadaid);
            
            CreateTable(
                "dbo.MinisterioPessoa",
                c => new
                    {
                        Ministerio_ministerioid = c.Int(nullable: false),
                        Pessoa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ministerio_ministerioid, t.Pessoa_Id })
                .ForeignKey("dbo.Ministerio", t => t.Ministerio_ministerioid, cascadeDelete: true)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id, cascadeDelete: true)
                .Index(t => t.Ministerio_ministerioid)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Crianca",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome_pai = c.String(nullable: false),
                        Nome_mae = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Membro",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Data_batismo = c.Int(nullable: false),
                        Desligamento = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Membro_aclamacao",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Denominacao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Membro", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Membro_batismo",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Membro", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Membro_Reconciliacao",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Data_reconciliacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Membro", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Membro_transferencia",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome_cidade_transferencia = c.String(nullable: false),
                        Estado_transferencia = c.String(nullable: false),
                        Nome_igreja_transferencia = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Membro", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Visitante",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Data_visita = c.DateTime(nullable: false),
                        Condicao_religiosa = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitante", "Id", "dbo.Pessoa");
            DropForeignKey("dbo.Membro_transferencia", "Id", "dbo.Membro");
            DropForeignKey("dbo.Membro_Reconciliacao", "Id", "dbo.Membro");
            DropForeignKey("dbo.Membro_batismo", "Id", "dbo.Membro");
            DropForeignKey("dbo.Membro_aclamacao", "Id", "dbo.Membro");
            DropForeignKey("dbo.Membro", "Id", "dbo.Pessoa");
            DropForeignKey("dbo.Crianca", "Id", "dbo.Pessoa");
            DropForeignKey("dbo.Celula", "Lidertreinamento_", "dbo.Lider_treinamento");
            DropForeignKey("dbo.Celula", "Lider_", "dbo.Lider");
            DropForeignKey("dbo.Lider", "Liderid", "dbo.Pessoa");
            DropForeignKey("dbo.Telefone", "telefoneid", "dbo.Pessoa");
            DropForeignKey("dbo.MinisterioPessoa", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.MinisterioPessoa", "Ministerio_ministerioid", "dbo.Ministerio");
            DropForeignKey("dbo.Ministerio", "lider_ministerio", "dbo.Lider");
            DropForeignKey("dbo.Historico", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "EnderecoId", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "celula_", "dbo.Celula");
            DropForeignKey("dbo.Supervisor_Treinamento", "Supervisortreinamentoid", "dbo.Pessoa");
            DropForeignKey("dbo.Celula", "Supervisortreinamento_", "dbo.Supervisor_Treinamento");
            DropForeignKey("dbo.Supervisor", "Supervisorid", "dbo.Pessoa");
            DropForeignKey("dbo.Celula", "Supervisor_", "dbo.Supervisor");
            DropForeignKey("dbo.Lider_treinamento", "Lidertreinamentoid", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco_celula", "enderecoid", "dbo.Celula");
            DropIndex("dbo.Visitante", new[] { "Id" });
            DropIndex("dbo.Membro_transferencia", new[] { "Id" });
            DropIndex("dbo.Membro_Reconciliacao", new[] { "Id" });
            DropIndex("dbo.Membro_batismo", new[] { "Id" });
            DropIndex("dbo.Membro_aclamacao", new[] { "Id" });
            DropIndex("dbo.Membro", new[] { "Id" });
            DropIndex("dbo.Crianca", new[] { "Id" });
            DropIndex("dbo.MinisterioPessoa", new[] { "Pessoa_Id" });
            DropIndex("dbo.MinisterioPessoa", new[] { "Ministerio_ministerioid" });
            DropIndex("dbo.Telefone", new[] { "telefoneid" });
            DropIndex("dbo.Ministerio", new[] { "lider_ministerio" });
            DropIndex("dbo.Historico", new[] { "Pessoa_Id" });
            DropIndex("dbo.Endereco", new[] { "EnderecoId" });
            DropIndex("dbo.Supervisor_Treinamento", new[] { "Supervisortreinamentoid" });
            DropIndex("dbo.Supervisor", new[] { "Supervisorid" });
            DropIndex("dbo.Lider_treinamento", new[] { "Lidertreinamentoid" });
            DropIndex("dbo.Pessoa", new[] { "celula_" });
            DropIndex("dbo.Pessoa", "CPF");
            DropIndex("dbo.Lider", new[] { "Liderid" });
            DropIndex("dbo.Endereco_celula", new[] { "enderecoid" });
            DropIndex("dbo.Celula", new[] { "Supervisortreinamento_" });
            DropIndex("dbo.Celula", new[] { "Supervisor_" });
            DropIndex("dbo.Celula", new[] { "Lidertreinamento_" });
            DropIndex("dbo.Celula", new[] { "Lider_" });
            DropTable("dbo.Visitante");
            DropTable("dbo.Membro_transferencia");
            DropTable("dbo.Membro_Reconciliacao");
            DropTable("dbo.Membro_batismo");
            DropTable("dbo.Membro_aclamacao");
            DropTable("dbo.Membro");
            DropTable("dbo.Crianca");
            DropTable("dbo.MinisterioPessoa");
            DropTable("dbo.Chamada");
            DropTable("dbo.Telefone");
            DropTable("dbo.Ministerio");
            DropTable("dbo.Historico");
            DropTable("dbo.Endereco");
            DropTable("dbo.Supervisor_Treinamento");
            DropTable("dbo.Supervisor");
            DropTable("dbo.Lider_treinamento");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Lider");
            DropTable("dbo.Endereco_celula");
            DropTable("dbo.Celula");
        }
    }
}
