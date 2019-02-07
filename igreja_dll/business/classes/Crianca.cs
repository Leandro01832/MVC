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
using System.Data;

namespace business.classes
{
    [Table("Crianca")]    
    public class Crianca : Pessoa
    {
        
        
        private string nome_pai;
        private string nome_mae;

        [Display(Name = "Nome do pai")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Nome_pai
        {
            get
            {
                return nome_pai;
            }

            set
            {
                if(value != "")
                nome_pai = value;
                else
                {
                    MessageBox.Show("informe o nome do pai");
                }
            }
        }

        [Display(Name = "Nome da mãe")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Nome_mae
        {
            get
            {
                return nome_mae;
            }

            set
            {
                if(value != "")
                nome_mae = value;
                else
                {
                    MessageBox.Show("informe o nome da mãe");
                    nome_mae = null;
                }
            }
        }

        
        //public int id_pessoa { get; set; }

        //[ForeignKey("id_pessoa")]
        //public virtual Pessoa pessoa { get; set; }

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
        /// <param name="imagem_location"></param>
        /// <param name="nome_pai"></param>
        /// <param name="nome_mae"></param>

        public Crianca(string nome, bool sexo_masculino, bool sexo_feminino,
            string data_nascimento, string rg, bool falescimento, string email, string cpf,
            int falta, string pais, string cidade, string bairro, string rua, string estado,
            int numero_casa, int cep, string complemento, string estado_civil, string status,
            string telefone, string celular, string whatsapp, string imagem_location,
            string nome_pai, string nome_mae)
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
            Endereco.Pais = pais;
            Endereco.Cidade = cidade;
            Endereco.Bairro = bairro;
            Endereco.Rua = rua;
            Endereco.Estado = estado;
            Endereco.Numero_casa = numero_casa;
            Endereco.Cep = cep;
            Endereco.Complemento = complemento;
            this.Estado_civil = estado_civil;
            this.Status = status;
            Telefone.Fone = telefone;
            Telefone.Celular = celular;
            Telefone.Whatsapp = whatsapp;
            this.Nome_mae = nome_mae;
            this.Nome_pai = nome_pai;
            
        }

        /// <summary>
        /// Construtor sem parametros
        /// </summary>

        public Crianca()
        {
            bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar crianca atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Crianca(int id)
        {
            bd = new BDcomum();
            recuperar(id);
        }

        public override string alterar(int id)
        {
            base.alterar(id);
            update_padrao = "update crianca set nome_pai='@pai', nome_mae='@mae' " +
                " from crianca inner join pessoa on pes_id=cri_pessoa " +
                "where pes_nome='@nome'";
            Update = update_padrao.Replace("@nome", Nome);
            Update = Update.Replace("@pai", nome_pai);
            Update = Update.Replace("@mae", nome_mae);

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

        public Crianca recuperar_crianca(int id)
        {
            Pessoa p = recuperar(id);
            select_padrao = " select * from Pessoa as P inner join Endereco as E on P.Id=E.EnderecoId inner join Telefone as T on P.Id=T.telefoneid "
             + " inner join Crianca as C on P.Id=C.Id "
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
                    this.Nome_pai = Convert.ToString(dr["Nome_pai"]);
                    this.Nome_mae = Convert.ToString(dr["Nome_mae"]);
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

            insert_padrao = "insert into Crianca (Nome_pai, Nome_mae, Id) values" +
                " ('@pai', '@mae', IDENT_CURRENT('pessoa'))";

            Insert = insert_padrao.Replace("@mae", Nome_mae);
            Insert = Insert.Replace("@pai", Nome_pai);

            return bd.montar_sql(Insert, null, null);
        }

        public override void foto(PictureBox foto)
        {
            base.foto(foto);
        }

        public override IEnumerable<Pessoa> recuperartodos()
        {
             base.recuperartodos();
            select_padrao = "select * from pessoa inner join endereco on pes_id=end_pessoa inner join telefone on pes_id=tel_pessoa @innerjoin where Pessoa_id='" + this.Id + "'";

            Select = select_padrao.Replace("@nome", this.Nome);
            Select = Select.Replace("@cpf", this.Cpf);
            Select = Select.Replace("@innerjoin", "inner join crianca on pes_id=cri_pessoa");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Crianca> crianca = new List<Crianca>();

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
                        this.Nome_pai = Convert.ToString(dr["Nome_pai"]);
                        this.Nome_mae = Convert.ToString(dr["Nome_mae"]);
                        crianca.Add(this);
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

                return crianca;
            }
        }


    }
}
