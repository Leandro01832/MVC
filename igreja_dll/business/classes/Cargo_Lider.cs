using database.banco;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace business.classes
{

    [Table("Lider")]    
    public class Cargo_Lider : modelocrud<Cargo_Lider>
    {
        [Key, ForeignKey("Pessoa")]
        public int Liderid { get; set; }

        public virtual Pessoa Pessoa { get; set; }        

        public Cargo_Lider()
        {
           // bd = new BDcomum();
        }
        
        /// <summary>
        /// contrutor para buscar lider atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Cargo_Lider(int id)
        {
           // bd = new BDcomum();
           // recuperar(id);
        }

        public override string salvar()
        {
            return "";
        }

        public override Cargo_Lider recuperar(int id)
        {
          return null;            
        }

        public Pessoa recuperar_pessoa_lider(int id)
        {           
          Pessoa p = this.Pessoa.recuperar(id);
          return p;            
        }

        public override string excluir(int id)
        {
            delete_padrao = "delete from Lider where Liderid = '@id'";
            Delete = delete_padrao.Replace("@id", id.ToString());
            return bd.montar_sql(Delete, null, null);
        }

        public override string alterar(int id)
        {
            update_padrao = "update  Lider set Liderid='@id'";
            Update = update_padrao.Replace("@id", id.ToString());           
            return bd.montar_sql(Update, null, null);
        }

        public override IEnumerable<Cargo_Lider> recuperartodos()
        {
            select_padrao = "select * from Lider";

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Cargo_Lider> lista = new List<Cargo_Lider>();

            while (dr.Read())
            {
                Cargo_Lider cl = new Cargo_Lider();
                cl.Liderid = int.Parse(dr["Liderid"].ToString());
                lista.Add(cl);
            }                

            return lista;
        }
    }
}
