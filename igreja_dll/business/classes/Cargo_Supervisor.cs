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
    [Table("Supervisor")]    
    public  class Cargo_Supervisor
    {
        
        
        private List<Celula> celulas;
        private int maximo_celula;       

        public virtual List<Celula> Celulas
        {
            get
            {
                return celulas;
            }

            set
            {
                celulas = value;
            }
        }

        [Display(Name = "Máximo de celulas para supervisioar")]
        public int Maximo_celula
        {
            get
            {
                return maximo_celula;
            }

            set
            {
                maximo_celula = value;
            }
        }

        [Key, ForeignKey("Pessoa")]
        public int Supervisorid { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public Cargo_Supervisor()
        {
           // bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar supervisor atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Cargo_Supervisor(int id)
        {
           // bd = new BDcomum();
           // recuperar(id);
        }

        //public override string alterar()
        //{
        //    return base.alterar();
        //}

        //public override string excluir()
        //{
        //    return base.excluir();
        //}

        //public override bool recuperar(int id)
        //{
        //    return base.recuperar(id);
        //}

        //public override string salvar()
        //{
        //    celulas = preenchersupervisor();
        //    Maximo_celula = buscarmaximo();

        //    if (Maximo_celula == 0)
        //    {
        //        Maximo_celula = 50;
        //    }

        //    if (celulas.Count > Maximo_celula)
        //    {
        //        MessageBox.Show("você já tem duas celulas para supervisão. Por favor converse com a autoridade para modificar as configurações de supervisionamento.");
        //        return "";
        //    }
        //    else
        //    {
        //        base.salvar();
        //        insert_padrao = "insert into supervisor " +
        //       " (id_pessoa, Maximo_celula) values (IDENT_CURRENT('Pessoa'), '@maximo')";                
        //        Insert = insert_padrao.Replace("@maximo", Maximo_celula.ToString());
        //        return bd.montar_sql(Insert, null, null);
        //    }
           
        //}

        //public List<Celula> preenchersupervisor()
        //{
        //    select_padrao = "select * from celula inner join supervisor_celula" +
        //        " on id_celula=super_celula" +
        //        " where cel_supervisor='@id'";
        //    Select = select_padrao.Replace("@id", this.Id.ToString());

        //    DataTable datatable = bd.lista(Select);

        //    List<Celula> lista = new List<Celula>();
        //    foreach (DataRow dtrow in datatable.Rows)
        //    {
        //        var pessoa = new Celula();
        //        pessoa.Cel_nome = dtrow["cel_nome"].ToString();
        //        int i = int.Parse(dtrow["id_celula"].ToString());
        //        lista.Add(pessoa);
        //    }

        //    return lista;
        //}

        //public int buscarmaximo()
        //{
        //    select_padrao = "select * from supervisor" +
        //       " where id_supervisor='@id'";
        //    Select = select_padrao.Replace("@id", this.Id.ToString());

        //    DataTable datatable = bd.lista(Select);

        //    foreach (DataRow dtrow in datatable.Rows)
        //    {
        //        Maximo_celula = int.Parse(dtrow["maximo_celula"].ToString());
        //    }

        //    return Maximo_celula;
        //}

        //public override IEnumerable<Pessoa> recuperartodos()
        //{
        //    return base.recuperartodos();
        //}
    }
}
