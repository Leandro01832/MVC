using database.banco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace business.classes
{
    [Table("Membro_transferencia")]    
    public class Membro_Transferencia : Membro
    {     
        
        private string nome_cidade_transferencia;
        private string estado_transferencia;
        private string nome_igreja_transferencia;

        [Display(Name = "Nome da cidade onde morava")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Nome_cidade_transferencia
        {
            get
            {
                return nome_cidade_transferencia;
            }

            set
            {
                if (value != "")
                nome_cidade_transferencia = value;
                else
                {
                    MessageBox.Show("O nome de cidade de transerencia pecisa ser preechido corretamente");
                    nome_cidade_transferencia = null;
                }
            }
        }

        [Display(Name = "Estado onde morava")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Estado_transferencia
        {
            get
            {
                return estado_transferencia;
            }

            set
            {
                if(value != "")
                estado_transferencia = value;
                else
                {
                    MessageBox.Show("O estado de transferencia deve ser preechido corretamente");
                    estado_transferencia = null;
                }
            }
        }

        [Display(Name = "Igreja onde congregava")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Nome_igreja_transferencia
        {
            get
            {
                return nome_igreja_transferencia;
            }

            set
            {
                if(value != "")
                nome_igreja_transferencia = value;
                else
                {
                    MessageBox.Show("O nome da igreja deve ser preenchido corretamente");
                    nome_igreja_transferencia = null;
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
        /// <param name="nome_cidade_transferencia"></param>
        /// <param name="estado_transferencia"></param>
        /// <param name="nome_igreja_transferencia"></param>
        /// <param name="ano_batismo"></param>
        /// <param name="imagem_location"></param>

        public Membro_Transferencia(string nome, bool sexo_masculino, bool sexo_feminino,
            string data_nascimento, string rg, bool falescimento, string email, string cpf,
            int falta, string pais, string cidade, string bairro, string rua, string estado,
            int numero_casa, int cep, string complemento, string estado_civil, string status,
            string telefone, string celular, string whatsapp, string nome_cidade_transferencia,
            string estado_transferencia, string nome_igreja_transferencia, int ano_batismo,
            string imagem_location)
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
            this.Nome_cidade_transferencia = nome_cidade_transferencia;
            this.Estado_transferencia = estado_transferencia;
            this.Nome_igreja_transferencia = nome_igreja_transferencia;
            this.Data_batismo = ano_batismo;
            

        }      

        /// <summary>
        /// Construtor sem paramentros
        /// </summary>

        public Membro_Transferencia()
        {
            bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar membro por transferencia atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Membro_Transferencia(int id)
        {
            bd = new BDcomum();
            recuperar(id);
        }

        public override string alterar(int id)
        {
             base.alterar(id);

            update_padrao = "update Membro_transferencia set Nome_cidade_transferencia ='@cidade_transferencia', Nome_igreja_transferencia='@igreja', Estado_transferencia='@estado'" +
                " from Membro_transferencia as MT inner join Membro as M on M.Id=id_membro inner join Pessoa as P on P.Pessoa_id=id_pessoa where P.Pessoa_id='@id' ";

            Update = update_padrao.Replace("@id", this.Id.ToString());
            Update = Update.Replace("@cidade_transferencia", nome_cidade_transferencia);
            Update = Update.Replace("@igreja", nome_igreja_transferencia);
            Update = Update.Replace("@estado", estado_transferencia);

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

        public  Membro_Transferencia recuperar_membro_transferencia(int id)
        {
            Pessoa p = recuperar(id);
            select_padrao = " select * from Pessoa as P inner join Endereco as E on P.Id=E.EnderecoId inner join Telefone as T on E.Id=T.telefoneid "
            + " inner join Membro as M on P.Id=M.Id inner join Membro_transferencia as MT on M.Id=MT.Id "
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
                    this.Nome_cidade_transferencia = Convert.ToString(dr["Nome_cidade_transferencia"]);
                    this.Nome_igreja_transferencia = Convert.ToString(dr["Nome_igreja_transferencia"]);
                    this.Estado_transferencia = Convert.ToString(dr["Estado_transferencia"]);

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

            insert_padrao = "insert into Membro_transferencia (Nome_cidade_transferencia, Estado_transferencia, Nome_igreja_transferencia, Id) values" +

              " ('@cidade', '@estado', '@nome_igreja', IDENT_CURRENT('Pessoa'))";

            Insert = insert_padrao.Replace("@cidade", Nome_cidade_transferencia);
            Insert = Insert.Replace("@estado", Estado_transferencia);
            Insert = Insert.Replace("@nome_igreja", Nome_igreja_transferencia);
            

            return bd.montar_sql(Insert, null, null);
            
        }

        public override IEnumerable<Pessoa> recuperartodos()
        {
             base.recuperartodos();
            select_padrao = "select * from pessoa inner join endereco on pes_id=end_pessoa inner join telefone on pes_id=tel_pessoa @innerjoin ";            
            Select = select_padrao.Replace("@innerjoin", " inner join membro on pes_id=memb_pessoa inner join membro_transferencia on id_membro=trans_membro ");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Membro_Transferencia> membro = new List<Membro_Transferencia>(); 

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
                        this.Nome_cidade_transferencia = Convert.ToString(dr["Nome_cidade_transferencia"]);
                        this.Nome_igreja_transferencia = Convert.ToString(dr["Nome_igreja_transferencia"]);
                        this.Estado_transferencia = Convert.ToString(dr["Estado_transferencia"]);
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
