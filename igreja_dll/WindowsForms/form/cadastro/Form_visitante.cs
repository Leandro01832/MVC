using business.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igreja2.form.cadastro
{
    public partial class Form_visitante : Form
    {
        public Form_visitante()
        {
            InitializeComponent();
            visi.Endereco = new Endereco();
            visi.Telefone = new Telefone();

        }
               
        Visitante visi = new Visitante();

        private void button1_Click(object sender, EventArgs e)
        {
            string listbox = listBox1.Text;
            Regex reg = new Regex(@"(\d+)");
            string id = reg.Match(listbox).ToString();
            visi.Nome = text_nome2.Text;
            visi.Email = textemail2.Text;
            visi.Rg = text_rg.Text;
            visi.Cpf = text_cpf.Text;
            visi.Estado_civil = listestado_civil2.Text;
            visi.Endereco.Pais = textpais2.Text;
            visi.Endereco.Cep = long.Parse(text_cep.Text);
            visi.Endereco.Estado = text_estado2.Text;
            visi.Endereco.Cidade = text_cidade2.Text;
            visi.Endereco.Bairro = text_bairro2.Text;
            visi.Endereco.Rua = text_rua2.Text;
            visi.Endereco.Complemento = text_complemento2.Text;
            visi.Endereco.Numero_casa = int.Parse(text_numero2.Text);
            visi.Telefone.Fone = mask_tel1_2.Text;
            visi.Telefone.Celular = mask_tel2_2.Text;
            visi.Telefone.Whatsapp = mask_tel3.Text;
            visi.Data_nascimento = Convert.ToDateTime(mask_data_nascimento2.Text);
            visi.Falescimento = false;
            visi.Sexo_feminino = radioButton_feminino2.Checked;
            visi.Sexo_masculino = radioButton_masculino2.Checked;
            visi.Condicao_religiosa = list_condicao.Text;
            visi.Data_visita = DateTime.Now;
            visi.celula_ = int.Parse(id);
            Celula cel = new Celula();
            visi.Chamada.Numero_chamada = cel.recuperar(int.Parse(id)).Pessoas.Count + 1;
            visi.salvar();
            visi.bd.montar_sql("", picEmp, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            visi.foto(picEmp);
            Visualizar_foto visu = new Visualizar_foto(picEmp);
            visu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urlconsulta = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";
            DataSet retornaendereco = new DataSet();
            retornaendereco.ReadXml(urlconsulta.Replace("@cep", text_cep.Text));

            string retorno = retornaendereco.Tables[0].Rows[0]["resultado"].ToString();

            if (retorno == "0")
            {
                MessageBox.Show("CEP invalido");
            }
            else
            {
                text_cidade2.Text = retornaendereco.Tables[0].Rows[0]["cidade"].ToString();
                text_estado2.Text = retornaendereco.Tables[0].Rows[0]["uf"].ToString();
                text_rua2.Text = retornaendereco.Tables[0].Rows[0]["logradouro"].ToString();
                text_bairro2.Text = retornaendereco.Tables[0].Rows[0]["bairro"].ToString();
            }
        }

        private void Form_visitante_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Celula cel = new Celula();
            IEnumerable<Celula> celulas = cel.recuperartodos();
            DataTable dtable = cel.bd.listar("select * from Celula order by Celulaid asc", false, false, false, "");
            foreach (var c in celulas)
            {
                ArrayList lista = new ArrayList();
                lista.Add(c);
                //exibe os registros no listbox
                listBox1.Items.Add(c.Cel_nome + " - " + c.Celulaid);
            }


            if (visi.Nome == null || visi.Rg == null || visi.Cpf == null || visi.Estado_civil == null
                || visi.Endereco.Pais == null || visi.Endereco.Cep == 0 || visi.Endereco.Estado == null || visi.Endereco.Cidade == null
                || visi.Endereco.Bairro == null || visi.Endereco.Rua == null || visi.Endereco.Numero_casa == 0 || visi.Status == null
                || visi.Sexo_feminino == false && visi.Sexo_masculino == false
                || visi.Condicao_religiosa == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void text_nome2_TextChanged(object sender, EventArgs e)
        {
            visi.Nome = text_nome2.Text;
            Form_visitante_Load(text_nome2.Text, e);
        }

        private void text_rg_TextChanged(object sender, EventArgs e)
        {
            visi.Rg = text_rg.Text;
            Form_visitante_Load(text_rg.Text, e);
        }

        private void text_cpf_TextChanged(object sender, EventArgs e)
        {
            visi.Cpf = text_cpf.Text;
            Form_visitante_Load(text_cpf.Text, e);
        }

        private void listestado_civil2_SelectedIndexChanged(object sender, EventArgs e)
        {
            visi.Estado_civil = listestado_civil2.Text;
            Form_visitante_Load(listestado_civil2.Text, e);
        }

        private void textpais2_TextChanged(object sender, EventArgs e)
        {
            visi.Endereco.Pais = textpais2.Text;
            Form_visitante_Load(textpais2.Text, e);
        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {
            if (text_cep.Text == "")
            {
                visi.Endereco.Cep = 0;
                Form_visitante_Load(text_cep.Text, e);
            }
            else
            {
                try
                {
                    visi.Endereco.Cep = long.Parse(text_cep.Text);
                    Form_visitante_Load(text_cep.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    visi.Endereco.Cep = 0;
                    Form_visitante_Load(text_cep.Text, e);
                    text_cep.Text = "";
                    return;
                }
                finally
                {

                }
            }
        }

        private void text_estado2_TextChanged(object sender, EventArgs e)
        {
            visi.Endereco.Estado = text_estado2.Text;
            Form_visitante_Load(text_estado2.Text, e);
        }

        private void text_cidade2_TextChanged(object sender, EventArgs e)
        {
            visi.Endereco.Cidade = text_cidade2.Text;
            Form_visitante_Load(text_cidade2.Text, e);
        }

        private void text_bairro2_TextChanged(object sender, EventArgs e)
        {
            visi.Endereco.Bairro = text_bairro2.Text;
            Form_visitante_Load(text_bairro2.Text, e);
        }

        private void text_rua2_TextChanged(object sender, EventArgs e)
        {
            visi.Endereco.Rua = text_rua2.Text;
            Form_visitante_Load( text_rua2.Text, e);
        }

        private void text_numero2_TextChanged(object sender, EventArgs e)
        {
            if (text_numero2.Text == "")
            {
                visi.Endereco.Numero_casa = 0;
                Form_visitante_Load(text_numero2.Text, e);
            }
            else
            {
                try
                {
                    visi.Endereco.Numero_casa = int.Parse(text_numero2.Text);
                    Form_visitante_Load(text_numero2.Text, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Você não digitou um numero." +
                        "\n Por favor digite um numero.");
                    visi.Endereco.Numero_casa = 0;
                    Form_visitante_Load(text_numero2.Text, e);
                    text_numero2.Text = "";
                    return;
                }
                finally
                {

                }
            }
        }

        private void text_complemento2_TextChanged(object sender, EventArgs e)
        {
            visi.Endereco.Complemento = text_complemento2.Text;
            Form_visitante_Load(text_complemento2.Text, e);
        }

        private void textemail2_TextChanged(object sender, EventArgs e)
        {
            visi.Email = textemail2.Text;
            Form_visitante_Load(textemail2.Text, e);
        }

        private void mask_tel1_2_TextChanged(object sender, EventArgs e)
        {
            visi.Telefone.Fone = mask_tel1_2.Text;
            Form_visitante_Load(mask_tel1_2.Text, e);
        }

        private void mask_tel2_2_TextChanged(object sender, EventArgs e)
        {
            visi.Telefone.Celular = mask_tel2_2.Text;
            Form_visitante_Load(mask_tel2_2.Text, e);
        }

        private void mask_tel3_TextChanged(object sender, EventArgs e)
        {
            visi.Telefone.Whatsapp = mask_tel3.Text;
            Form_visitante_Load(mask_tel3.Text, e);
        }

        private void listBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            visi.Status = listBox_status.Text;
            Form_visitante_Load(listBox_status.Text, e);
        }

        private void mask_data_nascimento2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque uma data valida");
        }

        private void mask_visita_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("coloque uma data valida");
        }

        private void radioButton_masculino2_CheckedChanged(object sender, EventArgs e)
        {
            visi.Sexo_masculino = radioButton_masculino2.Checked;
            Form_visitante_Load(radioButton_masculino2.Checked, e);
        }

        private void radioButton_feminino2_CheckedChanged(object sender, EventArgs e)
        {
            visi.Sexo_feminino = radioButton_feminino2.Checked;
            Form_visitante_Load(radioButton_feminino2.Checked, e);
        }

        private void list_condicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            visi.Condicao_religiosa = list_condicao.Text;
            Form_visitante_Load(list_condicao.Text, e);
        }
    }
}
