using database.banco;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace business.classes
{
    [Table("Chamada")]
    public  class Chamada : modelocrud<Chamada>
    {
        
        private int id;
        private DateTime data_inicio;

        [Display(Name = "Data de inicio")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public  DateTime Data_inicio
        {
            get;

            set;
        }

        [Display(Name = "Numero da chamada")]
        public int Numero_chamada { get; set; }
        
        [Display(Name = "Código")]
        [Key, ForeignKey("Pessoa")]
        public int chamadaid
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public virtual Pessoa Pessoa { get; set; }

        public Chamada()
        {
            bd = new BDcomum();
        }

        public override string alterar()
        {
            throw new NotImplementedException();
        }

        public override string excluir()
        {
            throw new NotImplementedException();
        }

        public override Chamada recuperar(int id)
        {
            DateTime data = DateTime.Now.AddDays(-60);
            select_padrao = "select * from pessoa inner join chamada on pes_id=hist_pessoa where Pessoa_id='@id'";
            Select = select_padrao.Replace("@id", data.ToString());

            return this;
        }

        public override string salvar()
        {
            throw new NotImplementedException();
        }       

        public override IEnumerable<Chamada> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }
}
