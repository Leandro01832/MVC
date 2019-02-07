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
using System.Windows.Forms;

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

        public override string alterar(int id)
        {
            update_padrao = "update chamada set Data_inicio='@data',"
               + "Numero_chamada='@numero' where chamadaid='@id'";
            Update = update_padrao.Replace("", Data_inicio.ToString());
            Update = Update.Replace("@numero", Numero_chamada.ToString());
            Update = Update.Replace("@id", id.ToString());
            return bd.montar_sql(Update, null, null);
        }

        public override string excluir(int id)
        {
            delete_padrao = "delete from Chamada where chamadaid='@id' ";
            Delete = delete_padrao.Replace("@id", id.ToString());
            return bd.montar_sql(Delete, null, null);
        }

        public override Chamada recuperar(int id)
        {
            DateTime data = DateTime.Now.AddDays(-60);
            select_padrao = "select * from Chamada where chamadaid='@id'";
            Select = select_padrao.Replace("@id", data.ToString());
            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            if (dr.HasRows == false)
            {
                return null;
            }
            else
            {
                try
                {
                    dr.Read();
                    this.chamadaid = int.Parse(dr["chamadaid"].ToString());
                    this.Data_inicio = Convert.ToDateTime(dr["Data_inicio"].ToString());
                    this.Numero_chamada = int.Parse(dr["Numero_chamada"].ToString());
                    this.Pessoa = this.Pessoa.recuperar(this.chamadaid);
                    dr.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    bd.obterconexao().Close();
                }

                return this;
            }
        }

        public override string salvar()
        {
            
            insert_padrao = "insert into Chamada"
            + " (Data_inicio, Numero_chamada, chamadaid) values"
            + " ('@data', '@numero', IDENT_CURRENT('Pessoa'))";
            Insert = insert_padrao.Replace("@data", DateTime.Now.ToString());
            Insert = Insert.Replace("@numero", Numero_chamada.ToString());
            return Insert;
        }       

        public override IEnumerable<Chamada> recuperartodos()
        {
            select_padrao = "select * from Celula";

            SqlCommand comando = new SqlCommand(select_padrao, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Chamada> lista = new List<Chamada>();

            while (dr.Read())
            {
                Chamada cl = new Chamada();
                cl.chamadaid = int.Parse(dr["chamadaid"].ToString());
                cl.Data_inicio = Convert.ToDateTime(dr["Data_inicio"].ToString());
                cl.Numero_chamada = int.Parse(dr["Numero_chamada"].ToString());
                cl.Pessoa = cl.Pessoa.recuperar(cl.chamadaid);
                lista.Add(cl);
            }

            return lista;
        }
    }
}
