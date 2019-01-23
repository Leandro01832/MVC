using System;
using System.Windows.Forms;
using System.Drawing;
using database.banco;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace business.classes
{
    [Table("Pessoa")]    
    public class Pessoa : modelocrud<Pessoa>  
    {
        
        private int      pessoa_id;
        private string   nome;
        private DateTime data_nascimento;
        private string   rg;
        private string   cpf;
        private string   estado_civil;
        private bool     sexo_masculino;
        private bool     sexo_feminino;
        private bool     falescimento;
        private string   status;        
        private string   email;
        private int      falta;
        private Celula   celula;
        private Endereco endereco;
        private Telefone telefone;
        private List<Historico> historico;
        private List<Ministerio> ministerios;       
        private  byte[] img;
        

        
        [Display(Name = "Codigo")]        
        public int Id
        {
            get
            {
                return pessoa_id;
            }

            set
            {
                pessoa_id = value;
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Nome
        {
            
            get
            {           
                return nome;
                
              
            }

            set
            {
                if (value != "")
                { nome = value; }
                else
                {
                    MessageBox.Show("nome precisa ser preenchido corretamente!!!");
                    nome = null;
                }
                
            }
        }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage ="Este campo precisa ser preenchido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data_nascimento
        {
            get
            {
                return data_nascimento;
            }

            set
            {
                data_nascimento = value;
            }
        }

        [Display(Name = "RG")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Rg
        {
            get
            {
                return rg;
            }

            set
            { 
                if (value != "")
                {
                    rg = value;
                }
                else
                {
                    MessageBox.Show("RG precisa ser preenchido corretamente");
                    rg = null;
                }                
            }
        }


        [Display(Name = "CPF")]
        [StringLength(11)]
        [Index("CPF", 2, IsUnique = true)]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Cpf
        {
            get
            {                
                return cpf ;
            }

            set
            {
                if (value != "")
                    cpf = value;
                else
                {
                    MessageBox.Show("CPF precisa ser preenchido corretamente");
                    cpf = null;
                }                                   
            }
        }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Estado_civil
        {
            get
            {
                return estado_civil;
            }

            set
            {
                if(value != "")
                estado_civil = value;
                else
                {
                    MessageBox.Show("Estado civil precisa ser preenchido corretamente");
                    estado_civil = null;
                }
            }
        }

        [Display(Name = "Sexo masculino")]
        public bool Sexo_masculino
        {
            get
            {
                return sexo_masculino;
            }

            set
            {
                sexo_masculino = value;
            }
        }

        [Display(Name = "Sexo feminino")]
        public bool Sexo_feminino
        {
            get
            {
                return sexo_feminino;
            }

            set
            {
                sexo_feminino = value;
            }
        }

        public bool Falescimento
        {
            get
            {
                return falescimento;
            }

            set
            {
                falescimento = value;
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                if (value != "")
                status = value;
                else
                {
                    MessageBox.Show("Estado civil precisa ser preenchido corretamente");
                    status = null;
                }
            }
        }

        [Required]
        [ScaffoldColumn(false)]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {                
                email = value;
            }
        }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        public int Falta
        {
            get
            {
                return falta;
            }

            set
            {
                falta = value;
            }
        }

        
        public Int32? celula_ { get; set; }

        [ForeignKey("celula_")]
        public virtual Celula Celula
        {
            get
            {
                return celula;
            }

            set
            {
                celula = value;
            }
        }
        
        public virtual Endereco Endereco
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
        
        public virtual Telefone Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }        

        public virtual Chamada Chamada { get; set; }
       
        public virtual List<Ministerio> Ministerios
        {
            get
            {
                return ministerios;
            }

            set
            {
                ministerios = value;
            }
        }

        public virtual List<Historico> Historico
        {
            get
            {
                return historico;
            }

            set
            {
                historico = value;
            }
        }

        public virtual List<Reuniao> Reuniao { get; set; }

        [Display(Name = "Foto do perfil")]
        public byte[] Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }

        [ScaffoldColumn(false)]
        public string imgtipo { get; set; }

        [ScaffoldColumn(false)]
        public string classe { get; set; }

        [ScaffoldColumn(false)]
        public virtual Cargo_Lider Cargo_Lider { get; set; }

        [ScaffoldColumn(false)]
        public virtual Cargo_Lider_Treinamento Cargo_Lider_Treinamento { get; set; }

        [ScaffoldColumn(false)]
        public virtual Cargo_Supervisor Cargo_Supervisor { get; set; }

        [ScaffoldColumn(false)]
        public virtual Cargo_Supervisor_Treinamento Cargo_Supervisor_Treinamento { get; set; }               

        public Pessoa()
        {
            bd = new BDcomum();            
        }

        /// <summary>
        /// contrutor para buscar pessoa atraves do id
        /// </summary>
        /// <param name="id"></param>
        public Pessoa(int id)
        {
            bd = new BDcomum();
            recuperar(id);
        }

        public override string salvar()
        {           

            insert_padrao = 
     "insert into Pessoa (Nome, Data_nascimento, Estado_civil, Sexo_masculino, " +
     "Rg, Cpf, Sexo_feminino, Falescimento, " +
     "Email, Status, Falta, Endereco_Id, Telefone_Id)" +
     " values ('@nome', '@data_nascimento', '@estado_civil', '@sexo_masculino'," +
     " '@rg', '@cpf', '@sexo_feminino', '@falescimento', '@email', " +
     " '@status', '@faltas', @img, @imgtipo " +
     this.Telefone.salvar();        
           
            Insert = insert_padrao.Replace("@nome", nome);
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = data_nascimento.ToString("yyyy-MM-dd 00.00.00.000");
            Insert = Insert.Replace("@data_nascimento", data_nascimento.ToString());
            Insert = Insert.Replace("@estado_civil", estado_civil);
            Insert = Insert.Replace("@sexo_masculino", sexo_masculino.ToString());
            Insert = Insert.Replace("@rg", rg);
            Insert = Insert.Replace("@cpf", cpf);
            Insert = Insert.Replace("@sexo_feminino", sexo_feminino.ToString());
            Insert = Insert.Replace("@email", email);
            Insert = Insert.Replace("@status", status);
            Insert = Insert.Replace("@faltas", falta.ToString());
            Insert = Insert.Replace("@falescimento", false.ToString());
            Insert = Insert.Replace("@imgtipo", imgtipo);
          //  Insert = Insert.Replace("@img", img);          
           
            

            return bd.montar_sql(Insert, null, null);            
        }

        public override string alterar()
        {
       update_padrao = "update Pessoa set Nome='@nome_pessoa', Estado_civil='@estado_civil', " +
       "Rg='@rg', Cpf='@cpf', Falescimento='@falescimento', Email='@email', Status='@status' " +
       "  where Pessoa_id='@id' " +
       "update Telefone set Fone = '@telefone', Celular = '@celular', Whatsapp = '@whatsapp' " +
       " from Telefone as T inner join Pessoa as P on T.Id=Telefone_Id where P.Pessoa_id='@id'" +
       " update Endereco set Pais ='@pais', Estado = '@estado',  Cep = '@cep', " +
       " Cidade = '@cidade', Bairro = '@bairro', Rua = '@rua', " +
       " Numero_casa=@numero,  Complemento='@complemento' from Endereco as E inner join Pessoa as P on E.Id=Endereco_Id where " +
       "P.Pessoa_id='@id' ";

            bd = new BDcomum();

            Update = update_padrao.Replace("@nome_pessoa", nome);
            Update = Update.Replace("@id", pessoa_id.ToString());            
            string sqlFormattedDate = data_nascimento.ToString("yyyy-MM-dd 00.00.00.000");
            Update = Update.Replace("@data_nascimento", data_nascimento.ToString());
            Update = Update.Replace("@estado_civil", estado_civil);
            Update = Update.Replace("@sexo_masculino", sexo_masculino.ToString());
            Update = Update.Replace("@rg", rg);
            Update = Update.Replace("@cpf", cpf);
            Update = Update.Replace("@sexo_feminino", sexo_feminino.ToString());
            Update = Update.Replace("@email", email);
            Update = Update.Replace("@status", status);
            Update = Update.Replace("@faltas", falta.ToString());
            Update = Update.Replace("@falescimento", false.ToString());

            Update = Update.Replace("@telefone", Telefone.Fone);
            Update = Update.Replace("@celular", Telefone.Celular);
            Update = Update.Replace("@whatsapp", Telefone.Whatsapp);

            Update = Update.Replace("@pais", Endereco.Pais);            
            Update = Update.Replace("@estado", Endereco.Estado);
            Update = Update.Replace("@cidade", Endereco.Cidade);
            Update = Update.Replace("@bairro", Endereco.Bairro);
            Update = Update.Replace("@rua", Endereco.Rua);
            Update = Update.Replace("@numero", Endereco.Numero_casa.ToString());
            Update = Update.Replace("@cep", Endereco.Cep.ToString());
            Update = Update.Replace("@complemento", Endereco.Complemento);


            return bd.montar_sql(Update, null, null);

        }

        public override string excluir()
        {
            delete_padrao = "delete from pessoa where Pessoa_id='@id'" +
                " delete Telefone from Telefone as T inner " +
                " join Pessoa as P on T.Id=Telefone_Id" +
                " where P.Pessoa_id='@id' " +
                "delete Endereco from Endereco as E inner " +
                "join Pessoa as P on E.Id=Endereco_Id" +
                " where P.Pessoa_id='@id'";
            Delete = delete_padrao.Replace("@id", pessoa_id.ToString());

            bd.montar_sql(Delete, null, null);
            
            return "";
        }

        public override Pessoa recuperar(int id)
        {       
           
            select_padrao = "select * from Pessoa as P "
           + " inner join Endereco as E on E.EnderecoId=P.Id " 
           + " inner join Telefone as T on T.telefoneid=P.Id "
           + " inner join Chamada as CH on CH.chamadaid=P.ID "
           + " inner join ReuniaoPessoa as REPE on REPE.Pessoa_Id=P.Id "
           + " inner join MinisterioPessoa as MIPE on MIPE.Pessoa_Id=P.Id "
           + " inner join Historico as H on H.pessoaid=P.Id "
           + " inner join Lider as L on L.Liderid=P.Id "
           + " inner join Lider_treinamento as LT on LT.lidertreinamentoid=P.Id "
           + " inner join Supervisor as S on S.Supervisorid=P.Id "
           + " inner join Supervisor_treinamento as ST on ST.Supervisortreinamentoid=P.Id "          
           + " where  P.Id='" + id+"'";

            Select = select_padrao.Replace("@id", Id.ToString());            
            Select = Select.Replace("@innerjoin", "inner join Chamada as CH on CH.chamadaid=P.ID");

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

                    this.Id = int.Parse(Convert.ToString(dr["Pessoa_id"]));
                    this.Nome = Convert.ToString(dr["Nome"]);
                    this.Email = Convert.ToString(dr["Email"]);
                    this.Falta = int.Parse(dr["Falta"].ToString());
                    this.Estado_civil = Convert.ToString(dr["Estado_civil"]);
                    this.Falescimento = Convert.ToBoolean(Convert.ToString(dr["Falescimento"]));
                    this.Sexo_feminino = Convert.ToBoolean(Convert.ToString(dr["Sexo_feminino"]));
                    this.Sexo_masculino = Convert.ToBoolean(Convert.ToString(dr["Sexo_masculino"]));
                    this.Rg = Convert.ToString(dr["Rg"]);
                    this.Data_nascimento = Convert.ToDateTime(Convert.ToString(dr["Data_nascimento"]));
                    this.Cpf = Convert.ToString(dr["Cpf"]);
                    this.Status = Convert.ToString(dr["Status"]);                    
                    this.Telefone.Fone = Convert.ToString(dr["Fone"]);
                    this.Telefone.Celular = Convert.ToString(dr["Celular"]);
                    this.Telefone.Whatsapp = Convert.ToString(dr["Whatsapp"]);
                    this.Endereco.Cep = long.Parse(Convert.ToString(dr["Cep"]));
                    this.Endereco.Pais = Convert.ToString(dr["Pais"]);
                    this.Endereco.Estado = Convert.ToString(dr["Estado"]);
                    this.Endereco.Cidade = Convert.ToString(dr["Cidade"]);
                    this.Endereco.Bairro = Convert.ToString(dr["Bairro"]);
                    this.Endereco.Rua = Convert.ToString(dr["Rua"]);
                    this.Endereco.Complemento = Convert.ToString(dr["Complemento"]);
                    this.Endereco.Numero_casa = int.Parse(Convert.ToString(dr["Numero"]));
                    this.Chamada.Data_inicio = Convert.ToDateTime(dr["Data_inicio"]);
                    this.Chamada.Numero_chamada = int.Parse(dr["Numero_chamada"].ToString());
                    this.Celula.Celulaid = int.Parse(dr["celulaid"].ToString());
                    this.Celula.Supervisor_ = int.Parse(dr["Supervisor"].ToString());
                    this.Celula.Supervisortreinamento_ = int.Parse(dr["Supervisortreinamento_"].ToString());
                    this.Celula.Lider_ = int.Parse(dr["Lider_"].ToString());
                    this.Celula.Lidertreinamento_ = int.Parse(dr["Lidertreinamento_"].ToString());
                    this.Celula.Pessoas = this.Celula.preenchercelula(this.Celula.Celulaid);
                    this.Celula.Maximo_pessoa = int.Parse(dr["Maximo_pessoa"].ToString());
                    
                    while (dr.Read())
                    {
                        Historico h = new Historico();
                        h.Data_inicio = Convert.ToDateTime(dr["Data_inicio"]);
                        h.Falta = int.Parse(dr["Falta"].ToString());
                        this.Historico.Add(h);

                        Ministerio m = new Ministerio();
                        m.ministerioid = int.Parse(dr["ministerioid"].ToString());
                        m.Nome = dr["Nome"].ToString();
                        m.lider_ministerio = int.Parse(dr["Lider_ministerio"].ToString());
                        m.Proposito = dr["proposito"].ToString();
                        m.Pessoas = m.preencherministerio(m.ministerioid);
                        this.Ministerios.Add(m);

                        Reuniao r = new Reuniao();
                        r.Data_reuniao = Convert.ToDateTime(dr["Data_reuniao"]);
                        r.Horario_inicio = Convert.ToDateTime(dr["Horario_inicio"]);
                        r.Horario_fim = Convert.ToDateTime(dr["Horario_fim"]);
                        r.Local_reuniao = dr["Local_reuniao"].ToString();
                        this.Reuniao.Add(r);
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

                return this;
            }
            
        }

        public virtual void foto(PictureBox foto)
        {
            
             try
             {

                 OpenFileDialog dlg = new OpenFileDialog();
                 dlg.InitialDirectory = @"C:\Release\imagens";
                 dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                 dlg.Title = "selecione uma imagem";
                 if (dlg.ShowDialog() == DialogResult.OK)
                 {
                    string imagem;
                     imagem = dlg.FileName;
                    foto.ImageLocation = imagem;
                   // Img = imagem;
                  //  btp = new Bitmap(imagem);

                  //  foto.Image = btp;                  
                }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        public override IEnumerable<Pessoa> recuperartodos()
        {
            select_padrao = "select * from Pessoa as P inner join Endereco as E on E.Id=Endereco_Id inner join Telefone as T on T.Id=Telefone_Id @innerjoin";

            Select = select_padrao.Replace("@id", pessoa_id.ToString());
            Select = Select.Replace("@innerjoin", "");

            SqlCommand comando = new SqlCommand(Select, bd.obterconexao());

            SqlDataReader dr = comando.ExecuteReader();

            List<Pessoa> pessoa = new List<Pessoa>();

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
                        this.Id = int.Parse(Convert.ToString(dr["Pessoa_id"]));
                        this.Nome = Convert.ToString(dr["Nome"]);
                        this.Sexo_feminino = Convert.ToBoolean(Convert.ToString(dr["Sexo_feminino"]));
                        this.Sexo_masculino = Convert.ToBoolean(Convert.ToString(dr["Sexo_masculino"]));
                        this.Rg = Convert.ToString(dr["Rg"]);
                        this.Data_nascimento = Convert.ToDateTime(Convert.ToString(dr["Data_nascimento"]));
                        this.Endereco.Cep = long.Parse(Convert.ToString(dr["Cep"]));
                        this.Telefone.Fone = Convert.ToString(dr["Fone"]);
                        this.Telefone.Celular = Convert.ToString(dr["Celular"]);
                        this.Telefone.Whatsapp = Convert.ToString(dr["Whatsapp"]);
                        this.Cpf = Convert.ToString(dr["Cpf"]);
                        this.Status = Convert.ToString(dr["Status"]);
                        this.Endereco.Pais = Convert.ToString(dr["Pais"]);
                        this.Endereco.Estado = Convert.ToString(dr["Estado"]);
                        this.Endereco.Cidade = Convert.ToString(dr["Cidade"]);
                        this.Endereco.Bairro = Convert.ToString(dr["Bairro"]);
                        this.Endereco.Rua = Convert.ToString(dr["Rua"]);
                        this.Endereco.Complemento = Convert.ToString(dr["Complemento"]);
                        this.Endereco.Numero_casa = int.Parse(Convert.ToString(dr["Numero"]));
                        this.Email = Convert.ToString(dr["Email"]);
                        this.Estado_civil = Convert.ToString(dr["Estado_civil"]);
                        this.Falescimento = Convert.ToBoolean(Convert.ToString(dr["Falescimento"]));
                        pessoa.Add(this);
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

                return pessoa;
            }
        }

         
    }
}
