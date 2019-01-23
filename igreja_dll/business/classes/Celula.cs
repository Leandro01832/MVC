
using database.banco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace business.classes
{
    [Table("Celula")]    
    public  class Celula : modelocrud<Celula>
    {
        
        
        private string cel_nome;
        private Endereco_Celula endereco;
        private Cargo_Lider lider;
        private Cargo_Lider_Treinamento lider_treinamento;
        private Cargo_Supervisor supervisor;
        private Cargo_Supervisor_Treinamento supervisor_treianamento;
        private List<Pessoa> pessoas;
        private string dia_semana;
        private DateTime horario;
        private int maximo_pessoa;


        // [Key]
        [Display(Name = "Codigo")]
        public int Celulaid { get; set; }

        [Display(Name = "Nome da celula")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]      
        public string Cel_nome
        {
            get
            {
                return cel_nome;
            }

            set
            {
                if (value != "")
                cel_nome = value;
                else
                {
                    MessageBox.Show("A celula precisa de um nome.");
                    cel_nome = null;
                }
                
            }
        }

        [Display(Name = "Dia da semana")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Dia_semana
        {
            get
            {
                return dia_semana;
            }

            set
            {
                if (value != "")
                dia_semana = value;
                else
                {
                    MessageBox.Show("Preencha o campo dia da semana para as reuniões de celula");
                    dia_semana = null;
                }
            }
        }

        [Display(Name = "Horário")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? Horario { get; set; }
        

        public virtual List<Pessoa> Pessoas
        {
            get
            {
                return pessoas;
            }

            set
            {
                pessoas = value;
            }
        }

        [Display(Name = "Máximo de pessoas")]
        public int Maximo_pessoa
        {
            get
            {
                return maximo_pessoa;
            }

            set
            {
                maximo_pessoa = value;
            }
        }
        
        public virtual Endereco_Celula Endereco_Celula
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        [Display(Name = "Lider")]
        public int Lider_ { get; set; }
        
        [ForeignKey("Lider_")]
        public virtual Cargo_Lider Lider
        {
            get
            {
                return lider;
            }

            set
            {
                lider = value;
            }
        }

        [Display(Name = "Lider em treinamento")]
        public int Lidertreinamento_ { get; set; }

        [ForeignKey("Lidertreinamento_")]
        public virtual Cargo_Lider_Treinamento Lider_treinamento
        {
            get
            {
                return lider_treinamento;
            }

            set
            {
                lider_treinamento = value;
            }
        }

        [Display(Name = "Supervisor")]
        public int Supervisor_ { get; set; }

        [ForeignKey("Supervisor_")]
        public virtual Cargo_Supervisor Supervisor
        {
            get
            {
                return supervisor;
            }

            set
            {
                supervisor = value;
            }
        }

        [Display(Name = "Supervisor em treinamento")]
        public int Supervisortreinamento_ { get; set; }
        
        [ForeignKey("Supervisortreinamento_")]
        public virtual Cargo_Supervisor_Treinamento Supervisor_treianamento
        {
            get
            {
                return supervisor_treianamento;
            }

            set
            {
                supervisor_treianamento = value;
            }
        }

        public Celula()
        {
            bd = new BDcomum();
        }      

        public override string alterar()
        {
            update_padrao = "update celula set cel_lider='@lider', cel_horario='@horario'," +
            " cel_lider_treinamento='@treino', cel_dia_semana='@dia_semana' where id_celula='@id' " +
            "update endereco_celula set cel_bairro='@bairro', cel_rua='@rua', cel_numero='@numero' " +
            " from endereco_celula inner join celula on id_celula=end_celula where id_celula='@id'";
            Update = update_padrao.Replace("@id", this.Cel_nome.ToString());            
            Update = Update.Replace("@dia_semana", dia_semana);
            Update = Update.Replace("@horario", horario.ToString("HH:mm:ss"));
            Update = Update.Replace("@bairro", Endereco_Celula.Cel_bairro);
            Update = Update.Replace("@rua", Endereco_Celula.Cel_rua);
            Update = Update.Replace("@numero", Endereco_Celula.Cel_numero.ToString());
            return bd.montar_sql(Update, null, null);

        }

        public override string excluir()
        {
            throw new NotImplementedException();
        }

        public override Celula recuperar(int id)
        {           
                bd = new BDcomum();
                select_padrao = "select * from celula inner join endereco_celula on id_celula=end_celula" +
                     " where id_celula='" + id + "' order by id_celula asc";
                Select = select_padrao.Replace("@id", id.ToString());

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

                    int i = int.Parse(Convert.ToString(dr["Id"]));
                    this.cel_nome = Convert.ToString(dr["Cel_nome"]);
                    this.Dia_semana = Convert.ToString(dr["Dia_semana"]);
                    this.Endereco_Celula.Cel_bairro = Convert.ToString(dr["Cel_bairro"]);
                    this.Endereco_Celula.Cel_numero = int.Parse(Convert.ToString(dr["Cel_numero"]));
                    this.Endereco_Celula.Cel_rua = Convert.ToString(dr["Cel_rua"]);
                    this.Horario = (TimeSpan)((dr["Horario"]));
                    this.Maximo_pessoa = int.Parse(Convert.ToString(dr["Maximo_pessoa"]));
                    this.pessoas = this.preenchercelula(this.Celulaid);
                    

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
            pessoas = preenchercelula(this.Celulaid);
            Maximo_pessoa = buscarmaximo();

            if (Maximo_pessoa == 0)
            {
                Maximo_pessoa = 70;
            }

            if (pessoas.Count > Maximo_pessoa)
            {
                MessageBox.Show("esta celula ja esta cheia");
                return "";
            }
            else
            {
                Endereco_Celula.salvar();
               // Lider.salvar();
               // Lider_treinamento.salvar();
               // Supervisor.salvar();
              //  Supervisor_treianamento.salvar();
                insert_padrao = "insert into celula(Cel_nome, Dia_semana, Horario, Maximo_pessoa "
             + "Endereco_Id, Lider_Id, Lider_treinamento_Id, Supervisor_Id, Supervisor_Treinamento_id) " +
             "values ('@nome', '@dia_semana', '@horario', '@maximo' "
             + " IDENT_CURRENT('Endereco'), IDENT_CURRENT('Lider'), IDENT_CURRENT('Lider_treinamento'), IDENT_CURRENT('Supervisor'), IDENT_CURRENT('Supervisor_Treinamento')) ";

                Insert = insert_padrao.Replace("@nome", cel_nome);               
                Insert = Insert.Replace("@dia_semana", dia_semana);
                Insert = Insert.Replace("@horario", horario.ToString("HH:mm:ss"));
                Insert = Insert.Replace("@maximo", Maximo_pessoa.ToString());               

                return bd.montar_sql(Insert, null, null);
            }                   
        }

        public List<Pessoa> preenchercelula(int id)
        {
            select_padrao = "select * from pessoa inner join celula_pessoa" +
                " on pes_id=cel_pessoa inner join celula on id_celula=pes_celula" +
                " where id_celula='@id'";
            Select = select_padrao.Replace("@id", id.ToString());

            DataTable datatable = bd.lista(Select);

            List<Pessoa> lista = new List<Pessoa>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                var pessoa = new business.classes.Pessoa();
                pessoa.Id = int.Parse(Convert.ToString(dtrow["Pessoa_id"]));
                pessoa.Nome = Convert.ToString(dtrow["Nome"]);
                pessoa.Sexo_feminino = Convert.ToBoolean(Convert.ToString(dtrow["Sexo_feminino"]));
                pessoa.Sexo_masculino = Convert.ToBoolean(Convert.ToString(dtrow["Sexo_masculino"]));
                pessoa.Rg = Convert.ToString(dtrow["Rg"]);
                pessoa.Data_nascimento = Convert.ToDateTime(Convert.ToString(dtrow["Data_nascimento"]));
                pessoa.Endereco.Cep = long.Parse(Convert.ToString(dtrow["Cep"]));
                pessoa.Telefone.Fone = Convert.ToString(dtrow["Fone"]);
                pessoa.Telefone.Celular = Convert.ToString(dtrow["Celular"]);
                pessoa.Telefone.Whatsapp = Convert.ToString(dtrow["Whatsapp"]);
                pessoa.Cpf = Convert.ToString(dtrow["Cpf"]);
                pessoa.Status = Convert.ToString(dtrow["Status"]);
                pessoa.Endereco.Pais = Convert.ToString(dtrow["Pais"]);
                pessoa.Endereco.Estado = Convert.ToString(dtrow["Estado"]);
                pessoa.Endereco.Cidade = Convert.ToString(dtrow["Cidade"]);
                pessoa.Endereco.Bairro = Convert.ToString(dtrow["Bairro"]);
                pessoa.Endereco.Rua = Convert.ToString(dtrow["Rua"]);
                pessoa.Endereco.Complemento = Convert.ToString(dtrow["Complemento"]);
                pessoa.Endereco.Numero_casa = int.Parse(Convert.ToString(dtrow["Numero"]));
                pessoa.Email = Convert.ToString(dtrow["Email"]);
                pessoa.Estado_civil = Convert.ToString(dtrow["Estado_civil"]);
                pessoa.Falescimento = Convert.ToBoolean(Convert.ToString(dtrow["Falescimento"]));
                lista.Add(pessoa);
            }

            return lista;
        }

        public int buscarmaximo()
        {
          select_padrao = "select * from celula" +        
          " where id_celula='@id'";
            Select = select_padrao.Replace("@id", this.Cel_nome.ToString());

            DataTable datatable = bd.lista(Select);

            foreach (DataRow dtrow in datatable.Rows)
            {
                Maximo_pessoa = int.Parse(dtrow["max_pessoa"].ToString());
            }

            return Maximo_pessoa;
        }                

        public Cargo_Lider info_lider()
        {
            select_padrao = "select * from Pessoa as P inner join Endereco as E on E.Id=Endereco_Id inner join Telefone as T on T.Id=Telefone_Id @innerjoin where  P.Pessoa_id='" + this.Cel_nome + "'";

            Select = select_padrao.Replace("@id", Cel_nome.ToString());
            Select = Select.Replace("@innerjoin", " inner join Celula on celula_=Id");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            var lider = new Cargo_Lider();
            //lider.Id = int.Parse(Convert.ToString(dr["Pessoa_id"]));
            //lider.Nome = Convert.ToString(dr["Nome"]);
            //lider.Sexo_feminino = Convert.ToBoolean(Convert.ToString(dr["Sexo_feminino"]));
            //lider.Sexo_masculino = Convert.ToBoolean(Convert.ToString(dr["Sexo_masculino"]));
            //lider.Rg = Convert.ToString(dr["Rg"]);
            //lider.Data_nascimento = Convert.ToDateTime(Convert.ToString(dr["Data_nascimento"]));
            //lider.Endereco.Cep = long.Parse(Convert.ToString(dr["Cep"]));
            //lider.Telefone.Fone = Convert.ToString(dr["Fone"]);
            //lider.Telefone.Celular = Convert.ToString(dr["Celular"]);
            //lider.Telefone.Whatsapp = Convert.ToString(dr["Whatsapp"]);
            //lider.Cpf = Convert.ToString(dr["Cpf"]);
            //lider.Status = Convert.ToString(dr["Status"]);
            //lider.Endereco.Pais = Convert.ToString(dr["Pais"]);
            //lider.Endereco.Estado = Convert.ToString(dr["Estado"]);
            //lider.Endereco.Cidade = Convert.ToString(dr["Cidade"]);
            //lider.Endereco.Bairro = Convert.ToString(dr["Bairro"]);
            //lider.Endereco.Rua = Convert.ToString(dr["Rua"]);
            //lider.Endereco.Complemento = Convert.ToString(dr["Complemento"]);
            //lider.Endereco.Numero_casa = int.Parse(Convert.ToString(dr["Numero"]));
            //lider.Email = Convert.ToString(dr["Email"]);
            //lider.Estado_civil = Convert.ToString(dr["Estado_civil"]);
            //lider.Falescimento = Convert.ToBoolean(Convert.ToString(dr["Falescimento"]));
            return lider;
        }

        public override IEnumerable<Celula> recuperartodos()
        {
            throw new NotImplementedException();
        }
    }
}
