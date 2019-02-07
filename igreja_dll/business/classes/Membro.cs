using database.banco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.classes
{
    [Table("Membro")]    
    public class Membro : Pessoa
    {        
        
        private int data_batismo;
        private bool desligamento;

        [Display(Name = "Ano de batismo")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public int Data_batismo
        {
            get
            {
                return data_batismo;
            }

            set
            {
                data_batismo = value;
            }
        }

        public bool Desligamento
        {
            get
            {
                return desligamento;
            }

            set
            {
                desligamento = value;
            }
        }

        public string Motivo_desligamento { get; set; }
        

        // public int id_pessoa { get; set; }

        //[ForeignKey("id_pessoa")]
        //public virtual Pessoa pessoa { get; set; }

        public Membro()
        {
            bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar membro atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Membro(int id)
        {
            bd = new BDcomum();
            this.Nome = recuperar_membro(id).Nome;
            this.Endereco = recuperar_membro(id).Endereco;
            this.Telefone = recuperar_membro(id).Telefone;
        }

        public override string alterar(int id)
        {
             base.alterar(id);

            update_padrao = "update Membro set Desligamento = '@desligamento', Data_batismo = '@ano_batismo' " +
                    " from Membro as M inner join Pessoa as P on P.Pessoa_id=id_pessoa where P.Pessoa_id='@id' ";
            Update = update_padrao.Replace("@id", id.ToString());
            Update = Update.Replace("@desligamento", desligamento.ToString());
            Update = Update.Replace("@ano_batismo", data_batismo.ToString());

            return bd.montar_sql(Update, null, null);
        }

        public override string excluir(int id)
        {
            return base.excluir(id);
        }

        public override Pessoa recuperar(int id)
        {
            return base.recuperar(id);
        }

        public  Membro recuperar_membro(int id)
        {
           Pessoa p = recuperar(id);
            select_padrao = " select * from Pessoa as P inner join Endereco as E on P.Id=E.EnderecoId inner join Telefone as T on P.Id=T.telefoneid "
            + " inner join Membro as M on P.Id=M.Id "
            + " where P.Id='" + id + "'";

            SqlCommand comando = new SqlCommand(select_padrao, bd.obterconexao());

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
                    this.Id = p.Id;
                    this.Nome = p.Nome;
                    this.Falescimento = p.Falescimento;
                    this.Falta = p.Falta;
                    this.Cpf = p.Cpf;
                    this.Rg = p.Rg;
                    this.Sexo_feminino = p.Sexo_feminino;
                    this.Sexo_masculino = p.Sexo_masculino;
                    this.Status = p.Status;
                    this.Img = p.Img;
                    this.imgtipo = p.imgtipo;
                    this.Ministerios = p.Ministerios;
                    this.Cargo_Lider = p.Cargo_Lider;
                    this.Cargo_Lider_Treinamento = p.Cargo_Lider_Treinamento;
                    this.Cargo_Supervisor = p.Cargo_Supervisor;
                    this.Cargo_Supervisor_Treinamento = p.Cargo_Supervisor_Treinamento;
                    this.classe = p.classe;                    
                    this.Endereco = p.Endereco;
                    this.Telefone = p.Telefone;
                    this.Historico = p.Historico;
                    this.celula_ = p.celula_;
                    this.Celula = p.Celula;
                    this.Chamada = p.Chamada;
                    this.Reuniao = p.Reuniao;
                    this.Img = p.Img;
                    this.Desligamento = Convert.ToBoolean(Convert.ToString(dr["Desligamento"]));
                    this.Data_batismo = int.Parse(Convert.ToString(dr["Data_batismo"]));

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
             base.salvar();

            insert_padrao = "insert into Membro (Desligamento, Data_batismo, Id) values('@desligamento', '@ano_batismo', IDENT_CURRENT('Pessoa'))";
               

            Insert = insert_padrao.Replace("@desligamento", false.ToString() );
            Insert = Insert.Replace("@ano_batismo", Data_batismo.ToString());

            return bd.montar_sql(Insert, null, null);
        }

        public override IEnumerable<Pessoa> recuperartodos()
        {
             base.recuperartodos();

            select_padrao = "select * from pessoa inner join endereco on pes_id=end_pessoa " +
     " inner join telefone on pes_id=tel_pessoa @innerjoin";

            
            Select = select_padrao.Replace("@innerjoin", " inner join membro on pes_id=memb_pessoa ");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Membro> membro = new List<Membro>();

            if (dr.HasRows == false)
            {
                return null;
            }
            else
            {
                try
                {
                    while (dr.Read())
                    {
                        this.Desligamento = Convert.ToBoolean(Convert.ToString(dr["Desligamento"]));
                        this.Data_batismo = int.Parse(Convert.ToString(dr["Data_batismo"]));
                        membro.Add(this);
                    }

                   

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

                return membro;
            }
        }
    }
}
