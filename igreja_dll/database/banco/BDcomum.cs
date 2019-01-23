using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace database.banco
{
    public class BDcomum
    {
        public static string conecta1 = @"Data Source=LAPTOP-9LQ8LUGC\SQLEXPRESS;Initial Catalog=site.context.DB;Integrated Security=True";
        public string sql;
        public int i;
        SqlParameter imag;
        byte[] imagem;

        public  SqlConnection obterconexao()
        {
            SqlConnection conn = new SqlConnection(conecta1);
            conn.Open();
            return conn;
        }

        public string buscar_dados(string comand, TextBox nome, TextBox cpf, TextBox rg, ListBox estado_civil, TextBox pais, TextBox cep,
            TextBox estado, TextBox cidade, TextBox bairro, TextBox rua, TextBox numero_casa, TextBox complemento, TextBox email, TextBox tel1,
            TextBox tel2, TextBox tel3, ListBox status, TextBox data_nascimento, RadioButton falescimento, PictureBox foto,
            TextBox nome_mae, TextBox nome_pai, TextBox data_visita, ListBox condicao, TextBox trans_cidade, TextBox trans_estado,
            TextBox trans_nome_igreja, TextBox denominacao, TextBox ano_reconciliacao, TextBox ano_batismo, RadioButton desligamento, Label id,
            ListBox data_reuniao_celula, MaskedTextBox horario_celula, TextBox lider, TextBox lider_treinamento, TextBox bairro_celula,
            TextBox rua_celula, TextBox numero_celula, Button botao)
        {
            return "";
        }

        public string montar_sql(string comand, PictureBox imagem, Label id)
        {
            
                if (imagem != null)
                {
                    comand = "update pessoa set pes_foto=@foto where pes_id=@id";
                    MemoryStream memory = new MemoryStream();
                    Bitmap btp = new Bitmap(imagem.ImageLocation);
                    btp.Save(memory, ImageFormat.Bmp);
                    byte[] foto = memory.ToArray();
                    imag = new SqlParameter("@foto", SqlDbType.Image);
                    imag.Value = foto;

                    if (id != null)
                    {
                        comand = comand.Replace("@id", id.Text);
                    }
                    else
                    {
                        comand = comand.Replace("@id", "IDENT_CURRENT('pessoa')");
                    }
                }
                SqlCommand comando = new SqlCommand(comand, obterconexao());
                if (imagem != null)
                {
                    comando.Parameters.Add(imag);
                }
                try
                {
                    comando.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obterconexao().Close();
                }
                     
           
            return comand;
        }

        public string visualizar(string comand, DataGridView data, CheckBox documento, CheckBox telefone, CheckBox endereco, CheckBox falta,
            NumericUpDown idade_maior, NumericUpDown idade_menor, RadioButton sexo_masculino, RadioButton sexo_feminino, ListBox estado_civil,
            ListBox status, CheckBox desligamento, CheckBox falescimento)
        {
            Regex regex = new Regex(@"where pes_nome='.?' or pes_cpf='.?'");
            string restricao = regex.Match(comand).ToString();

            comand = comand.Replace(restricao, "");

            if (documento.Checked)
            {              
                comand = comand.Replace("*", "pes_nome, pes_rg, pes_cpf, pes_data_nascimento");
            }

            if (telefone.Checked)
            {
                comand = comand.Replace("*", "pes_nome, tel_telefone, tel_celular, tel_whatsapp");
            }

            if (endereco.Checked)
            {
                comand = comand.Replace("*", "pes_nome, end_cep, end_pais, end_estado, end_cidade, end_bairro, end_rua, end_numero, end_complemento");
            }

            if (falta.Checked)
            {
                comand = comand.Replace("*", "pes_nome, pes_falta");
            }

           

            DateTime atual = DateTime.Now;
            comand += "where pes_data_nascimento<='@data_nascimento' and pes_data_nascimento>='@data2' ";
                
            comand = comand.Replace("@data_nascimento", atual.AddDays((-365) * int.Parse(idade_maior.Text) + 1).ToString());
            comand = comand.Replace("@data2", atual.AddDays((-365) * int.Parse(idade_menor.Text)).ToString());

            if (sexo_feminino.Checked || sexo_masculino.Checked)
            {
                comand += "and pes_sexo_masculino='@sexo_masculino' ";
                comand = comand.Replace("@sexo_masculino", sexo_masculino.Checked.ToString());
            }

            if(estado_civil.Text != "")
            {
                comand += "and pes_estado_civil='@estado_civil' ";
                comand = comand.Replace("@estado_civil", estado_civil.Text);
            }

            if (status.Text != "")
            {
                comand += "and pes_status='@status' ";
                comand = comand.Replace("@status", status.Text);
            }

            if (falescimento.Checked)
            {
                comand += "and pes_falescimento='@falescimento' ";
                comand = comand.Replace("@falescimento", falescimento.Checked.ToString());
            }

            if (desligamento.Checked)
            {
                comand += "and desligamento='@desligamento' ";
                comand = comand.Replace("@desligamento", desligamento.Checked.ToString());
            }



            MessageBox.Show(comand);

            SqlCommand comando = new SqlCommand(comand, obterconexao());

            SqlDataAdapter objadp = new SqlDataAdapter(comando);
            DataTable dtlista = new DataTable();

            objadp.Fill(dtlista);
            data.DataSource = dtlista;

            return "";
        }

        public DataTable montar_relatorio(string comand, bool lisbox, bool ministerio, ListBox list)
        {
            Regex regex = new Regex(@"where pes_nome='.?' or pes_cpf='.?'");
            string restricao = regex.Match(comand).ToString();
            
            comand = comand.Replace(restricao, " ");

            if (lisbox)
            {
                if (ministerio)
                {
                    i = 1;
                }else
                {
                    i = 0;
                    comand = comand.Replace("*", "pes_nome");
                    comand += " left join celula_pessoa on pes_id=cel_pessoa " +
                        " where cel_pessoa is null order by pes_nome asc";
                }
               
                
            }

            DataTable dtable = new DataTable();
            SqlCommand comando = new SqlCommand(comand, obterconexao());
            SqlDataAdapter objadp = new SqlDataAdapter(comando);
            objadp.Fill(dtable);


            if (lisbox)
            {
                foreach (DataRow dtrow in dtable.Rows)
                {
                    ArrayList lista = new ArrayList();
                    lista.Add(dtrow);
                    //exibe os registros no listbox
                    list.Items.Add(dtrow.ItemArray[i]);
                }
            }
            return dtable;
        }                   

        public DataTable listar(string comand, bool semsupervisor, bool semcelula, bool listarpessoas, string id)
        {
            if (semsupervisor)
            {
                comand = "select * from celula left join supervisor_celula on id_celula=super_celula " +
                    " where super_celula is null"; 
            }

            if (listarpessoas) 
            {
                comand = "select * from pessoa left join celula_pessoa on pes_id=cel_pessoa " +
                    " inner join celula on id_celula=pes_celula where cel_pessoa is not null and id_celula='@id'";
                comand = comand.Replace("@id", id);
            }

            if (semcelula)
            {
                comand = "select * from pessoa left join celula_pessoa on pes_id=cel_pessoa where cel_pessoa is  null";
            }

            DataTable dtable = new DataTable();
            SqlCommand comando = new SqlCommand(comand, obterconexao());            
            SqlDataAdapter objadp = new SqlDataAdapter(comando);
            objadp.Fill(dtable);

            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
              //  list.Items.Add(dtrow.ItemArray[0]);
            }

            return dtable;
        }

        public DataTable lista(string comand)
        {
            DataTable dtable = new DataTable();
            SqlCommand comando = new SqlCommand(comand, obterconexao());
            SqlDataAdapter objadp = new SqlDataAdapter(comando);
            objadp.Fill(dtable);

            foreach (DataRow dtrow in dtable.Rows)
            {
                ArrayList lista = new ArrayList();
                lista.Add(dtrow);
                //exibe os registros no listbox
                //  list.Items.Add(dtrow.ItemArray[0]);
            }

            return dtable;
        }

    }
}
