using database.banco;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace business.classes
{
    [Table("Supervisor")]    
    public  class Cargo_Supervisor : modelocrud<Cargo_Supervisor>
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

        public override string alterar(int id)
        {
            update_padrao = "update  Supervisor set Maximo_celula='@maximo' where Supervisorid='@id' ";
            Update = update_padrao.Replace("@id", id.ToString());
            Update = Update.Replace("@maximo", this.maximo_celula.ToString());
            return bd.montar_sql(Update, null, null);
        }

        public override string excluir(int id)
        {
            delete_padrao = "delete from Supervisor where Supervisorid = '@id'";
            Delete = delete_padrao.Replace("@id", id.ToString());
            return bd.montar_sql(Delete, null, null);            
        }

        public override Cargo_Supervisor recuperar(int id)
        {
            return null;
        }

        public Pessoa recuperar_pessoa_supervisor(int id)
        {
            Pessoa p = this.Pessoa.recuperar(id);
            return p;
        }

        public override string salvar()
        {
           return "";
        }

        public List<Celula> preenchersupervisor( int id)
        {
            select_padrao = "select * from celula inner join supervisor_celula" +
                " on id_celula=super_celula" +
                " where cel_supervisor='@id'";
            Select = select_padrao.Replace("@id", id.ToString());

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

        public int buscarmaximo(int id)
        {
            select_padrao = "select * from supervisor" +
               " where id_supervisor='@id'";
            Select = select_padrao.Replace("@id", id.ToString());

            DataTable datatable = bd.lista(Select);

            foreach (DataRow dtrow in datatable.Rows)
            {
                Maximo_celula = int.Parse(dtrow["maximo_celula"].ToString());
            }

            return Maximo_celula;
        }

        public override IEnumerable<Cargo_Supervisor> recuperartodos()
        {
            select_padrao = "select * from Supervisor";

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Cargo_Supervisor> lista = new List<Cargo_Supervisor>();

            while (dr.Read())
            {
                Cargo_Supervisor cs = new Cargo_Supervisor();
                cs.Supervisorid = int.Parse(dr["Supervisorid"].ToString());
                cs.Maximo_celula = int.Parse(dr["Maximo_celula"].ToString());
                lista.Add(cs);
            }

            return lista;
        }
    }
}
