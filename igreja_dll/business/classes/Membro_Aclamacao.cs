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
    [Table("Membro_aclamacao")]
    public class Membro_Aclamacao : Membro
    {
        
        
        private string denominacao;

        [Display(Name = "Denominação")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Denominacao
        {
            get
            {
                return denominacao;
            }

            set
            {
                if(value != "")
                denominacao = value;
                else
                {
                    MessageBox.Show("denominação precisa ser preenchido corretamente");
                    denominacao = null;
                }
            }
        }

        

       // public int id_membro { get; set; }

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
        /// <param name="denominacao"></param>

        public Membro_Aclamacao(Membro_Aclamacao membro)
        {
            bd = new BDcomum();

            this.Nome = membro.Nome;
            this.Sexo_masculino = membro.Sexo_masculino;
            this.Sexo_feminino = membro.Sexo_feminino;
            this.Data_nascimento = Convert.ToDateTime(membro.Data_nascimento);
            this.Rg = membro.Rg;
            this.Falescimento = false;
            this.Email = membro.Email;
            this.Cpf = membro.Cpf;
            this.Falta = membro.Falta;
            this.Endereco.Pais = membro.Endereco.Pais;
            this.Endereco.Cidade = membro.Endereco.Cidade;
            this.Endereco.Bairro = membro.Endereco.Bairro;
            this.Endereco.Rua = membro.Endereco.Rua;
            this.Endereco.Estado = membro.Endereco.Estado;
            this.Endereco.Numero_casa = membro.Endereco.Numero_casa;
            this.Endereco.Cep = membro.Endereco.Cep;
            this.Endereco.Complemento = membro.Endereco.Complemento;
            this.Estado_civil = membro.Estado_civil;
            this.Status = membro.Status;
            this.Telefone.Fone = membro.Telefone.Fone;
            this.Telefone.Celular = membro.Telefone.Celular;
            this.Telefone.Whatsapp = membro.Telefone.Whatsapp;
            this.Denominacao = membro.Denominacao;
            this.Data_batismo = membro.Data_batismo;
            
        }

        /// <summary>
        /// Construtor sem paramentros
        /// </summary>

       public Membro_Aclamacao()
        {
            bd = new BDcomum();
        }


        /// <summary>
        /// contrutor para buscar membro por reconciliacao atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Membro_Aclamacao(int id)
        {
            bd = new BDcomum();
            recuperar(id);
        }

        public override string alterar()
        {
             base.alterar();

            update_padrao = "update membro_aclamacao set acla_denominacao = '@denominacao' " +
                " from membro_aclamacao as MA inner join membro as M on M.id_membro=MA.acla_membro inner join pessoa as P on P.pes_id=M.memb_pessoa where pes_nome = '@nome'";
            Update = update_padrao.Replace("@nome", this.Nome);
            Update = Update.Replace("@denominacao", denominacao);

            return bd.montar_sql(Update, null, null);
        }

        public override string excluir()
        {
            return base.excluir();
        }

        public override Pessoa recuperar(int id)
        {
            return base.recuperar(id);
        }

        public  Membro_Aclamacao recuperar_membro_aclamacao(int id)
        {
            Pessoa p = recuperar(id);
            select_padrao = "select * from pessoa inner join endereco on pes_id=end_pessoa inner join telefone on pes_id=tel_pessoa @innerjoin where Pessoa_id='" + id + "'";            
            Select = Select.Replace("@innerjoin", " inner join membro on pes_id=memb_pessoa inner join membro_aclamacao on id_membro=acla_membro ");

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
                    this.Denominacao = Convert.ToString(dr["Denominacao"]);
                    this.Data_batismo = int.Parse(Convert.ToString(dr["Data_batismo"]));
                    this.Desligamento = Convert.ToBoolean(dr["Desligamento"]);
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

            insert_padrao = "insert into membro_aclamacao (Denominacao, id_membro) values ('@denominacao', IDENT_CURRENT('Membro'))";
            Insert = insert_padrao.Replace("@denominacao", denominacao);

            return bd.montar_sql(Insert, null, null);
        }

        public override IEnumerable<Pessoa> recuperartodos()
        {
            base.recuperartodos();
            select_padrao = "select * from pessoa inner join endereco on pes_id=end_pessoa inner join telefone on pes_id=tel_pessoa @innerjoin";
            Select = select_padrao.Replace("@innerjoin", " inner join membro on pes_id=memb_pessoa inner join membro_aclamacao on id_membro=acla_membro ");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Membro_Aclamacao> membro = new List<Membro_Aclamacao>();

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
                        this.Denominacao = Convert.ToString(dr["Denominacao"]);
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
