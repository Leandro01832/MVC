using database.banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace business.classes
{
    [Table("Reuniao")]
    public class Reuniao : modelocrud<Reuniao>
    {
       
        private int id;
        private DateTime data_reuniao;
        private DateTime horario_inicio;
        private DateTime horario_fim;
        private string local_reuniao;

        [Display(Name = "Código")]
        [Key]
        public int cronologiaid
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [Display(Name = "Data da reunião")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data_reuniao
        {
            get
            {
                return data_reuniao;
            }

            set
            {
                if(value >= DateTime.Now)
                data_reuniao = value;
                else
                {
                    MessageBox.Show("A data precisa ser maior ou igual ao dia atual");
                    data_reuniao = DateTime.Now;
                }
            }
        }

        [Display(Name = "Horário de início")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Horario_inicio
        {
            get
            {
                return horario_inicio;
            }

            set
            {
                horario_inicio = value;
            }
        }

        [Display(Name = "Horário de termino")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Horario_fim
        {
            get
            {
                return horario_fim;
            }

            set
            {
                if (value > horario_inicio)
                horario_fim = value;
                else
                {
                    MessageBox.Show("O horario que termina a reunião deve ser maior que o horario de inicio");
                    horario_fim = horario_inicio.AddHours(1);
                }
            }
        }

        [Display(Name = "Local da reunião")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Local_reuniao
        {
            get
            {
                return local_reuniao;
            }

            set
            {
                if(value != "")
                local_reuniao = value;
                else
                {
                    MessageBox.Show("Informe o local da reunião");
                    local_reuniao = null;
                }
            }
        }

        public List<Pessoa> Pessoas { get; set; }

        public Reuniao()
        {
            bd = new BDcomum();
        }

        public override string alterar(int id)
        {
            update_padrao = "update Reuniao set Data_reuniao='@data', Horario_inicio='@inicio', Horario_fim='@fim' where cronologiaid='@id'";
            Update = update_padrao.Replace("@id", id.ToString());
            return bd.montar_sql(Update, null, null);
        }

        public override string excluir(int id)
        {
            delete_padrao = " delete from Reuniao where cronologiaid='@id' ";
            Delete = delete_padrao.Replace("@id", id.ToString());

            return bd.montar_sql(Delete, null, null);
        }

        public override Reuniao recuperar(int id)
        {
            select_padrao = "select * from Reuniao where cronologiaid='@id'";
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
                    this.cronologiaid = int.Parse(dr["cronologiaid"].ToString());
                    this.Data_reuniao = Convert.ToDateTime(dr["Data_reuniao"].ToString());
                    this.Horario_inicio = Convert.ToDateTime(dr["Horario_inicio"].ToString());
                    this.Horario_fim = Convert.ToDateTime(dr["Horario_fim"].ToString());
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
            insert_padrao = "insert into Reuniao (Data_reuniao," +
                " Horario_inicio, Horario_fim, Local_reuniao) " +
        " values ('@data', '@inicio', '@fim', '@local_reuniao')";

            Insert = insert_padrao.Replace("@data", Data_reuniao.ToString("yyyy-MM-dd"));
            Insert = Insert.Replace("@inicio", Horario_inicio.ToString("HH:mm:ss"));
            Insert = Insert.Replace("@fim", Horario_fim.ToString("HH:mm:ss"));
            Insert = Insert.Replace("@local_reuniao", Local_reuniao);

            return bd.montar_sql(Insert, null, null);
        }     

        public List<Pessoa> preecher_reuniao()
        {
            select_padrao = "select * from Reuniao as R"
               + " inner join ReuniaoPessoa as RP"
               + " on R.cronologiaid=RP.Reuniao_cronologiaid"
               + " inner join Pessoa as P on "
              + " P.Id=RP.Pessoa_Id "
              + " where R.cronologiaid='@id'";

            SqlCommand comando = new SqlCommand(select_padrao, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Pessoa> lista = new List<Pessoa>();

            while (dr.Read())
            {
                Pessoa cl = new Pessoa();                
                cl.Id = int.Parse(Convert.ToString(dr["Id"]));
                cl.Nome = Convert.ToString(dr["Nome"]);
                cl.Email = Convert.ToString(dr["Email"]);
                cl.Falta = int.Parse(dr["Falta"].ToString());
                cl.Estado_civil = Convert.ToString(dr["Estado_civil"]);
                cl.Falescimento = Convert.ToBoolean(Convert.ToString(dr["Falescimento"]));
                cl.Sexo_feminino = Convert.ToBoolean(Convert.ToString(dr["Sexo_feminino"]));
                cl.Sexo_masculino = Convert.ToBoolean(Convert.ToString(dr["Sexo_masculino"]));
                cl.Rg = Convert.ToString(dr["Rg"]);
                cl.Data_nascimento = Convert.ToDateTime(Convert.ToString(dr["Data_nascimento"]));
                cl.Cpf = Convert.ToString(dr["Cpf"]);
                cl.Status = Convert.ToString(dr["Status"]);
                cl.Telefone.Fone = Convert.ToString(dr["Fone"]);
                cl.Telefone.Celular = Convert.ToString(dr["Celular"]);
                cl.Telefone.Whatsapp = Convert.ToString(dr["Whatsapp"]);
                cl.Endereco.Cep = long.Parse(Convert.ToString(dr["Cep"]));
                cl.Endereco.Pais = Convert.ToString(dr["Pais"]);
                cl.Endereco.Estado = Convert.ToString(dr["Estado"]);
                cl.Endereco.Cidade = Convert.ToString(dr["Cidade"]);
                cl.Endereco.Bairro = Convert.ToString(dr["Bairro"]);
                cl.Endereco.Rua = Convert.ToString(dr["Rua"]);
                cl.Endereco.Complemento = Convert.ToString(dr["Complemento"]);
                cl.Endereco.Numero_casa = int.Parse(Convert.ToString(dr["Numero"]));
                cl.Chamada.Data_inicio = Convert.ToDateTime(dr["Data_inicio"]);
                cl.Chamada.Numero_chamada = int.Parse(dr["Numero_chamada"].ToString());
                cl.Celula.Celulaid = int.Parse(dr["celulaid"].ToString());
                cl.Celula.Supervisor_ = int.Parse(dr["Supervisor"].ToString());
                cl.Celula.Supervisortreinamento_ = int.Parse(dr["Supervisortreinamento_"].ToString());
                cl.Celula.Lider_ = int.Parse(dr["Lider_"].ToString());
                cl.Celula.Lidertreinamento_ = int.Parse(dr["Lidertreinamento_"].ToString());
                cl.Celula.Pessoas = cl.Celula.preenchercelula(cl.Celula.Celulaid);
                cl.Celula.Maximo_pessoa = int.Parse(dr["Maximo_pessoa"].ToString());
                cl.Celula.Horario = TimeSpan.Parse(dr["Horario"].ToString());
                cl.Celula.Cel_nome = dr["Cel_nome"].ToString();

                
                    Historico h = new Historico();
                    h.Data_inicio = Convert.ToDateTime(dr["Data_inicio"]);
                    h.Falta = int.Parse(dr["Falta"].ToString());
                    cl.Historico.Add(h);

                    Ministerio m = new Ministerio();
                    m.ministerioid = int.Parse(dr["ministerioid"].ToString());
                    m.Nome = dr["Nome"].ToString();
                    m.lider_ministerio = int.Parse(dr["Lider_ministerio"].ToString());
                    m.Proposito = dr["proposito"].ToString();
                    m.Pessoas = m.preencherministerio(m.ministerioid);
                    cl.Ministerios.Add(m);

                    Reuniao r = new Reuniao();
                    r.Data_reuniao = Convert.ToDateTime(dr["Data_reuniao"]);
                    r.Horario_inicio = Convert.ToDateTime(dr["Horario_inicio"]);
                    r.Horario_fim = Convert.ToDateTime(dr["Horario_fim"]);
                    r.Local_reuniao = dr["Local_reuniao"].ToString();
                    cl.Reuniao.Add(r);
                
                lista.Add(cl);
            }

            return lista;
        }


        public override IEnumerable<Reuniao> recuperartodos()
        {
            select_padrao = "select * from Reuniao as R"
                + " inner join ReuniaoPessoa as RP on R.cronologiaid=RP.Reuniao_cronologiaid ";

            SqlCommand comando = new SqlCommand(select_padrao, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Reuniao> lista = new List<Reuniao>();

            while (dr.Read())
            {
                Reuniao cl = new Reuniao();

                cl.cronologiaid = int.Parse(dr["cronologiaid"].ToString());
                cl.Data_reuniao = Convert.ToDateTime(dr["Data_reuniao"].ToString());
                cl.Horario_inicio = Convert.ToDateTime(dr["Horario_inicio"].ToString());
                cl.Horario_fim = Convert.ToDateTime(dr["Horario_fim"].ToString());
                cl.Pessoas = cl.preecher_reuniao();
                lista.Add(cl);
            }

            return lista;
        }
    }
}
