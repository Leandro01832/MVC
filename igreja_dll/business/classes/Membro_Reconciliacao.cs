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
    [Table("Membro_Reconciliacao")]
    public class Membro_Reconciliacao : Membro
    {        
        private int data_reconciliacao;

        [Display(Name = "Ano da reconciliação")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public int Data_reconciliacao
        {
            get
            {
                return data_reconciliacao;
            }

            set
            {
                if(value != 0)
                data_reconciliacao = value;
                else
                {
                    MessageBox.Show("O ano de reconciliação deve ser preenchido corretamente");
                    data_reconciliacao = 0;
                }
            }
        }       

      //  public int id_membro { get; set; }

        //[ForeignKey("id_membro")]
        //public virtual Membro membro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sexo_masculino"></param>
        /// <param name="sexo_feminino"></param>
        /// <param name="data_nascimento"></param>
        /// <param name="rg"></param>
        /// <param name="falescimento"></param>
        /// <param name="email"></param>
        /// <param name="cpf"></param>
        /// <param name="falta"></param>
        /// <param name="pais"></param>
        /// <param name="cidade"></param>
        /// <param name="bairro"></param>
        /// <param name="rua"></param>
        /// <param name="estado"></param>
        /// <param name="numero_casa"></param>
        /// <param name="cep"></param>
        /// <param name="complemento"></param>
        /// <param name="estado_civil"></param>
        /// <param name="status"></param>
        /// <param name="telefone"></param>
        /// <param name="celular"></param>
        /// <param name="whatsapp"></param>
        /// <param name="ano_batismo"></param>
        /// <param name="imagem_location"></param>
        /// <param name="data_reconciliacao"></param>

        public Membro_Reconciliacao(string nome, bool sexo_masculino, bool sexo_feminino,
            string data_nascimento, string rg, bool falescimento, string email, string cpf,
            int falta, string pais, string cidade, string bairro, string rua, string estado,
            int numero_casa, int cep, string complemento, string estado_civil, string status,
            string telefone, string celular, string whatsapp, int ano_batismo,
            string imagem_location, int data_reconciliacao)
        {
            bd = new BDcomum();

            this.Nome = nome;
            this.Sexo_masculino = sexo_masculino;
            this.Sexo_feminino = sexo_feminino;
            this.Data_nascimento = Convert.ToDateTime(data_nascimento);
            this.Rg = rg;
            this.Falescimento = false;
            this.Email = email;
            this.Cpf = cpf;
            this.Falta = falta;
            this.Endereco.Pais = pais;
            this.Endereco.Cidade = cidade;
            this.Endereco.Bairro = bairro;
            this.Endereco.Rua = rua;
            this.Endereco.Estado = estado;
            this.Endereco.Numero_casa = numero_casa;
            this.Endereco.Cep = cep;
            this.Endereco.Complemento = complemento;
            this.Estado_civil = estado_civil;
            this.Status = status;
            this.Telefone.Fone = telefone;
            this.Telefone.Celular = celular;
            this.Telefone.Whatsapp = whatsapp;
            this.Data_reconciliacao = data_reconciliacao;
            this.Data_batismo = ano_batismo;
            
        }      


        /// <summary>
        /// Construtor sem paramentros
        /// </summary>

        public Membro_Reconciliacao()
        {
            bd = new BDcomum();
        }


        /// <summary>
        /// contrutor para buscar membro por reconciliacao atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Membro_Reconciliacao(int id)
        {
            bd = new BDcomum();
            recuperar(id);
        }

        public override string alterar(int id)
        {
             base.alterar(id);
            update_padrao = "update membro_reconciliacao set reco_data = '@data'" +
            " from membro_reconciliacao as MR inner join membro as M on M.id_membro=MR.reco_membro inner join pessoa as P on P.pes_id=M.memb_pessoa where pes_nome = '@nome'";
            Update = update_padrao.Replace("@nome", this.Nome);
            Update = Update.Replace("@data", data_reconciliacao.ToString());

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

        public Membro_Reconciliacao recuperar_membro_reconciliacao(int id)
        {
            Pessoa p = recuperar(id);
            
            select_padrao = " select * from Pessoa as P inner join Endereco as E on P.Id=E.EnderecoId inner join Telefone as T on E.Id=T.telefoneid "
            + " inner join Membro as M on P.Id=M.Id inner join Membro_Reconciliacao as MR on M.Id=MR.Id "
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
                    this.Data_batismo = int.Parse(Convert.ToString(dr["Data_batismo"]));
                    this.Desligamento = Convert.ToBoolean(dr["Desligamento"]);
                    this.Data_reconciliacao = int.Parse(Convert.ToString(dr["Data_reconciliacao"]));

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

            insert_padrao = "insert into Membro_Reconciliacao (Data_reconciliacao, Id) values ('@data', IDENT_CURRENT('Pessoa'))";

            Insert = insert_padrao.Replace("@data", Data_reconciliacao.ToString());

            return bd.montar_sql(Insert, null, null);
        }

        public override IEnumerable<Pessoa> recuperartodos()
        {
             base.recuperartodos();
            select_padrao = "select * from pessoa inner join endereco on pes_id=end_pessoa inner join telefone on pes_id=tel_pessoa @innerjoin";

          
            Select = select_padrao.Replace("@innerjoin", " inner join membro on pes_id=memb_pessoa inner join membro_reconciliacao on id_membro=reco_membro ");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();
            List<Membro_Reconciliacao> membro = new List<Membro_Reconciliacao>();

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
                        this.Data_reconciliacao = int.Parse(Convert.ToString(dr["Data_reconciliacao"]));
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
