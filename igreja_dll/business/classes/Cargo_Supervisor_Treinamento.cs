using database.banco;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace business.classes
{
    [Table("Supervisor_Treinamento")]    
    public class Cargo_Supervisor_Treinamento : modelocrud<Cargo_Supervisor_Treinamento>
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
        public int Supervisortreinamentoid { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Cargo_Supervisor_Treinamento()
        {
          //  bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar supervisor por treinamento atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Cargo_Supervisor_Treinamento(int id)
        {
           // bd = new BDcomum();
           // recuperar(id);
        }

        public override string alterar(int id)
        {
            update_padrao = "update  Supervisor_Treinamento set Maximo_celula='@maximo' where Supervisortreinamentoid='@id' ";
            Update = update_padrao.Replace("@id", id.ToString());
            Update = Update.Replace("@maximo", this.Maximo_celula.ToString());
            return bd.montar_sql(Update, null, null);
        }

        public override string excluir(int id)
        {
            delete_padrao = "delete from Supervisor_Treinamento where Supervisortreinamentoid = '@id'";
            Delete = delete_padrao.Replace("@id", id.ToString());
            return bd.montar_sql(Delete, null, null);
        }

        public override Cargo_Supervisor_Treinamento recuperar(int id)
        {
            return null;
        }

        public Pessoa recuperar_pessoa_supervisor_treinamento(int id)
        {
            Pessoa p = this.Pessoa.recuperar(id);
            return p;
        }

        public override string salvar()
        {
            celulas = preenchersupervisor_treinamento();
            Maximo_celula = buscarmaximo();

            if (Maximo_celula == 0)
            {
                Maximo_celula = 50;
            }

            if (celulas.Count > Maximo_celula)
            {
                MessageBox.Show("você já tem duas celulas para supervisão. Por favor converse com a autoridade para modificar as configurações de supervisionamento.");
                return "";
            }
            else
            {
                
                insert_padrao = "insert into supervisor_treinamento " +
               " (id_pessoa, Maximo_celula) values (IDENT_CURRENT('Pessoa'), '@maximo')";
                Insert = insert_padrao.Replace("@maximo", Maximo_celula.ToString());
                return bd.montar_sql(Insert, null, null);
            }

        }

        public List<Celula> preenchersupervisor_treinamento()
        {
            select_padrao = "select * from celula inner join supervisor_treinamento_celula" +
                " on id_celula=sup_trei_celula" +
                " where cel_supervisor_treinamento='@id'";
            Select = select_padrao.Replace("@id", this.Supervisortreinamentoid.ToString());

            DataTable datatable = bd.lista(Select);

            List<Celula> lista = new List<Celula>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                var pessoa = new Celula();
                pessoa.Cel_nome = dtrow["cel_nome"].ToString();
                int i = int.Parse(dtrow["id_celula"].ToString());
                lista.Add(pessoa);
            }

            return lista;
        }

        public int buscarmaximo()
        {
            select_padrao = "select * from supervisor_treinamento" +
               " where id_sup_treinamento='@id'";
            Select = select_padrao.Replace("@id", this.Supervisortreinamentoid.ToString());

            DataTable datatable = bd.lista(Select);

            foreach (DataRow dtrow in datatable.Rows)
            {
                Maximo_celula = int.Parse(dtrow["max_celula"].ToString());
            }

            return Maximo_celula;
        }

        public override IEnumerable<Cargo_Supervisor_Treinamento> recuperartodos()
        {
            select_padrao = "select * from Supervisor";

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Cargo_Supervisor_Treinamento> lista = new List<Cargo_Supervisor_Treinamento>();

            while (dr.Read())
            {
                Cargo_Supervisor_Treinamento cs = new Cargo_Supervisor_Treinamento();
                cs.Supervisortreinamentoid = int.Parse(dr["Supervisorid"].ToString());
                cs.Maximo_celula = int.Parse(dr["Maximo_celula"].ToString());
                lista.Add(cs);
            }

            return lista;
        }

    }
}
