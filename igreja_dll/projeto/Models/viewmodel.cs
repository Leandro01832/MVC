using business.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto.Models
{
    public class viewmodel
    {
        public Ministerio ministerio { get; set; }
        public Reuniao reuniao { get; set; }
        public Pessoa pessoa { get; set; }
        public Endereco endereco { get; set; }
        public Telefone telefone { get; set; }
        public Cargo_Lider lider { get; set; }
        public List<Cargo_Lider> lista_lider { get; set; }
        public Cargo_Lider_Treinamento lider_treinamento { get; set; }
        public List<Cargo_Lider_Treinamento> lista_lider_treianmento { get; set; }
        public Crianca crianca { get; set; }
        public Membro_Aclamacao membro_aclamacao { get; set; }
        public Membro_Batismo membro_batismo { get; set; }
        public Membro_Transferencia membro_transferencia { get; set; }
        public Membro_Reconciliacao membro_reconciliacao { get; set; }
        public Cargo_Supervisor supervisor { get; set; }
        public List<Cargo_Supervisor> lista_supervisor { get; set; }
        public Cargo_Supervisor_Treinamento supervisor_treinamento { get; set; }
        public List<Cargo_Supervisor_Treinamento> lista_supervisor_treinamento { get; set; }
        public Visitante visitante { get; set; }
        public Celula celula { get; set; }
        public Endereco_Celula endereco_celula { get; set; }
        
    }
}