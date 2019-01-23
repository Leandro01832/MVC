using business.classes;
using database.banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.classes
{
    [Table("Ministerio")]    
    public class Ministerio : modelocrud<Ministerio>
    {
        
        private int id;
        private string nome;        
        private Cargo_Lider lider;
        private string proprosito;
        private List<Pessoa> pessoas;
        private int maximo_pessoa;

        [Display(Name = "Codigo")]
        [Key]
        public int ministerioid
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

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if(value != "")
                nome = value;
                else
                {
                    MessageBox.Show("informe o nome do ministério");
                    nome = null;
                }
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Proposito
        {
            get
            {
                return proprosito;
            }

            set
            {
                if(value != "")
                proprosito = value;
                else
                {
                    MessageBox.Show("Informe o proposito do ministerio.");
                    proprosito = null;
                }
            }
        }

        public virtual List<Pessoa> Pessoas { get; set;}

        [Display(Name = "Maximo de pessoas")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public int Maximo_pessoa
        {
            get
            {
                return maximo_pessoa;
            }

            set
            {
                maximo_pessoa = value;
            }
        }

        [Display(Name = "lider do ministério")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public int lider_ministerio { get; set; }

        [ForeignKey("lider_ministerio")]
        public virtual Cargo_Lider Lider
        {
            get
            {
                return lider;
            }

            set
            {
                lider = value;
            }
        }

        public Ministerio()
        {
            bd = new BDcomum();
        }

        public override string alterar()
        {
            update_padrao = "update ministerio set minis_nome='@nome',"
              + " minis_lider='@lider', minis_proposito='@proposito'"
              + " where id_ministerio=@id";

            Update = update_padrao.Replace("@nome", nome);
            
            Update = Update.Replace("@proposito", proprosito);
            Update = Update.Replace("@id", id.ToString());

            return bd.montar_sql(Update, null, null);
        }

        public override string excluir()
        {
            throw new NotImplementedException();
        }

        public override Ministerio recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public override string salvar()
        {
            Pessoas = preencherministerio(this.ministerioid);
            Maximo_pessoa = buscarmaximo();

            if (Maximo_pessoa == 0)
            {
                Maximo_pessoa = 60;
            }

            if (pessoas.Count > Maximo_pessoa) {
                MessageBox.Show("existem muitas pessoas no ministerio. Por favor converse com o lider deste ministerio.");
                return "";
            }
            else
            {
               // Lider.salvar();
                insert_padrao = "insert into ministerio (Nome,  Proposito, Maximo_pessoa, Lider_id) values " +
                " ('@nome', '@proposito', '@maximo', IDENT_CURRENT('Lider'))";

                Insert = insert_padrao.Replace("@nome", nome);               
                Insert = Insert.Replace("@proposito", proprosito);
                Insert = Insert.Replace("@maximo", Maximo_pessoa.ToString());
                return bd.montar_sql(Insert, null, null);
            }            
        }

        public List<Pessoa> preencherministerio(int ID)
        {
            select_padrao = "select * from pessoa inner join ministerio_pessoa" +
                " on pes_id=minis_pessoa inner join ministerio" +
                " on id_ministerio=pes_ministerio where id_ministerio='@id'";
            Select = select_padrao.Replace("@id", id.ToString());

            DataTable datatable = bd.lista(Select);

            List<Pessoa> lista = new List<Pessoa>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                var pessoa = new business.classes.Pessoa();
                pessoa.Nome = dtrow["pes_nome"].ToString();
                pessoa.Id = int.Parse(dtrow["pes_id"].ToString());
                lista.Add(pessoa);
            }

            return lista;
        }

        public int buscarmaximo()
        {
            select_padrao = "select * from ministerio" +               
               " where id_ministerio='@id'";
            Select = select_padrao.Replace("@id", id.ToString());

            DataTable datatable = bd.lista(Select);


            foreach (DataRow dtrow in datatable.Rows)
            {
                Maximo_pessoa = int.Parse(dtrow["max_pessoa"].ToString());
            }

            return Maximo_pessoa;
        }

        public override IEnumerable<Ministerio> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }
}
