
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

        public override string alterar(int id)
        {
            update_padrao = "update Celula set Cel_nome='@nome', Lider_='@lider', Horario='@horario'," +
            " Lidertreinamento_='@li_treinanmento', Dia_semana='@dia_semana', Maximo_pessoa='@maximo' " +
            " Supervisor_='@supervisor', Supervisortreinamento_='@sup_treinamento' where Celulaid='@id' " +
            "update endereco_celula set cel_bairro='@bairro', cel_rua='@rua', cel_numero='@numero' " +
            " from endereco_celula inner join celula on Celulaid=enderecoid where Celulaid='@id'";
            Update = update_padrao.Replace("@id", id.ToString());
            Update = Update.Replace("@nome", Cel_nome);
            Update = Update.Replace("@lider", Lider_.ToString());
            Update = Update.Replace("@li_treinamento", Lidertreinamento_.ToString());
            Update = Update.Replace("@supervisor", Supervisor_.ToString());
            Update = Update.Replace("@sup_treinamento", Supervisortreinamento_.ToString());
            Update = Update.Replace("@dia_semana", Dia_semana);
            Update = Update.Replace("@maximo", Maximo_pessoa.ToString());
            Update = Update.Replace("@horario", horario.ToString("HH:mm:ss"));
            Update = Update.Replace("@bairro", this.Endereco_Celula.Cel_bairro);
            Update = Update.Replace("@rua", this.Endereco_Celula.Cel_rua);
            Update = Update.Replace("@numero", this.Endereco_Celula.Cel_numero.ToString());
            return bd.montar_sql(Update, null, null);

        }

        public override string excluir(int id)
        {
            delete_padrao = "delete from Celula where Celulaid='@id'"
                + " delete from Endereco_celula from Endereco_celula"
                + " as EC inner join Celula as C on CE.enderecoid=C.Celulaid"
                + " where C.Celulaid='@id'";
            Delete = delete_padrao.Replace("@id", id.ToString());

            return bd.montar_sql(Delete, null, null);
        }

        public override Celula recuperar(int id)
        {           
                bd = new BDcomum();
                select_padrao = "select * from Celula as C inner join Endereco_celula as EC on C.Celulaid=EC.enderecoid" +
                     " where C.Celulaid='@id' ";
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

                    this.Celulaid = int.Parse(Convert.ToString(dr["Celulaid"]));
                    this.cel_nome = Convert.ToString(dr["Cel_nome"]);
                    this.Lider_ = int.Parse(dr["Lider_"].ToString());
                    this.Lidertreinamento_ = int.Parse(dr["Lidertreinamento_"].ToString());
                    this.Supervisor_ = int.Parse(dr["Supervisor_"].ToString());
                    this.Supervisortreinamento_ = int.Parse(dr["Supervisortreianamento_"].ToString());
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
            insert_padrao = "insert into Celula (Cel_nome, Dia_semana, Horario, Maximo_pessoa "
             + "Endereco_Id, Lider_Id, Lider_treinamento_Id, Supervisor_Id, Supervisor_Treinamento_id) " +
             "values ('@nome', '@dia_semana', '@horario', '@maximo' "
             + " '@lider', '@li_treinamento', '@supervisor', '@sup_treinamento' " 
             + Endereco_Celula.salvar();

                Insert = insert_padrao.Replace("@nome", Cel_nome);               
                Insert = Insert.Replace("@dia_semana", Dia_semana);
                Insert = Insert.Replace("@horario", Horario.ToString());
                Insert = Insert.Replace("@maximo", Maximo_pessoa.ToString());
                Insert = Insert.Replace("@lider", Lider_.ToString());
                Insert = Insert.Replace("@li_treinamento", Lidertreinamento_.ToString());
                Insert = Insert.Replace("@supervisor", Supervisor_.ToString());
                Insert = Insert.Replace("@sup_treinamento", Supervisortreinamento_.ToString());
                Insert = insert_padrao.Replace("@bairro", this.Endereco_Celula.Cel_bairro);
                Insert = Insert.Replace("@rua", this.Endereco_Celula.Cel_rua);
                Insert = Insert.Replace("@numero", this.Endereco_Celula.Cel_numero.ToString());

            return bd.montar_sql(Insert, null, null);                              
        }

        public List<Pessoa> preenchercelula(int id)
        {
            select_padrao = "select * from Pessoa as P " +
                " inner join Celula as C" +
                " on P.celula_=C.Celulaid" +
                " inner join Endereco as E" +
                " on E.EnderecoId=P.Id" +
                " inner join Telefone as T" +
                " on T.telefoneid=P.Id" +
                " where C.Celulaid='@id'";
            Select = select_padrao.Replace("@id", id.ToString());

            DataTable datatable = bd.lista(Select);

            List<Pessoa> lista = new List<Pessoa>();
            foreach (DataRow dtrow in datatable.Rows)
            {
                var pessoa = new Pessoa();
                pessoa.Id = int.Parse(Convert.ToString(dtrow["Id"]));
                pessoa.Nome = Convert.ToString(dtrow["Nome"]);
                pessoa.Status = Convert.ToString(dtrow["Status"]);
                pessoa.Email = Convert.ToString(dtrow["Email"]);
                pessoa.Estado_civil = Convert.ToString(dtrow["Estado_civil"]);
                pessoa.Falescimento = Convert.ToBoolean(Convert.ToString(dtrow["Falescimento"]));
                pessoa.Cpf = Convert.ToString(dtrow["Cpf"]);
                pessoa.Sexo_feminino = Convert.ToBoolean(Convert.ToString(dtrow["Sexo_feminino"]));
                pessoa.Sexo_masculino = Convert.ToBoolean(Convert.ToString(dtrow["Sexo_masculino"]));
                pessoa.Rg = Convert.ToString(dtrow["Rg"]);
                pessoa.Data_nascimento = Convert.ToDateTime(Convert.ToString(dtrow["Data_nascimento"]));
                pessoa.Telefone = new Telefone();              
                pessoa.Telefone.Fone = Convert.ToString(dtrow["Fone"]);
                pessoa.Telefone.Celular = Convert.ToString(dtrow["Celular"]);
                pessoa.Telefone.Whatsapp = Convert.ToString(dtrow["Whatsapp"]);
                pessoa.Endereco = new Endereco();               
                pessoa.Endereco.Cep = long.Parse(Convert.ToString(dtrow["Cep"]));
                pessoa.Endereco.Pais = Convert.ToString(dtrow["Pais"]);
                pessoa.Endereco.Estado = Convert.ToString(dtrow["Estado"]);
                pessoa.Endereco.Cidade = Convert.ToString(dtrow["Cidade"]);
                pessoa.Endereco.Bairro = Convert.ToString(dtrow["Bairro"]);
                pessoa.Endereco.Rua = Convert.ToString(dtrow["Rua"]);
                pessoa.Endereco.Complemento = Convert.ToString(dtrow["Complemento"]);
                pessoa.Endereco.Numero_casa = int.Parse(Convert.ToString(dtrow["Numero_casa"]));
                
                lista.Add(pessoa);
            }

            return lista;
        }        

        public override IEnumerable<Celula> recuperartodos()
        {
            select_padrao = "select * from Celula order by Celulaid asc";

            SqlCommand comando = new SqlCommand(select_padrao, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Celula> lista = new List<Celula>();

            while (dr.Read())
            {
                Celula cl = new Celula();
                cl.Celulaid = int.Parse(Convert.ToString(dr["Celulaid"]));
                cl.cel_nome = Convert.ToString(dr["Cel_nome"]);
                cl.Lider_ = int.Parse(dr["Lider_"].ToString());
                cl.Lidertreinamento_ = int.Parse(dr["Lidertreinamento_"].ToString());
                cl.Supervisor_ = int.Parse(dr["Supervisor_"].ToString());
                cl.Supervisortreinamento_ = int.Parse(dr["Supervisortreianamento_"].ToString());
                cl.Dia_semana = Convert.ToString(dr["Dia_semana"]);
                cl.Endereco_Celula.Cel_bairro = Convert.ToString(dr["Cel_bairro"]);
                cl.Endereco_Celula.Cel_numero = int.Parse(Convert.ToString(dr["Cel_numero"]));
                cl.Endereco_Celula.Cel_rua = Convert.ToString(dr["Cel_rua"]);
                cl.Horario = (TimeSpan)((dr["Horario"]));
                cl.Maximo_pessoa = int.Parse(Convert.ToString(dr["Maximo_pessoa"]));
                cl.pessoas = cl.preenchercelula(cl.Celulaid);
                lista.Add(cl);
            }

            return lista;
        }
    }
}
