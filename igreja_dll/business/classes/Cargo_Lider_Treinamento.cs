using database.banco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.classes
{

    [Table("Lider_treinamento")]    
    public class Cargo_Lider_Treinamento : modelocrud<Cargo_Lider_Treinamento>
    {
        [Key, ForeignKey("Pessoa")]
        public int Lidertreinamentoid { get; set; }

        public virtual Pessoa Pessoa { get; set; }        

        public Cargo_Lider_Treinamento()
        {
           // bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar lider por treinamento atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Cargo_Lider_Treinamento(int id)
        {
           // bd = new BDcomum();
           // recuperar(id);
        }

        public override string salvar()
        {
            return "";
        }

        public override Cargo_Lider_Treinamento recuperar(int id)
        {
            return null;
        }

        public Pessoa recuperar_pessoa_lider_treinamento(int id)
        {
            Pessoa p = this.Pessoa.recuperar(id);
            return p;
        }

        public override string excluir(int id)
        {
            delete_padrao = "delete from Lider_treinamento where Lidertreinamentoid = '@id'";
            Delete = delete_padrao.Replace("@id", id.ToString());
            return bd.montar_sql(Delete, null, null);
        }

        public override string alterar(int id)
        {
            update_padrao = "update  Lider_treinamento set Lidertreinamentoid='@id'";
            Update = update_padrao.Replace("@id", id.ToString());
            return bd.montar_sql(Update, null, null);
        }

        public override IEnumerable<Cargo_Lider_Treinamento> recuperartodos()
        {
            select_padrao = "select * from Lider";

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Cargo_Lider_Treinamento> lista = new List<Cargo_Lider_Treinamento>();

            while (dr.Read())
            {
                Cargo_Lider_Treinamento cl = new Cargo_Lider_Treinamento();
                cl.Lidertreinamentoid = int.Parse(dr["Lidertreinamentoid"].ToString());
                lista.Add(cl);
            }

            return lista;
        }
    }
}
