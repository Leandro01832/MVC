using database.banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace business.classes
{
    [Table("Membro_batismo")]    
    public class Membro_Batismo : Membro
    {
       

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

        public Membro_Batismo(string nome, bool sexo_masculino, bool sexo_feminino,
            string data_nascimento, string rg, bool falescimento, string email, string cpf,
            int falta, string pais, string cidade, string bairro, string rua, string estado,
            int numero_casa, int cep, string complemento, string estado_civil, string status,
            string telefone, string celular, string whatsapp, int ano_batismo,
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
            this.Data_batismo = ano_batismo;
            
        }

        /// <summary>
        /// Construtor sem parametros
        /// </summary>

        public Membro_Batismo()
        {
            bd = new BDcomum();
        }

        /// <summary>
        /// contrutor para buscar membro por reconciliacao atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Membro_Batismo(int id)
        {
            bd = new BDcomum();
            recuperar(id);
        }

        public override string alterar(int id)
        {
            return  bd.montar_sql(base.alterar(id), null, null);
        }

        public override string excluir(int id)
        {
            return base.excluir(id);
        }

        public override Pessoa recuperar(int id)
        {
            return base.recuperar(id);
        }

        public Membro_Batismo recuperar_membro_batismo(int id)
        {
            Pessoa p = recuperar(id);
            select_padrao = " select * from Pessoa as P inner join Endereco as E on P.Id=E.EnderecoId inner join Telefone as T on E.Id=T.telefoneid " 
            +" inner join Membro as M on P.Id=M.Id inner join Membro_batismo as MB on M.Id=MB.Id " 
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

            insert_padrao = "insert into Membro_batismo (Id) values (IDENT_CURRENT('Pessoa'))";          

            return bd.montar_sql(insert_padrao, null, null);
        }

        public override IEnumerable<Pessoa> recuperartodos()
        {
            return base.recuperartodos();
        }
    }
}
