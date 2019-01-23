using business.classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace web.context
{
    public class DB : DbContext
    {
        public DB() : base("conexaodb")
        {

        }
        
        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Endereco> endereco { get; set; }
        public DbSet<Telefone> telefone { get; set; }
        public DbSet<Celula> celula { get; set; }
        public DbSet<Membro_Batismo> membro_batismo { get; set; }
        public DbSet<Membro_Reconciliacao> membro_reconciliacao { get; set; }
        public DbSet<Membro_Aclamacao> membro_aclamacao { get; set; }
        public DbSet<Membro_Transferencia> membro_transferencia { get; set; }
        public DbSet<Membro> membro { get; set; }
        public DbSet<Visitante> visitante { get; set; }
        public DbSet<Crianca> crianca { get; set; }
        public DbSet<Lider> lider { get; set; }
        public DbSet<Ministerio> ministerio { get; set; }
        public DbSet<Historico> historico { get; set; }
        public DbSet<Lider_Treinamento> lider_treinamento { get; set; }
        public DbSet<Supervisor> supervisor { get; set; }
        public DbSet<Supervisor_Treinamento> supervisor_treinamento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}