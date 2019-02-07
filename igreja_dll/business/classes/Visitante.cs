using database.banco;
using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace business.classes
{
    [Table("Visitante")]    
    public class Visitante : Pessoa 
    {       
        private DateTime data_visita;
        
        private string condicao_religiosa;

        [Display(Name = "Data da visita")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data_visita
        {
            get
            {
                string sqlTimeAsString = data_visita.ToString("yyyy-MM-dd HH:mm:ss.fff");
                return Convert.ToDateTime(sqlTimeAsString);
            }

            set
            {
                string sqlTimeAsString = value.ToString("yyyy-MM-dd HH:mm:ss.fff");
                data_visita = Convert.ToDateTime(sqlTimeAsString);
            }
        }

        [Display(Name = "Condição religiosa")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Condicao_religiosa
        {
            get
            {
                return condicao_religiosa;
            }

            set
            {
                if(value != "")
                condicao_religiosa = value;
                else
                {
                    MessageBox.Show("indique a condição religiiosa");
                    condicao_religiosa = null;
                }
            }
        }

        

      //  public int id_pessoa { get; set; }

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
        /// <param name="data_visita"></param>
        /// <param name="condicao_religiosa"></param>

        public Visitante(string nome, bool sexo_masculino, bool sexo_feminino,
            string data_nascimento, string rg, bool falescimento, string email, string cpf,
            int falta, string pais, string cidade, string bairro, string rua, string estado,
            int numero_casa, int cep, string complemento, string estado_civil, string status,
            string telefone, string celular, string whatsapp, string imagem_location,
            string data_visita, string condicao_religiosa)
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
            this.Data_visita = Convert.ToDateTime(data_visita);
            this.Condicao_religiosa = condicao_religiosa;
           
        }

       /// <summary>
       /// contrutor para buscar visitante atraves do id
       /// </summary>
       /// <param name="id"></param>

        public Visitante(int id)
        {
            bd = new BDcomum();
             recuperar(id);            
        }

        /// <summary>
        /// construtor sem paramentros
        /// </summary>
        public Visitante()
        {
            bd = new BDcomum();           
        }



        public DateTime freguentar()
        {


            DateTime frequencia = DateTime.Today.AddDays(30);

            return data_visita;
        }      

        public override string alterar(int id)
        {
             base.alterar(id);
            update_padrao = "update Visitante set visita = @data, condicao_religiosa = @condicao_religiosa inner join pessoa on pes_id=visi_pessoa " +
                "where pes_nome = @nome";
            Update = update_padrao.Replace("@nome", Nome);
            Update = Update.Replace("@data", data_visita.ToString());
            Update = Update.Replace("@condicao_religiosa",  condicao_religiosa);

         return   bd.montar_sql(Update, null, null);
        }

        public override string excluir(int id)
        {
            return base.excluir(id);
        }

        public override Pessoa recuperar(int id)
        {
            return base.recuperar(id);
        }

        public  Visitante recuperar_visitante(int id)
        {
            Pessoa p = recuperar(id);           

            select_padrao = " select * from Pessoa as P inner join Endereco as E on P.Id=E.EnderecoId inner join Telefone as T on E.Id=T.telefoneid "
            + " inner join Visitante as V on P.Id=V.Id "
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
                    this.data_visita = Convert.ToDateTime(Convert.ToString(dr["Data_visita"]));
                    this.condicao_religiosa = Convert.ToString(dr["Condicao_religiosa"]);

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

            insert_padrao = "insert into Visitante (Data_visita, Condicao_religiosa, Id) values" +
                " ('@data', '@condicao_religiosa', IDENT_CURRENT('Pessoa'))";

            Insert = insert_padrao.Replace("@data", Data_visita.ToString());
            Insert = Insert.Replace("@condicao_religiosa", Condicao_religiosa);

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
            Select = Select.Replace("@innerjoin", "inner join visitante on pes_id=visi_pessoa");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Visitante> visitante = new List<Visitante>();

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
                        this.data_visita = Convert.ToDateTime(Convert.ToString(dr["Data_visita"]));
                        this.condicao_religiosa = Convert.ToString(dr["Condicao_religiosa"]);
                        visitante.Add(this);
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

                return visitante;
            }
        }
    }
}
